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
    
    public partial class Article_Reference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article_Reference()
        {
            this.Article_CodeBarre = new HashSet<Article_CodeBarre>();
            this.BL_Article = new HashSet<BL_Article>();
            this.Emplacement = new HashSet<Emplacement>();
        }
    
        public int ref_ID { get; set; }
        public Nullable<int> art_ID { get; set; }
        public string ref_reference { get; set; }
        public Nullable<bool> ref_Checked { get; set; }
        public Nullable<bool> ref_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article_CodeBarre> Article_CodeBarre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BL_Article> BL_Article { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emplacement> Emplacement { get; set; }
        public virtual Article_Info Article_Info { get; set; }
    }
}
