using System;
using System.Collections.Generic;
using TVS.Model.Models.GameAnswer;

namespace TVS.Model.Models.GameQuestion
{
    public partial class GameQuestionModel
    {
        public GameQuestionModel()
        {
            Answers = new List<GameAnswerModel>();
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
        public List<GameAnswerModel> Answers { get; set; }
    }
}
