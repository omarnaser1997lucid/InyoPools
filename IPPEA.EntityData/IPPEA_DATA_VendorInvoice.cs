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
    
    public partial class IPPEA_DATA_VendorInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_VendorInvoice()
        {
            this.IPPEA_DATA_VendorInvoiceItem = new HashSet<IPPEA_DATA_VendorInvoiceItem>();
        }
    
        public int ID { get; set; }
        public int OrderFormID { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<decimal> ShippingCost { get; set; }
        public Nullable<decimal> TaxCost { get; set; }
        public Nullable<decimal> HandlingCost { get; set; }
        public Nullable<decimal> TotalDiscount { get; set; }
        public decimal TotalCost { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string UserName { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool PaidVendor { get; set; }
        public Nullable<System.DateTime> VendorDatePaid { get; set; }
        public Nullable<int> BatchNum { get; set; }
        public System.DateTime VendorInvoiceDate { get; set; }
        public int InvoiceTypeID { get; set; }
    
        public virtual IPPEA_DATA_OrderFormHeader IPPEA_DATA_OrderFormHeader { get; set; }
        public virtual IPPEA_DATA_PaidVendorBatch IPPEA_DATA_PaidVendorBatch { get; set; }
        public virtual IPPEA_DECODE_VendorInvoiceType IPPEA_DECODE_VendorInvoiceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_VendorInvoiceItem> IPPEA_DATA_VendorInvoiceItem { get; set; }
    }
}