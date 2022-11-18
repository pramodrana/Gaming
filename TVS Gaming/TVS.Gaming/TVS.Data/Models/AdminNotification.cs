using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class AdminNotification
    {
        public long AdminnotificationId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? Message { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Imageurl { get; set; }
        public string? Link { get; set; }
        public string? Title { get; set; }
        public string? IsNotification { get; set; }
        public string? Status { get; set; }
        public string? IsProcessed { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
