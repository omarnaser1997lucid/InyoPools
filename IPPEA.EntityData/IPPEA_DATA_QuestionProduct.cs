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
    
    public partial class IPPEA_DATA_QuestionProduct
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int ProductID { get; set; }
    
        public virtual IPPEA_DATA_Product IPPEA_DATA_Product { get; set; }
        public virtual IPPEA_DATA_Question IPPEA_DATA_Question { get; set; }
    }
}
