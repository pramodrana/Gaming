using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class MobileNotification
    {
        public long MobileNotificationId { get; set; }
        public long? UserId { get; set; }
        public long? UservehicleId { get; set; }
        public int? NotificationTypeId { get; set; }
        public string? Message { get; set; }
        public bool? IsSent { get; set; }
        public string? Acknowledge { get; set; }
        public string? NotificationType { get; set; }
        public long? VehicleTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsRead { get; set; }
    }
}
