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
    
    public partial class GroupSpecificationsTemp1
    {
        public int Id { get; set; }
        public int ProductGroupID { get; set; }
        public string SpecificationName { get; set; }
        public string SpecificationType { get; set; }
        public Nullable<int> ProductSpecificationDefinitionID { get; set; }
        public bool ToBeInserted { get; set; }
        public bool ToBeDeleted { get; set; }
        public string OldSpecificationName { get; set; }
        public string OldSpecificationType { get; set; }
        public Nullable<int> OldProductSpecificationDefinitionID { get; set; }
    }
}
