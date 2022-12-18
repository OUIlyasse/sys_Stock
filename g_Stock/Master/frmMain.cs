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
    }
}