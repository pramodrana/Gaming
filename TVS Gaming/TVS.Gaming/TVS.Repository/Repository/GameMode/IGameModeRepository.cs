
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameMode
{
    public interface IGameModeRepository : IGenericRepository<Data.Models.GameMode>
    {
        Task<int> GetGameModeIdByCode(int gameModeCode);
    }
}
