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
    
    public partial class IPPEA_DATA_Notes
    {
        public int ID { get; set; }
        public int ObjectTypeID { get; set; }
        public int ObjectKey { get; set; }
        public string NoteDesc { get; set; }
        public string UserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool PrintFlag { get; set; }
        public int NoteTypeID { get; set; }
        public Nullable<int> ObjectFlags { get; set; }
    }
}
