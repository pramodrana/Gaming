using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Csifeedback
    {
        public long CsifeedbackId { get; set; }
        public bool IsVehiclePerformanceSatisfactory { get; set; }
        public bool IsVehicleAppearanceSatisfactory { get; set; }
        public bool WasRoadTestOffered { get; set; }
        public byte RecommendationValue { get; set; }
        public string? Comment { get; set; }
        public string FrameNo { get; set; } = null!;
        public long JobCardId { get; set; }
        public DateTime ServiceDate { get; set; }
        public int DealerId { get; set; }
        public int BranchId { get; set; }
        public byte? Jctype { get; set; }
        public byte? Jcstatus { get; set; }
        public long? BookingId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public long? CsifeedbackRescheduleId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsSavedInDms { get; set; }
        public string? ResponseFromDms { get; set; }

        public virtual CsifeedbackReschedule? CsifeedbackReschedule { get; set; }
        public virtual UserProfile User { get; set; } = null!;
    }
}
