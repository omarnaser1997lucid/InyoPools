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
    
    public partial class IPPEA_DATA_HowToInformation_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public int SectionTypeID { get; set; }
        public int HowToPageID { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int Rank { get; set; }
        public string Link { get; set; }
        public string HtmlLink { get; set; }
        public string ImageFileName { get; set; }
        public string AltImageText { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
