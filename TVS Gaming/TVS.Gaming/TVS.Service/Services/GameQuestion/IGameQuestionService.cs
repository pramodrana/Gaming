using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.ApiService.Service.GameQuestion
{
    public interface IGameQuestionService
    {
        Task<List<Data.Models.GameQuestion>> GetQuestionsByGameCategoryId(int gameCategoryId);
    }
}
