using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ScopeConfigDss
    {
        public Guid ConfigId { get; set; }
        public string ConfigData { get; set; } = null!;
        public string? ScopeStatus { get; set; }
    }
}
