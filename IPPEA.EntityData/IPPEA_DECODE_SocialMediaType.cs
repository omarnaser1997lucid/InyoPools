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
    
    public partial class IPPEA_DECODE_SocialMediaType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DECODE_SocialMediaType()
        {
            this.IPPEA_DATA_ProductSocialMediaSubmission = new HashSet<IPPEA_DATA_ProductSocialMediaSubmission>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductSocialMediaSubmission> IPPEA_DATA_ProductSocialMediaSubmission { get; set; }
    }
}