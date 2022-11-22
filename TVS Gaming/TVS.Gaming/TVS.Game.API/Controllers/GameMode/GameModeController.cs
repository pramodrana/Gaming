using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using TVS.ApiService.Service.GameMode;
using TVS.Common.Constant;
using TVS.Common.Resources;
using TVS.Factory.Factory.Game;
using TVS.Model.Models;
using TVS.Model.Models.GameMode;
using TVS.Model.Models.GameQuestion;
using TVS.Repository.Repository.GameMode;
using TVS.Service.Services.ExceptionLog;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TVS.Game.API.Controllers.GameMode
{
    [Route("api/gaming/")]
    [ApiController]
    public class GameModeController : ControllerBase
    {
        #region Private Variables
        private readonly IGameModeService _gameModeService;
        private readonly IGameModeFactory _gameModeFactory;
        private readonly IExceptionService _exceptionService;
        #endregion

        #region COnstructor
        public GameModeController(IGameModeService gameModeService,
            IGameModeFactory gameModeFactory,
            IExceptionService exceptionService)
        {
            this._gameModeService = gameModeService;
            this._gameModeFactory = gameModeFactory;
            this._exceptionService = exceptionService;
        }
        #endregion

        #region APIs
        /// <summary>
        /// API to get list of properties (i.e. badges)
        /// </summary>
        /// <returns></returns>
        //[JwtAuthenticationFilter]
        [HttpGet]
        [Route("getgamemodes")]
        public async Task<ApiResponseBody<List<GameModeModel>, Response>> GetModes()
        {
            ApiResponseBody<List<GameModeModel>, Response> response = new ApiResponseBody<List<GameModeModel>, Response>() { Data = new List<GameModeModel>() };
            try
            {
                List<GameModeModel> gameModeDtoList = new();
                var gameModeList = await _gameModeService.GetGameModes();
                if (gameModeList.Count > 0)
                {
                    gameModeDtoList = _gameModeFactory.GameModeEntityToModelList(gameModeList);
                    response.Data = gameModeDtoList;
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
