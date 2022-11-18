using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserAddress
    {
        public long UserAddressId { get; set; }
        public long UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public string? Title { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserProfile User { get; set; } = null!;
    }
}
