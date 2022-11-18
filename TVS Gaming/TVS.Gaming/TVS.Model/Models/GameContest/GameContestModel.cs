using System;
using System.Collections.Generic;

namespace TVS.Model.Models.GameContest
{
    public partial class GameContestModel
    {
        public long ContestId { get; set; }
        public long? QuestionId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
