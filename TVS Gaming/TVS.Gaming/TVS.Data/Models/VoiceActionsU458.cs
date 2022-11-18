using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VoiceActionsU458
    {
        public long VoiceActionId { get; set; }
        public string? VoiceAction { get; set; }
        public string? VoiceIntent { get; set; }
        public string? VoiceFeedback { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Platform { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? ClusterFeedback1 { get; set; }
        public string? ClusterFeedback2 { get; set; }
        public int? Theme { get; set; }
    }
}
