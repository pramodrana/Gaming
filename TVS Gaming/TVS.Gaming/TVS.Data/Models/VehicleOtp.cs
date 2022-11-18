using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VehicleOtp
    {
        public long VehicleOtpid { get; set; }
        public string? MobileNumber { get; set; }
        public long? Otp { get; set; }
        public bool? IsOtpverified { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OtpgenerateTime { get; set; }
    }
}
