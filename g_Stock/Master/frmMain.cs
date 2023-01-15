using g_Stock.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g_Stock.Master
{
    public partial class frmMain : Form
    {
        #region Variables

        private string username = Properties.Settings.Default.Identifiant;
        private string profil = Properties.Settings.Default.Profil;
        private string service = Properties.Settings.Default.Service;

        #endregion Variables

        #region Codes

        public void OpenForm(Form _Form)
        {
            if (!isFormActivated(_Form))
            {
                _Form.MdiParent = this;
                _Form.Show();
            }
        }

        private bool isFormActivated(Form _Form)
        {
            bool isOpen = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (_Form.Name == item.Name)
                    {
                        mdi_Manager.Pages[item].MdiChild.Activate();
                        isOpen = true;
                    }
                }
            }
            return isOpen;
        }

        #endregion Codes

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFamille_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFamille frm = new frmFamille();
            frm.ShowDialog();
        }

        private void btnService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmService frm = new frmService();
            frm.ShowDialog();
        }

        private void btnProfil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProfil frm = new frmProfil();
            frm.ShowDialog();
        }

        private void btnUtilisateur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUtilisateur frm = new frmUtilisateur();
            OpenForm(frm);
        }

        private void btnMagasin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMagasin frm = new frmMagasin();
            frm.ShowDialog();
        }

        private void btnRayonnage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRayonnage frm = new frmRayonnage();
            frm.ShowDialog();
        }

        private void btnArticle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmA_ArticleInfo frm = new frmA_ArticleInfo();
            OpenForm(frm);
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblProfil.Caption = string.Format("Profil: {0}", profil);
            lblUser.Caption = string.Format("Identifiant: {0}", username);
            lblService.Caption = string.Format("Service: {0}", service);
        }
    }
}