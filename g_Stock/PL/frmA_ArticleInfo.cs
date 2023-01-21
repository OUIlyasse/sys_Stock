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
            lblLigne.Text = string.Format("Ligne {00}", db.Count_Article_Info().FirstOrDefault());
        }

        public override void openForm()
        {
            frmArticleInfo frm = new frmArticleInfo(this);
            frm.Text = "Ajouter un article";
            frm.ShowDialog();
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

        private void gvArticle_DoubleClick(object sender, EventArgs e)
        {
            {
                try
                {
                    if (gvArticle.RowCount > 0)
                    {
                        var row = gvArticle.FocusedRowHandle;
                        int idArt = int.Parse(gvArticle.GetRowCellValue(row, "art_ID").ToString());
                        Article_Info ai = db.Select_Article_Info_By_ID(idArt).FirstOrDefault();
                        frmArticleInfo frm = new frmArticleInfo(this, ai);
                        frm.Text = "Modifier un article";
                        frm.ShowDialog();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void gvArticle_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvArticle.RowCount > 0)
                Verify_Buttons(false);
        }
    }
}