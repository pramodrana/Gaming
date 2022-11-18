

using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.GameCategory;

namespace TVS.ApiService.Service.GameCategory
{
    public class GameCategoryService : IGameCategoryService
    {
        #region Private Variables
         private readonly IGameCategoryRepository _gameCategoryRepository;
        #endregion

        #region Constructor
        public GameCategoryService( IGameCategoryRepository gameCategoryRepository)
        {
            this._gameCategoryRepository = gameCategoryRepository;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Get Category list by game id
        /// </summary>
        /// <param name="gameCategoryId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameCategory>> GetGameGategoryListByGameId(long gameId)
        {
            try
            {
                if (gameId > 0)
                {
                    return (await _gameCategoryRepository.GetGameGategoryListByGameId(gameId)).ToList();
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
        }

        /// <summary>
        /// Get Category Id by code
        /// </summary>
        /// <param name="gameCategoryId"></param>
        /// <returns></returns>
        public async Task<Data.Models.GameCategory> GetGameGategoryById(long gameCategoryId)
        {
            try
            {
                if (gameCategoryId > 0)
                {
                    var category = await _gameCategoryRepository.GetById(gameCategoryId);
                    return category;
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
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
