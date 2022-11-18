using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class RideTypeMapping
    {
        public long RideTypeMappingId { get; set; }
        public long RideId { get; set; }
        public long TourId { get; set; }
        public int? Type { get; set; }
        public DateTime? InsertDate { get; set; }

        public virtual Ride Ride { get; set; } = null!;
        public virtual Tour Tour { get; set; } = null!;
    }
}
