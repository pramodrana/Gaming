using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Common.Constant;
using TVS.Common.Exception;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.GameScore;

namespace TVS.ApiService.Service.GameScore
{
    public class GameScoreService : IGameScoreService
    {
        #region Private Variable
        private readonly IGameScoreRepository _gameScoreRepository;      
        #endregion

        #region Constructor
        public GameScoreService(IGameScoreRepository gameScoreRepository)
        {
            this._gameScoreRepository = gameScoreRepository;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Save Game Score
        /// </summary>
        /// <param name="gameScore"></param>
        /// <returns></returns>
        public async Task<Data.Models.GameScore> Save(Data.Models.GameScore gameScore)
        {
            try
            {
                if (gameScore != null)
                {
                   await _gameScoreRepository.Insert(gameScore);
                   await _gameScoreRepository.Save();
                    return gameScore;
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
        /// Update Game Score
        /// </summary>
        /// <param name="gameScore"></param>
        /// <returns></returns>
        public async Task<Data.Models.GameScore> Update(Data.Models.GameScore gameScore)
        {
            try
            {
                if (gameScore != null)
                {
                   await _gameScoreRepository.Update(gameScore);
                   await _gameScoreRepository.Save();
                    return gameScore;
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
        /// Get Game Score
        /// </summary>
        /// <param name="gameScore"></param>
        /// <returns></returns>
        public async Task<Data.Models.GameScore> Get(long gameScoreId)
        {
            try
            {
                if (gameScoreId > 0) 
                {
                    return await _gameScoreRepository.GetById(gameScoreId);                    
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
        /// Get total scores obtained by a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public long GetTotalScoreByUserId(long userId ,out Data.Models.UserProfile userProfile)
        {
            try
            {
                if (userId > 0)
                {
                    return _gameScoreRepository.GetTotalScoreByUserId(userId, out userProfile);
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
        /// Method to get scores for an user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameScore>> GetGameScoreListByUserId(long userId = 0)
        {

            try
            {
                if (userId > 0)
                {
                    List<Data.Models.GameScore> gameScores = new();
                    gameScores = (await _gameScoreRepository.GetGameScoresByUserId(userId)).ToList();                  
                    return gameScores;
                }
                else
                {
                    List<Data.Models.GameScore> gameScores = new();
                    gameScores = (await _gameScoreRepository.GetAll()).ToList();
                    return gameScores;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Method to get scores for an user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameScore>> GetGameScoreListByGameMode(long gameModeId)
        {

            try
            {
                if (gameModeId > 0)
                {
                    List<Data.Models.GameScore> gameScores = new();
                    gameScores = (await _gameScoreRepository.GetGameScoresByGameModeId(gameModeId)).ToList();
                    return gameScores;
                }
                else
                {
                    List<Data.Models.GameScore> gameScores = new();
                    gameScores = (await _gameScoreRepository.GetAll()).ToList();
                    return gameScores;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Getting total scores for a particular game mode for a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="gameModeId"></param>
        /// <returns></returns>
        public async Task<long> GetTotalScoresByUserAndGameMode(long userId,long gameModeId)
        {
            try
            {
                if (userId > 0 && gameModeId > 0)
                {
                    return await _gameScoreRepository.GetTotalGamePointsByGameMode(userId, gameModeId);
                }
                else
                {
                    throw new ArgumentException(Constants.BAD_REQUEST);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Getting total scores for a particular game category for a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="gameCategoryId"></param>
        /// <returns></returns>
        public async Task<long> GetTotalScoresByUserAndGame(long userId, long gameId)
        {
            try
            {
                if (userId > 0 && gameId > 0)
                {
                    return await _gameScoreRepository.GetTotalGamePointsByGameId(userId, gameId);
                }
                else
                {
                    throw new ArgumentException(Constants.BAD_REQUEST);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new CustomException(ResourceManager.GetResource(Constants.DB_SAVE_ERROR));
            }
        }

        /// <summary>
        /// Method to get scores by badge Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<Data.Models.GameScore>> GetGameScoreListByBadgeId(long badgeId)
        {
            try
            {
                if (badgeId > 0)
                {
                    List<Data.Models.GameScore> gameScores = new List<Data.Models.GameScore>();
                    gameScores = (await _gameScoreRepository.GetGameSocresByBadgeId(badgeId)).ToList();
                    return gameScores;
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
                    return await _gameScoreRepository.GetUsersGameScoreByCategoryAndMode(gameCategoryId, gameModeId, userId);
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
