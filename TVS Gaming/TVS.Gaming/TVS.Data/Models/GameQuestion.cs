using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class GameQuestion
    {
        public GameQuestion()
        {
            GameAnswers = new HashSet<GameAnswer>();
            GameContests = new HashSet<GameContest>();
        }

        public long QuestionId { get; set; }
        public long? GameCategoryId { get; set; }
        public string? QuestionText { get; set; }
        public string? HelpText { get; set; }
        public string? QuestionImageUrl { get; set; }
        public int Weightage { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual GameCategory? GameCategory { get; set; }
        public virtual UserProfile? InsertedByNavigation { get; set; }
        public virtual UserProfile? UpdatedByNavigation { get; set; }
        public virtual ICollection<GameAnswer> GameAnswers { get; set; }
        public virtual ICollection<GameContest> GameContests { get; set; }
    }
}
