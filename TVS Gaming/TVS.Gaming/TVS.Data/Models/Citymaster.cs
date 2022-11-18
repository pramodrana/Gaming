using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Citymaster
    {
        public Citymaster()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        public long CityId { get; set; }
        public string? CityName { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
