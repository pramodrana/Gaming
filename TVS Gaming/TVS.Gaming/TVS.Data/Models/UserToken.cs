using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserToken
    {
        public int? Id { get; set; }
        public long? UserId { get; set; }
        public string? ExpiredToken { get; set; }
        public string? Token { get; set; }
        public DateTime? ExpiredTokenTime { get; set; }
    }
}
