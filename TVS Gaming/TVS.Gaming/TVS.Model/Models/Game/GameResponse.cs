using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Model.Models.Game
{
    public class GameResponse
    {
        public GameResponse()
        {
            GameList = new List<GameModel>();
        }
        public string UserName { get; set; }
        public string ProfileImageUrl { get; set; }
        public long TotalCoins { get; set; }
        public List<GameModel> GameList { get; set; }
    }
}
