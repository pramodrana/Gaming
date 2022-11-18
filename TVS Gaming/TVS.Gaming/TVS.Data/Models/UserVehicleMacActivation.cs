using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserVehicleMacActivation
    {
        public long UserVehicleMacActivationId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? Theme { get; set; }
        public string FrameNo { get; set; } = null!;
        public string? MacId { get; set; }
        public int? ActivationStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public string? RequestUrl { get; set; }
        public string? Response { get; set; }

        public virtual UserProfile? User { get; set; }
        public virtual UserVehicle? UserVehicle { get; set; }
        public virtual VehicleType? VehicleType { get; set; }
    }
}
