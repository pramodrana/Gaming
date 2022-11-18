using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class RideArchived
    {
        public long ArchivedId { get; set; }
        public long RideId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public string? RideFileName { get; set; }
        public string? BikeModelName { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public long? RideStartDateTime { get; set; }
        public long? RideEndDateTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public string? RideStatsDownloadLink { get; set; }
        public string? RideRouteSnapshotLink { get; set; }
        public bool? IsArchivable { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? RideName { get; set; }
        public bool? IsEligibleForProcess { get; set; }
        public bool? IsDeleted { get; set; }
        public string? OtherRideParameters { get; set; }
        public bool? IsFavourite { get; set; }
        public int? Type { get; set; }
        public string? Day { get; set; }
        public string? RideMmidownloadLink { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserVehicle UserVehicle { get; set; } = null!;
        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
