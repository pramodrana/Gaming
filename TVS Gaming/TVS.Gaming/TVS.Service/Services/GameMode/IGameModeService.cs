using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.ApiService.Service.GameMode
{
    public interface IGameModeService
    {
        Task<int> GetGameModeIdByCode(int gameModeCode);
        Task<List<Data.Models.GameMode>> GetGameModes();
    }
}
