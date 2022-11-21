using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.GameAnswer;

namespace TVS.ApiService.Service.GameAnswer
{
    public class GameAnswerService : IGameAnswerService
    {
        #region Private Variables
        private readonly IGameAnswerRepository _gameAnswerRepository;
        #endregion

        #region Constructor
        public GameAnswerService(IGameAnswerRepository gameAnswerRepository)
        {
            this._gameAnswerRepository = gameAnswerRepository;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method to get list og answer on the basis of question id
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public List<Data.Models.GameAnswer> GetAnswersByQuestionId(int questionId)
        {
            try
            {
                if (questionId >= 0) 
                return  _gameAnswerRepository.GetGameAnswersByQuestionId(questionId);
                throw new ArgumentException(Constants.INVALID_ARGS);
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
