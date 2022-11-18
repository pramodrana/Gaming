using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameScore;

namespace TVS.Factory.Factory.GameScore
{
    public interface IGameScoreFactory
    {
        Data.Models.GameScore GameScoreModelToEntity(GameScoreModel gameScoreModel);
    }
}
