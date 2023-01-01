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
    public partial class frmFamille : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();

        #endregion Variables

        #region Codes

        public void getData()
        {
            gcFamille.DataSource = db.Select_Famille();
            lblLigne.Text = string.Format("Ligne {00}", gvFamille.RowCount);
        }

        public void newRecord()
        {
            txtFamille.Text = string.Empty;
            txtDescription.Text = string.Empty;
            getData();
            txtFamille.Focus();
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
                        if (string.IsNullOrEmpty(txtFamille.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (db.Famille.Any(f => f.fam_Nom == txtFamille.Text.ToUpper() && f.fam_Status == true))
                        {
                            iTools.iMessage.warningMsg("Attention", "Cette famille est excite déjà");
                            txtFamille.Focus();
                            return;
                        }
                        else
                        {
                            db.Insert_Famille(db.MaxID_Famille().FirstOrDefault(), txtFamille.Text.Trim().ToUpper(), txtDescription.Text);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre famille a bien ajouté");
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
                        var row = gvFamille.FocusedRowHandle;
                        int id = int.Parse(gvFamille.GetRowCellValue(row, "fam_ID").ToString());
                        db.Update_Famille(id, txtFamille.Text.Trim().ToUpper(), txtDescription.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iTools.iMessage.sucMsg("Information", "Votre famille a bien modifié");
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
                DialogResult re = MessageBox.Show("Voulez-vous supprimer cette famille", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var row = gvFamille.FocusedRowHandle;
                            int id = int.Parse(gvFamille.GetRowCellValue(row, "fam_ID").ToString());
                            db.Delete_Famille(id);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre famille a bien supprimé");
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

        public frmFamille()
        {
            InitializeComponent();
        }

        private void frmFamille_Load(object sender, EventArgs e)
        {
            newRecord();
            Verify_Buttons(true);
        }

        private void txtFamille_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFamille.Text))
            {
                //e.Cancel = true;
                txtFamille.Focus();
                errorProvider1.SetError(txtFamille, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFamille, null);
            }
        }

        private void gvFamille_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvFamille.RowCount > 0)
                {
                    try
                    {
                        Verify_Buttons(false);
                        var row = gvFamille.FocusedRowHandle;
                        int id = int.Parse(gvFamille.GetRowCellValue(row, "fam_ID").ToString());
                        Refresh();
                        Famille f = db.Select_Famille_By_ID(id).FirstOrDefault();
                        txtFamille.Text = f.fam_Nom;
                        txtDescription.Text = f.fam_Descripction;
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
    }
}