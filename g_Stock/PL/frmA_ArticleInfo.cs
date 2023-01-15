using DAL.DB;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmA_ArticleInfo : frmL
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();

        #endregion Variables

        #region Codes

        private void PopulateGridView()
        {
            gvArticle.OptionsView.ShowGroupPanel = false;
            gvArticle.Columns["fam_Nom"].Group();
        }

        #endregion Codes

        #region Overrides

        public override void getData()
        {
            string svc = Properties.Settings.Default.Service;
            gcArticle.DataSource = db.Select_vw_Article(svc);
        }

        #endregion Overrides

        public frmA_ArticleInfo()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void frmA_ArticleInfo_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}