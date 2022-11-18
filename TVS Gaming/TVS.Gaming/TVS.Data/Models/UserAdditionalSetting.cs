using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserAdditionalSetting
    {
        public long UserAdditionalSettingId { get; set; }
        public string? UserSettingType { get; set; }
        public string? UserSettingValue { get; set; }
        public long UserSettingConfigurationId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserSettingConfiguration UserSettingConfiguration { get; set; } = null!;
    }
}
