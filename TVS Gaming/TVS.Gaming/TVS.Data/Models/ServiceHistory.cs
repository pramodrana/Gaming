using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class ServiceHistory
    {
        public long ServiceHistoryId { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? Action { get; set; }
        public string? BranchId { get; set; }
        public string? City { get; set; }
        public string? CustName { get; set; }
        public string? Complaint { get; set; }
        public string? ComplaintGroup { get; set; }
        public string? CustVoice { get; set; }
        public string? DealershipName { get; set; }
        public string? DealerId { get; set; }
        public string? Description { get; set; }
        public string? EngineNo { get; set; }
        public string? FrameNo { get; set; }
        public string? FscClaimNo { get; set; }
        public string? InsComp { get; set; }
        public string? InsType { get; set; }
        public string? IssuedQty { get; set; }
        public string? Issuemode { get; set; }
        public string? JobCardDate { get; set; }
        public string? JobCardNo { get; set; }
        public string JobTypeDesc { get; set; } = null!;
        public string? Kilometers { get; set; }
        public string? LabourId { get; set; }
        public string? LabourRate { get; set; }
        public string? LabQuantity { get; set; }
        public string? MobileNo { get; set; }
        public string? Model { get; set; }
        public string? ModelPart { get; set; }
        public string? ObservDesc { get; set; }
        public string? Observation { get; set; }
        public string? ObsrvGroup { get; set; }
        public string? PartDesc { get; set; }
        public string? PartNo { get; set; }
        public string? PinCode { get; set; }
        public string? PolicyNo { get; set; }
        public string? ProdMon { get; set; }
        public string? ProdYr { get; set; }
        public string? RegNo { get; set; }
        public string? SaleDate { get; set; }
        public string? Servicemode { get; set; }
        public string? State { get; set; }
    }
}
