using TVS.Common.Constant;
using TVS.Common.Exception;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.Game;

namespace TVS.Service.Service.Game
{
    public class GameService : IGameService
    {
        #region Private Variables
        private readonly IGameRepository _gameRepository;
        #endregion

        #region Constructor
        public GameService(IGameRepository gameRepository)
        {
            this._gameRepository = gameRepository;
        }
        #endregion

        #region Public Variables
        
        /// <summary>
        /// Getting list of all the available active games
        /// </summary>
        /// <returns></returns>
        public async Task<List<Data.Models.Game>> GetGames()
        {
            try
            {
                return (await _gameRepository.GetAll()).ToList();               
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }
        #endregion
    }
}
