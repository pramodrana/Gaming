using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class FeedbackType
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsVehicleRelatedFeedback { get; set; }
    }
}
