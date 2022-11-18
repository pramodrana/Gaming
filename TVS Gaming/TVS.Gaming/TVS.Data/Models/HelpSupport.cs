using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class HelpSupport
    {
        public long HelpSupportId { get; set; }
        public string? HelpTitle { get; set; }
        public string? HelpDescription { get; set; }
        public string? HelpImage { get; set; }
        public string? HelpCategory { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
