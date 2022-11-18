using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class N109travelTransectionArchived
    {
        public long ArchivedId { get; set; }
        public long TravelId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public string? TravelFileName { get; set; }
        public string? TravelName { get; set; }
        public decimal? TravelStartDateTime { get; set; }
        public decimal? TravelEndDateTime { get; set; }
        public string? VehicleModelName { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal BestShortestTime0to30 { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public string? TravelStatsDownloadLink { get; set; }
        public decimal? Co2saved { get; set; }
        public int? LastFuelStatus { get; set; }
        public int? LastBatteryStatus { get; set; }
        public decimal? EcoModeTotalDistance { get; set; }
        public decimal? PowerModeTotalDistance { get; set; }
        public decimal? EcoModeBatteryDistance { get; set; }
        public decimal? EcoModeEngineDistance { get; set; }
        public decimal? PowerModeCombinedBedistance { get; set; }
        public decimal? PowerModeOnlyEngDistance { get; set; }
        public DateTime? Insertdate { get; set; }
        public bool? IsEligibleForProcess { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsArchivable { get; set; }
        public bool? IsProcessed { get; set; }
        public decimal? LastDistanceToEmpty { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
