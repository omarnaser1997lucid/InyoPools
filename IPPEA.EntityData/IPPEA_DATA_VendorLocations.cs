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
    
    public partial class IPPEA_DATA_VendorLocations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_VendorLocations()
        {
            this.IPPEA_DATA_VendorInventory = new HashSet<IPPEA_DATA_VendorInventory>();
        }
    
        public int ID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string LocationKey { get; set; }
        public Nullable<bool> IsVirtual { get; set; }
        public Nullable<int> PhysicalLocationID { get; set; }
    
        public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_VendorInventory> IPPEA_DATA_VendorInventory { get; set; }
    }
}