using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class DmsquestionAnswerMapper
    {
        public int Id { get; set; }
        public int MapperType { get; set; }
        public string MapKey { get; set; } = null!;
        public string MapValue { get; set; } = null!;
        public int DmsquestionId { get; set; }
        public int DmsanswerId { get; set; }
        public string? QuestionDesc { get; set; }
    }
}
