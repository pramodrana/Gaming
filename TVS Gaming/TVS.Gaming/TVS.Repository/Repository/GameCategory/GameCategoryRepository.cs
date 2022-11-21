using Microsoft.EntityFrameworkCore;
using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameCategory
{
    public class GameCategoryRepository : GenericRepository<Data.Models.GameCategory> , IGameCategoryRepository
    {
       
        #region Public Methods

        /// <summary>
        /// Get Category list by game id
        /// </summary>
        /// <param name="gameCategoryCode"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameCategory>> GetGameGategoryListByGameId(long gameId)
        {
            try
            {
                if (gameId > 0)
                {
                    return await (Task<List<Data.Models.GameCategory>>)_tvsDbContext.GameCategories.Where(x => x.GameId == gameId).ToListAsync();
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
