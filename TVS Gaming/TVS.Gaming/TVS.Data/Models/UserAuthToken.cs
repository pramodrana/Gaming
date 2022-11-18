using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserAuthToken
    {
        public long? UserId { get; set; }
        public string? RefreshToken { get; set; }
        public string? AccessToken { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long UserAuthTokenId { get; set; }
    }
}
