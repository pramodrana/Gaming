using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Http.Controllers;
using TVS.Common.Logging;

namespace TVS.Game.API.Filters
{
    public class TokenValidtionAttribute : System.Web.Http.Filters.AuthorizationFilterAttribute, IActionFilter
    {
        public TokenValidtionAttribute() { }

        private const string CommunicationKey = "GQDstc21ewfffffffffffFiwDffVvVBrk";

        public override void OnAuthorization(HttpActionContext filterContext)
        {
            if (filterContext.Request.Headers.Contains("accesstoken"))
            {
               
            }
            else
            {
                
            }
            base.OnAuthorization(filterContext);
        }
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var accessToken = filterContext.HttpContext.Request.Headers["accessToken"];
            var userId = filterContext.HttpContext.Request.Headers["userId"];
            string userName = string.Empty;
            ValidateToken(accessToken,out userName);


        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
        }

        /// <summary>
        /// get principal from token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

                if (jwtToken == null)
                    return null;

                var symmetricKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(CommunicationKey));// Convert.FromBase64String(CommunicationKey);

                var validationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(CommunicationKey))
                };

                Microsoft.IdentityModel.Tokens.SecurityToken securityToken;
                var principal = tokenHandler.ValidateToken(token, validationParameters, out securityToken);

                return principal;
            }

            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// validate token
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool ValidateToken(string token, out string username)
        {
            username = null;

            var simplePrinciple = GetPrincipal(token);
            var identity = simplePrinciple?.Identity as ClaimsIdentity;

            if (identity == null)
                return false;

            if (!identity.IsAuthenticated)
                return false;

            var usernameClaim = identity.FindFirst(ClaimTypes.Name);
            username = usernameClaim?.Value;

            if (string.IsNullOrEmpty(username))
                return false;

            // More validate to check whether username exists in system

            return true;
        }

        private bool ValidateTokenLifeTime(string authToken, string UserId)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = GetValidationParameters();

                SecurityToken validatedToken;
                var principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
                if (principal.Identities.First().Claims
                     .Any(c => c.Type == ClaimTypes.NameIdentifier && c.Value == UserId.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (SecurityTokenExpiredException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        private TokenValidationParameters GetValidationParameters() => new TokenValidationParameters()
        {
            ValidateLifetime = true,
            //ValidateAudience = false,
            //ValidateIssuer = false,
            ClockSkew = TimeSpan.Zero,
            ValidIssuer = "self",
            ValidAudience = "http://www.example.com",
            IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(CommunicationKey)) // The same key as the one that generate the token
        };
    }
}
