using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models.Gaming;

namespace TVS.Model.Models.GameQuestion
{
   
    public class GameQuestionResponse
    {
        public GameQuestionResponse()
        {
            Questions = new List<GameQuestionModel>();
            GameModeDetail = new List<GameModeDetail>();
        }

        public long HelpCoins { get; set; }
        public long FlipCoins { get; set; }
        public List<GameModeDetail> GameModeDetail { get; set; }
        public List<GameQuestionModel> Questions { get; set; }
        public PagingHeader PagingHeader { get; set; }
    }

    public class GameModeDetail
    {
        public string GameModeName { get; set; }
        public long GameModeId { get; set; }
        public long TotalCoins { get; set; }
    }
}
