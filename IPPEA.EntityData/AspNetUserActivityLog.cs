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
    
    public partial class AspNetUserActivityLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public int UserActivityId { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
        public string RawUrl { get; set; }
        public string UrlMethod { get; set; }
        public bool IsAuthenticated { get; set; }
    
        public virtual AspNetUserActivityType AspNetUserActivityType { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
