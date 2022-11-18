using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserGuide23022021
    {
        public int UserGuideId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VideoLink { get; set; }
        public string? UserManual { get; set; }
        public string? Title { get; set; }
        public DateTime? Insertdate { get; set; }
        public string? VideoTitle { get; set; }
        public string? VideoThumbnailLink { get; set; }
        public string? DmpModelId { get; set; }
    }
}
