

using Microsoft.EntityFrameworkCore;
using TVS.Common.Constant;
using TVS.Common.Exception;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameScore
{
    public class GameScoreRepository : GenericRepository<Data.Models.GameScore> , IGameScoreRepository
    {

        #region Public Methods

        /// <summary>
        /// Getting total scores obtianed by user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public long GetTotalScoreByUserId(long userId, out Data.Models.UserProfile userProfile)
        {
            try
            {
                if (userId > 0)
                {
                    long totalpoints = 0;
                    var scores = _tvsDbContext.GameScores.Include(x => x.User).Where(x => x.UserId == userId);
                    userProfile = (scores.ToList().Count > 0) ? scores.FirstOrDefault().User : null;
                    if (scores != null)
                    {
                        totalpoints = scores.Sum(x => x.GamePoints);
                    }
                    return totalpoints;
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Get game scores by user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameScore>> GetGameScoresByUserId(long userId)
        {
            try
            {
                if (userId > 0)
                {
                    return await _tvsDbContext.GameScores.Where(x => x.UserId == userId).ToListAsync();
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Get game scores by game mode
        /// </summary>
        /// <param name="gameModeId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameScore>> GetGameScoresByGameModeId(long gameModeId)
        {
            try
            {
                if (gameModeId > 0)
                {
                    return await (Task<List<Data.Models.GameScore>>)((_tvsDbContext.GameScores.Include(x => x.User).Where(x => x.GameModeId == gameModeId)).ToListAsync());
                }
                else
                {
                    throw new ArgumentException(Constants.DB_ERROR);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Obtaining points gained by a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public long GetTotalGamePointsByGameMode(long userId, long gameModeId)
        {
            try
            {
                if (userId > 0)
                {
                    var gameScores =  _tvsDbContext.GameScores.Where(x => x.UserId == userId && x.GameModeId == gameModeId).ToList();
                    if (gameScores.Count > 0)
                    {
                        long totalPoints = gameScores.Sum(x => x.GamePoints);
                        return totalPoints;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Obtaining points gained by a user for a game category
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<long> GetTotalGamePointsByGameId(long userId, long gameId)
        {
            try
            {
                if (userId > 0)
                {
                    var gameScores = await _tvsDbContext.GameScores.Where(x => x.UserId == userId).
                         Join(_tvsDbContext.GameCategories.Where(x => x.GameId == gameId),
                         r => r.GameCategoryId, p => p.GameCategoryId,
                         (r, p) => new { r.GameCategoryId, r.GamePoints }).ToListAsync();
                    if (gameScores.Count > 0)
                    {
                        long totalPoints = gameScores.Sum(x => x.GamePoints);
                        return totalPoints;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Get List of obtained scores on the basis of badge id
        /// </summary>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameScore>> GetGameSocresByBadgeId(long propertyId)
        {
            try
            {
                if (propertyId > 0)
                {
                    return await _tvsDbContext.GameScores.Include(x => x.User).Where(x => x.BadgeId == propertyId).ToListAsync();
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Method to get game score by game category id , game mode id and user id
        /// </summary>
        /// <param name="gameCategoryId"></param>
        /// <param name="gameModeId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Data.Models.GameScore> GetUsersGameScoreByCategoryAndMode(long gameCategoryId, long gameModeId, long userId)
        {
            try
            {
                if (gameCategoryId > 0 && gameModeId > 0 && userId > 0)
                {
                    return await _tvsDbContext.GameScores.
                        Where(x => x.UserId == userId && x.GameCategoryId == gameCategoryId
                        && x.GameModeId == gameModeId).FirstOrDefaultAsync();
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
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
