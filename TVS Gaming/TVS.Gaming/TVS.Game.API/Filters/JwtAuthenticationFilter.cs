
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Web.Http.Controllers;
using TVS.Common.Resources;
using System.Web.Http.Filters;
using TVS.Model.Models;
using TVS.Common.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace TVS.Game.API.Filters
{
    public class JwtAuthenticationFilter : AuthorizationFilterAttribute
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public JwtAuthenticationFilter(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public JwtAuthenticationFilter() { }

        private const string CommunicationKey = "GQDstc21ewfffffffffffFiwDffVvVBrk";

        public override void OnAuthorization(HttpActionContext filterContext)
        {
            if (filterContext.Request.Headers.Contains("accesstoken"))
            {
                int returnAuthoriseResponse = IsUserAuthorized_V2(filterContext);
                if (returnAuthoriseResponse > 0)
                {
                    ShowAuthenticationError_V2(filterContext, returnAuthoriseResponse);
                    return;
                }
            }
            else
            {
                if (!IsUserAuthorized(filterContext))
                {
                    ShowAuthenticationError(filterContext);
                    return;
                }
            }
            base.OnAuthorization(filterContext);
        }

        public bool IsUserAuthorized(HttpActionContext actionContext)
        {
            var customvalidator = new JwtAuthenticationFilter();
            if (!actionContext.Request.Headers.Contains("token") ||
                !actionContext.Request.Headers.Contains("userid")) return false;
            var headertoken = Convert.ToString(((string[])actionContext.Request.Headers.GetValues("token"))[0]);
            var headeruserid = Convert.ToString(((string[])actionContext.Request.Headers.GetValues("userid"))[0]);
            if (string.IsNullOrEmpty(headertoken)) return false;
            if (!IsValidUserIdInQueryString(actionContext, headeruserid))
                return false;
            if (!IsValidUserIdInJsonBody(actionContext, headeruserid))
                return false;
            var isvalid = customvalidator.CustomTokenValidator(headertoken, headeruserid);
            // Setting Current Principle if user is authenticated, so that logged in UserId can be retrieved in Controller actions
            if (isvalid)
            {
                var identity = new GenericIdentity(headeruserid);
                var genericPrincipal = new GenericPrincipal(identity, null);
                SetPrincipal(genericPrincipal);
            }
            return isvalid;
        }

        public bool CustomTokenValidator(string headertoken, string headeruserid)
        {
            //var liSqlParameter = new Collection<SqlParameter>
            //{
            //    new SqlParameter {ParameterName = "@token", Value = headertoken},
            //    new SqlParameter {ParameterName = "@UserId", Value = headeruserid},
            //    new SqlParameter
            //    {
            //        ParameterName = "@ReturnCode",
            //        Value = 0,
            //        Direction = ParameterDirection.InputOutput
            //    }
            //};
            //var value = TokenValidateDa.ValidateToken("ValidateToken", liSqlParameter);
            return  true;
        }

        public bool CustomTokenValidator_v2(string headertoken, string headeruserid)
        {
            //var liSqlParameter = new Collection<SqlParameter>
            //{
            //    new SqlParameter {ParameterName = "@token", Value = headertoken},
            //    new SqlParameter {ParameterName = "@UserId", Value = headeruserid},
            //    new SqlParameter
            //    {
            //        ParameterName = "@ReturnCode",
            //        Value = 0,
            //        Direction = ParameterDirection.InputOutput
            //    }
            //};
            //var value = TokenValidateDa.ValidateToken("ValidateAccessToken", liSqlParameter);
            return true;
        }

        private static void ShowAuthenticationError(HttpActionContext filterContext)
        {

            var jasonresponse = new Response(HttpStatusCode.Unauthorized, "failure", "Session    Expired");
            filterContext.Response = filterContext.Request.CreateResponse(HttpStatusCode.Unauthorized, jasonresponse);
            Logger.Debug("RESPONSE : " + filterContext.Response);
        }

        private void SetPrincipal(IPrincipal principal)
        {
            Thread.CurrentPrincipal = principal;
            if (_httpContextAccessor.HttpContext.User != null)
            {
                _httpContextAccessor.HttpContext.User = (ClaimsPrincipal)principal;
            }
        }

        /// <summary>
        /// validate UserId in Json body
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="headeruserid"></param>
        /// <returns></returns>
        private static bool IsValidUserIdInJsonBody(HttpActionContext actionContext, string headeruserid)
        {
            var jsonBody = actionContext.Request.Content.ReadAsStringAsync().Result;
            if (!string.IsNullOrEmpty(jsonBody) && IsValidJson(jsonBody))
            {
                try
                {
                    var jsonBodyUserId = JsonConvert.DeserializeObject<ParseUserId>(jsonBody).UserId;
                    if (!string.IsNullOrEmpty(jsonBodyUserId) && jsonBodyUserId != "0")
                        if (jsonBodyUserId != headeruserid)
                            return false;
                }
                catch (Exception ex)
                {
                    //Do nothing
                }
            }
            return true;
        }

        /// <summary>
        ///validate UserId in query string
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="headeruserid"></param>
        /// <returns></returns>
        private static bool IsValidUserIdInQueryString(HttpActionContext actionContext, string headeruserid)
        {
            var queryStringid = actionContext.Request.RequestUri.ParseQueryString()["userid"];
            if (!string.IsNullOrEmpty(queryStringid))
            {
                if (queryStringid != headeruserid)
                    return false;
            }
            return true;
        }

        private static bool IsValidJson(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    Logger.Error(jex);
                    return false;
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public class ParseUserId
        {
            public string UserId { get; set; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns> 0 - Success
        /// 1 - If userid or accesstoken is missing in Header
        /// 2 - If the usrId in Querystring parameter is not valid
        /// 3 - If the "UserId" field is JSON body is not exact match with the header UserId
        /// 4 - If the Token is expired or the UserId in token does not match with the provided ID
        /// 5 - If the accessToken in header does not match with the existing Token in Database against the userid
        /// </returns>
        public int IsUserAuthorized_V2(HttpActionContext actionContext)
        {
            var customvalidator = new JwtAuthenticationFilter();
            if (!actionContext.Request.Headers.Contains("accesstoken") ||
                !actionContext.Request.Headers.Contains("userid")) return 1;
            var headertoken = Convert.ToString(((string[])actionContext.Request.Headers.GetValues("accesstoken"))[0]);
            var headeruserid = Convert.ToString(((string[])actionContext.Request.Headers.GetValues("userid"))[0]);
            if (string.IsNullOrEmpty(headertoken)) return 1;
            if (!IsValidUserIdInQueryString(actionContext, headeruserid))
                return 2;
            if (!IsValidUserIdInJsonBody(actionContext, headeruserid))
                return 3;
            bool isTokenLive = ValidateTokenLifeTime(headertoken, headeruserid);
            if (!isTokenLive)
            {
                return 4;
            }
            var isvalid = customvalidator.CustomTokenValidator_v2(headertoken, headeruserid);
            if (!isvalid)
            {
                return 5;
            }
            // Setting Current Principle if user is authenticated, so that logged in UserId can be retrieved in Controller actions
            if (isvalid && isTokenLive)
            {
                var identity = new GenericIdentity(headeruserid);
                var genericPrincipal = new GenericPrincipal(identity, null);
                SetPrincipal(genericPrincipal);
            }
            return 0;
        }

        private static void ShowAuthenticationError_V2(HttpActionContext filterContext, int authoriseResponseCode)
        {
            string errorMessage = GetTokenSpecificErrorMessage(authoriseResponseCode);
            var jasonresponse = new Response(HttpStatusCode.Unauthorized, "failure", errorMessage);
            filterContext.Response = filterContext.Request.CreateResponse(HttpStatusCode.Unauthorized, jasonresponse);
            Logger.Debug("RESPONSE : " + filterContext.Response);
        }

        private static string GetTokenSpecificErrorMessage(int authoriseResponseCode)
        {
            switch (authoriseResponseCode)
            {
                case 1:
                    return ResourceManager.GetResource("MissingUserId");
                case 2:
                    return ResourceManager.GetResource("InvalidUserIdInQueryString");
                case 3:
                    return ResourceManager.GetResource("DifferentUserId");
                case 4:
                    return ResourceManager.GetResource("InvalidAccessToken");
                case 5:
                    return ResourceManager.GetResource("AccessTokenNotMatch");
                default:
                    return ResourceManager.GetResource("SessionExpired");
            }
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
