using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class BikeService
    {
        public long BikeServiceId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public string? Dealername { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? CustomerId { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? Emailid { get; set; }
        public string? Model { get; set; }
        public string? CityId { get; set; }
        public string? ServiceTypeId { get; set; }
        public string? RemarksComplaints { get; set; }
        public DateTime? ServiceDateTime { get; set; }
        public string? DealerId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? Bookingid { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual UserVehicle? UserVehicle { get; set; }
    }
}
