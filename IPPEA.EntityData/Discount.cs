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
    
    public partial class Discount
    {
        public int uid { get; set; }
        public string Name { get; set; }
        public Nullable<int> DiscountType { get; set; }
        public string PercentOff { get; set; }
        public string DollarOff { get; set; }
        public string Expires { get; set; }
        public string MinAmount { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<int> AppliedTo { get; set; }
        public Nullable<int> AppliedToID { get; set; }
        public string Code { get; set; }
        public Nullable<int> MinAmountType { get; set; }
        public string Description { get; set; }
    }
}
