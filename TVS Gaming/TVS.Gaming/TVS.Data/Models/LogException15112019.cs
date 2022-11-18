using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class LogException15112019
    {
        public int LogExceptionId { get; set; }
        public string? ErrorMessage { get; set; }
        public string? StackTrace { get; set; }
        public string? PageName { get; set; }
        public string? MethodName { get; set; }
        public string? UserId { get; set; }
        public string? Modulename { get; set; }
        public string? SourceSystem { get; set; }
        public string? Extra1 { get; set; }
        public string? Extra2 { get; set; }
        public string? Extra3 { get; set; }
        public DateTime? Enterydate { get; set; }
    }
}
