using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Model.Models.GameCategory
{
    public class GameCategoryResponse
    {
        public GameCategoryResponse()
        {
            GameCategoryList = new List<GameCategoryModel>();
        }
        public long TotalCategoryCoints { get; set; }
        public List<GameCategoryModel> GameCategoryList { get; set; }
    }
}
