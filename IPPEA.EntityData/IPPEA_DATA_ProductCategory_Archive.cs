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
    
    public partial class IPPEA_DATA_ProductCategory_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int ParentLevel { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string CategoryPage { get; set; }
        public bool IsActive { get; set; }
        public string ImageName { get; set; }
        public string PageFooter { get; set; }
        public string PageHeader { get; set; }
        public bool DisplayProductListing { get; set; }
        public bool OverridePhysicalFile { get; set; }
        public string GoogleConversionLabel { get; set; }
        public Nullable<decimal> GoogleConversionValue { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeywords { get; set; }
        public string PageH1 { get; set; }
        public bool DisplayOnNavigation { get; set; }
        public string NavigationTitle { get; set; }
        public string NavigationAdvertisementHeading { get; set; }
        public string NavigationAdvertisementImagePath { get; set; }
        public string NavigationAdvertisementText { get; set; }
        public int PageTypeId { get; set; }
        public Nullable<int> RelatedPartCategoryID { get; set; }
        public bool RenderNewVersion { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
