﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class g_StockEntities : DbContext
    {
        public g_StockEntities()
            : base("name=g_StockEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Armoire> Armoire { get; set; }
        public virtual DbSet<Article_CodeBarre> Article_CodeBarre { get; set; }
        public virtual DbSet<Article_Info> Article_Info { get; set; }
        public virtual DbSet<Article_Photo> Article_Photo { get; set; }
        public virtual DbSet<Article_Reference> Article_Reference { get; set; }
        public virtual DbSet<BL> BL { get; set; }
        public virtual DbSet<BL_Article> BL_Article { get; set; }
        public virtual DbSet<Emplacement> Emplacement { get; set; }
        public virtual DbSet<Famille> Famille { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
        public virtual DbSet<Magasin> Magasin { get; set; }
        public virtual DbSet<Mouvement> Mouvement { get; set; }
        public virtual DbSet<Profil> Profil { get; set; }
        public virtual DbSet<Rayonnage> Rayonnage { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Unite> Unite { get; set; }
        public virtual DbSet<Unite_Mesure> Unite_Mesure { get; set; }
        public virtual DbSet<Unite_Type> Unite_Type { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
    
        public virtual int Delete_Famille(Nullable<int> fam_ID)
        {
            var fam_IDParameter = fam_ID.HasValue ?
                new ObjectParameter("fam_ID", fam_ID) :
                new ObjectParameter("fam_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Famille", fam_IDParameter);
        }
    
        public virtual int Insert_Famille(string fam_Nom, string fam_Descripction)
        {
            var fam_NomParameter = fam_Nom != null ?
                new ObjectParameter("fam_Nom", fam_Nom) :
                new ObjectParameter("fam_Nom", typeof(string));
    
            var fam_DescripctionParameter = fam_Descripction != null ?
                new ObjectParameter("fam_Descripction", fam_Descripction) :
                new ObjectParameter("fam_Descripction", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Famille", fam_NomParameter, fam_DescripctionParameter);
        }
    
        public virtual int Update_Famille(Nullable<int> fam_ID, string fam_Nom, string fam_Descripction)
        {
            var fam_IDParameter = fam_ID.HasValue ?
                new ObjectParameter("fam_ID", fam_ID) :
                new ObjectParameter("fam_ID", typeof(int));
    
            var fam_NomParameter = fam_Nom != null ?
                new ObjectParameter("fam_Nom", fam_Nom) :
                new ObjectParameter("fam_Nom", typeof(string));
    
            var fam_DescripctionParameter = fam_Descripction != null ?
                new ObjectParameter("fam_Descripction", fam_Descripction) :
                new ObjectParameter("fam_Descripction", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Famille", fam_IDParameter, fam_NomParameter, fam_DescripctionParameter);
        }
    
        public virtual ObjectResult<Select_Famille_Result> Select_Famille()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Famille_Result>("Select_Famille");
        }
    
        public virtual ObjectResult<Famille> Select_Famille_By_Famille(string fam_Nom)
        {
            var fam_NomParameter = fam_Nom != null ?
                new ObjectParameter("fam_Nom", fam_Nom) :
                new ObjectParameter("fam_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Famille>("Select_Famille_By_Famille", fam_NomParameter);
        }
    
        public virtual ObjectResult<Famille> Select_Famille_By_Famille(string fam_Nom, MergeOption mergeOption)
        {
            var fam_NomParameter = fam_Nom != null ?
                new ObjectParameter("fam_Nom", fam_Nom) :
                new ObjectParameter("fam_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Famille>("Select_Famille_By_Famille", mergeOption, fam_NomParameter);
        }
    
        public virtual ObjectResult<Famille> Select_Famille_By_ID(Nullable<int> fam_ID)
        {
            var fam_IDParameter = fam_ID.HasValue ?
                new ObjectParameter("fam_ID", fam_ID) :
                new ObjectParameter("fam_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Famille>("Select_Famille_By_ID", fam_IDParameter);
        }
    
        public virtual ObjectResult<Famille> Select_Famille_By_ID(Nullable<int> fam_ID, MergeOption mergeOption)
        {
            var fam_IDParameter = fam_ID.HasValue ?
                new ObjectParameter("fam_ID", fam_ID) :
                new ObjectParameter("fam_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Famille>("Select_Famille_By_ID", mergeOption, fam_IDParameter);
        }
    
        public virtual int Delete_Service(Nullable<int> svc_ID)
        {
            var svc_IDParameter = svc_ID.HasValue ?
                new ObjectParameter("svc_ID", svc_ID) :
                new ObjectParameter("svc_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Service", svc_IDParameter);
        }
    
        public virtual int Insert_Service(string svc_Nom, string svc_description, Nullable<System.DateTime> svc_Date)
        {
            var svc_NomParameter = svc_Nom != null ?
                new ObjectParameter("svc_Nom", svc_Nom) :
                new ObjectParameter("svc_Nom", typeof(string));
    
            var svc_descriptionParameter = svc_description != null ?
                new ObjectParameter("svc_description", svc_description) :
                new ObjectParameter("svc_description", typeof(string));
    
            var svc_DateParameter = svc_Date.HasValue ?
                new ObjectParameter("svc_Date", svc_Date) :
                new ObjectParameter("svc_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Service", svc_NomParameter, svc_descriptionParameter, svc_DateParameter);
        }
    
        public virtual ObjectResult<Select_Service_Result> Select_Service()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Service_Result>("Select_Service");
        }
    
        public virtual ObjectResult<Service> Select_Service_By_ID(Nullable<int> svc_ID)
        {
            var svc_IDParameter = svc_ID.HasValue ?
                new ObjectParameter("svc_ID", svc_ID) :
                new ObjectParameter("svc_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("Select_Service_By_ID", svc_IDParameter);
        }
    
        public virtual ObjectResult<Service> Select_Service_By_ID(Nullable<int> svc_ID, MergeOption mergeOption)
        {
            var svc_IDParameter = svc_ID.HasValue ?
                new ObjectParameter("svc_ID", svc_ID) :
                new ObjectParameter("svc_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("Select_Service_By_ID", mergeOption, svc_IDParameter);
        }
    
        public virtual ObjectResult<Service> Select_Service_By_Service(string svc_Nom)
        {
            var svc_NomParameter = svc_Nom != null ?
                new ObjectParameter("svc_Nom", svc_Nom) :
                new ObjectParameter("svc_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("Select_Service_By_Service", svc_NomParameter);
        }
    
        public virtual ObjectResult<Service> Select_Service_By_Service(string svc_Nom, MergeOption mergeOption)
        {
            var svc_NomParameter = svc_Nom != null ?
                new ObjectParameter("svc_Nom", svc_Nom) :
                new ObjectParameter("svc_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Service>("Select_Service_By_Service", mergeOption, svc_NomParameter);
        }
    
        public virtual int Update_Service(Nullable<int> svc_ID, string svc_Nom, string svc_description)
        {
            var svc_IDParameter = svc_ID.HasValue ?
                new ObjectParameter("svc_ID", svc_ID) :
                new ObjectParameter("svc_ID", typeof(int));
    
            var svc_NomParameter = svc_Nom != null ?
                new ObjectParameter("svc_Nom", svc_Nom) :
                new ObjectParameter("svc_Nom", typeof(string));
    
            var svc_descriptionParameter = svc_description != null ?
                new ObjectParameter("svc_description", svc_description) :
                new ObjectParameter("svc_description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Service", svc_IDParameter, svc_NomParameter, svc_descriptionParameter);
        }
    
        public virtual int Delete_Profil(Nullable<int> prof_ID)
        {
            var prof_IDParameter = prof_ID.HasValue ?
                new ObjectParameter("prof_ID", prof_ID) :
                new ObjectParameter("prof_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Profil", prof_IDParameter);
        }
    
        public virtual int Insert_Profil(string prof_Nom, string prof_Description)
        {
            var prof_NomParameter = prof_Nom != null ?
                new ObjectParameter("prof_Nom", prof_Nom) :
                new ObjectParameter("prof_Nom", typeof(string));
    
            var prof_DescriptionParameter = prof_Description != null ?
                new ObjectParameter("prof_Description", prof_Description) :
                new ObjectParameter("prof_Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Profil", prof_NomParameter, prof_DescriptionParameter);
        }
    
        public virtual ObjectResult<Select_Profil_Result> Select_Profil()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Profil_Result>("Select_Profil");
        }
    
        public virtual ObjectResult<Profil> Select_Profil_By_ID(Nullable<int> prof_ID)
        {
            var prof_IDParameter = prof_ID.HasValue ?
                new ObjectParameter("prof_ID", prof_ID) :
                new ObjectParameter("prof_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Profil>("Select_Profil_By_ID", prof_IDParameter);
        }
    
        public virtual ObjectResult<Profil> Select_Profil_By_ID(Nullable<int> prof_ID, MergeOption mergeOption)
        {
            var prof_IDParameter = prof_ID.HasValue ?
                new ObjectParameter("prof_ID", prof_ID) :
                new ObjectParameter("prof_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Profil>("Select_Profil_By_ID", mergeOption, prof_IDParameter);
        }
    
        public virtual ObjectResult<Profil> Select_Profil_By_Profil(string prof_Nom)
        {
            var prof_NomParameter = prof_Nom != null ?
                new ObjectParameter("prof_Nom", prof_Nom) :
                new ObjectParameter("prof_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Profil>("Select_Profil_By_Profil", prof_NomParameter);
        }
    
        public virtual ObjectResult<Profil> Select_Profil_By_Profil(string prof_Nom, MergeOption mergeOption)
        {
            var prof_NomParameter = prof_Nom != null ?
                new ObjectParameter("prof_Nom", prof_Nom) :
                new ObjectParameter("prof_Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Profil>("Select_Profil_By_Profil", mergeOption, prof_NomParameter);
        }
    
        public virtual int Update_Profil(Nullable<int> prof_ID, string prof_Nom, string prof_Description)
        {
            var prof_IDParameter = prof_ID.HasValue ?
                new ObjectParameter("prof_ID", prof_ID) :
                new ObjectParameter("prof_ID", typeof(int));
    
            var prof_NomParameter = prof_Nom != null ?
                new ObjectParameter("prof_Nom", prof_Nom) :
                new ObjectParameter("prof_Nom", typeof(string));
    
            var prof_DescriptionParameter = prof_Description != null ?
                new ObjectParameter("prof_Description", prof_Description) :
                new ObjectParameter("prof_Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Profil", prof_IDParameter, prof_NomParameter, prof_DescriptionParameter);
        }
    
        public virtual ObjectResult<select_vw_Utilisateur_Result> select_vw_Utilisateur()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_vw_Utilisateur_Result>("select_vw_Utilisateur");
        }
    
        public virtual int Delete_Utilisateur(Nullable<int> util_ID)
        {
            var util_IDParameter = util_ID.HasValue ?
                new ObjectParameter("util_ID", util_ID) :
                new ObjectParameter("util_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Utilisateur", util_IDParameter);
        }
    
        public virtual int Insert_Utilisateur(string util_Nom, Nullable<System.DateTime> util_Date, string util_Identifiant, string util_MotPasse, Nullable<int> svc_ID, Nullable<int> prof_ID)
        {
            var util_NomParameter = util_Nom != null ?
                new ObjectParameter("util_Nom", util_Nom) :
                new ObjectParameter("util_Nom", typeof(string));
    
            var util_DateParameter = util_Date.HasValue ?
                new ObjectParameter("util_Date", util_Date) :
                new ObjectParameter("util_Date", typeof(System.DateTime));
    
            var util_IdentifiantParameter = util_Identifiant != null ?
                new ObjectParameter("util_Identifiant", util_Identifiant) :
                new ObjectParameter("util_Identifiant", typeof(string));
    
            var util_MotPasseParameter = util_MotPasse != null ?
                new ObjectParameter("util_MotPasse", util_MotPasse) :
                new ObjectParameter("util_MotPasse", typeof(string));
    
            var svc_IDParameter = svc_ID.HasValue ?
                new ObjectParameter("svc_ID", svc_ID) :
                new ObjectParameter("svc_ID", typeof(int));
    
            var prof_IDParameter = prof_ID.HasValue ?
                new ObjectParameter("prof_ID", prof_ID) :
                new ObjectParameter("prof_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Utilisateur", util_NomParameter, util_DateParameter, util_IdentifiantParameter, util_MotPasseParameter, svc_IDParameter, prof_IDParameter);
        }
    
        public virtual ObjectResult<Utilisateur> Select_Utilisateur_By_ID(Nullable<int> util_ID)
        {
            var util_IDParameter = util_ID.HasValue ?
                new ObjectParameter("util_ID", util_ID) :
                new ObjectParameter("util_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Utilisateur>("Select_Utilisateur_By_ID", util_IDParameter);
        }
    
        public virtual ObjectResult<Utilisateur> Select_Utilisateur_By_ID(Nullable<int> util_ID, MergeOption mergeOption)
        {
            var util_IDParameter = util_ID.HasValue ?
                new ObjectParameter("util_ID", util_ID) :
                new ObjectParameter("util_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Utilisateur>("Select_Utilisateur_By_ID", mergeOption, util_IDParameter);
        }
    
        public virtual ObjectResult<Utilisateur> Select_Utilisateur_By_User(string util_Identifiant)
        {
            var util_IdentifiantParameter = util_Identifiant != null ?
                new ObjectParameter("util_Identifiant", util_Identifiant) :
                new ObjectParameter("util_Identifiant", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Utilisateur>("Select_Utilisateur_By_User", util_IdentifiantParameter);
        }
    
        public virtual ObjectResult<Utilisateur> Select_Utilisateur_By_User(string util_Identifiant, MergeOption mergeOption)
        {
            var util_IdentifiantParameter = util_Identifiant != null ?
                new ObjectParameter("util_Identifiant", util_Identifiant) :
                new ObjectParameter("util_Identifiant", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Utilisateur>("Select_Utilisateur_By_User", mergeOption, util_IdentifiantParameter);
        }
    
        public virtual int Update_Utilisateur(Nullable<int> util_ID, string util_Nom, string util_Identifiant, string util_MotPasse, Nullable<int> svc_ID, Nullable<int> prof_ID)
        {
            var util_IDParameter = util_ID.HasValue ?
                new ObjectParameter("util_ID", util_ID) :
                new ObjectParameter("util_ID", typeof(int));
    
            var util_NomParameter = util_Nom != null ?
                new ObjectParameter("util_Nom", util_Nom) :
                new ObjectParameter("util_Nom", typeof(string));
    
            var util_IdentifiantParameter = util_Identifiant != null ?
                new ObjectParameter("util_Identifiant", util_Identifiant) :
                new ObjectParameter("util_Identifiant", typeof(string));
    
            var util_MotPasseParameter = util_MotPasse != null ?
                new ObjectParameter("util_MotPasse", util_MotPasse) :
                new ObjectParameter("util_MotPasse", typeof(string));
    
            var svc_IDParameter = svc_ID.HasValue ?
                new ObjectParameter("svc_ID", svc_ID) :
                new ObjectParameter("svc_ID", typeof(int));
    
            var prof_IDParameter = prof_ID.HasValue ?
                new ObjectParameter("prof_ID", prof_ID) :
                new ObjectParameter("prof_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Utilisateur", util_IDParameter, util_NomParameter, util_IdentifiantParameter, util_MotPasseParameter, svc_IDParameter, prof_IDParameter);
        }
    
        public virtual ObjectResult<Search_Utilisateur_Result> Search_Utilisateur(string mode, string search, Nullable<System.DateTime> dt1, Nullable<System.DateTime> dt2)
        {
            var modeParameter = mode != null ?
                new ObjectParameter("mode", mode) :
                new ObjectParameter("mode", typeof(string));
    
            var searchParameter = search != null ?
                new ObjectParameter("Search", search) :
                new ObjectParameter("Search", typeof(string));
    
            var dt1Parameter = dt1.HasValue ?
                new ObjectParameter("dt1", dt1) :
                new ObjectParameter("dt1", typeof(System.DateTime));
    
            var dt2Parameter = dt2.HasValue ?
                new ObjectParameter("dt2", dt2) :
                new ObjectParameter("dt2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Utilisateur_Result>("Search_Utilisateur", modeParameter, searchParameter, dt1Parameter, dt2Parameter);
        }
    
        public virtual ObjectResult<Select_Service_By_Nom_Result> Select_Service_By_Nom()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Service_By_Nom_Result>("Select_Service_By_Nom");
        }
    }
}
