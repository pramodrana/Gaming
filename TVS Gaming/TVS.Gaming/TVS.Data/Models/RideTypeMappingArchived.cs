using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class RideTypeMappingArchived
    {
        public long ArchiveId { get; set; }
        public long RideTypeMappingId { get; set; }
        public long RideId { get; set; }
        public long TourId { get; set; }
        public int? Type { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
