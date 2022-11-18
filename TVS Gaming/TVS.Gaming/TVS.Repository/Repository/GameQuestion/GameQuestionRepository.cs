
using Microsoft.EntityFrameworkCore;
using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameQuestion
{
    public class GameQuestionRepository : GenericRepository<Data.Models.GameQuestion>, IGameQuestionRepository
    {
        #region Public Methods
        /// <summary>
        /// Get Questions by Game category id
        /// </summary>
        /// <param name="gameCategoryId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameQuestion>> GetByGameCategoryId(int gameCategoryId)
        {
            try
            {
                return await  _tvsDbContext.GameQuestions.Where(x => x.GameCategoryId == gameCategoryId).ToListAsync();
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
