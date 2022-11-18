using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class RideCumulative
    {
        public long RideCumulativeId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public long? TotalRides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? OtherRideParameters { get; set; }

        public virtual UserVehicle UserVehicle { get; set; } = null!;
        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
