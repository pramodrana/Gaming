using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class TourPoint
    {
        public long TourPointId { get; set; }
        public long TourId { get; set; }
        public string? PlaceName { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public virtual Tour Tour { get; set; } = null!;
    }
}
