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
    
    public partial class IPPEA_DATA_ProductPriceUpdateResult
    {
        public int Id { get; set; }
        public int UpdateId { get; set; }
        public string ManufacturerCode { get; set; }
        public int MatchingProductCount { get; set; }
        public Nullable<decimal> PriceBeforeUpdate { get; set; }
        public decimal NewPrice { get; set; }
        public bool IsUpdated { get; set; }
        public bool RequiresManualReview { get; set; }
        public string UpdateNotes { get; set; }
    
        public virtual IPPEA_DATA_ProductPriceUpdate IPPEA_DATA_ProductPriceUpdate { get; set; }
    }
}