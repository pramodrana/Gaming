using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.GameCategory;
using TVS.Repository.Repository.GameQuestion;

namespace TVS.ApiService.Service.GameQuestion
{
    public class GameQuestionService : IGameQuestionService
    {
        #region Private Variables
        private readonly IGameQuestionRepository _gameQuestionRepository;
        private readonly IGameCategoryRepository _gameCategoryRepository;
        #endregion

        #region Constructor
        public GameQuestionService(IGameQuestionRepository gameQuestionRepository,
            IGameCategoryRepository gameCategoryRepository)
        {
            this._gameQuestionRepository = gameQuestionRepository;
            this._gameCategoryRepository = gameCategoryRepository;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Method to get list of question on the basis of selected game category
        /// </summary>
        /// <param name="gameCategoryCode"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameQuestion>> GetQuestionsByGameCategoryId(int gameCategoryId)
        {
            try
            {
                if (gameCategoryId > 0)
                {

                    return await _gameQuestionRepository.GetByGameCategoryId(gameCategoryId);
                }
                else
                {
                    throw new ArgumentException(Constants.BAD_REQUEST);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
        }

        #endregion
    }
}
