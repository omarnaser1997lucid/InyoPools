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
    
    public partial class IPPEA_DATA_EbaySettings
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string Certificate { get; set; }
        public string Application { get; set; }
        public string RuName { get; set; }
        public string Token { get; set; }
        public Nullable<System.DateTime> TokenCreateDate { get; set; }
        public Nullable<System.DateTime> TokenExpirationDate { get; set; }
        public string ApiUrl { get; set; }
        public string FeedbackMsg { get; set; }
        public Nullable<bool> Selected { get; set; }
    }
}