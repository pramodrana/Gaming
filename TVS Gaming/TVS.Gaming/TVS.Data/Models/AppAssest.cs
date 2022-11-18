using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class AppAssest
    {
        public long AppAssestId { get; set; }
        public long? AppVersionId { get; set; }
        public string? AndroidAppVersionNumber { get; set; }
        public string? IosAppVersionNumber { get; set; }
        public string? Ios { get; set; }
        public string? Android { get; set; }
        public string? Resolution { get; set; }
        public string? Plateform { get; set; }
        public string? Link { get; set; }
        public long? VehicleTypeId { get; set; }
        public long? IsForcefullyupdate { get; set; }
        public string? Theme { get; set; }
    }
}
