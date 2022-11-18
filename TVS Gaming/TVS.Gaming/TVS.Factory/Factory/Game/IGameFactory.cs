using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.Game;

namespace TVS.Factory.Factory.Game
{
    public interface IGameFactory
    {
        GameModel GameEntityToModel(Data.Models.Game game);
        List<GameModel> GameEntityToModelList(List<Data.Models.Game> gameList);
    }
}
