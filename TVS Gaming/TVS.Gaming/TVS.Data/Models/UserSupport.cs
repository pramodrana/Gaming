using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserSupport
    {
        public int UserSupportId { get; set; }
        public long? Userid { get; set; }
        public string? ChassisNo { get; set; }
        public string? Name { get; set; }
        public string? Rccopy { get; set; }
        public string? DrivingLicence { get; set; }
        public string? MobileNo { get; set; }
        public string? Comment { get; set; }
        public string? RequestId { get; set; }
        public bool? Issent { get; set; }
        public string? InsertedDate { get; set; }
    }
}
