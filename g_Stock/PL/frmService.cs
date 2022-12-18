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
    public partial class frmService : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();

        #endregion Variables

        #region Codes

        public void getData()
        {
            gcService.DataSource = db.Select_Service();
            lblLigne.Text = string.Format("Ligne {00}", gvService.RowCount);
        }

        public void newRecord()
        {
            txtService.Text = string.Empty;
            txtDescription.Text = string.Empty;
            getData();
            txtService.Focus();
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
                        if (string.IsNullOrEmpty(txtService.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (db.Service.Any(f => f.svc_Nom == txtService.Text.ToUpper() && f.svc_Status == true))
                        {
                            iTools.iMessage.warningMsg("Attention", "Ce service est excite déjà");
                            txtService.Focus();
                            return;
                        }
                        else
                        {
                            db.Insert_Service(txtService.Text.Trim().ToUpper(), txtDescription.Text, DateTime.Now);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre service a bien ajouté");
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
                        var row = gvService.FocusedRowHandle;
                        int id = int.Parse(gvService.GetRowCellValue(row, "svc_ID").ToString());
                        db.Update_Service(id, txtService.Text.Trim().ToUpper(), txtDescription.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iTools.iMessage.sucMsg("Information", "Votre service a bien modifié");
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
                DialogResult re = MessageBox.Show("Voulez-vous supprimer ce service", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var row = gvService.FocusedRowHandle;
                            int id = int.Parse(gvService.GetRowCellValue(row, "svc_ID").ToString());
                            db.Delete_Service(id);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre service a bien supprimé");
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

        public frmService()
        {
            InitializeComponent();
        }

        private void gvService_DoubleClick(object sender, EventArgs e)
        {
            if (gvService.RowCount > 0)
            {
                try
                {
                    Verify_Buttons(false);
                    var row = gvService.FocusedRowHandle;
                    int id = int.Parse(gvService.GetRowCellValue(row, "svc_ID").ToString());
                    Service f = db.Select_Service_By_ID(id).FirstOrDefault();
                    txtService.Text = f.svc_Nom;
                    txtDescription.Text = f.svc_description;
                }
                catch (Exception ex)
                {
                    iTools.iMessage.errorMsg("Erreur", ex.Message);
                }
            }
        }

        private void txtService_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtService.Text))
            {
                //e.Cancel = true;
                txtService.Focus();
                errorProvider1.SetError(txtService, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtService, null);
            }
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            newRecord();
            Verify_Buttons(true);
        }
    }
}