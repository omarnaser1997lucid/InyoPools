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
    
    public partial class IPPEA_DATA_CheckoutShippingMethod
    {
        public int ID { get; set; }
        public System.Guid CheckoutID { get; set; }
        public int ShipMethodID { get; set; }
        public string Name { get; set; }
        public string DeliveryCommitment { get; set; }
        public string Disclaimer { get; set; }
        public decimal Cost { get; set; }
    
        public virtual IPPEA_DATA_Checkout IPPEA_DATA_Checkout { get; set; }
        public virtual IPPEA_DATA_ShipMethods IPPEA_DATA_ShipMethods { get; set; }
    }
}
