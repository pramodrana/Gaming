using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserFeedbackForm
    {
        public long UserFeedbackId { get; set; }
        public long? UserId { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? FeedbackType { get; set; }
        public string? FrameNumber { get; set; }
        public string? Message { get; set; }
        public string? AppVersion { get; set; }
        public string? OsVersion { get; set; }
        public string? Model { get; set; }
        public string? Platform { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserProfile? User { get; set; }
    }
}
