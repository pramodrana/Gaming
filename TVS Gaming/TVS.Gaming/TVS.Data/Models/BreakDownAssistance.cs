using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class BreakDownAssistance
    {
        public int BreakDownAssitanceId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public int? VehicleAssistanceTypeMappingId { get; set; }
        public string? Lat { get; set; }
        public string? Long { get; set; }
        public string? Landmark { get; set; }
        public string? Comment { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
