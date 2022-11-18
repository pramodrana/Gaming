using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class CsifeedbackReschedule
    {
        public CsifeedbackReschedule()
        {
            Csifeedbacks = new HashSet<Csifeedback>();
        }

        public long CsifeedbackRescheduleId { get; set; }
        public string FrameNo { get; set; } = null!;
        public long JobCardId { get; set; }
        public int BranchId { get; set; }
        public int DealerId { get; set; }
        public DateTime ServiceDate { get; set; }
        public byte RescheduleDuration { get; set; }
        public DateTime RescheduleDate { get; set; }
        public int Status { get; set; }
        public int StatusId { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool FeedbackSubmitted { get; set; }
        public long? RescheduleFromId { get; set; }
        public bool? IsRescheduledMaxLimitReached { get; set; }

        public virtual UserProfile User { get; set; } = null!;
        public virtual ICollection<Csifeedback> Csifeedbacks { get; set; }
    }
}
