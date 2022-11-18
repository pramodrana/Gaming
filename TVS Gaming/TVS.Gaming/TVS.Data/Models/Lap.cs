using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Lap
    {
        public long LapId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public long? LapNumber { get; set; }
        public long? LapTime { get; set; }
        public decimal? LapDistance { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }
        public long? RideId { get; set; }
        public long? TourId { get; set; }

        public virtual Ride? Ride { get; set; }
        public virtual UserVehicle UserVehicle { get; set; } = null!;
        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
