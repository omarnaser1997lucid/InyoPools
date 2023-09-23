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
    
    public partial class IPPEA_DATA_Coupons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_Coupons()
        {
            this.IPPEA_DATA_CheckoutItem = new HashSet<IPPEA_DATA_CheckoutItem>();
            this.IPPEA_DATA_CouponProducts = new HashSet<IPPEA_DATA_CouponProducts>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CouponTypeID { get; set; }
        public string Description { get; set; }
        public string PublicDescription { get; set; }
        public Nullable<int> PctOff { get; set; }
        public Nullable<decimal> AmountOff { get; set; }
        public Nullable<decimal> FixedPrice { get; set; }
        public Nullable<bool> FreeShipping { get; set; }
        public Nullable<bool> FreeHandling { get; set; }
        public Nullable<decimal> MinOrderTotal { get; set; }
        public Nullable<decimal> MaxOrderTotal { get; set; }
        public Nullable<int> MinQty { get; set; }
        public Nullable<int> MaxQty { get; set; }
        public Nullable<int> MaxUses { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public string Referrer { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<bool> CanBeCombined { get; set; }
        public Nullable<int> CriteriaTypeID { get; set; }
        public string ManufacturerCodeStart { get; set; }
        public string ManufacturerCodeEnd { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Terms { get; set; }
        public Nullable<bool> AutoUse { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_CheckoutItem> IPPEA_DATA_CheckoutItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_CouponProducts> IPPEA_DATA_CouponProducts { get; set; }
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
    }
}
