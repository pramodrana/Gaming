using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class N251sppcumulative
    {
        public long N251sppcumulativeId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public long? Totalrides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public int? LastFuelStatus { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
