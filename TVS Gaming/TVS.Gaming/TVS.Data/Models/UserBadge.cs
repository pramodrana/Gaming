using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserBadge
    {
        public long BadgeId { get; set; }
        public long? UserId { get; set; }
        public int? BadgeTypeId { get; set; }
        public string? BadgeName { get; set; }
        public DateTime? Insertdate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual BadgeType? BadgeType { get; set; }
        public virtual UserProfile? User { get; set; }
    }
}
