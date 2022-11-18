using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameAnswer;

namespace TVS.Factory.Factory.GameAnswer
{
    public interface IGameAnswerFactory
    {
        GameAnswerModel GameAnswerEntityToModel(TVS.Data.Models.GameAnswer gameAnswer);
        List<GameAnswerModel> GameAnswerEntityToModelList(List<TVS.Data.Models.GameAnswer> gameAnswerList);
    }
}
