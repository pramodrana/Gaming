using System;
using System.Collections.Generic;
using TVS.Model.Models.GameScore;

namespace TVS.Model.Models.GameMode
{
    public partial class GameModeModel
    {
        public GameModeModel()
        {
            GameScores = new HashSet<GameScoreModel>();
        }

        public long GameModeId { get; set; }
        public string? GameModeName { get; set; }
        public int Code { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<GameScoreModel> GameScores { get; set; }
    }
}
