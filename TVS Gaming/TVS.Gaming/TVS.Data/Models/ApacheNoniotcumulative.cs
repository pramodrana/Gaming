using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ApacheNoniotcumulative
    {
        public long ApacheCumulativeId { get; set; }
        public long? UserVehicleId { get; set; }
        public long? UserId { get; set; }
        public long? BikeTotalDrivenTime { get; set; }
        public long? TotalRides { get; set; }
        public decimal? TotalDistanceTravelled { get; set; }
        public decimal? BikeBestShortestTime { get; set; }
        public decimal? BikeTopSpeed { get; set; }
        public decimal? BikeAverageSpeed { get; set; }
        public decimal? BikeMaxGforce { get; set; }
        public decimal? BikeMaxLeanAngle { get; set; }
        public decimal? BikeMaxAltitude { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
