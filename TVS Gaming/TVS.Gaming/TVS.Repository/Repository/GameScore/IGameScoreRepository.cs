using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameScore
{
    public interface IGameScoreRepository : IGenericRepository<Data.Models.GameScore>
    {
        long GetTotalScoreByUserId(long userId, out Data.Models.UserProfile userProfile);
        Task<List<Data.Models.GameScore>> GetGameScoresByUserId(long userId);
        Task<List<Data.Models.GameScore>> GetGameScoresByGameModeId(long gameModeId);
        long GetTotalGamePointsByGameMode(long userId, long gameModeId);
        Task<long> GetTotalGamePointsByGameId(long userId, long gameCategoryId);
        Task<List<Data.Models.GameScore>> GetGameSocresByBadgeId(long propertyId);
        Task<Data.Models.GameScore> GetUsersGameScoreByCategoryAndMode(long gameCategoryId, long gameModeId, long userId);
    }
}
