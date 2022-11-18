using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VehicleAssistanceTypeMapping
    {
        public int VehicleAssistanceTypeMappingId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? BreakDownAssistanceTypeId { get; set; }

        public virtual BreakDownAssistanceType? BreakDownAssistanceType { get; set; }
        public virtual VehicleType? VehicleType { get; set; }
    }
}
