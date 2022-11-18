using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class AppVersion
    {
        public long AppVersionId { get; set; }
        public string? IosAppVersionNumber { get; set; }
        public string? AndroidAppVersionNumber { get; set; }
        public bool? IsForcefullyupdate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
