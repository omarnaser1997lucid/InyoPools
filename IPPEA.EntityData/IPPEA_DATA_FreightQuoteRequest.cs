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
    
    public partial class IPPEA_DATA_FreightQuoteRequest
    {
        public int ID { get; set; }
        public Nullable<int> OrderFormID { get; set; }
        public Nullable<decimal> FreightCost { get; set; }
        public string Carrier { get; set; }
        public string Notes { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> OrderGroupID { get; set; }
    
        public virtual IPPEA_DATA_OrderGroup IPPEA_DATA_OrderGroup { get; set; }
    }
}