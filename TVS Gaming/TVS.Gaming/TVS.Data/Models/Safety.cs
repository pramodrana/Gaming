using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Safety
    {
        public int SafetyId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? VideoLink { get; set; }
        public DateTime? InsertedDate { get; set; }
    }
}
