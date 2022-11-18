using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class LastLocationParked
    {
        public int LastLocationPathId { get; set; }
        public int? UserId { get; set; }
        public int? UserVehicleId { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Isdeleted { get; set; }
        public string? Timestamp { get; set; }
    }
}
