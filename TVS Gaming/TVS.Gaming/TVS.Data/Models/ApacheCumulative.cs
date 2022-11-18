using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ApacheCumulative
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
        public decimal? FirstGearAvgSpeed { get; set; }
        public decimal? SecondGearAvgSpeed { get; set; }
        public decimal? ThirdGearAvgSpeed { get; set; }
        public decimal? FourthGearAvgSpeed { get; set; }
        public decimal? FifthGearAvgSpeed { get; set; }
        public decimal? FirstGearAvgRpm { get; set; }
        public decimal? SecondGearAvgRpm { get; set; }
        public decimal? ThirdGearAvgRpm { get; set; }
        public decimal? FourthGearAvgRpm { get; set; }
        public decimal? FifthGearAvgRpm { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
