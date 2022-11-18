using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameMode;

namespace TVS.Factory.Factory.Game
{
    public class GameModeFactory : IGameModeFactory
    {
        #region Public Methods
        /// <summary>
        /// Game mode  entity to dto
        /// </summary>
        /// <param name="gameMode"></param>
        /// <returns></returns>
        public GameModeModel GameModeEntityToModel(TVS.Data.Models.GameMode gameMode)
        {
            GameModeModel gameModeModel = new GameModeModel();
            if (gameMode != null)
            {
                gameModeModel.GameModeId = gameMode.GameModeId;
                gameModeModel.GameModeName = gameMode.GameModeName;
            }
            return gameModeModel;
        }

        /// <summary>
        /// Game mode  entity list to dto list
        /// </summary>
        /// <param name="gameModeList"></param>
        /// <returns></returns>
        public List<GameModeModel> GameModeEntityToModelList(List<TVS.Data.Models.GameMode> gameModeList)
        {
            List<GameModeModel> GameModeModelList = new();
            gameModeList?.ForEach(x =>
                {
                    GameModeModelList.Add(GameModeEntityToModel(x));
                });
            return GameModeModelList;
        }
        #endregion
    }
}
