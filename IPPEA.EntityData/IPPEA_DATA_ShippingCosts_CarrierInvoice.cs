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
    
    public partial class IPPEA_DATA_ShippingCosts_CarrierInvoice
    {
        public int ID { get; set; }
        public string CarrierInvoice { get; set; }
        public Nullable<System.DateTime> InvoicingDate { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public Nullable<int> InvoiceStatus { get; set; }
        public Nullable<int> CarrierID { get; set; }
        public string AccountNumber { get; set; }
        public string UserName { get; set; }
    }
}