using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class BreakDownAssistanceType
    {
        public BreakDownAssistanceType()
        {
            VehicleAssistanceTypeMappings = new HashSet<VehicleAssistanceTypeMapping>();
        }

        public int BreakDownAssistanceTypeId { get; set; }
        public string? AssistanceType { get; set; }

        public virtual ICollection<VehicleAssistanceTypeMapping> VehicleAssistanceTypeMappings { get; set; }
    }
}
