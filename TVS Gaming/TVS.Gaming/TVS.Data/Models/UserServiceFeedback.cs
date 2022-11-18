using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserServiceFeedback
    {
        public int ServiceFeedbackId { get; set; }
        public byte? Performance { get; set; }
        public byte? DealerPerformance { get; set; }
        public string? Recommendation { get; set; }
        public string? Comment { get; set; }
        public string? ServiceId { get; set; }
        public int? UserVehicleId { get; set; }
        public int? UserId { get; set; }
    }
}
