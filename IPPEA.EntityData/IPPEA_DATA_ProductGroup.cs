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
    
    public partial class IPPEA_DATA_ProductGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_ProductGroup()
        {
            this.IPPEA_DATA_Product = new HashSet<IPPEA_DATA_Product>();
            this.IPPEA_DATA_ProductGroupSpecifications = new HashSet<IPPEA_DATA_ProductGroupSpecifications>();
            this.IPPEA_DATA_QandAProductGroups = new HashSet<IPPEA_DATA_QandAProductGroups>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Priority { get; set; }
        public bool OnlyShowInStock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_Product> IPPEA_DATA_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductGroupSpecifications> IPPEA_DATA_ProductGroupSpecifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAProductGroups> IPPEA_DATA_QandAProductGroups { get; set; }
    }
}
