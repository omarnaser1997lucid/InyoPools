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
    
    public partial class IPPEA_DATA_ProductAvailability_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public Nullable<System.DateTimeOffset> EmailSentDate { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
