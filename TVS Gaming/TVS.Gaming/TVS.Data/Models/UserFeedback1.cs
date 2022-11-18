using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserFeedback1
    {
        public long UserFeedback11 { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public long? UserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? Appversion { get; set; }
        public string? Osversion { get; set; }
        public string? Model { get; set; }

        public virtual UserProfile? User { get; set; }
    }
}
