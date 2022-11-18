using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameMode;

namespace TVS.Factory.Factory.Game
{
    public interface IGameModeFactory
    {
        GameModeModel GameModeEntityToModel(TVS.Data.Models.GameMode gameMode);
        List<GameModeModel> GameModeEntityToModelList(List<TVS.Data.Models.GameMode> gameModeList);

    }
}
