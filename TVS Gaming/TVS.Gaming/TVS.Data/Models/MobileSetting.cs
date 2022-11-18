using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class MobileSetting
    {
        public int Id { get; set; }
        public string? Platform { get; set; }
        public string? Brand { get; set; }
        public string? OptimizationCatagory { get; set; }
        public string? OptimizationStep { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? InfoUrl { get; set; }
        public int? Action { get; set; }
        public string? Benefit { get; set; }
        public string? CategoryUrl { get; set; }
    }
}
