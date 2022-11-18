using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VehicleServiceDatum
    {
        public long BookingId { get; set; }
        public string? AcceptedStatus { get; set; }
        public DateTime? AppoinmentDate { get; set; }
        public string? AppoinmentTime { get; set; }
        public string? Remark { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? IsDeleted { get; set; }
        public bool? ServiceMode { get; set; }
        public bool? IsPickDropReq { get; set; }
        public bool? IsEowReq { get; set; }
        public long? BranchId { get; set; }
        public string? DealerId { get; set; }
        public string? Platform { get; set; }
        public int? ServiceType { get; set; }
        public string? DealerName { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? Comment { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
