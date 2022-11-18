using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class GameContest
    {
        public long ContestId { get; set; }
        public long? QuestionId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual UserProfile? InsertedByNavigation { get; set; }
        public virtual GameQuestion? Question { get; set; }
        public virtual UserProfile? UpdatedByNavigation { get; set; }
    }
}
