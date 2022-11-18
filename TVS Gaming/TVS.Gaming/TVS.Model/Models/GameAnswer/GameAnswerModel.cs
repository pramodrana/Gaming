using System;
using System.Collections.Generic;

namespace TVS.Model.Models.GameAnswer
{
    public partial class GameAnswerModel
    {
        public long AnswerId { get; set; }
        public long? QuestionId { get; set; }
        public string? AnswerText { get; set; }
        public string? ShuffleText { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }      
    }
}
