using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class U347cumulative
    {
        public long N109cumulativeId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public long? TotalRides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? BestShortestTime0to30 { get; set; }
        public long? TopSpeed { get; set; }
        public long? AverageSpeed { get; set; }
        public decimal? Co2saved { get; set; }
        public int? LastBatteryStatus { get; set; }
        public decimal? LastDistanceToEmpty { get; set; }
        public decimal? EcoModeTotalDistance { get; set; }
        public decimal? PowerModeTotalDistance { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
