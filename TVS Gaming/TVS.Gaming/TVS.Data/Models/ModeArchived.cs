using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ModeArchived
    {
        public long ArchiveId { get; set; }
        public long ModeId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public long? TotalDuration { get; set; }
        public long? ModeTypeId { get; set; }
        public decimal? TotalDistanceCovered { get; set; }
        public decimal? Mileage { get; set; }
        public decimal? CruisingRange { get; set; }
        public decimal? LiterPer100Km { get; set; }
        public long? NumberOfLaps { get; set; }
        public long? BestLapNumber { get; set; }
        public long? BestLapTime { get; set; }
        public long? LastLapTime { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }
        public long? ModeStartDateTime { get; set; }
        public long? ModeEndDateTime { get; set; }
        public long? TourId { get; set; }
        public long? RideId { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserVehicle UserVehicle { get; set; } = null!;
        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
