using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserImage
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public int VehicleTypeId { get; set; }
        public string ImageName { get; set; } = null!;
        public int ImageId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
