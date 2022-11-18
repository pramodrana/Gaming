using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class InAppFeedback
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string? PlatformType { get; set; }
        public string? Version { get; set; }
        public decimal? Rating { get; set; }
        public string? ReviewTopic { get; set; }
        public string? Feedback { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual UserProfile User { get; set; } = null!;
    }
}
