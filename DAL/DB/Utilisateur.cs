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
    
    public partial class Utilisateur
    {
        public int util_ID { get; set; }
        public string util_Nom { get; set; }
        public Nullable<System.DateTime> util_Date { get; set; }
        public string util_Identifiant { get; set; }
        public string util_MotPasse { get; set; }
        public Nullable<int> svc_ID { get; set; }
        public Nullable<int> prof_ID { get; set; }
    
        public virtual Profil Profil { get; set; }
        public virtual Service Service { get; set; }
    }
}
