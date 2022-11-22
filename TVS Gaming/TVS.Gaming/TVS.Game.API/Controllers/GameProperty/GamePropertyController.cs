using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using TVS.ApiService.Service.GameProperty;
using TVS.Common.Constant;
using TVS.Common.Resources;
using TVS.Factory.Factory.GameProperty;
using TVS.Model.Models.GameCategory;
using TVS.Model.Models;
using TVS.Model.Models.GameProperty;
using TVS.Service.Services.ExceptionLog;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TVS.Game.API.Controllers.GameProperty
{
    [Route("api/gaming/")]
    [ApiController]
    public class GamePropertyController : ControllerBase
    {
        #region Private Variable
        private readonly IGamePropertyService _gamePropertyService;
        private readonly IGamePropertyFactory _gamePropertyFactory;
        private readonly IExceptionService _exceptionService;
        #endregion

        #region Constructor
        public GamePropertyController(IGamePropertyService gamePropertyService,
            IGamePropertyFactory gamePropertyFactory,
            IExceptionService exceptionService)
        {
            this._gamePropertyService = gamePropertyService;
            this._gamePropertyFactory = gamePropertyFactory;
            this._exceptionService = exceptionService;
        }

        public IGamePropertyService GamePropertyService => _gamePropertyService;
        #endregion

        #region APIs
        /// <summary>
        /// API to get list of properties (i.e. badges)
        /// </summary>
        /// <returns></returns>
        //[JwtAuthenticationFilter]
        [HttpGet]
        [Route("getproperties")]
        public async Task<ApiResponseBody<List<GamePropertyModel>, Response>> GetProperties()
        {
            ApiResponseBody<List<GamePropertyModel>, Response> response = new() { Data = new List<GamePropertyModel>() };
            try
            {
                List<GamePropertyModel> gamePropertyDtoList = new();
                var gamePropertyList = await _gamePropertyService.GetAllProperties();
                if (gamePropertyList.Count > 0)
                {
                    gamePropertyDtoList = _gamePropertyFactory.GamePropertyEntityToModelList(gamePropertyList);
                    response.Data = gamePropertyDtoList;
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
