using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserRsakey
    {
        public long UserRsakeyId { get; set; }
        public long UserId { get; set; }
        public string? PublicKey { get; set; }
        public string? PrivateKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserProfile User { get; set; } = null!;
    }
}
