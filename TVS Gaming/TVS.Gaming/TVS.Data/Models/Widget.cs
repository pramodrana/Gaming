using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Widget
    {
        public long WidgetId { get; set; }
        public int VehicleTypeId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public string? CardName { get; set; }
        public string? PrimaryImageUrl { get; set; }
        public string? SecondaryImageUrl { get; set; }
        public int? SetType { get; set; }
        public int? PrimaryReading { get; set; }
        public int? SecondaryReading { get; set; }
        public int ModeTypeId { get; set; }
        public bool? IsPredefined { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsEnabled { get; set; }
        public int? LeftPrimaryReading { get; set; }
        public int? LeftSecondaryReading { get; set; }
        public int? RightPrimaryReading { get; set; }
        public int? RightSecondaryReading { get; set; }

        public virtual UserVehicle UserVehicle { get; set; } = null!;
        public virtual VehicleType VehicleType { get; set; } = null!;
    }
}
