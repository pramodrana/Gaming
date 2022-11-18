using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserFeedback
    {
        public long UserFeedback1 { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public long? UserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? Appversion { get; set; }
        public string? Osversion { get; set; }
        public string? Model { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Platform { get; set; }
        public string? City { get; set; }
        public string? FeedBackType { get; set; }
        public string? FrameNumber { get; set; }
        public string? FeedbackSeverity { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ReferenceNumber { get; set; }
        public bool? IsSend { get; set; }

        public virtual UserProfile? User { get; set; }
    }
}
