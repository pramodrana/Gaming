using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class AppBanner
    {
        public long BannerId { get; set; }
        public string? BannerImageLink { get; set; }
        public string? BannerRedirectLink { get; set; }
    }
}
