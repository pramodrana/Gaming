using System;
using System.Collections.Generic;

namespace TVS.Model.Models.GameProperty
{
    public partial class GamePropertyModel
    {
        public long PropertyId { get; set; }
        public string? PropertyName { get; set; }
        public string? PropertyValue { get; set; }
        public long? InsertedBy { get; set; }
        public DateTime? InsertedOn { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
