using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Faq
    {
        public int Faqid { get; set; }
        public string? Questions { get; set; }
        public string? Answers { get; set; }
        public long? FaqcategoryId { get; set; }
        public string? AccessVersion { get; set; }
        public int? VehicleTypeId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Faqcategory? Faqcategory { get; set; }
    }
}
