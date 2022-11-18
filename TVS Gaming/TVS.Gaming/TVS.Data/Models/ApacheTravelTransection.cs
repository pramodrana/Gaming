using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ApacheTravelTransection
    {
        public long TravelId { get; set; }
        public string? TravelFileName { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public string? BikeModelName { get; set; }
        public bool? IsRideType { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public long? TravelStartDateTime { get; set; }
        public long? TravelEndDateTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? BestShortestTime { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public decimal? MaxAltitude { get; set; }
        public decimal? MaxLeanAngle { get; set; }
        public decimal? MaxGforce { get; set; }
        public string? TravelStatsDownloadLink { get; set; }
        public string? TravelRouteSnapshotLink { get; set; }
        public decimal? FirstGearAvgSpeed { get; set; }
        public decimal? SecondGearAvgSpeed { get; set; }
        public decimal? ThirdGearAvgSpeed { get; set; }
        public decimal? FourthGearAvgSpeed { get; set; }
        public decimal? FifthGearAvgSpeed { get; set; }
        public decimal? FirstGearAvgRpm { get; set; }
        public decimal? SecondGearAvgRpm { get; set; }
        public decimal? ThirdGearAvgRpm { get; set; }
        public decimal? FourthGearAvgRpm { get; set; }
        public decimal? FifthGearAvgRpm { get; set; }
        public bool? IsArchivable { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? Insertdate { get; set; }
        public string? TravelName { get; set; }
        public int? MaxRpm { get; set; }
        public bool? IsEligibleForProcess { get; set; }
        public bool? IsDeleted { get; set; }
        public string? WayPoints { get; set; }
        public int? VehicleTypeId { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
