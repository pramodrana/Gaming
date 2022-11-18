using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class EmergencyContact
    {
        public long EmergencyContactId { get; set; }
        public long? UserId { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public string? ContactImagePath { get; set; }
        public string? ContactName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserProfile? User { get; set; }
    }
}
