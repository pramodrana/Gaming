using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Repository.Repository.Generic;

namespace TVS.Repository.Repository.GameQuestion
{
    public interface IGameQuestionRepository : IGenericRepository<Data.Models.GameQuestion>
    {
        Task<List<Data.Models.GameQuestion>> GetByGameCategoryId(int gameCategoryId);
    }
}
