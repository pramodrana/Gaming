using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class MileageForVehicle
    {
        public int MileageVehicleId { get; set; }
        public long? UserId { get; set; }
        public long? UserVehicleId { get; set; }
        public decimal? MiterReading { get; set; }
        public decimal? FuelQuantity { get; set; }
        public decimal? Mileage { get; set; }
        public decimal? AverageRunningPerDay { get; set; }
        public decimal? InsertedDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
