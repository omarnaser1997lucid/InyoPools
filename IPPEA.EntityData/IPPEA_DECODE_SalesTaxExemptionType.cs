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
    
    public partial class IPPEA_DECODE_SalesTaxExemptionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DECODE_SalesTaxExemptionType()
        {
            this.IPPEA_DATA_SalesTaxExemption = new HashSet<IPPEA_DATA_SalesTaxExemption>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool StateSpecific { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_SalesTaxExemption> IPPEA_DATA_SalesTaxExemption { get; set; }
    }
}
