using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class BadgeType
    {
        public BadgeType()
        {
            UserBadges = new HashSet<UserBadge>();
        }

        public int BadgeTypeId { get; set; }
        public string? BadgeTypeName { get; set; }

        public virtual ICollection<UserBadge> UserBadges { get; set; }
    }
}
