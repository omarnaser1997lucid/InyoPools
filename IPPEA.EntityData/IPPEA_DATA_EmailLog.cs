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
    
    public partial class IPPEA_DATA_EmailLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_EmailLog()
        {
            this.IPPEA_DATA_EmailAttachmentsLog = new HashSet<IPPEA_DATA_EmailAttachmentsLog>();
            this.IPPEA_DATA_EmailLog1 = new HashSet<IPPEA_DATA_EmailLog>();
            this.IPPEA_DATA_EmailQueue = new HashSet<IPPEA_DATA_EmailQueue>();
        }
    
        public int ID { get; set; }
        public Nullable<int> EmailTypeID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string UserID { get; set; }
        public System.DateTime DateSent { get; set; }
        public Nullable<int> OrderGroupID { get; set; }
        public Nullable<int> OrderFormID { get; set; }
        public Nullable<int> EmailTransactionTypeID { get; set; }
        public string EmailBody { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public string EmailBcc { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> QuoteId { get; set; }
        public Nullable<int> OriginalEmailLogId { get; set; }
        public Nullable<int> MediaID { get; set; }
    
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_EmailAttachmentsLog> IPPEA_DATA_EmailAttachmentsLog { get; set; }
        public virtual IPPEA_DECODE_EmailTransactionTypes IPPEA_DECODE_EmailTransactionTypes { get; set; }
        public virtual IPPEA_DECODE_EmailTypes IPPEA_DECODE_EmailTypes { get; set; }
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
        public virtual IPPEA_DATA_Manufacturer IPPEA_DATA_Manufacturer { get; set; }
        public virtual IPPEA_DATA_Media IPPEA_DATA_Media { get; set; }
        public virtual IPPEA_DATA_OrderFormHeader IPPEA_DATA_OrderFormHeader { get; set; }
        public virtual IPPEA_DATA_OrderGroup IPPEA_DATA_OrderGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_EmailLog> IPPEA_DATA_EmailLog1 { get; set; }
        public virtual IPPEA_DATA_EmailLog IPPEA_DATA_EmailLog2 { get; set; }
        public virtual IPPEA_DATA_Quotes IPPEA_DATA_Quotes { get; set; }
        public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_EmailQueue> IPPEA_DATA_EmailQueue { get; set; }
    }
}