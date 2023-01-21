using DAL.DB;
using g_Stock.Master;
using iTools;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g_Stock.PL
{
    public partial class frmArticleInfo : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();
        private frmA_ArticleInfo grid;
        private Article_Info an;

        private const string FormatImages = "Tous les images(images)|*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp;*.png;*.bmp;*.tif;*.tiff|Format d'échange graphique(GIF)|*.gif" +
                                                                               "|Groupe conjoint d'experts en photographie(JPEG)|*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp|Portable Network Graphics(PNG)" +
                                                                               "|*.png|Bitmap(BMP)|*.bmp|Format de fichier image balisé(TIFF)|*.tif;*.tiff|Portable Document Format (pdf)|*.pdf";

        #endregion Variables

        #region Codes

        private void Verify(bool rs)
        {
            if (rs)
            {
                //Verify_Buttons(true);
                lbImages.Items.Clear();
                btnDeleteItem.Enabled = false;
                btnViewImages.Enabled = false;
                //btnUpdateImages.Enabled = false;
                btnDeleteImages.Enabled = false;
            }
        }

        private bool ExistImage(string name)
        {
            bool rs = false;
            string path = string.Format(@"{0}\{1}", Properties.Settings.Default.pathLphoto, name);
            if (File.Exists(path))
                rs = true;
            else
                rs = false;
            return rs;
        }

        private int getPhotoID(string photoName)
        {
            int AssNo = (from a in db.Article_Photo
                         where a.pho_Nom == photoName
                         select a).Single().pho_ID;
            return AssNo;
        }

        private string getPhotoExt(string photoName)
        {
            string ext = (from a in db.Article_Photo
                          where a.pho_Nom == photoName
                          && a.Article_Info.art_Designation == txtDesignation.Text.Trim().ToUpper()
                          select a).Single().pho_Extension;
            return ext;
        }

        public void getData()
        {
            string svc = Properties.Settings.Default.Service;
            grid.gcArticle.DataSource = db.Select_vw_Article(svc);
            grid.lblLigne.Text = string.Format("Ligne {00}", db.Count_Article_Info().FirstOrDefault());
            cmbxFamille.DataSource = db.Select_Famille();
            cmbxUnite.DataSource = db.Select_Unite_Mesure();
        }

        public void newRecord()
        {
            txtDesignation.Text = string.Empty;
            txtAbreviation.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cmbxFamille.Text = string.Empty;
            cmbxUnite.Text = string.Empty;
            getData();
            lbImages.Items.Clear();
            cmbxFamille.SelectedIndex = -1;
            cmbxUnite.SelectedIndex = -1;
            txtDesignation.Focus();
        }

        private void MovePhoto(string Fpath, string Lpath)
        {
            try
            {
                File.Copy(Fpath, Lpath, true);
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
            }
        }

        private bool CopyPhoto(string source, string destinataire)
        {
            bool rs = false;
            try
            {
                File.Copy(source, destinataire, true);
                rs = true;
            }
            catch (Exception ex)
            {
                rs = false;
                iMessage.errorMsg("Erreur", ex.Message);
            }
            return rs;
        }

        private bool CopyToTemp()
        {
            bool rs = false;
            string imgName;
            string newPath = Properties.Settings.Default.pathTemp;
            string str;
            foreach (string item in lbImages.Items)
            {
                FileInfo fi = new FileInfo(item);
                imgName = fi.Name;
                str = string.Format(@"{0}\{1}", newPath, imgName);
                if (CopyPhoto(item, str))
                    rs = true;
                else
                    rs = false;
            }
            return rs;
        }

        private void ClearFolderTemp(string folder, string item)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);

            FileInfo f = new FileInfo(item);
            foreach (FileInfo fi in dir.GetFiles())
            {
                if (f.Name.Equals(fi.Name))
                {
                    fi.Delete();
                }
            }

            //foreach (DirectoryInfo di in dir.GetDirectories())
            //{
            //    ClearFolderTemp(di.FullName);
            //    di.Delete();
            //}
        }

        private void showImages(Article_Info a)
        {
            lbImages.Items.Clear();
            Verify(true);
            foreach (var item in db.Select_Article_Photo_By_Article(a.art_ID))
            {
                lbImages.Items.Add(item.pho_Nom);
            }
        }

        #endregion Codes

        #region Overides

        public override void verifyButtons(Form f, string txt)
        {
            base.verifyButtons(this, "Ajouter un article");
        }

        public override void Add_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        int x = 0;
                        if (string.IsNullOrEmpty(txtDesignation.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDesignation.Focus();
                            return;
                        }
                        else if (string.IsNullOrEmpty(cmbxFamille.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cmbxFamille.Focus();
                            return;
                        }
                        else if (string.IsNullOrEmpty(cmbxUnite.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cmbxUnite.Focus();
                            return;
                        }
                        if (db.Article_Info.Any(f => f.art_Designation == txtDesignation.Text.ToUpper() && f.fam_ID == (int)cmbxFamille.SelectedValue && f.unit_M_ID == (int)cmbxUnite.SelectedValue))
                        {
                            iMessage.warningMsg("Attention", "Cet article est existe déjà");
                            txtDesignation.Focus();
                            return;
                        }
                        else
                        {
                            //Copier les photos vers dossier temporaire
                            if (CopyToTemp())
                            {
                                //Ajouter Article_Info
                                Service svc = db.Service.Where(f => f.svc_Nom == Properties.Settings.Default.Service).FirstOrDefault();
                                db.Insert_Article_Info(db.MaxID_Article_Info().FirstOrDefault(), txtDesignation.Text.Trim(), txtAbreviation.Text, txtDescription.Text.Trim(), svc.svc_ID, (int)cmbxFamille.SelectedValue, (int)cmbxUnite.SelectedValue);
                                //Ajouter les Article_Photo
                                string imgName;
                                string newPath = Properties.Settings.Default.pathLphoto;
                                string name = txtAbreviation.Text.ToUpper();
                                string ext;
                                foreach (string item in lbImages.Items)
                                {
                                    if (!db.Article_Photo.Any(f => f.pho_Nom == item && f.Article_Info.art_Abreviation == txtAbreviation.Text))
                                    {
                                        x++;
                                        FileInfo fi = new FileInfo(item);
                                        imgName = fi.Name;
                                        ext = fi.Extension;
                                        string num = string.Format("{0:00}", x);
                                        string Fphoto = string.Format(@"{0}\{1}", Properties.Settings.Default.pathTemp, imgName);
                                        string Lphoto = string.Format(@"{0}\{1}_{2}{3}", newPath, name, num, ext);

                                        if (CopyPhoto(Fphoto, Lphoto))
                                        {
                                            db.Insert_Article_Photo(db.MaxID_Article_Photo().FirstOrDefault(), newPath, (name + "_" + num).ToUpper(), ext, db.Select_Article_Info_By_Designation(txtDesignation.Text.Trim()).FirstOrDefault());
                                            ClearFolderTemp(Properties.Settings.Default.pathTemp, item);
                                        }
                                    }
                                }
                                db.SaveChanges();
                                transaction.Commit();
                                //form.txtStatus.Caption = "Votre code a bien ajouté";
                                iMessage.sucMsg("Information", "Votre article a bien ajouté");
                                newRecord();
                                Verify(true);
                                Verify_Buttons(true);
                            }
                            else
                                transaction.Rollback();

                            //    //ClearFolderTemp(Properties.Settings.Default.pathTemp);
                            //}
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

        #endregion Overides

        public frmArticleInfo(frmA_ArticleInfo f)
        {
            InitializeComponent();
            grid = f;
        }

        public frmArticleInfo(frmA_ArticleInfo f, Article_Info ai)
        {
            InitializeComponent();
            grid = f;
            an = ai;
            cmbxFamille.DataSource = db.Select_Famille();
            cmbxUnite.DataSource = db.Select_Unite_Mesure();
            txtDesignation.Text = ai.art_Designation;
            txtAbreviation.Text = ai.art_Abreviation;
            txtDescription.Text = ai.art_Description;
            cmbxFamille.SelectedValue = ai.fam_ID;
            cmbxUnite.SelectedValue = ai.unit_M_ID;
            showImages(an);
        }

        private void frmArticleInfo_Load(object sender, EventArgs e)
        {
            if (Text == "Ajouter un article")
            {
                newRecord();
                Verify(true);
            }
        }

        private void txtDesignation_Validating(object sender, CancelEventArgs e)
        {
            string rs = txtDesignation.Text;
            txtDesignation.Text = iText.UpperCase(rs).Trim();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string rs = txtDescription.Text;
            txtDescription.Text = iText.DefaultText(rs).Trim();
        }

        private void btnFamAjouter_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Veuillez entrer une famille", "Ajout", null, Location.X + 20, Location.Y + 30);
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(input.Trim()))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (db.Famille.Any(f => f.fam_Nom == input.ToUpper() && f.fam_Status == true))
                    {
                        iMessage.warningMsg("Attention", "Cette famille est existe déjà");
                        return;
                    }
                    else
                    {
                        db.Insert_Famille(db.MaxID_Famille().FirstOrDefault(), input.Trim().ToUpper(), "");
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre famille a bien ajouté");
                        cmbxFamille.DataSource = db.Select_Famille();
                        cmbxFamille.Text = input.ToUpper();
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

        private void btnMAjouter_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Veuillez entrer une unité de mesure", "Ajout", null, Location.X + 20, Location.Y + 30);
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(input.Trim()))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (db.Unite_Mesure.Any(f => f.unit_M_Abreviation == input.Trim().ToUpper() && f.unit_M_Status == true))
                    {
                        iMessage.warningMsg("Attention", "Cette unité de mesure est existe déjà");
                        return;
                    }
                    else
                    {
                        db.Insert_Unite_Mesure(db.MaxID_Unite_Mesure().FirstOrDefault(), "", input.Trim().ToUpper());
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre unité de mesure a bien ajouté");
                        cmbxUnite.DataSource = db.Select_Unite_Mesure();
                        cmbxUnite.Text = input.Trim().ToUpper();
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

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            ofdImages.Filter = FormatImages;
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofdImages.FileNames)
                {
                    lbImages.Items.Add(file);
                }
            }
        }

        private void lbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(lbImages.Items == null))
                {
                    if (lbImages.Items.Count > 0)
                    {
                        if (db.Article_Photo.Any(f => f.pho_Nom == lbImages.SelectedItem.ToString() && f.Article_Info.art_Designation == txtDesignation.Text))
                        {
                            btnDeleteImages.Enabled = true;
                            btnDeleteItem.Enabled = false;
                        }
                        else
                        {
                            btnDeleteImages.Enabled = false;
                            btnDeleteItem.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (string s in lbImages.SelectedItems.OfType<string>().ToList())
                lbImages.Items.Remove(s);
        }

        private void btnUpdateImages_Click(object sender, EventArgs e)
        {
            using (var transction = db.Database.BeginTransaction())
            {
            }
            FileInfo fi;
            string DbPath = Properties.Settings.Default.pathLphoto;
            string TempPath = Properties.Settings.Default.pathTemp;
            string name = txtAbreviation.Text.Trim().ToUpper();
            string ext, num, imgName, DirNew, DirTemp;
            int x = 0;
            foreach (string item in lbImages.Items)
            {
                x++;
                fi = new FileInfo(item);
                ext = fi.Extension;
                num = string.Format("{0:00}", x);
                imgName = fi.Name;
                DirNew = string.Format(@"{0}\{1}_{2}{3}", DbPath, name, num, ext);
                DirTemp = string.Format(@"{0}\{1}", TempPath, imgName);
                if (db.Article_Photo.Any(f => f.pho_Nom == item && f.Article_Info.art_Designation == txtDesignation.Text))
                    db.Update_Article_Photo(DbPath, string.Format(@"{0}_{1}", name, num), ext, getPhotoID(item));
                else
                {
                    //Copy to Temp Folder
                    if (!CopyPhoto(item, DirTemp))
                        return;
                    //Copy to DB folder
                    if (!CopyPhoto(DirTemp, DirNew))
                        return;
                    db.Insert_Article_Photo(db.MaxID_Article_Photo().FirstOrDefault(), DbPath, (name + "_" + num).ToUpper(), ext, db.Select_Article_Info_By_Designation(txtDesignation.Text.Trim()).FirstOrDefault());
                    ClearFolderTemp(Properties.Settings.Default.pathTemp, item);
                }
            }
            db.SaveChanges();
            showImages(an);
        }

        private void btnDeleteImages_Click(object sender, EventArgs e)
        {
        }

        private void txtAbreviation_Validating(object sender, CancelEventArgs e)
        {
            string txt = txtAbreviation.Text;
            txtAbreviation.Text = txt.Trim().ToUpper();
            //if (db.Article_Info.Any(f => f.art_Abreviation == txt))
            //    epError.SetError(txtAbreviation, "Cette abréviation existe déjà");
            //else
            //{
            //    epError.SetError(txtAbreviation, "");
            //}
        }
    }
}