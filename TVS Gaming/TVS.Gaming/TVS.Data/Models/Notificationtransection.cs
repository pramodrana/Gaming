using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Notificationtransection
    {
        public long Notificationtransectionid { get; set; }
        public DateTime? Createddate { get; set; }
        public long AdminnotificationId { get; set; }
        public bool? Isread { get; set; }
        public long? Userid { get; set; }
        public long? Uservehicleid { get; set; }
        public string? Issent { get; set; }
        public string? IsProcessed { get; set; }
    }
}
