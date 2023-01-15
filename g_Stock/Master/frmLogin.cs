using DAL.DB;
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

namespace g_Stock.Master
{
    public partial class frmLogin : Form
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();

        #endregion Variables

        #region Codes

        private void LoadData()
        {
            cmbxService.DataSource = db.Select_Service();
            cmbxProfil.DataSource = db.Select_Profil();
            cmbxProfil.Text = "Profil";
            cmbxService.Text = "Service";
        }

        private void Login()
        {
            if (txtUsername.Text == "Identifiant")
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else if (txtPassword.Text == "Mot de passe")
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            else if (cmbxService.Text == "Service")
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxProfil.Focus();
                return;
            }
            else if (cmbxProfil.Text == "Profil")
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxService.Focus();
                return;
            }
            else
            {
                try
                {
                    int? userId = db.Validate_Utilisateur(txtUsername.Text, iCryptage.Encrypt(txtPassword.Text), (int)cmbxService.SelectedValue, (int)cmbxProfil.SelectedValue).FirstOrDefault();
                    if (userId.Value > 0)
                    {
                        Utilisateur util = db.Select_Utilisateur_By_ID(userId).FirstOrDefault();
                        Properties.Settings.Default.Service = util.Service.svc_Nom;
                        Properties.Settings.Default.Profil = util.Profil.prof_Nom;
                        Properties.Settings.Default.Identifiant = util.util_Identifiant;
                        Properties.Settings.Default.Save();
                        frmMain frm = new frmMain();
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Votre nom d'utilisateur et votre mot de passe sont erronés", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion Codes

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Identifiant")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void cmbxService_Enter(object sender, EventArgs e)
        {
            if (cmbxService.Text == "Service" || !(cmbxService.DataSource == null))
            {
                cmbxService.Text = "";
                cmbxService.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Identifiant";
                txtUsername.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mot de passe";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void cmbxService_Leave(object sender, EventArgs e)
        {
            if (cmbxService.Text == "" || cmbxService.DataSource == null)
            {
                cmbxService.Text = "Service";
                cmbxService.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void cmbxProfil_Leave(object sender, EventArgs e)
        {
            if (cmbxProfil.Text == "" || cmbxProfil.DataSource == null)
            {
                cmbxProfil.Text = "Profil";
                cmbxProfil.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void cmbxProfil_Enter(object sender, EventArgs e)
        {
            if (cmbxProfil.Text == "Profil" || !(cmbxProfil.DataSource == null))
            {
                cmbxProfil.Text = "";
                cmbxProfil.ForeColor = Color.Black;
            }
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}