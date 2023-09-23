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
    
    public partial class IPPEA_DATA_PaidVendorBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_PaidVendorBatch()
        {
            this.IPPEA_DATA_VendorInvoice = new HashSet<IPPEA_DATA_VendorInvoice>();
        }
    
        public int ID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public decimal BatchTotal { get; set; }
        public decimal ChangeInTotal { get; set; }
        public Nullable<decimal> EarlyDiscount { get; set; }
        public Nullable<decimal> NewTotal { get; set; }
        public string UserID { get; set; }
        public int VendorID { get; set; }
        public string CheckNumber { get; set; }
        public Nullable<System.DateTime> DatePaid { get; set; }
        public string PaymentNote { get; set; }
        public Nullable<int> MediaId { get; set; }
        public Nullable<int> MediaResourceTypeId { get; set; }
    
        public virtual IPPEA_DATA_Media IPPEA_DATA_Media { get; set; }
        public virtual IPPEA_DECODE_MediaResourceTypes IPPEA_DECODE_MediaResourceTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_VendorInvoice> IPPEA_DATA_VendorInvoice { get; set; }
    }
}