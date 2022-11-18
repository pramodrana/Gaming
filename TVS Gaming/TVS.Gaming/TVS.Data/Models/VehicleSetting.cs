using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VehicleSetting
    {
        public long VehicleSettingId { get; set; }
        public int VehicleTypeId { get; set; }
        public long ElevationKm { get; set; }
        public long WayPointDuration { get; set; }
        public long WayPointDistance { get; set; }
        public long Csvfrequency { get; set; }
        public long? EventHubFrequency { get; set; }

        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
