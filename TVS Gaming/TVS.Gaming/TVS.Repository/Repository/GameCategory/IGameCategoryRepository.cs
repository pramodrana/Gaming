using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameCategory
{
    public interface IGameCategoryRepository : IGenericRepository<Data.Models.GameCategory>
    {
        Task<List<Data.Models.GameCategory>> GetGameGategoryListByGameId(long gameId);
    }
}
