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
    
    public partial class IPPEA_DATA_QandAQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_QandAQuestion()
        {
            this.IPPEA_DATA_ConversationQandAQuestion = new HashSet<IPPEA_DATA_ConversationQandAQuestion>();
            this.IPPEA_DATA_QandAAnswer = new HashSet<IPPEA_DATA_QandAAnswer>();
            this.IPPEA_DATA_QandAAsked = new HashSet<IPPEA_DATA_QandAAsked>();
            this.IPPEA_DATA_QandAProductGroups = new HashSet<IPPEA_DATA_QandAProductGroups>();
            this.IPPEA_DATA_QandAProducts = new HashSet<IPPEA_DATA_QandAProducts>();
            this.IPPEA_DATA_QandAQuestionMedia = new HashSet<IPPEA_DATA_QandAQuestionMedia>();
            this.IPPEA_DATA_Quotes = new HashSet<IPPEA_DATA_Quotes>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ConversationQandAQuestion> IPPEA_DATA_ConversationQandAQuestion { get; set; }
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees1 { get; set; }
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees2 { get; set; }
        public virtual IPPEA_DATA_Product IPPEA_DATA_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAAnswer> IPPEA_DATA_QandAAnswer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAAsked> IPPEA_DATA_QandAAsked { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAProductGroups> IPPEA_DATA_QandAProductGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAProducts> IPPEA_DATA_QandAProducts { get; set; }
        public virtual IPPEA_DECODE_QandAStatus IPPEA_DECODE_QandAStatus { get; set; }
        public virtual IPPEA_DATA_SupportTickets IPPEA_DATA_SupportTickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAQuestionMedia> IPPEA_DATA_QandAQuestionMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_Quotes> IPPEA_DATA_Quotes { get; set; }
    }
}
