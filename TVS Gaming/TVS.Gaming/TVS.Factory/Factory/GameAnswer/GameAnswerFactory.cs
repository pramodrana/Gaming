using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameAnswer;

namespace TVS.Factory.Factory.GameAnswer
{
    public class GameAnswerFactory : IGameAnswerFactory
    {
        #region Public Methods

        /// <summary>
        /// Method to convert Game Answer Entity to Model
        /// </summary>
        /// <param name="gameAnswer"></param>
        /// <returns></returns>
        public GameAnswerModel GameAnswerEntityToModel(TVS.Data.Models.GameAnswer gameAnswer)
        {
            GameAnswerModel gameAnswerModel = new GameAnswerModel();
            if (gameAnswer != null)
            {
                //GameAnswerModel.AnswerId = gameAnswer.AnswerId;
                gameAnswerModel.AnswerText = gameAnswer.AnswerText;

                char[] array = gameAnswer.AnswerText.ToCharArray();
                Random rng = new Random();
                int n = array.Length;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = array[k];
                    array[k] = array[n];
                    array[n] = value;
                }

                gameAnswerModel.ShuffleText = new string(array);
                //GameAnswerModel.IsCorrectAnswer = gameAnswer.IsCorrectAnswer;
            }
            return gameAnswerModel;
        }

        /// <summary>
        /// Method to convert answer entity list to Model list
        /// </summary>
        /// <param name="gameAnswerList"></param>
        /// <returns></returns>
        public List<GameAnswerModel> GameAnswerEntityToModelList(List<TVS.Data.Models.GameAnswer> gameAnswerList)
        {
            List<GameAnswerModel> answerModelList = new List<GameAnswerModel>();
            gameAnswerList.ForEach(x =>
            {
                answerModelList.Add(GameAnswerEntityToModel(x));
            });
            return answerModelList;
        }



        #endregion
    }
}
