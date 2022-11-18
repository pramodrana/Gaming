using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ClientSecret
    {
        public long ClientSecretId { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Platform { get; set; }
        public string? Provider { get; set; }
    }
}
