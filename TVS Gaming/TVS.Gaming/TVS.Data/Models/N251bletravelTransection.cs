using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class N251bletravelTransection
    {
        public long TravelId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public string? TravelFileName { get; set; }
        public string? TravelName { get; set; }
        public decimal? TravelStartDateTime { get; set; }
        public decimal? TravelEndDateTime { get; set; }
        public string? VehicleModelName { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public bool? IsSportMode { get; set; }
        public bool? IsStreetMode { get; set; }
        public decimal? TotalDistanceOverAll { get; set; }
        public decimal? LapDistanceSportMode { get; set; }
        public decimal? TotalDistanceStreetMode { get; set; }
        public decimal? TotalDistanceSportMode { get; set; }
        public decimal? BestShortestTimeSportMode { get; set; }
        public decimal? TopSpeedOverAll { get; set; }
        public decimal? TopSpeedSportMode { get; set; }
        public decimal? TopSpeedStreetMode { get; set; }
        public decimal? AverageSpeedSportMode { get; set; }
        public decimal? AverageSpeedStreetMode { get; set; }
        public decimal? AverageSpeedOverAll { get; set; }
        public string? TravelStatsDownloadLink { get; set; }
        public int? LastFuelStatus { get; set; }
        public DateTime? Insertdate { get; set; }
        public bool? IsArchivable { get; set; }
        public bool? IsProcessed { get; set; }
        public bool? IsEligibleForProcess { get; set; }
        public bool? IsDeleted { get; set; }
        public long? SportModeRides { get; set; }
        public long? StreetModeRides { get; set; }
        public int? VehicleTypeId { get; set; }
        public long? TopRpm { get; set; }
        public long? AverageRpm { get; set; }
        public long? IdleTime { get; set; }
        public decimal? OdometerReading { get; set; }
        public bool? IsRaceMode { get; set; }
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
        public int? RideTag { get; set; }
        public int? AchievementType { get; set; }
        public string? WeatherTemp { get; set; }
        public string? WeatherShortDescription { get; set; }
        public string? WeatherIcon { get; set; }
        public string? AchievementList { get; set; }
        public string? RideMmidownloadLink { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
