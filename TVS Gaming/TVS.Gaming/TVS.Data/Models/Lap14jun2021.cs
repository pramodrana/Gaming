using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Lap14jun2021
    {
        public long LapId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public long? LapNumber { get; set; }
        public decimal? TopSpeed { get; set; }
        public long? LapStartDateTime { get; set; }
        public long? LapEndDateTime { get; set; }
        public long? Rpm { get; set; }
        public decimal? LeanAngle { get; set; }
        public long? LapTime { get; set; }
        public decimal? LapDistance { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }
        public long? RideId { get; set; }
        public long? TourId { get; set; }
    }
}
