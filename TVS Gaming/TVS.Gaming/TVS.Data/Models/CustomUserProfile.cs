using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class CustomUserProfile
    {
        public long CustomUserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public long? CityId { get; set; }
        public string? BloodGroup { get; set; }
        public string? ProfileImagePath { get; set; }
        public string? EmergencyNumber1 { get; set; }
        public string? EmergencyNumber2 { get; set; }
        public string? EmergencyNumber3 { get; set; }
        public string? AllergicContent { get; set; }
        public string? Token { get; set; }
        public bool? IsOtpverified { get; set; }
        public long? Otp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OtpgenerateTime { get; set; }
        public string? FacebookId { get; set; }
        public string? GooglePlusId { get; set; }
        public DateTime? CrashAlertDate { get; set; }
        public bool? IsRegistered { get; set; }
        public string? IosToken { get; set; }
        public string? AndroidToken { get; set; }
        public string? RegistrationId { get; set; }
    }
}
