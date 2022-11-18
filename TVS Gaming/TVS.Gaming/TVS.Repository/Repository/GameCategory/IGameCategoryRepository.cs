using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameCategory
{
    public interface IGameCategoryRepository : IGenericRepository<Data.Models.GameCategory>
    {
        Task<IEnumerable<Data.Models.GameCategory>> GetGameGategoryListByGameId(long gameId);
    }
}
