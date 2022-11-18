using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class GameCategory
    {
        public GameCategory()
        {
            GameQuestions = new HashSet<GameQuestion>();
            GameScores = new HashSet<GameScore>();
        }

        public long GameCategoryId { get; set; }
        public string? GameCategoryName { get; set; }
        public long? GameId { get; set; }
        public long GameCategoryCode { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public long HelpCoins { get; set; }
        public long FlipCoints { get; set; }
        public string? IsActive { get; set; }

        public virtual Game? Game { get; set; }
        public virtual UserProfile? InsertedByNavigation { get; set; }
        public virtual UserProfile? UpdatedByNavigation { get; set; }
        public virtual ICollection<GameQuestion> GameQuestions { get; set; }
        public virtual ICollection<GameScore> GameScores { get; set; }
    }
}
