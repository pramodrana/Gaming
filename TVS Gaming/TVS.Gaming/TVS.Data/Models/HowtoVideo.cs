using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class HowtoVideo
    {
        public int VedioId { get; set; }
        public string? VideoName { get; set; }
        public string? VideoLink { get; set; }
        public string? Application { get; set; }
        public string? WebSite { get; set; }
        public string? ThumbNailPath { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? Platform { get; set; }
        public int? Theme { get; set; }
    }
}
