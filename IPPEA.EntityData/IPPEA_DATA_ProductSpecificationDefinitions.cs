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
    
    public partial class IPPEA_DATA_ProductSpecificationDefinitions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_ProductSpecificationDefinitions()
        {
            this.IPPEA_DATA_ProductGroupSpecifications = new HashSet<IPPEA_DATA_ProductGroupSpecifications>();
            this.IPPEA_DATA_ProductSpecifications = new HashSet<IPPEA_DATA_ProductSpecifications>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductSpecificationTypeID { get; set; }
        public Nullable<int> UnitOfMeasurementID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductGroupSpecifications> IPPEA_DATA_ProductGroupSpecifications { get; set; }
        public virtual IPPEA_DECODE_ProductSpecificationTypes IPPEA_DECODE_ProductSpecificationTypes { get; set; }
        public virtual IPPEA_DECODE_UnitOfMeasurement IPPEA_DECODE_UnitOfMeasurement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductSpecifications> IPPEA_DATA_ProductSpecifications { get; set; }
    }
}
