using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameCategory;

namespace TVS.Factory.Factory.GameCategory
{
    public interface IGameCategoryFactory
    {
        GameCategoryModel GameCategoryEntityToModel(TVS.Data.Models.GameCategory gameCategory);
        List<GameCategoryModel> GameCategoryEntityToModelList(List<TVS.Data.Models.GameCategory> gameCategoryList);
    }
}
