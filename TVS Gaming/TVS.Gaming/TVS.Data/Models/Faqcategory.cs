using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class Faqcategory
    {
        public Faqcategory()
        {
            Faqs = new HashSet<Faq>();
        }

        public long FaqcategoryId { get; set; }
        public string? FaqcategoryName { get; set; }
        public string? FaqcategoryType { get; set; }
        public string? AccessVersion { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Faq> Faqs { get; set; }
    }
}
