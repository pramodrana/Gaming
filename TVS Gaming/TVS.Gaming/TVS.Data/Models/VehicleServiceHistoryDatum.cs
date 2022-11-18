using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VehicleServiceHistoryDatum
    {
        public long BookingServiceHistoryId { get; set; }
        public long? BookingId { get; set; }
        public string? CurrentStatus { get; set; }
        public string? Remark { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public DateTime? StatusCurrentDate { get; set; }
        public string? StatusCurrentTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? IsDeleted { get; set; }
    }
}
