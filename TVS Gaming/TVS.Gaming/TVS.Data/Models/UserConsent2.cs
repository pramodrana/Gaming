using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserConsent2
    {
        public long UserConsentId { get; set; }
        public string MobileNumber { get; set; } = null!;
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public string Platform { get; set; } = null!;
        public string Application { get; set; } = null!;
        public DateTime ConsentTakenDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
