using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class GameMode
    {
        public GameMode()
        {
            GameScores = new HashSet<GameScore>();
        }

        public long GameModeId { get; set; }
        public string? GameModeName { get; set; }
        public int Code { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual UserProfile? InsertedByNavigation { get; set; }
        public virtual UserProfile? UpdatedByNavigation { get; set; }
        public virtual ICollection<GameScore> GameScores { get; set; }
    }
}
