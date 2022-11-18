using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserVoiceCommand
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public long UserVehicleId { get; set; }
        public string? VoiceAudioFilePath { get; set; }
        public string? ConvertedText { get; set; }
        public string? IntentIdentified { get; set; }
        public string? ActionTaken { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Platform { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? Theme { get; set; }
    }
}
