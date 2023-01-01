using DAL.DB;
using g_Stock.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g_Stock.PL
{
    public partial class frmProfil : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();

        #endregion Variables

        #region Codes

        public void getData()
        {
            gcProfil.DataSource = null;
            gcProfil.DataSource = db.Select_Profil();
            lblLigne.Text = string.Format("Ligne {00}", gvProfil.RowCount);
        }

        public void newRecord()
        {
            txtProfil.Text = string.Empty;
            txtDescription.Text = string.Empty;
            getData();
            txtProfil.Focus();
        }

        #endregion Codes

        #region Override

        public override void Add_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txtProfil.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (db.Profil.Any(f => f.prof_Nom == txtProfil.Text.ToUpper() && f.prof_Status == true))
                        {
                            iTools.iMessage.warningMsg("Attention", "Ce profil est excite déjà");
                            txtProfil.Focus();
                            return;
                        }
                        else
                        {
                            db.Insert_Profil(db.MaxID_Profil().FirstOrDefault(), txtProfil.Text.Trim().ToUpper(), txtDescription.Text);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre profil a bien ajouté");
                            newRecord();
                            Verify_Buttons(true);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iTools.iMessage.errorMsg("Erreur", ex.Message);
                        //form.txtStatus.Caption = ex.Message;
                    }
                }
            }
        }

        public override void Update_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var row = gvProfil.FocusedRowHandle;
                        int id = int.Parse(gvProfil.GetRowCellValue(row, "prof_ID").ToString());
                        db.Update_Profil(id, txtProfil.Text.Trim().ToUpper(), txtDescription.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iTools.iMessage.sucMsg("Information", "Votre profil a bien modifié");
                        newRecord();
                        Verify_Buttons(true);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iTools.iMessage.errorMsg("Erreur", ex.Message);
                        //form.txtStatus.Caption = ex.Message;
                    }
                }
            }
        }

        public override void Verify_Buttons(bool status)
        {
            base.Verify_Buttons(status);
        }

        public override void Delete_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult re = MessageBox.Show("Voulez-vous supprimer ce profil", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var row = gvProfil.FocusedRowHandle;
                            int id = int.Parse(gvProfil.GetRowCellValue(row, "prof_ID").ToString());
                            db.Delete_Profil(id);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre profil a bien supprimé");
                            newRecord();
                            Verify_Buttons(true);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            iTools.iMessage.errorMsg("Erreur", ex.Message);
                            //form.txtStatus.Caption = ex.Message;
                        }
                    }
                }
            }
        }

        #endregion Override

        public frmProfil()
        {
            InitializeComponent();
        }

        private void Profil_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProfil.Text))
            {
                //e.Cancel = true;
                txtProfil.Focus();
                errorProvider1.SetError(txtProfil, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtProfil, null);
            }
        }

        private void gvProfil_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvProfil.RowCount > 0)
                {
                    try
                    {
                        Verify_Buttons(false);
                        var row = gvProfil.FocusedRowHandle;
                        string id = gvProfil.GetRowCellValue(row, "prof_Nom").ToString();
                        Profil f = db.Select_Profil_By_Profil(id).FirstOrDefault();
                        MessageBox.Show(f.prof_Nom);
                        txtProfil.Text = f.prof_Nom;
                        txtDescription.Text = f.prof_Description;
                    }
                    catch (Exception ex)
                    {
                        iTools.iMessage.errorMsg("Erreur", ex.Message);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            newRecord();
            Verify_Buttons(true);
        }
    }
}