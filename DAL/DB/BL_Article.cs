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
    
    public partial class BL_Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BL_Article()
        {
            this.Mouvement = new HashSet<Mouvement>();
        }
    
        public int bl_A_ID { get; set; }
        public Nullable<System.DateTime> bl_A_Date { get; set; }
        public Nullable<decimal> bl_Qte_Demandee { get; set; }
        public Nullable<decimal> bl_Qte_Livree { get; set; }
        public Nullable<decimal> bl_Qte_Manque { get; set; }
        public Nullable<int> bl_ID { get; set; }
        public Nullable<int> art_ID { get; set; }
        public Nullable<int> ref_ID { get; set; }
        public Nullable<int> cb_ID { get; set; }
        public Nullable<bool> bl_A_Status { get; set; }
    
        public virtual Article_CodeBarre Article_CodeBarre { get; set; }
        public virtual Article_Reference Article_Reference { get; set; }
        public virtual BL BL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mouvement> Mouvement { get; set; }
        public virtual Article_Info Article_Info { get; set; }
    }
}
