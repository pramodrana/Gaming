using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Model.Models.Gaming
{
    public class LeadershipBoard
    {
        public int Rank { get; set; }
        public string FullName { get; set; }
        public long TotalScores { get; set; }
        public int NumberOfBadges { get; set; }
        public string ProfileImageUrl { get; set; }
        public bool IsCurrentUser { get; set; }
    }

    public class LeadershipBoardResponse
    {
        public LeadershipBoardResponse()
        {
            LeadershipBoardList = new List<LeadershipBoard>();
            //LeadershipBoard = new LeadershipBoard();
        }
        //public LeadershipBoard LeadershipBoard { get; set; }
        public List<LeadershipBoard> LeadershipBoardList { get; set; }
        public PagingHeader PagingHeader { get; set; }
    }
}
