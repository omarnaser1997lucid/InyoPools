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
    
    public partial class IPPEA_DATA_QandAAnswerMedia
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public int MediaResourceTypeId { get; set; }
        public int QandAAnswerId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public bool IsApproved { get; set; }
    
        public virtual IPPEA_DATA_Media IPPEA_DATA_Media { get; set; }
        public virtual IPPEA_DATA_QandAAnswer IPPEA_DATA_QandAAnswer { get; set; }
        public virtual IPPEA_DECODE_MediaResourceTypes IPPEA_DECODE_MediaResourceTypes { get; set; }
    }
}
