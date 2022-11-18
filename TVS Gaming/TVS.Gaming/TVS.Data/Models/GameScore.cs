using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class GameScore
    {
        public long ScoreId { get; set; }
        public long? GameCategoryId { get; set; }
        public long? GameModeId { get; set; }
        public long? UserId { get; set; }
        public long GamePoints { get; set; }
        public long? BadgeId { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual GameProperty? Badge { get; set; }
        public virtual GameCategory? GameCategory { get; set; }
        public virtual GameMode? GameMode { get; set; }
        public virtual UserProfile? InsertedByNavigation { get; set; }
        public virtual UserProfile? UpdatedByNavigation { get; set; }
        public virtual UserProfile? User { get; set; }
    }
}
