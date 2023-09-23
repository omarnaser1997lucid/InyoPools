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
    
    public partial class IPPEA_DATA_EmailQueue_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailBcc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public Nullable<int> BodyFormat { get; set; }
        public Nullable<int> EmailTypeID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public int Attempts { get; set; }
        public string UserID { get; set; }
        public System.DateTime DateEntered { get; set; }
        public Nullable<int> OrderGroupID { get; set; }
        public Nullable<int> OrderFormID { get; set; }
        public int EmailTransactionTypeID { get; set; }
        public Nullable<System.DateTime> DelaySendUntil { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> QuoteId { get; set; }
        public Nullable<int> OriginalEmailLogId { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}