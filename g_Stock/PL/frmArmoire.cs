using DAL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTools;

namespace g_Stock.PL
{
    public partial class frmArmoire : Form
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();
        private frmRayonnage grid;
        private DataTable dt;
        private int id, rayoID;

        #endregion Variables

        public frmArmoire(frmRayonnage f, string status, int rayoID)
        {
            InitializeComponent();
            Text = status;
            grid = f;
            dt = iData.CreateDataTable("Armoire", ("arm_Nom", "System.String"), ("arm_Description", "System.String"));
            Verify_Buttons(status);
            this.rayoID = rayoID;
        }

        public frmArmoire(frmRayonnage f, string status, int id, string nom, string description, int rayoID)
        {
            InitializeComponent();
            grid = f;
            dt = iData.CreateDataTable("Armoire", ("arm_Nom", "System.String"), ("arm_Description", "System.String"));
            Verify_Buttons(status);
            this.id = id;
            txtArmoire.Text = nom;
            txtDescription.Text = description;
            this.rayoID = rayoID;
        }

        #region Codes

        public void getData()
        {
            grid.gcArmoire.DataSource = dt;
        }

        public void Verify_Buttons(string status)
        {
            if (Text == "Ajouter une Armoire")
            {
                Text = "Ajouter une Armoire";
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
            }
            else
            {
                Text = "Modifier une Armoire";
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
            }
        }

        public void newRecord()
        {
            txtArmoire.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtArmoire.Focus();
        }

        public void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtArmoire.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db.Armoire.Any(f => f.arm_Nom == txtArmoire.Text.ToUpper() && f.arm_Status == true))
                {
                    iMessage.warningMsg("Attention", "Cette Armoire est existe déjà");
                    txtArmoire.Focus();
                    return;
                }
                else
                {
                    if (rayoID > 0)
                    {
                        db.Insert_Armoire(db.MaxID_Armoire().FirstOrDefault(), txtArmoire.Text, txtDescription.Text, rayoID);
                        iMessage.sucMsg("Information", "Votre Armoire a bien ajouté");
                        newRecord();
                        grid.gcArmoire.DataSource = db.Select_Armoire_By_Rayonage(rayoID).ToList();
                        Verify_Buttons("Ajouter une Armoire");
                    }
                    else
                    {
                        dt.Rows.Add(txtArmoire.Text, txtDescription.Text);
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre Armoire a bien ajouté");
                        newRecord();
                        getData();
                        Verify_Buttons("Ajouter une Armoire");
                    }
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public void Update_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Update_Armoire(id, txtArmoire.Text.Trim().ToUpper(), txtDescription.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre Armoire a bien modifié");
                        newRecord();
                        grid.gcArmoire.DataSource = db.Select_Armoire_By_Rayonage(rayoID).ToList();
                        Close();
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

        #endregion Codes

        private void frmArmoire_Load(object sender, EventArgs e)
        {
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void txtArmoire_Validating(object sender, CancelEventArgs e)
        {
            string rs = txtArmoire.Text;
            txtArmoire.Text = iText.UpperCase(rs);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string rs = txtDescription.Text;
            txtDescription.Text = iText.DefaultText(rs);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Update_Data();
        }
    }
}