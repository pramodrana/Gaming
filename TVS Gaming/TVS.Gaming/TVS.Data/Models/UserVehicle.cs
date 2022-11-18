using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserVehicle
    {
        public UserVehicle()
        {
            ApacheCumulatives = new HashSet<ApacheCumulative>();
            ApacheNoniottravelTransectionArchiveds = new HashSet<ApacheNoniottravelTransectionArchived>();
            ApacheNoniottravelTransections = new HashSet<ApacheNoniottravelTransection>();
            ApacheTravelTransectionArchiveds = new HashSet<ApacheTravelTransectionArchived>();
            ApacheTravelTransections = new HashSet<ApacheTravelTransection>();
            BikeServices = new HashSet<BikeService>();
            BreakDownAssistances = new HashSet<BreakDownAssistance>();
            Gears = new HashSet<Gear>();
            LapArchiveds = new HashSet<LapArchived>();
            Laps = new HashSet<Lap>();
            ModeArchiveds = new HashSet<ModeArchived>();
            Modes = new HashSet<Mode>();
            N109cumulatives = new HashSet<N109cumulative>();
            N109travelTransectionArchiveds = new HashSet<N109travelTransectionArchived>();
            N109travelTransections = new HashSet<N109travelTransection>();
            N251blecumulatives = new HashSet<N251blecumulative>();
            N251bletravelTransectionArchiveds = new HashSet<N251bletravelTransectionArchived>();
            N251bletravelTransections = new HashSet<N251bletravelTransection>();
            N251sppcumulatives = new HashSet<N251sppcumulative>();
            N251spptravelTransectionArchiveds = new HashSet<N251spptravelTransectionArchived>();
            N251spptravelTransections = new HashSet<N251spptravelTransection>();
            RideArchiveds = new HashSet<RideArchived>();
            RideCumulatives = new HashSet<RideCumulative>();
            Rides = new HashSet<Ride>();
            TourArchiveds = new HashSet<TourArchived>();
            Tours = new HashSet<Tour>();
            U347cumulatives = new HashSet<U347cumulative>();
            U347travelTransectionArchiveds = new HashSet<U347travelTransectionArchived>();
            U347travelTransections = new HashSet<U347travelTransection>();
            UserSurveys = new HashSet<UserSurvey>();
            UserVehicleMacActivations = new HashSet<UserVehicleMacActivation>();
            Widgets = new HashSet<Widget>();
        }

        public long UserVehicleId { get; set; }
        public long? UserId { get; set; }
        public string? FrameNo { get; set; }
        public string? ContactNo { get; set; }
        public string? VehicleName { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? RegNo { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string? EngineNo { get; set; }
        public string? DealerId { get; set; }
        public string? CustomerName { get; set; }
        public string? TovPartId { get; set; }
        public string? TovModelId { get; set; }
        public string? EmailAddress { get; set; }
        public string? LastServiceDate { get; set; }
        public string? LastServiceType { get; set; }
        public string? DmpPartId { get; set; }
        public string? Description { get; set; }
        public string? DmpModelId { get; set; }
        public string? Active { get; set; }
        public string? Series { get; set; }
        public string? Color { get; set; }
        public string? BrandCode { get; set; }
        public string? BrandDesc { get; set; }
        public DateTime? Insertdate { get; set; }
        public string? ContactType { get; set; }
        public string? CustomerId { get; set; }
        public string? Iot { get; set; }
        public string? Connected { get; set; }
        public string? NickName { get; set; }
        public int? Theme { get; set; }
        public long? BookingId { get; set; }
        public string? OnGoingBooking { get; set; }

        public virtual UserProfile? User { get; set; }
        public virtual ICollection<ApacheCumulative> ApacheCumulatives { get; set; }
        public virtual ICollection<ApacheNoniottravelTransectionArchived> ApacheNoniottravelTransectionArchiveds { get; set; }
        public virtual ICollection<ApacheNoniottravelTransection> ApacheNoniottravelTransections { get; set; }
        public virtual ICollection<ApacheTravelTransectionArchived> ApacheTravelTransectionArchiveds { get; set; }
        public virtual ICollection<ApacheTravelTransection> ApacheTravelTransections { get; set; }
        public virtual ICollection<BikeService> BikeServices { get; set; }
        public virtual ICollection<BreakDownAssistance> BreakDownAssistances { get; set; }
        public virtual ICollection<Gear> Gears { get; set; }
        public virtual ICollection<LapArchived> LapArchiveds { get; set; }
        public virtual ICollection<Lap> Laps { get; set; }
        public virtual ICollection<ModeArchived> ModeArchiveds { get; set; }
        public virtual ICollection<Mode> Modes { get; set; }
        public virtual ICollection<N109cumulative> N109cumulatives { get; set; }
        public virtual ICollection<N109travelTransectionArchived> N109travelTransectionArchiveds { get; set; }
        public virtual ICollection<N109travelTransection> N109travelTransections { get; set; }
        public virtual ICollection<N251blecumulative> N251blecumulatives { get; set; }
        public virtual ICollection<N251bletravelTransectionArchived> N251bletravelTransectionArchiveds { get; set; }
        public virtual ICollection<N251bletravelTransection> N251bletravelTransections { get; set; }
        public virtual ICollection<N251sppcumulative> N251sppcumulatives { get; set; }
        public virtual ICollection<N251spptravelTransectionArchived> N251spptravelTransectionArchiveds { get; set; }
        public virtual ICollection<N251spptravelTransection> N251spptravelTransections { get; set; }
        public virtual ICollection<RideArchived> RideArchiveds { get; set; }
        public virtual ICollection<RideCumulative> RideCumulatives { get; set; }
        public virtual ICollection<Ride> Rides { get; set; }
        public virtual ICollection<TourArchived> TourArchiveds { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }
        public virtual ICollection<U347cumulative> U347cumulatives { get; set; }
        public virtual ICollection<U347travelTransectionArchived> U347travelTransectionArchiveds { get; set; }
        public virtual ICollection<U347travelTransection> U347travelTransections { get; set; }
        public virtual ICollection<UserSurvey> UserSurveys { get; set; }
        public virtual ICollection<UserVehicleMacActivation> UserVehicleMacActivations { get; set; }
        public virtual ICollection<Widget> Widgets { get; set; }
    }
}
