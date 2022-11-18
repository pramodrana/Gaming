using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class RidingTip
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? VideoLink { get; set; }
        public string? ThumbnailLink { get; set; }
        public int? VehicleTypeId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
