using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Gears = new HashSet<Gear>();
            LapArchiveds = new HashSet<LapArchived>();
            Laps = new HashSet<Lap>();
            ModeArchiveds = new HashSet<ModeArchived>();
            Modes = new HashSet<Mode>();
            RideArchiveds = new HashSet<RideArchived>();
            RideCumulatives = new HashSet<RideCumulative>();
            Rides = new HashSet<Ride>();
            TourArchiveds = new HashSet<TourArchived>();
            Tours = new HashSet<Tour>();
            UserVehicleMacActivations = new HashSet<UserVehicleMacActivation>();
            VehicleAssistanceTypeMappings = new HashSet<VehicleAssistanceTypeMapping>();
            VehicleSettings = new HashSet<VehicleSetting>();
            Widgets = new HashSet<Widget>();
        }

        public int VehicleTypeId { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? VehicleCategory { get; set; }
        public DateTime? Insertdate { get; set; }
        public string? Series { get; set; }

        public virtual ICollection<Gear> Gears { get; set; }
        public virtual ICollection<LapArchived> LapArchiveds { get; set; }
        public virtual ICollection<Lap> Laps { get; set; }
        public virtual ICollection<ModeArchived> ModeArchiveds { get; set; }
        public virtual ICollection<Mode> Modes { get; set; }
        public virtual ICollection<RideArchived> RideArchiveds { get; set; }
        public virtual ICollection<RideCumulative> RideCumulatives { get; set; }
        public virtual ICollection<Ride> Rides { get; set; }
        public virtual ICollection<TourArchived> TourArchiveds { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }
        public virtual ICollection<UserVehicleMacActivation> UserVehicleMacActivations { get; set; }
        public virtual ICollection<VehicleAssistanceTypeMapping> VehicleAssistanceTypeMappings { get; set; }
        public virtual ICollection<VehicleSetting> VehicleSettings { get; set; }
        public virtual ICollection<Widget> Widgets { get; set; }
    }
}
