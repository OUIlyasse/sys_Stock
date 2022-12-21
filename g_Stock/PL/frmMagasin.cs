using DAL.DB;
using g_Stock.Master;
using iTools;
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
    public partial class frmMagasin : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();

        #endregion Variables

        #region Codes

        public void getData()
        {
            gcMagasin.DataSource = db.Select_Magasin();
            lblLigne.Text = string.Format("Ligne {00}", gvMagasin.RowCount);
        }

        public void newRecord()
        {
            txtMagasin.Text = string.Empty;
            txtVille.Text = "AGADIR";
            txtDescription.Text = string.Empty;
            getData();
            txtMagasin.Focus();
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
                        if (string.IsNullOrEmpty(txtMagasin.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (db.Magasin.Any(f => f.mags_Magasin == txtMagasin.Text.ToUpper()))
                        {
                            iMessage.warningMsg("Attention", "Cette magasin est existe déjà");
                            txtMagasin.Focus();
                            return;
                        }
                        else
                        {
                            db.Insert_Magasin(txtMagasin.Text.Trim().ToUpper(), txtVille.Text.Trim().ToUpper(), txtDescription.Text);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iMessage.sucMsg("Information", "Votre magasin a bien ajouté");
                            newRecord();
                            Verify_Buttons(true);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iMessage.errorMsg("Erreur", ex.Message);
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
                        var row = gvMagasin.FocusedRowHandle;
                        int id = int.Parse(gvMagasin.GetRowCellValue(row, "mags_ID").ToString());
                        db.Update_Magasin(id, txtMagasin.Text.Trim().ToUpper(), txtVille.Text.Trim().ToUpper(), txtDescription.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre magasin a bien modifié");
                        newRecord();
                        Verify_Buttons(true);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iMessage.errorMsg("Erreur", ex.Message);
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
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette magasin", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var row = gvMagasin.FocusedRowHandle;
                            int id = int.Parse(gvMagasin.GetRowCellValue(row, "mags_ID").ToString());
                            db.Delete_Magasin(id);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iMessage.sucMsg("Information", "Votre magasin a bien supprimé");
                            newRecord();
                            Verify_Buttons(true);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            iMessage.errorMsg("Erreur", ex.Message);
                            //form.txtStatus.Caption = ex.Message;
                        }
                    }
                }
            }
        }

        #endregion Override

        public frmMagasin()
        {
            InitializeComponent();
            newRecord();
        }

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            newRecord();
            Verify_Buttons(true);
        }

        private void txtMagasin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMagasin.Text))
            {
                //e.Cancel = true;
                txtMagasin.Focus();
                errorProvider1.SetError(txtMagasin, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtMagasin, null);
            }
        }

        private void gvMagasin_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvMagasin.RowCount > 0)
                {
                    try
                    {
                        Verify_Buttons(false);
                        var row = gvMagasin.FocusedRowHandle;
                        int id = int.Parse(gvMagasin.GetRowCellValue(row, "mags_ID").ToString());
                        Refresh();
                        Magasin f = db.Select_Magasin_By_ID(id).FirstOrDefault();
                        txtMagasin.Text = f.mags_Magasin;
                        txtVille.Text = f.mags_Ville;
                        txtDescription.Text = f.mags_Description;
                    }
                    catch (Exception ex)
                    {
                        iMessage.errorMsg("Erreur", ex.Message);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}