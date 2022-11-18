using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Service.Service.Game
{
    public interface IGameService
    {
        Task<List<Data.Models.Game>> GetGames();
    }
}
