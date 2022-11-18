using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserSettingConfiguration
    {
        public UserSettingConfiguration()
        {
            UserAdditionalSettings = new HashSet<UserAdditionalSetting>();
        }

        public long UserSettingFieldId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public bool? DoNotDisturb { get; set; }
        public bool? AutoReplySms { get; set; }
        public string? AutoReplySmstext { get; set; }
        public int? OverSpeedLimit { get; set; }
        public bool? OverSpeedAlert { get; set; }
        public int? Illumination { get; set; }
        public string? BikeNickName { get; set; }
        public string? RegistrationNumber { get; set; }
        public bool? ManualConnect { get; set; }
        public bool? AutoLaunch { get; set; }

        public virtual ICollection<UserAdditionalSetting> UserAdditionalSettings { get; set; }
    }
}
