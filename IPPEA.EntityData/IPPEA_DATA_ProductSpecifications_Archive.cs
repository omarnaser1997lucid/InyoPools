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
    
    public partial class IPPEA_DATA_ProductSpecifications_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string SpecificationName { get; set; }
        public string SpecificationValue { get; set; }
        public string SpecificationType { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ProductSpecificationDefinitionID { get; set; }
        public string OldSpecificationValue { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
