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
using Microsoft.VisualBasic;
using iTools;

namespace g_Stock.PL
{
    public partial class frmA_Utilisateur : frmG
    {
        #region Variables

        private g_StockEntities db = new g_StockEntities();
        private frmUtilisateur fu;
        private int getID;

        #endregion Variables

        #region Override

        public override void verifyButtons(Form f, string txt)
        {
            base.verifyButtons(this, "Ajouter un utilisateur");
        }

        public override void Add_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txtIdentifiant.Text.Trim()) || string.IsNullOrEmpty(txtNom.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(cmbxProfil.Text.Trim()) || string.IsNullOrEmpty(cmbxService.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!(txtPass.Text == txtRepeter.Text))
                        {
                            MessageBox.Show("Les champs de mot de passe ne sont plus les mêmes", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (db.Utilisateur.Any(f => f.util_Identifiant == txtIdentifiant.Text.ToUpper()))
                        {
                            iMessage.warningMsg("Attention", "Cet identifiant est existe déjà");
                            txtIdentifiant.Focus();
                            return;
                        }
                        else
                        {
                            db.Insert_Utilisateur(txtNom.Text.Trim().ToUpper(), DateTime.Now, txtIdentifiant.Text.Trim().ToUpper(), iTools.iCryptage.Encrypt(txtPass.Text), int.Parse(cmbxService.SelectedValue.ToString()), int.Parse(cmbxProfil.SelectedValue.ToString()));
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre identifiant a bien ajouté");
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
                        if (string.IsNullOrEmpty(txtIdentifiant.Text.Trim()) || string.IsNullOrEmpty(txtNom.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(cmbxProfil.Text.Trim()) || string.IsNullOrEmpty(cmbxService.Text.Trim()))
                        {
                            MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!(txtPass.Text == txtRepeter.Text))
                        {
                            MessageBox.Show("Les champs de mot de passe ne sont plus les mêmes", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        db.Update_Utilisateur(getID, txtNom.Text.Trim().ToUpper(), txtIdentifiant.Text.Trim().ToUpper(), iCryptage.Encrypt(txtPass.Text), int.Parse(cmbxService.SelectedValue.ToString()), int.Parse(cmbxProfil.SelectedValue.ToString()));
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iMessage.sucMsg("Information", "Votre identifiant a bien modifié");
                        newRecord();
                        Text = "Ajouter un utilisateur";
                        verifyButtons(this, "Ajouter un utilisateur");
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

        public override void Verify_Buttons(bool status)
        {
            base.Verify_Buttons(status);
        }

        public override void Delete_Data()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        DialogResult re = MessageBox.Show("Voulez-vous supprimer cet utilisateur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (re == DialogResult.Yes)
                        {
                            db.Delete_Utilisateur(getID);
                            db.SaveChanges();
                            transaction.Commit();
                            //form.txtStatus.Caption = "Votre code a bien ajouté";
                            iTools.iMessage.sucMsg("Information", "Votre identifiant a bien supprimé");
                            newRecord();
                            Text = "Ajouter un utilisateur";
                            verifyButtons(this, "Ajouter un utilisateur");
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

        #endregion Override

        #region Code

        private void fillCombo()
        {
            cmbxService.DataSource = db.Select_Service();
            cmbxProfil.DataSource = db.Select_Profil();
        }

        private void newRecord()
        {
            txtNom.Text = string.Empty;
            txtIdentifiant.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtRepeter.Text = string.Empty;
            cmbxProfil.Text = string.Empty;
            cmbxService.Text = string.Empty;
            txtNom.Focus();
            fu.gcUtilisateur.DataSource = db.select_vw_Utilisateur();
            fu.lblLigne.Text = string.Format("Ligne {00}", fu.gvUtilisateur.RowCount);
        }

        #endregion Code

        public frmA_Utilisateur(frmUtilisateur f)
        {
            InitializeComponent();
            fillCombo();
            fu = f;
        }

        public frmA_Utilisateur(frmUtilisateur f, Utilisateur u)
        {
            InitializeComponent();
            fillCombo();
            fu = f;
            getID = u.util_ID;
            txtNom.Text = u.util_Nom;
            txtIdentifiant.Text = u.util_Identifiant;
            txtPass.Text = iCryptage.Decrypt(u.util_MotPasse);
            txtRepeter.Text = iCryptage.Decrypt(u.util_MotPasse);
            cmbxService.SelectedValue = int.Parse(u.svc_ID.ToString());
            cmbxProfil.SelectedValue = int.Parse(u.prof_ID.ToString());
        }

        private void txtIdentifiant_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentifiant.Text))
            {
                //e.Cancel = true;
                txtIdentifiant.Focus();
                errorProvider1.SetError(txtIdentifiant, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtIdentifiant, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                //e.Cancel = true;
                txtPass.Focus();
                errorProvider1.SetError(txtPass, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtPass, null);
            }
        }

        private void txtRepeter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRepeter.Text))
            {
                //e.Cancel = true;
                txtRepeter.Focus();
                errorProvider1.SetError(txtRepeter, "Veuillez remplir ce champ");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtRepeter, null);
            }
        }

        private void cmbxAfficher_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbxAfficher.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtRepeter.UseSystemPasswordChar = false;
                txtRepeter.Enabled = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtRepeter.UseSystemPasswordChar = true;
                txtRepeter.Enabled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!txtRepeter.Enabled)
            {
                txtRepeter.Text = txtPass.Text;
            }
        }

        private void frmA_Utilisateur_Load(object sender, EventArgs e)
        {
            if (Text == "Ajouter un utilisateur")
                newRecord();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Veuillez entrer un service", "Ajout", null, Location.X + 20, Location.Y + 30);
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(input.Trim()))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (db.Service.Any(f => f.svc_Nom == input.ToUpper() && f.svc_Status == true))
                    {
                        iTools.iMessage.warningMsg("Attention", "Ce service est existe déjà");
                        return;
                    }
                    else
                    {
                        db.Insert_Service(input.Trim().ToUpper(), "", DateTime.Now);
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iTools.iMessage.sucMsg("Information", "Votre service a bien ajouté");
                        cmbxService.DataSource = db.Select_Service();
                        cmbxService.Text = input.ToUpper();
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

        private void btnProfil_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Veuillez entrer un profil", "Ajout", null, Location.X + 20, Location.Y + 30);
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(input.Trim()))
                    {
                        MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (db.Profil.Any(f => f.prof_Nom == input.ToUpper() && f.prof_Status == true))
                    {
                        iTools.iMessage.warningMsg("Attention", "Ce profil est existe déjà");
                        return;
                    }
                    else
                    {
                        db.Insert_Profil(input.Trim().ToUpper(), "");
                        db.SaveChanges();
                        transaction.Commit();
                        //form.txtStatus.Caption = "Votre code a bien ajouté";
                        iTools.iMessage.sucMsg("Information", "Votre profil a bien ajouté");
                        cmbxProfil.DataSource = db.Select_Profil();
                        cmbxProfil.Text = input.ToUpper();
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
}