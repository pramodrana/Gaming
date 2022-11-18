using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserSurvey
    {
        public int UserSurveyId { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public int VehicleTypeId { get; set; }
        public int SurveyTypeId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual UserProfile User { get; set; } = null!;
        public virtual UserVehicle UserVehicle { get; set; } = null!;
    }
}
