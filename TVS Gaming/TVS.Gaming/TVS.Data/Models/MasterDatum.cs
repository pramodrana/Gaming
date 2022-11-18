using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class MasterDatum
    {
        public int MasterDataId { get; set; }
        public string Type { get; set; } = null!;
        public string? Value { get; set; }
    }
}
