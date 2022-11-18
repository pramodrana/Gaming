using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class MobileSettingInfo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public string? Data { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Platform { get; set; }
        public string? InfoHeader { get; set; }
    }
}
