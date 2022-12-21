using DAL.DB;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmUtilisateur : frmL
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();
        private string mode;

        #endregion Variables

        #region Codes

        public override void getData()
        {
            gcUtilisateur.DataSource = db.select_vw_Utilisateur();
            lblLigne.Text = string.Format("Ligne {00}", gvUtilisateur.RowCount);
        }

        public void Search(string mode, string txt, DateTime dt1, DateTime dt2)
        {
            gcUtilisateur.DataSource = db.Search_Utilisateur(mode, txt, dt1, dt2);
            lblLigne.Text = string.Format("Ligne {0}", gvUtilisateur.RowCount);
        }

        #endregion Codes

        #region Override

        public override void openForm()
        {
            frmA_Utilisateur frm = new frmA_Utilisateur(this);
            frm.Text = "Ajouter un utilisateur";
            frm.ShowDialog();
        }

        public override void Delete_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    DialogResult re = MessageBox.Show("Voulez-vous supprimer cet utilisateur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        var row = gvUtilisateur.FocusedRowHandle;
                        int id = int.Parse(gvUtilisateur.GetRowCellValue(row, "util_ID").ToString());
                        db.Delete_Utilisateur(id);
                        db.SaveChanges();
                        transaction.Commit();
                        getData();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre identifiant a bien supprimé");
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

        #endregion Override

        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void gvUtilisateur_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvUtilisateur.RowCount > 0)
                {
                    var row = gvUtilisateur.FocusedRowHandle;
                    int name = int.Parse(gvUtilisateur.GetRowCellValue(row, "util_ID").ToString());
                    Utilisateur ei = db.Select_Utilisateur_By_ID(name).FirstOrDefault();
                    string dt = ei.util_Date.ToString();
                    frmA_Utilisateur frm = new frmA_Utilisateur(this, ei);
                    frm.Text = "Modifier un utilisateur";
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void gvUtilisateur_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvUtilisateur.RowCount > 0)
                Verify_Buttons(false);
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value, dtp2.Value);
        }

        private void cmbxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMode.Text == "Nom")
            {
                dtp1.Visible = false;
                dtp2.Visible = false;
                lblDu.Visible = false;
                lblAu.Visible = false;
                txtSearch.Visible = true;
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                mode = "Nom";
            }
            else if (cmbxMode.Text == "Identifiant")
            {
                dtp1.Visible = false;
                dtp2.Visible = false;
                lblDu.Visible = false;
                lblAu.Visible = false;
                txtSearch.Visible = true;
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                mode = "Identifiant";
            }
            else if (cmbxMode.Text == "Date")
            {
                dtp1.Visible = true;
                dtp2.Visible = true;
                lblDu.Visible = true;
                lblAu.Visible = true;
                txtSearch.Visible = false;
                mode = "Date";
            }
            else if (cmbxMode.Text == "Service")
            {
                dtp1.Visible = false;
                dtp2.Visible = false;
                lblDu.Visible = false;
                lblAu.Visible = false;
                txtSearch.Visible = true;
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                mode = "Service";
            }
            else if (cmbxMode.Text == "Profil")
            {
                dtp1.Visible = false;
                dtp2.Visible = false;
                lblDu.Visible = false;
                lblAu.Visible = false;
                txtSearch.Visible = true;
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                mode = "Profil";
            }
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value, dtp2.Value);
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            Search(mode, txtSearch.Text, dtp1.Value, dtp2.Value);
        }
    }
}