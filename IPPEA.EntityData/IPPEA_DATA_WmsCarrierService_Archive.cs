//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPPEA.EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class IPPEA_DATA_WmsCarrierService_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int Id { get; set; }
        public int ShippingProcessorId { get; set; }
        public string CarrierName { get; set; }
        public string CarrierCode { get; set; }
        public string AccountNumber { get; set; }
        public int ShippingProviderId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> ShipMethodId { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string PackageCodeModifier { get; set; }
        public Nullable<int> WeightModifier { get; set; }
        public Nullable<bool> InsuranceCodeModifer { get; set; }
        public string WeightUnitCodeModifier { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
