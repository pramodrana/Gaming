using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ContactSupport
    {
        public long ContactSupportId { get; set; }
        public string? FeatureName { get; set; }
        public string? FeatureImage { get; set; }
        public string? FeatureDescription { get; set; }
    }
}
