using Microsoft.EntityFrameworkCore;
using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameMode
{
    public class GameModeRepository : GenericRepository<Data.Models.GameMode>, IGameModeRepository
    {     
        #region Public Methods

        /// <summary>
        /// Get Mode Id by code
        /// </summary>
        /// <param name="gameCategoryCode"></param>
        /// <returns></returns>
        public async Task<int> GetGameModeIdByCode(int gameModeCode)
        {
            try
            {
                if (gameModeCode > 0)
                {
                    var category = await _tvsDbContext.GameModes.Where(x => x.Code == gameModeCode).FirstOrDefaultAsync();
                    return  (int)category.GameModeId;
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
