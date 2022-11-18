using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ServiceFeedback
    {
        public long ServiceFeedback1 { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public long? UserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserProfile? User { get; set; }
    }
}
