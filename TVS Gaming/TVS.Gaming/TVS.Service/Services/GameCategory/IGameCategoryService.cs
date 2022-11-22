using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.ApiService.Service.GameCategory
{
    public interface IGameCategoryService
    {
        Task<List<Data.Models.GameCategory>> GetGameGategoryListByGameId(long gameId);
        Data.Models.GameCategory GetGameGategoryById(long gameCategoryId);
    }
}
