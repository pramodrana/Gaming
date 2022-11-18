using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class HomeVideo
    {
        public long VideoLinkId { get; set; }
        public string? VideoLink { get; set; }
        public string? VideoThumbnailLink { get; set; }
        public string? Title { get; set; }
    }
}
