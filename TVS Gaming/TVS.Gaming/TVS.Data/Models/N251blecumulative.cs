﻿using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class N251blecumulative
    {
        public long N251blecumulativeId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public long? Totalrides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalDistanceOverAll { get; set; }
        public decimal? TotalDistanceStreetMode { get; set; }
        public decimal? BestShortestTimeSportMode { get; set; }
        public long? TopSpeedOverAll { get; set; }
        public long? TopSpeedSportMode { get; set; }
        public long? TopSpeedStreetMode { get; set; }
        public decimal? AverageSpeedSportMode { get; set; }
        public decimal? AverageSpeedStreetMode { get; set; }
        public decimal? AverageSpeedOverAll { get; set; }
        public int? LastFuelStatus { get; set; }
        public long? LapDistanceSportMode { get; set; }
        public long? StreetModeRides { get; set; }
        public long? SportModeRides { get; set; }
        public decimal? TotalDistanceSportMode { get; set; }
        public int? VehicleTypeId { get; set; }
        public decimal? OdometerReading { get; set; }
        public decimal? TotalDistanceRaceMode { get; set; }
        public long? TopSpeedRaceMode { get; set; }
        public decimal? AverageSpeedRaceMode { get; set; }
        public long? RaceModeRides { get; set; }
        public long? TopRpmraceMode { get; set; }
        public decimal? Best0to60RaceMode { get; set; }
        public long? TopRpmstreetMode { get; set; }
        public long? RideTimeStreetMode { get; set; }
        public long? RideTimeRaceMode { get; set; }
        public decimal? Best0to60StreetMode { get; set; }
        public bool? IsDeleted { get; set; }
        public long? TopRpm { get; set; }
        public long? IdleTime { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
