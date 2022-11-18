using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class AppVersion1
    {
        public int AppVersionId { get; set; }
        public string? IosAppVersionId { get; set; }
        public bool? IosForcefullyupdate { get; set; }
        public string? AndroidAppVersionId { get; set; }
        public bool? AndroidForcefullyupdate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
