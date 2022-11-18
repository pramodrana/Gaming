using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class NpsfeedbackReschedule
    {
        public NpsfeedbackReschedule()
        {
            Npsfeedbacks = new HashSet<Npsfeedback>();
        }

        public long NpsfeedbackRescheduleId { get; set; }
        public string FrameNo { get; set; } = null!;
        public byte RescheduleDuration { get; set; }
        public DateTime RescheduleDate { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? DealerId { get; set; }
        public int? BranchId { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? FeedbackSubmitted { get; set; }
        public long? RescheduleFromId { get; set; }
        public bool? IsRescheduledMaxLimitReached { get; set; }

        public virtual UserProfile User { get; set; } = null!;
        public virtual ICollection<Npsfeedback> Npsfeedbacks { get; set; }
    }
}
