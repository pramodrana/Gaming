using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class GearArchived
    {
        public long ArchiveId { get; set; }
        public long GearId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public long? GearNumber { get; set; }
        public long? TotalDuration { get; set; }
        public decimal? TotalDistanceCovered { get; set; }
        public decimal? AverageSpeed { get; set; }
        public decimal? AverageDownShiftSpeed { get; set; }
        public decimal? AverageUpShiftSpeed { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }
        public long? GearStartDateTime { get; set; }
        public long? GearEndDateTime { get; set; }
        public long? AverageRpm { get; set; }
        public long? AverageDownShiftRpm { get; set; }
        public long? AverageUpShiftRpm { get; set; }
        public long? TourId { get; set; }
        public long? RideId { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
