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
    
    public partial class IPPEA_DATA_Returns
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_Returns()
        {
            this.IPPEA_DATA_ConversationReturn = new HashSet<IPPEA_DATA_ConversationReturn>();
            this.IPPEA_DATA_ReturnItems = new HashSet<IPPEA_DATA_ReturnItems>();
        }
    
        public int ID { get; set; }
        public int OrderFormID { get; set; }
        public string RMANumber { get; set; }
        public int RMAStatusID { get; set; }
        public bool CreditIssued { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public string Vendor { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string UserID { get; set; }
        public bool IsCancelled { get; set; }
        public Nullable<System.DateTime> CancelledDate { get; set; }
        public string CancelledUserID { get; set; }
        public Nullable<int> ReOrderOption { get; set; }
        public Nullable<bool> ReOrderIssued { get; set; }
        public Nullable<int> MistakeID { get; set; }
        public Nullable<int> ResponsibilityID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ConversationReturn> IPPEA_DATA_ConversationReturn { get; set; }
        public virtual IPPEA_DATA_OrderFormHeader IPPEA_DATA_OrderFormHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ReturnItems> IPPEA_DATA_ReturnItems { get; set; }
        public virtual IPPEA_DECODE_RMA_Mistakes IPPEA_DECODE_RMA_Mistakes { get; set; }
        public virtual IPPEA_DECODE_RMA_Responsibility IPPEA_DECODE_RMA_Responsibility { get; set; }
        public virtual IPPEA_DECODE_RMAStatus IPPEA_DECODE_RMAStatus { get; set; }
    }
}