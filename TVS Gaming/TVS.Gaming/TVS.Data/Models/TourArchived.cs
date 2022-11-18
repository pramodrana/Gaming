using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class TourArchived
    {
        public long ArchiveId { get; set; }
        public long TourId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public string? TourName { get; set; }
        public string? TourStartLocation { get; set; }
        public string? TourEndLocation { get; set; }
        public long? TotalDuration { get; set; }
        public decimal? TotalDistance { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsTourEnded { get; set; }
        public long? TourStartDateTime { get; set; }
        public long? TourEndDateTime { get; set; }
        public decimal? Mileage { get; set; }
        public decimal? LiterPer100Km { get; set; }
        public decimal? HighestAltitude { get; set; }
        public decimal? LowestAltitude { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public bool? IsFavourite { get; set; }
        public string? TourMmidownloadLink { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserVehicle UserVehicle { get; set; } = null!;
        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
