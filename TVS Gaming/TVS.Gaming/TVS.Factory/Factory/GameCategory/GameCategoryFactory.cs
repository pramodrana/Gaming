using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameCategory;

namespace TVS.Factory.Factory.GameCategory
{
    public class GameCategoryFactory : IGameCategoryFactory
    {
        #region Public Methods

        /// <summary>
        /// Converting Game category entity to model (dto)
        /// </summary>
        /// <param name="gameCategory"></param>
        /// <returns></returns>
        public GameCategoryModel GameCategoryEntityToModel(TVS.Data.Models.GameCategory gameCategory)
        {
            GameCategoryModel gameCategoryModel = new();
            if (gameCategory != null)
            {
                gameCategoryModel.GameCategoryId = gameCategory.GameCategoryId;
                gameCategoryModel.GameCategoryName = gameCategory.GameCategoryName;
                gameCategoryModel.FlipCoins = gameCategory.FlipCoints;
                gameCategoryModel.HelpCoins = gameCategory.HelpCoins;
            }
            return gameCategoryModel;
        }

        /// <summary>
        /// Converting Game category list to model list
        /// </summary>
        /// <param name="gameCategoryList"></param>
        /// <returns></returns>
        public List<GameCategoryModel> GameCategoryEntityToModelList(List<TVS.Data.Models.GameCategory> gameCategoryList)
        {
            List<GameCategoryModel> gameCategoryModelList = new();
            if (gameCategoryList.Count > 0)
            {
                gameCategoryList.ForEach(x => {
                    gameCategoryModelList.Add(GameCategoryEntityToModel(x));
                });
            }
            return gameCategoryModelList;
        }

        #endregion
    }
}
