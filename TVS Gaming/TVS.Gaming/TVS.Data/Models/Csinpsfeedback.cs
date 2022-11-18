using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Csinpsfeedback
    {
        public long CsinpsfeedbackId { get; set; }
        public byte FeedbackType { get; set; }
        public bool? PerformanceAfterService { get; set; }
        public bool? VehicleAppearance { get; set; }
        public bool? WasRoadTestOffered { get; set; }
        public bool? WillRecommend { get; set; }
        public byte RecommendationValue { get; set; }
        public string? Comment { get; set; }
        public string FrameNumber { get; set; } = null!;
        public long? JobCarId { get; set; }
        public byte? JobCardStatus { get; set; }
        public long? BookingId { get; set; }
        public DateTime? Csicreated { get; set; }
        public DateTime? NpscreatedOn { get; set; }
        public long UserId { get; set; }
        public bool? IsCsirecheduled { get; set; }
        public DateTime? CsirescheduledDate { get; set; }
        public bool? IsNpsrecheduled { get; set; }
        public DateTime? NpsrescheduledDate { get; set; }
        public long? CsifeedbackRescheduleId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserProfile User { get; set; } = null!;
    }
}
