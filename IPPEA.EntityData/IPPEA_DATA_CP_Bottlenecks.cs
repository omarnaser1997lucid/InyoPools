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
    
    public partial class IPPEA_DATA_CP_Bottlenecks
    {
        public int ID { get; set; }
        public Nullable<int> BottleneckTypeID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> EMP_OR_TEAM_ID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> StatusVar1_Date { get; set; }
        public string StatusVar2_ThirdParty { get; set; }
        public Nullable<int> StatusVar3_TransferToID { get; set; }
        public Nullable<int> StatusVar4_TransferToType { get; set; }
        public Nullable<int> BottleneckStatusID { get; set; }
        public string CreatedBy { get; set; }
    }
}
