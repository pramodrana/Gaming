using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ThirdPartyApihitCount
    {
        public long HitCountId { get; set; }
        public DateTime? ApihitCountDate { get; set; }
        public long? AqiapihitCount { get; set; }
        public long? WeatherApihitCount { get; set; }
        public long? CricketApihitCount { get; set; }
        public long? FootballApihitCount { get; set; }
        public long? NewsApihitCount { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
