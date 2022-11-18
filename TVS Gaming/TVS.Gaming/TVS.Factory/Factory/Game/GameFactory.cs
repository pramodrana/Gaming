using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models.Game;

namespace TVS.Factory.Factory.Game
{
    public class GameFactory : IGameFactory
    {
        #region Public Methods

        /// <summary>
        /// Converting game entity to model
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public GameModel GameEntityToModel(Data.Models.Game game)
        {
            GameModel gameModel = new();
            if (game != null)
            {
                gameModel.GameName = game.GameName;
                gameModel.GameId = game.GameId;
            }
            return gameModel;
        }

        /// <summary>
        /// Converting game list to model list
        /// </summary>
        /// <param name="gameList"></param>
        /// <returns></returns>
        public List<GameModel> GameEntityToModelList(List<Data.Models.Game> gameList)
        {
            List<GameModel> gameModelList = new();
            if (gameList.Count > 0)
            {
                gameList.ForEach(x =>
                {
                    gameModelList.Add(GameEntityToModel(x));
                });
            }
            return gameModelList;
        }

        #endregion
    }
}
