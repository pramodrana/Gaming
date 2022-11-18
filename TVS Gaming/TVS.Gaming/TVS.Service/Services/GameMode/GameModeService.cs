
using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.GameMode;

namespace TVS.ApiService.Service.GameMode
{
    public class GameModeService : IGameModeService
    {
        #region Private Variables
        private readonly IGameModeRepository _gameModeRepository;
        #endregion

        #region Constructor

        public GameModeService(IGameModeRepository gameModeRepository)
        {
            this._gameModeRepository = gameModeRepository;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get Mode Id by code
        /// </summary>
        /// <param name="game mode code"></param>
        /// <returns></returns>
        public async Task<int> GetGameModeIdByCode(int gameModeCode)
        {
            try
            {
                if (gameModeCode > 0)
                {
                    var gameModeId = await _gameModeRepository.GetGameModeIdByCode(gameModeCode);
                    return gameModeId;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
        }

        /// <summary>
        /// Get All the game mode list
        /// </summary>
        /// <returns></returns>
        public async Task<List<Data.Models.GameMode>> GetGameModes()
        {
            try
            {
                var gameModeList = (await _gameModeRepository.GetAll()).Where(x => x.IsActive);
                if (gameModeList != null)
                {
                    return gameModeList.ToList();
                }
                else
                {
                    throw new ArgumentException(Constants.RECORD_NOT_FOUND);
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
