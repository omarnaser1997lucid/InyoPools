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
    
    public partial class IPPEA_DATA_Shipper
    {
        public int ID { get; set; }
        public string ShipperName { get; set; }
        public string ShipperPhone { get; set; }
        public Nullable<int> MethodOfPayment { get; set; }
        public Nullable<decimal> LateChargeFee { get; set; }
        public string URL { get; set; }
        public string ShipUserName { get; set; }
        public string ShipPassword { get; set; }
        public string SalesRepName { get; set; }
        public string SalesRepPhone { get; set; }
        public string SalesRepEmail { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string ShipperNumber { get; set; }
    }
}
