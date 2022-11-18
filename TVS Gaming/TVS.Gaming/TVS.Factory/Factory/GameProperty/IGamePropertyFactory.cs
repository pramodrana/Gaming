using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models;
using TVS.Model.Models.GameProperty;

namespace TVS.Factory.Factory.GameProperty
{
    public interface IGamePropertyFactory
    {
        GamePropertyModel GamePropertyEntityToModel(TVS.Data.Models.GameProperty gameProperty);
        List<GamePropertyModel> GamePropertyEntityToModelList(List<TVS.Data.Models.GameProperty> gamePropertyList);
    }
}
