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
    
    public partial class IPPEA_DATA_CouponCodes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_CouponCodes()
        {
            this.IPPEA_DATA_CheckoutItem = new HashSet<IPPEA_DATA_CheckoutItem>();
            this.IPPEA_DATA_OrderCoupons = new HashSet<IPPEA_DATA_OrderCoupons>();
            this.IPPEA_DATA_ProductBlogMentions = new HashSet<IPPEA_DATA_ProductBlogMentions>();
            this.IPPEA_DATA_ShoppingCartCoupons = new HashSet<IPPEA_DATA_ShoppingCartCoupons>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CouponID { get; set; }
        public string CouponCode { get; set; }
        public Nullable<int> MaxUses { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_CheckoutItem> IPPEA_DATA_CheckoutItem { get; set; }
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_OrderCoupons> IPPEA_DATA_OrderCoupons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductBlogMentions> IPPEA_DATA_ProductBlogMentions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ShoppingCartCoupons> IPPEA_DATA_ShoppingCartCoupons { get; set; }
    }
}
