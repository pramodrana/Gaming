using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameProperty;

namespace TVS.Factory.Factory.GameProperty
{
    public class GamePropertyFactory: IGamePropertyFactory
    {
        #region Public Methods

        /// <summary>
        /// COnverting game property db entity to model
        /// </summary>
        /// <param name="gameProperty"></param>
        /// <returns></returns>
        public GamePropertyModel GamePropertyEntityToModel(TVS.Data.Models.GameProperty gameProperty)
        {
            GamePropertyModel gamePropertyModel = new();
            if (gameProperty != null)
            {
                gamePropertyModel.PropertyId = gameProperty.PropertyId;
                gamePropertyModel.PropertyName = gameProperty.PropertyName;
            }
            return gamePropertyModel;
        }

        /// <summary>
        /// COnverting list of game property object to dto
        /// </summary>
        /// <param name="gamePropertyList"></param>
        /// <returns></returns>
        public List<GamePropertyModel> GamePropertyEntityToModelList(List<TVS.Data.Models.GameProperty> gamePropertyList)
        {
            List<GamePropertyModel> gamePropertyModelList = new List<GamePropertyModel>();
            gamePropertyList?.ForEach(x =>
                {
                    gamePropertyModelList.Add(GamePropertyEntityToModel(x));
                });
            return gamePropertyModelList;
        }


        #endregion
    }
}
