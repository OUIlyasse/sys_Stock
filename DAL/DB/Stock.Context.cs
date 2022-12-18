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
    
        public virtual int Delete_Famille_Provisoire(Nullable<int> fam_ID)
        {
            var fam_IDParameter = fam_ID.HasValue ?
                new ObjectParameter("fam_ID", fam_ID) :
                new ObjectParameter("fam_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Famille_Provisoire", fam_IDParameter);
        }
    
        public virtual int Return_Famille(Nullable<int> fam_ID)
        {
            var fam_IDParameter = fam_ID.HasValue ?
                new ObjectParameter("fam_ID", fam_ID) :
                new ObjectParameter("fam_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Return_Famille", fam_IDParameter);
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
    }
}
