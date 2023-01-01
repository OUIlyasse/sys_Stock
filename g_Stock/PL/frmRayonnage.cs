using DAL.DB;
using DevExpress.XtraGrid.Views.Grid;
using g_Stock.Master;
using iTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g_Stock.PL
{
    public partial class frmRayonnage : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();
        private int id;

        #endregion Variables

        #region Codes

        public void LoadRayonnage()
        {
            gcRayonnage.DataSource = db.Select_Rayonnage();
            lblLigne.Text = string.Format("Ligne {00}", gvRayonnage.RowCount);
        }

        public void LoadArmoire()
        {
            gcArmoire.DataSource = db.Select_Armoire_By_Rayonage(id).ToList();
        }

        public void SuuprimerArmoire()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer cette armoire", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var row = gvArmoire.FocusedRowHandle;
                        int id = int.Parse(gvArmoire.GetRowCellValue(row, "arm_ID").ToString());
                        db.Delete_Armoire(id);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre armoire a bien supprimé");
                        LoadArmoire();
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

        public void newRecord()
        {
            txtRayonnage.Text = string.Empty;
            txtDescription.Text = string.Empty;
            LoadRayonnage();
            gcArmoire.DataSource = null;
            txtRayonnage.Focus();
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
                        if (string.IsNullOrEmpty(txtRayonnage.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtRayonnage.Focus();
                            return;
                        }
                        if (gvArmoire.RowCount <= 0)
                        {
                            MessageBox.Show("Votre armoire est vide, insérez-en au moins un", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gvArmoire.Focus();
                            return;
                        }
                        if (db.Rayonnage.Any(f => f.rayo_Nom == txtRayonnage.Text))
                        {
                            iMessage.warningMsg("Attention", "Cette rayonnage est existe déjà");
                            txtRayonnage.Select();
                            return;
                        }
                        else
                        {
                            db.Insert_Rayonnage(db.MaxID_Rayonnage().FirstOrDefault(), txtRayonnage.Text, txtDescription.Text);
                            for (int i = 0; i < gvArmoire.DataRowCount; i++)
                            {
                                string Nom = gvArmoire.GetRowCellValue(i, "arm_Nom").ToString();
                                string Description = gvArmoire.GetRowCellValue(i, "arm_Description").ToString();
                                db.Insert_Armoire_By_Rayonnage(db.MaxID_Armoire().FirstOrDefault(), Nom, Description, txtRayonnage.Text);
                            }
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iMessage.sucMsg("Information", "Votre Rayonnage a bien ajouté");
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
                        if (string.IsNullOrEmpty(txtRayonnage.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtRayonnage.Focus();
                            return;
                        }
                        if (gvArmoire.RowCount <= 0)
                        {
                            MessageBox.Show("Votre armoire est vide, insérez-en au moins un", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gvArmoire.Focus();
                            return;
                        }
                        if (db.Rayonnage.Any(f => f.rayo_Nom == txtRayonnage.Text))
                        {
                            iMessage.warningMsg("Attention", "Cette rayonnage est existe déjà");
                            txtRayonnage.Select();
                            return;
                        }
                        else
                        {
                            db.Update_Rayonnage(id, txtRayonnage.Text, txtDescription.Text);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iMessage.sucMsg("Information", "Votre Rayonnage a bien ajouté");
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

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer cette Rayonnage", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var row = gvRayonnage.FocusedRowHandle;
                        int id = int.Parse(gvRayonnage.GetRowCellValue(row, "rayo_ID").ToString());
                        for (int i = 0; i < gvArmoire.DataRowCount; i++)
                        {
                            int idArmoir = int.Parse(gvArmoire.GetRowCellValue(i, "arm_ID").ToString());
                            db.Delete_Armoire(idArmoir);
                        }
                        db.Delete_Rayonnage(id);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre armoire a bien supprimé");
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

        #endregion Override

        public frmRayonnage()
        {
            InitializeComponent();
            newRecord();
        }

        private void frmRayonnage_Load(object sender, EventArgs e)
        {
            btnArmSupprimer.Enabled = false;
        }

        private void txtRayonnage_Validating(object sender, CancelEventArgs e)
        {
            string rs = txtRayonnage.Text;
            txtRayonnage.Text = iText.UpperCase(rs);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string rs = txtDescription.Text;
            txtDescription.Text = iText.DefaultText(rs);
        }

        private void btnArmAjouter_Click(object sender, EventArgs e)
        {
            int rayoID;
            var row = gvRayonnage.FocusedRowHandle;
            if (db.Count_Rayonnage_By_Nom(txtRayonnage.Text).FirstOrDefault() > 0)
                rayoID = int.Parse(gvRayonnage.GetRowCellValue(row, "rayo_ID").ToString());
            else
                rayoID = 0;
            frmArmoire f = new frmArmoire(this, "Ajouter une Armoire", rayoID);
            f.ShowDialog();
        }

        private void gvRayonnage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvRayonnage.RowCount > 0)
                {
                    try
                    {
                        Verify_Buttons(false);
                        var row = gvRayonnage.FocusedRowHandle;
                        int id = int.Parse(gvRayonnage.GetRowCellValue(row, "rayo_ID").ToString());
                        Rayonnage f = db.Select_Rayonnage_By_ID(id).FirstOrDefault();
                        txtRayonnage.Text = f.rayo_Nom;
                        txtDescription.Text = f.rayo_Description;
                        this.id = id;
                        LoadArmoire();
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

        private void gvArmoire_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvArmoire.RowCount > 0)
                {
                    try
                    {
                        var row = gvArmoire.FocusedRowHandle;
                        int id = int.Parse(gvArmoire.GetRowCellValue(row, "arm_ID").ToString());
                        Armoire f = db.Select_Armoire_By_ID(id).FirstOrDefault();
                        frmArmoire frm = new frmArmoire(this, "Modifier une Armoire", f.arm_ID, f.arm_Nom, f.arm_Description, int.Parse(f.rayo_ID.ToString()));
                        frm.ShowDialog();
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

        private void btnArmSupprimer_Click(object sender, EventArgs e)
        {
            SuuprimerArmoire();
        }

        private void gvArmoire_RowClick(object sender, RowClickEventArgs e)
        {
            btnArmSupprimer.Enabled = true;
        }
    }
}