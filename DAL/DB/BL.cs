//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class BL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BL()
        {
            this.BL_Article = new HashSet<BL_Article>();
        }
    
        public int bl_ID { get; set; }
        public Nullable<System.DateTime> bl_Date { get; set; }
        public string bl_Reference { get; set; }
        public Nullable<int> frns_ID { get; set; }
        public Nullable<int> unt_ID { get; set; }
        public Nullable<int> act_ID { get; set; }
        public string bl_Description { get; set; }
        public Nullable<bool> bl_Status { get; set; }
    
        public virtual Action Action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BL_Article> BL_Article { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Unite Unite { get; set; }
    }
}