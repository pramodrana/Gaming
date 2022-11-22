using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using TVS.ApiService.Service.GameCategory;
using TVS.ApiService.Service.GameScore;
using TVS.Common.Constant;
using TVS.Common.Resources;
using TVS.Factory.Factory.GameCategory;
using TVS.Model.Models.Game;
using TVS.Model.Models;
using TVS.Model.Models.GameCategory;
using TVS.Model.Models.Gaming;
using TVS.Service.Services.ExceptionLog;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TVS.Game.API.Controllers.GameCategory
{
    [Route("api/gaming/")]
    [ApiController]
    public class GameCategoryController : ControllerBase
    {
        #region Private Variables
        private readonly IGameCategoryService _gameCategoryService;
        private readonly IGameScoreService _gameScoreService;
        private readonly IGameCategoryFactory _gameCategoryFactory;
        private readonly IExceptionService _exceptionService;
        #endregion

        #region Constructor
        public GameCategoryController(IGameCategoryService gameCategoryService,
            IGameScoreService gameScoreService,
            IGameCategoryFactory gameCategoryFactory,
            IExceptionService exceptionService)
        {
            this._gameCategoryService = gameCategoryService;
            this._gameScoreService = gameScoreService;
            this._gameCategoryFactory = gameCategoryFactory;
            this._exceptionService= exceptionService;
        }
        #endregion

        #region Validaton
        private void ValidateGameCategoryParameters(ApiRequestBody<PagingParams, long> requestMapper)
        {
            if (requestMapper == null)
            {
                throw new ArgumentException(ResourceManager.GetResource(Constants.INVALID_ARGS));
            }

            List<string> error = new List<string>();

            //if (CommonMethods.GetRequestHeaderUserId(Request) == 0)
            //{
            //    error.Add(Constants.CSI_FEEDBACK_PARAM_USER_ID);
            //}

            if (requestMapper.Data <= 0)
            {
                error.Add(Constants.GamingConstants.GAME_ID_REQUIRED);
            }

            if (error.Count > 0)
            {
                string errorMessage = string.Concat(ResourceManager.GetResource(Constants.INVALID_ARGS), string.Join("|", error));
                throw new ArgumentException(errorMessage);
            }
        }
        #endregion

        #region APIs
        /// <summary>
        /// API to get list of properties (i.e. badges)
        /// </summary>
        /// <returns></returns>
        //[JwtAuthenticationFilter]
        [HttpPost]
        [Route("getgamecategories")]
        public async Task<ApiResponseBody<GameCategoryResponse, Response>> GetAllGameCategory(ApiRequestBody<PagingParams, long> requestMapper)
        {
            ApiResponseBody<GameCategoryResponse, Response> response = new() { Data = new GameCategoryResponse() };
            this.ValidateGameCategoryParameters(requestMapper);
            try
            {
                var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
                GameCategoryResponse gameCategoryResponse = new();
                List<GameCategoryModel> gameCategoryDtoList = new();
                var gameCategoryList = await _gameCategoryService.GetGameGategoryListByGameId(requestMapper.Data);
                if (gameCategoryList.Count > 0)
                {
                    gameCategoryDtoList = _gameCategoryFactory.GameCategoryEntityToModelList(gameCategoryList);
                    gameCategoryResponse.GameCategoryList = gameCategoryDtoList;
                    var userProfile = new TVS.Data.Models.UserProfile();
                    var totalcoins = await _gameScoreService.GetTotalScoresByUserAndGame(Convert.ToInt32(userId), requestMapper.Data);
                    gameCategoryResponse.TotalCategoryCoints = totalcoins;
                    response.Data = gameCategoryResponse;
                    response.Response = (new Response(HttpStatusCode.OK, ResourceManager.GetResource(Constants.SUCCESS), ResourceManager.GetResource(Constants.SUCCESS)));
                    return response;
                }
                else
                {
                    response.Response = (new Response(HttpStatusCode.NotFound, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND)));
                    return response;
                }
            }
            catch (Exception ex)
            {
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Get Property", string.Empty, "Gaming", string.Empty);
                response.Response = (new Response(HttpStatusCode.ExpectationFailed, Constants.FAILURE, Constants.DB_ERROR));
                return response;
            }
        }

        #endregion
    }
}
