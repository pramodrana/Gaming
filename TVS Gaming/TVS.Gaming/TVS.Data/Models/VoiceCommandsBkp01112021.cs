using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class VoiceCommandsBkp01112021
    {
        public long VoiceCommandId { get; set; }
        public long VoiceActionId { get; set; }
        public string? Command { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
