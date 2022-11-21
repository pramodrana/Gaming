using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using TVS.ApiService.Service.GameScore;
using TVS.Common.Constant;
using TVS.Common.Resources;
using TVS.Factory.Factory.Game;
using TVS.Model.Models;
using TVS.Model.Models.Game;
using TVS.Model.Models.GameQuestion;
using TVS.Service.Service.Game;
using TVS.Service.Services.ExceptionLog;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TVS.Game.API.Controllers.Game
{
    [Route("api/gaming/")]
    [ApiController]
    public class GameController : ControllerBase
    {
        #region Private Variables
        private readonly IGameService _gameService;
        private readonly IGameScoreService _gameScoreService;
        private readonly IGameFactory _gameFactory;
        private readonly IExceptionService _exceptionService;
        #endregion

        #region Constructor
        public GameController(IGameService gameService,
            IGameScoreService gameScoreService,
            IGameFactory gameFactory,
            IExceptionService exceptionService)
        {
            this._gameService = gameService;
            this._gameScoreService = gameScoreService;
            this._gameFactory = gameFactory;
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
        [Route("getgames")]
        public async Task<ResponseWithoutHeader<GameResponse, Response>> GetAllGames()
        {
            ResponseWithoutHeader<GameResponse, Response> response = new() { Data = new GameResponse() };
            try
            {
                var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
                GameResponse gameResponse = new GameResponse();
                List<GameModel> gameModelList = new List<GameModel>();
                var gameList = await _gameService.GetGames();
                if (gameList.Count > 0)
                {
                    gameModelList = _gameFactory.GameEntityToModelList(gameList);
                    gameResponse.GameList = gameModelList;
                    var userProfile = new Data.Models.UserProfile();
                    var totalcoins = _gameScoreService.GetTotalScoreByUserId(Convert.ToInt32(userId), out userProfile);
                    gameResponse.TotalCoins = totalcoins;
                    if (userProfile != null)
                    {
                        gameResponse.UserName = userProfile.FullName;
                        gameResponse.ProfileImageUrl = userProfile.ProfileImagePath;
                    }
                    response.Data = gameResponse;
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
