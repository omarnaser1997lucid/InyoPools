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
    
    public partial class IPPEA_DATA_PartCharts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_PartCharts()
        {
            this.IPPEA_DATA_PartChartRows = new HashSet<IPPEA_DATA_PartChartRows>();
        }
    
        public int ID { get; set; }
        public int PartPageID { get; set; }
        public bool UseKey { get; set; }
        public bool UseItem { get; set; }
        public bool UseManufacturer { get; set; }
        public bool UseDescription { get; set; }
        public bool UseColumnHeader1 { get; set; }
        public bool UseColumnHeader2 { get; set; }
        public bool UseColumnHeader3 { get; set; }
        public bool UseColumnHeader4 { get; set; }
        public string ColumnHeader1 { get; set; }
        public string ColumnHeader2 { get; set; }
        public string ColumnHeader3 { get; set; }
        public string ColumnHeader4 { get; set; }
        public string ChartImage { get; set; }
        public string UserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> SortOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_PartChartRows> IPPEA_DATA_PartChartRows { get; set; }
        public virtual IPPEA_DATA_PartPages IPPEA_DATA_PartPages { get; set; }
    }
}
