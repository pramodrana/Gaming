using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.ApiService.Service.GameScore
{
    public interface IGameScoreService
    {
        long GetTotalScoreByUserId(long userId, out Data.Models.UserProfile userProfile);
        Task<Data.Models.GameScore> Save(Data.Models.GameScore gameScore);
        Task<Data.Models.GameScore> Update(Data.Models.GameScore gameScore);
        Task<Data.Models.GameScore> Get(long gameScoreId);
        Task<List<Data.Models.GameScore>> GetGameScoreListByUserId(long userId = 0);
        Task<List<Data.Models.GameScore>> GetGameScoreListByGameMode(long gameModeId);
        Task<long> GetTotalScoresByUserAndGameMode(long userId, long gameModeId);
        Task<long> GetTotalScoresByUserAndGame(long userId, long gameId);
        Task<List<Data.Models.GameScore>> GetGameScoreListByBadgeId(long badgeId);
        Task<Data.Models.GameScore> GetUsersGameScoreByCategoryAndMode(long gameCategoryId, long gameModeId, long userId);
    }
}
