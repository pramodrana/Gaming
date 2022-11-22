using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using TVS.ApiService.Service.GameAnswer;
using TVS.ApiService.Service.GameCategory;
using TVS.ApiService.Service.GameMode;
using TVS.ApiService.Service.GameProperty;
using TVS.ApiService.Service.GameQuestion;
using TVS.ApiService.Service.GameScore;
using TVS.Common.Constant;
using TVS.Common.Functions;
using TVS.Common.Resources;
using TVS.Data.Models;
using TVS.Factory.Factory.GameAnswer;
using TVS.Factory.Factory.GameScore;
using TVS.Model.Models;
using TVS.Model.Models.GameCategory;
using TVS.Model.Models.GameQuestion;
using TVS.Model.Models.GameScore;
using TVS.Model.Models.Gaming;

using TVS.Service.Services.ExceptionLog;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TVS.Game.API.Controllers.Gaming
{
    [Route("api/gaming/")]
    [ApiController]
    public class GamingController : ControllerBase
    {
        #region Private Variables
        private readonly IGameQuestionService _gameQuestionService;
        private readonly IGameAnswerService _gameAnswerService;
        private readonly IGameScoreService _gameScoreService;
        private readonly IGamePropertyService _gamePropertyService;
        private readonly IGameModeService _gameModeService;
        private readonly IGameCategoryService _gameCategoryService;

        private readonly IGameAnswerFactory _gameAnswerFactory;
        private readonly IExceptionService _exceptionService;
        private readonly IGameScoreFactory _gameScoreFactory;
        #endregion

        #region Constructor
        public GamingController(IGameQuestionService gameQuestionService,
            IGameAnswerService gameAnswerService,
            IGameScoreService gameScoreService,
            IGamePropertyService gamePropertyService,
            IGameModeService gameModeService,
            IGameCategoryService gameCategoryService,
            IGameAnswerFactory gameAnswerFactory,
            IExceptionService exceptionService,
            IGameScoreFactory gameScoreFactory)
        {
            this._gameQuestionService = gameQuestionService;
            this._gameAnswerService = gameAnswerService;
            this._gameScoreService = gameScoreService;
            this._gamePropertyService = gamePropertyService;
            this._gameModeService = gameModeService;
            this._gameCategoryService = gameCategoryService;
            this._gameAnswerFactory = gameAnswerFactory;
            this._exceptionService = exceptionService;
            this._gameScoreFactory = gameScoreFactory;
        }
        #endregion


        #region Validations
        private void ValidateGamingQuestion(ApiRequestBody<PagingParams, int> requestMapper)
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
                error.Add(Constants.GamingConstants.GAME_CATEGORY_ID_REQUIRED);
            }

            if (requestMapper.Header.PageNumber == 0)
            {
                error.Add(Constants.GamingConstants.PAGE_NUMBER_REQUIRED);
            }

            if (requestMapper.Header.PageSize == 0)
            {
                error.Add(Constants.GamingConstants.PAGE_SIZE_REQUIRED);
            }

            if (error.Count > 0)
            {
                string errorMessage = string.Concat(ResourceManager.GetResource(Constants.INVALID_ARGS), string.Join("|", error));
                throw new ArgumentException(errorMessage);
            }
        }

        private void ValidateGameScore(GameScoreModel gameScoreModel)
        {
            if (gameScoreModel == null)
            {
                throw new ArgumentException(ResourceManager.GetResource(Constants.INVALID_ARGS));
            }

            List<string> error = new List<string>();

            //if (CommonMethods.GetRequestHeaderUserId(Request) == 0)
            //{
            //    error.Add(Constants.CSI_FEEDBACK_PARAM_USER_ID);
            //}

            if (gameScoreModel.GameCategoryId == 0)
            {
                error.Add(Constants.GamingConstants.GAME_CATEGORY_ID_REQUIRED);
            }

            if (gameScoreModel.GameModeId == 0)
            {
                error.Add(Constants.GamingConstants.GAME_MODE_REQUIRED);
            }

            if (gameScoreModel.GamePoints == 0)
            {
                error.Add(Constants.GamingConstants.GAME_POINT_REQUIRED);
            }

            if (error.Count > 0)
            {
                string errorMessage = string.Concat(ResourceManager.GetResource(Constants.INVALID_ARGS), string.Join("|", error));
                throw new ArgumentException(errorMessage);
            }
        }

        private void ValidateLeadershipBoard(ApiRequestBody<PagingParams, int> requestMapper)
        {
            if (requestMapper == null)
            {
                throw new ArgumentException(ResourceManager.GetResource(Constants.INVALID_ARGS));
            }

            List<string> error = new List<string>();
            if (requestMapper.Header.PageNumber == 0)
            {
                error.Add(Constants.GamingConstants.PAGE_NUMBER_REQUIRED);
            }

            if (requestMapper.Header.PageSize == 0)
            {
                error.Add(Constants.GamingConstants.PAGE_SIZE_REQUIRED);
            }

            if (error.Count > 0)
            {
                string errorMessage = string.Concat(ResourceManager.GetResource(Constants.INVALID_ARGS), string.Join("|", error));
                throw new ArgumentException(errorMessage);
            }
        }

        private void ValidateLeadershipBadge(ApiRequestBody<PagingParams, int> requestMapper)
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
                error.Add(Constants.GamingConstants.BADGE_REQUIRED);
            }

            if (requestMapper.Header.PageNumber == 0)
            {
                error.Add(Constants.GamingConstants.PAGE_NUMBER_REQUIRED);
            }

            if (requestMapper.Header.PageSize == 0)
            {
                error.Add(Constants.GamingConstants.PAGE_SIZE_REQUIRED);
            }

            if (error.Count > 0)
            {
                string errorMessage = string.Concat(ResourceManager.GetResource(Constants.INVALID_ARGS), string.Join("|", error));
                throw new ArgumentException(errorMessage);
            }
        }

        #endregion

        #region APIs related to Game

        /// <summary>
        /// API to get list of questions
        /// </summary>
        /// <param name="requestMapper"></param>
        /// <returns></returns>
        //[JwtAuthenticationFilter]
        [Route("getquestions")]
        [HttpPost]
        public async Task<ApiResponseBody<GameQuestionResponse,Response>> GetQuestions(ApiRequestBody<PagingParams, int> requestMapper)
        {
            ApiResponseBody<GameQuestionResponse, Response> response = new() { Data = new GameQuestionResponse() };
            this.ValidateGamingQuestion(requestMapper);
            var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
            try
            {
                GameQuestionResponse questionResponseModel = new GameQuestionResponse();
                var questionEntity = await _gameQuestionService.GetQuestionsByGameCategoryId(requestMapper.Data);
                if (questionEntity.Count > 0)
                {
                    var questionList = (List<TVS.Data.Models.GameQuestion>)CommonFunction.GetRecordList<TVS.Data.Models.GameQuestion>(questionEntity, requestMapper.Header);
                    List<GameQuestionModel> questionModelList = new List<GameQuestionModel>();
                    if (questionList.Count > 0)
                    {
                        questionList.ForEach( x =>
                        {
                            questionModelList.Add(new GameQuestionModel()
                            {
                                GameCategoryId = x.GameCategoryId,
                                QuestionId = x.QuestionId,
                                QuestionText = x.QuestionText,
                                IsActive = x.IsActive,
                                HelpText = x.HelpText,
                                QuestionImageUrl = x.QuestionImageUrl,
                                Weightage = x.Weightage,
                                Answers = _gameAnswerFactory.GameAnswerEntityToModelList(_gameAnswerService.GetAnswersByQuestionId((int)x.QuestionId))
                            });
                        });
                    }

                    //Getting coins for various mode
                    var gameMode = await _gameModeService.GetGameModes();
                    if (gameMode.Count > 0)
                    {
                        gameMode.ForEach(x =>
                        {
                            questionResponseModel.GameModeDetail.Add(new GameModeDetail()
                            {
                                GameModeName = x.GameModeName,
                                GameModeId = x.GameModeId,
                                TotalCoins =  _gameScoreService.GetTotalScoresByUserAndGameMode(Convert.ToInt32(userId), x.GameModeId)
                            });
                        });
                    }

                    //Getting help & flip coins
                    var gameCategory = _gameCategoryService.GetGameGategoryById(requestMapper.Data);
                    if (gameCategory != null)
                    {
                        questionResponseModel.HelpCoins = gameCategory.HelpCoins;
                        questionResponseModel.FlipCoins = gameCategory.FlipCoints;
                    }

                    questionResponseModel.Questions = questionModelList;
                    response.Data = questionResponseModel;
                    response.Response = new Response(HttpStatusCode.OK, ResourceManager.GetResource(Constants.SUCCESS), ResourceManager.GetResource(Constants.SUCCESS));
                    return response;
                }
                else
                {
                    response.Response = new Response(HttpStatusCode.NotFound, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND));
                    return response;
                }
            }
            catch (Exception ex)
            {
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Get Questions", string.Empty, "Gaming", string.Empty);
                response.Response = new Response(HttpStatusCode.ExpectationFailed, Constants.FAILURE, Constants.DB_ERROR);
                return response;
            }
        }

        //[JwtAuthenticationFilter]
        [HttpPost]
        [Route("savescores")]
        public async Task<ApiResponseBody<GameScore, Response>> SaveGameScore(GameScoreModel gameScoreModel)
        {
            ApiResponseBody<GameScore, Response> jSONResponseMapper = new ApiResponseBody<GameScore, Response>() { Data = new GameScore(), Response = new Model.Models.Response() };
            this.ValidateGameScore(gameScoreModel);
            var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
            try
            {
                var gameScore = _gameScoreFactory.GameScoreModelToEntity(gameScoreModel);
                //gameScore.BadgeId = _gamePropertyService.GetBadgeByScore(gameScoreDto.GamePoints);
                gameScore.UserId = Convert.ToInt32(userId);
                gameScore.InsertedBy = Convert.ToInt32(userId);
                gameScore.InsertedOn = DateTime.Now;
                gameScore.IsActive = true;

                var questionEntity = await _gameScoreService.Save(gameScore);
                if (questionEntity != null)
                {
                    jSONResponseMapper.Data = questionEntity;
                    return jSONResponseMapper;
                }
                else
                {
                    return jSONResponseMapper;
                }
            }
            catch (Exception ex)
            {
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Save Score", string.Empty, "Gaming", string.Empty);
                var response = new Response(HttpStatusCode.ExpectationFailed, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND));
                jSONResponseMapper.Response = response;
                return jSONResponseMapper;
            }
        }

        //[JwtAuthenticationFilter]
        [HttpPost]
        [Route("reducecoins")]
        public async Task<ApiResponseBody<long, Response>> ReduceCoins(GameScoreModel gameScoreModel)
        {
            ApiResponseBody<long, Response> jSONResponseMapper = new ApiResponseBody<long, Response>() { Response = new Model.Models.Response() };
            this.ValidateGameScore(gameScoreModel);
            var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
            try
            {
                long totalCoins = 0;
                var gameScore = await _gameScoreService.GetUsersGameScoreByCategoryAndMode((long)gameScoreModel.GameCategoryId, (long)gameScoreModel.GameModeId, Convert.ToInt32(userId));
                if (gameScore != null)
                {
                    gameScore.GamePoints -= gameScoreModel.GamePoints;
                    var gameScoreEntity = await _gameScoreService.Update(gameScore);
                    if (gameScoreEntity != null)
                    {
                        totalCoins = (await _gameScoreService.GetGameScoreListByUserId(Convert.ToInt32(userId))).Sum(x => x.GamePoints);
                    }
                    jSONResponseMapper.Data = totalCoins;

                    jSONResponseMapper.Response = (new Response(HttpStatusCode.OK, ResourceManager.GetResource(Constants.SUCCESS), ResourceManager.GetResource(Constants.SUCCESS)));
                    return jSONResponseMapper;
                }
                else
                {
                    jSONResponseMapper.Response = (new Response(HttpStatusCode.NotFound, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND)));
                    return jSONResponseMapper;
                }
            }
            catch (Exception ex)
            {
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Save Score", string.Empty, "Gaming", string.Empty);
                jSONResponseMapper.Response = (new Response(HttpStatusCode.ExpectationFailed, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND)));
                return jSONResponseMapper;
            }
        }

        #endregion

        #region APIs related to Leadership & Badges

        /// <summary>
        /// API to get list of badges for a particular user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getbadges")]
        public async Task<ApiResponseBody<List<BadgeModel>, Response>> GetBadges()
        {
            ApiResponseBody<List<BadgeModel>, Response> response = new ApiResponseBody<List<BadgeModel>, Response>() { Data = new List<BadgeModel>() };
            var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
            try
            {
                List<BadgeModel> badges = new();
                var gameScores = await _gameScoreService.GetGameScoreListByUserId(Convert.ToInt32(userId));
                if (gameScores != null)
                {
                    var scores = gameScores.GroupBy(i => i.BadgeId);
                    scores.ToList().ForEach( x =>
                    {
                        badges.Add(new BadgeModel()
                        {
                            NumberOfBadges = x.Count(),
                            BadgeId = x.Key,
                            BadgeName = _gamePropertyService.GetPropertyById((long)x.Key),
                        });
                    });
                    response.Data = badges;
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
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Save Score", string.Empty, "Gaming", string.Empty);
                response.Response = (new Response(HttpStatusCode.ExpectationFailed, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND)));
                return response;
            }
        }

        /// <summary>
        /// API to get list of badges for a particular user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("getleadershipboard")]
        public async Task<ApiResponseBody<LeadershipBoardResponse, Response>> GetLeadershipBoard([FromBody] ApiRequestBody<PagingParams, int> requestMapper)
        {
            ApiResponseBody<LeadershipBoardResponse, Response> response = new() { Data = new LeadershipBoardResponse() };
            this.ValidateLeadershipBoard(requestMapper);
            var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
            try
            {
                LeadershipBoardResponse leadershipBoardResponse = new();
                List<LeadershipBoard> leadershipBoardList = new();
                var gameModeId = requestMapper.Data; //_gameModeService.GetGameModeIdByCode(requestMapper.Data);               
                var listGameScores = await _gameScoreService.GetGameScoreListByGameMode(gameModeId);
                if (listGameScores != null)
                {
                    leadershipBoardList = listGameScores.GroupBy(d => d.UserId).Select(g => new LeadershipBoard()
                    {
                        TotalScores = g.Sum(s => s.GamePoints),
                        FullName = g.First().User.FullName,
                        ProfileImageUrl = g.First().User.ProfileImagePath,
                        IsCurrentUser = (g.First().UserId == Convert.ToDouble(userId)),
                    }).OrderByDescending(x => x.TotalScores).ToList();

                    leadershipBoardList = leadershipBoardList.Select((x, i) => new LeadershipBoard()
                    {
                        Rank = i + 1,
                        TotalScores = x.TotalScores,
                        FullName = x.FullName,
                        ProfileImageUrl = x.ProfileImageUrl,
                        IsCurrentUser = x.IsCurrentUser
                    }).OrderBy(s => s.Rank).OrderByDescending(x => x.IsCurrentUser).ToList();

                    leadershipBoardResponse.LeadershipBoardList = (List<LeadershipBoard>)CommonFunction.GetRecordList<LeadershipBoard>(leadershipBoardList, requestMapper.Header);
                    leadershipBoardResponse.PagingHeader = (PagingHeader)CommonFunction.GetPagingHeader(leadershipBoardList, requestMapper.Header, string.Empty);
                    response.Data = leadershipBoardResponse;
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
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Save Score", string.Empty, "Gaming", string.Empty);
                response.Response = (new Response(HttpStatusCode.ExpectationFailed, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND)));
                return response;
            }
        }

        /// <summary>
        /// Get Leadership board by badge id
        /// </summary>
        /// <param name="badgeId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("getleadershipboardbybadge")]
        public async Task<ApiResponseBody<LeadershipBoardResponse, Response>> GetLeadershipByBadge([FromBody] ApiRequestBody<PagingParams, int> requestMapper)
        {
            ApiResponseBody<LeadershipBoardResponse, Response> response = new() { Data = new LeadershipBoardResponse() };
            this.ValidateLeadershipBadge(requestMapper);
            try
            {
                var userId = Convert.ToString(((string[])Request.Headers.GetCommaSeparatedValues("userid"))[0]);
                LeadershipBoardResponse leadershipBoardResponse = new();
                List<LeadershipBoard> leadershipBoardList = new();
                var gameScores = await _gameScoreService.GetGameScoreListByBadgeId(requestMapper.Data);
                if (gameScores != null)
                {
                    leadershipBoardList = gameScores.GroupBy(x => new { x.BadgeId, x.UserId, x.User }).Select(y => new LeadershipBoard()
                    {
                        NumberOfBadges = y.ToList().Count,
                        FullName = y.FirstOrDefault().User.FullName,
                        ProfileImageUrl = y.FirstOrDefault().User.ProfileImagePath,
                        IsCurrentUser = (y.Key.UserId == Convert.ToDouble(userId)),
                    }).OrderByDescending(y => y.NumberOfBadges).ToList();

                    leadershipBoardList = leadershipBoardList.Select((x, i) => new LeadershipBoard()
                    {
                        Rank = i + 1,
                        NumberOfBadges = x.NumberOfBadges,
                        FullName = x.FullName,
                        ProfileImageUrl = x.ProfileImageUrl,
                        IsCurrentUser = x.IsCurrentUser
                    }).OrderBy(x => x.Rank).OrderByDescending(x => x.IsCurrentUser).ToList();

                    leadershipBoardResponse.LeadershipBoardList = (List<LeadershipBoard>)CommonFunction.GetRecordList<LeadershipBoard>(leadershipBoardList, requestMapper.Header);
                    leadershipBoardResponse.PagingHeader = (PagingHeader)CommonFunction.GetPagingHeader(leadershipBoardList, requestMapper.Header, string.Empty);
                    var badgeName =  _gamePropertyService.GetPropertyById(requestMapper.Data);
                    response.Data = leadershipBoardResponse;
                    response.Response = (new Response(HttpStatusCode.OK, ResourceManager.GetResource(Constants.SUCCESS), badgeName));
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
                await _exceptionService.InsertLogException(ex.Message, ex.StackTrace, "Gaming", "Save Score", string.Empty, "Gaming", string.Empty);
                response.Response = (new Response(HttpStatusCode.ExpectationFailed, ResourceManager.GetResource(Constants.FAILURE), ResourceManager.GetResource(Constants.RECORD_NOT_FOUND)));
                return response;
            }
        }

        #endregion
    }
}
