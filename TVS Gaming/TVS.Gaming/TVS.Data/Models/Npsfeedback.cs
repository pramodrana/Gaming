using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Npsfeedback
    {
        public long NpsfeedbackId { get; set; }
        public int? QuestionOne { get; set; }
        public byte RecommendationValue { get; set; }
        public int? QuestionTwo { get; set; }
        public string? ExplanationForRating { get; set; }
        public bool WillRecommendVehicle { get; set; }
        public int? DealerId { get; set; }
        public int? BranchId { get; set; }
        public string? AreaOfImprovement { get; set; }
        public string FrameNo { get; set; } = null!;
        public DateTime? SaleDate { get; set; }
        public byte? SaleMode { get; set; }
        public string? ContactInformation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public bool IsDeleted { get; set; }
        public long? NpsfeedbackRescheduleId { get; set; }
        public bool? IsSavedInDms { get; set; }
        public string? ResponseFromDms { get; set; }

        public virtual NpsfeedbackReschedule? NpsfeedbackReschedule { get; set; }
        public virtual UserProfile User { get; set; } = null!;
    }
}
