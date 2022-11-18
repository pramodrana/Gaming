using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserDeleteReason
    {
        public int UserDeleteReasonId { get; set; }
        public string? ReasonMessage { get; set; }
        public DateTime? InserDate { get; set; }
        public bool IsActive { get; set; }
    }
}
