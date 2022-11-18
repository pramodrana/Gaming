using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameScore;

namespace TVS.Factory.Factory.GameScore
{
    public class GameScoreFactory: IGameScoreFactory
    {
        #region Public Methods

        /// <summary>
        /// Method to convert GameScoreDTo to entity
        /// </summary>
        /// <param name="gameScoreModel"></param>
        /// <returns></returns>
        public Data.Models.GameScore GameScoreModelToEntity(GameScoreModel gameScoreModel)
        {
            Data.Models.GameScore gameScore = new();
            if (gameScoreModel != null)
            {
                gameScore.UserId = gameScoreModel.UserId;
                gameScore.GamePoints = gameScoreModel.GamePoints;
                gameScore.BadgeId = gameScoreModel.BadgeId;
                gameScore.InsertedBy = gameScoreModel.InsertedBy;
                gameScore.InsertedOn = gameScoreModel.InsertedOn;
                gameScore.UpdatedBy = gameScoreModel.UpdatedBy;
                gameScore.UpdatedOn = gameScoreModel.UpdatedOn;
                gameScore.IsActive = gameScoreModel.IsActive;
                gameScore.GameCategoryId = gameScoreModel.GameCategoryId;
                gameScore.GameModeId = gameScoreModel.GameModeId;
            }
            return gameScore;
        }

        #endregion
    }
}
