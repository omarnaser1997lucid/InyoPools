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
    
    public partial class IPPEA_DATA_QandAQuestion_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int Id { get; set; }
        public string OriginalQuestion { get; set; }
        public string Question { get; set; }
        public string EmailAddress { get; set; }
        public string OriginalName { get; set; }
        public string Name { get; set; }
        public int QandAStatusId { get; set; }
        public Nullable<int> OriginalProductId { get; set; }
        public Nullable<int> SupportTicketId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
        public Nullable<System.DateTimeOffset> EmailSentDate { get; set; }
        public Nullable<System.DateTimeOffset> LockDate { get; set; }
        public Nullable<int> LockEmployeeId { get; set; }
        public Nullable<System.DateTimeOffset> LastStatusChangeDate { get; set; }
        public Nullable<int> SentToCustomerByEmployeeId { get; set; }
        public Nullable<System.DateTimeOffset> SentToCustomerDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string ZipCode { get; set; }
        public bool TaggedForQuote { get; set; }
        public Nullable<int> TaggedById { get; set; }
        public Nullable<System.DateTimeOffset> DateTagged { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}