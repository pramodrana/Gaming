using System;
using System.Collections.Generic;

namespace TVS.Model.Models.GameQuestion
{
    public partial class GameQuestionModel
    {     
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
    }
}
