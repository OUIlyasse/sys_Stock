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
    
    public partial class Emplacement
    {
        public int eplc_ID { get; set; }
        public Nullable<System.DateTime> eplc_Date { get; set; }
        public Nullable<int> art_ID { get; set; }
        public Nullable<int> ref_ID { get; set; }
        public Nullable<int> arm_ID { get; set; }
        public Nullable<int> rayo_ID { get; set; }
        public Nullable<int> mags_ID { get; set; }
        public string eplc_Description { get; set; }
    
        public virtual Armoire Armoire { get; set; }
        public virtual Article_Info Article_Info { get; set; }
        public virtual Article_Reference Article_Reference { get; set; }
        public virtual Magasin Magasin { get; set; }
        public virtual Rayonnage Rayonnage { get; set; }
    }
}
