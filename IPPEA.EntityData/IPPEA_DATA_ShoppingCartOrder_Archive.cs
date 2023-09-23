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
    
    public partial class IPPEA_DATA_ShoppingCartOrder_Archive
    {
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> ContactAddressID { get; set; }
        public Nullable<int> BillToAddressID { get; set; }
        public Nullable<int> ShipToAddressID { get; set; }
        public Nullable<int> EmailID { get; set; }
        public Nullable<int> PhoneID { get; set; }
        public Nullable<int> FaxID { get; set; }
        public Nullable<int> BillingOptionID { get; set; }
        public Nullable<int> BillingTypeID { get; set; }
        public Nullable<decimal> BillTotal { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> Shipping { get; set; }
        public Nullable<decimal> Handling { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> SalesTaxID { get; set; }
        public Nullable<int> ShipAccountID { get; set; }
        public Nullable<int> AffiliateID { get; set; }
        public string PONumber { get; set; }
        public string Notes { get; set; }
        public string AlternatePhoneNumber { get; set; }
        public Nullable<int> QuoteID { get; set; }
        public Nullable<int> BMLPromoType { get; set; }
        public string CCID { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<decimal> LiftGateFee { get; set; }
        public Nullable<int> CommercialAddress { get; set; }
        public Nullable<bool> SelectedLiftGate { get; set; }
        public Nullable<bool> UnishipperApiFailed { get; set; }
        public string TemplateTheme { get; set; }
    }
}
