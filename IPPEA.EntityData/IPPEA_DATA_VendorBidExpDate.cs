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
    
    public partial class IPPEA_DATA_VendorBidExpDate
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> VendorProductID { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public Nullable<decimal> NewPrice { get; set; }
        public Nullable<int> InStock { get; set; }
        public string ShipFromLocation { get; set; }
        public Nullable<bool> PriceMatch { get; set; }
        public string VendorNote { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> ParentID { get; set; }
    }
}
