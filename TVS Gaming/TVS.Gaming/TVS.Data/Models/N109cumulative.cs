using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class N109cumulative
    {
        public long N109cumulativeId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public long Totalrides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? BestShortestTime0to30 { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public decimal? Co2saved { get; set; }
        public int? LastFuelStatus { get; set; }
        public int? LastBatteryStatus { get; set; }
        public decimal? LastDistanceToEmpty { get; set; }
        public decimal? EcoModeTotalDistance { get; set; }
        public decimal? PowerModeTotalDistance { get; set; }
        public decimal? EcoModeBatteryDistance { get; set; }
        public decimal? EcoModeEngineDistance { get; set; }
        public decimal? PowerModeCombinedBedistance { get; set; }
        public decimal? PowerModeOnlyEngDistance { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
