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
    
    public partial class IPPEA_DATA_ProductAttribute_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int TemplateID { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageFileName { get; set; }
        public string InstructionsTitle { get; set; }
        public string Instructions { get; set; }
        public string ArrowImageFileName { get; set; }
        public Nullable<int> OldProductID { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
