using System;
using System.Collections.Generic;

namespace TVS.Model.Models.GameScore
{
    public partial class GameScoreModel
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
    }
}
