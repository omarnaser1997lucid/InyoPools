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
    
    public partial class IPPEA_DATA_SafetyCoverSampleRequest
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Nullable<int> Approved { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
        public Nullable<System.DateTime> DateProcessed { get; set; }
        public Nullable<int> ServiceRepID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> ProcessedRepID { get; set; }
    }
}