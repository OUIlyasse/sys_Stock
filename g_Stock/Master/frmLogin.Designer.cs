namespace g_Stock.Master
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbxService = new System.Windows.Forms.ComboBox();
            this.ckbRemember = new System.Windows.Forms.CheckBox();
            this.lnkForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cmbxProfil = new System.Windows.Forms.ComboBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Se connecter";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(53, 260);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(356, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Identifiant";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(53, 320);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(356, 28);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Mot de passe";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // cmbxService
            // 
            this.cmbxService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxService.DisplayMember = "svc_Nom";
            this.cmbxService.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbxService.FormattingEnabled = true;
            this.cmbxService.Location = new System.Drawing.Point(240, 380);
            this.cmbxService.Name = "cmbxService";
            this.cmbxService.Size = new System.Drawing.Size(169, 29);
            this.cmbxService.TabIndex = 2;
            this.cmbxService.Text = "Service";
            this.cmbxService.ValueMember = "svc_ID";
            this.cmbxService.Enter += new System.EventHandler(this.cmbxService_Enter);
            this.cmbxService.Leave += new System.EventHandler(this.cmbxService_Leave);
            // 
            // ckbRemember
            // 
            this.ckbRemember.AutoSize = true;
            this.ckbRemember.Location = new System.Drawing.Point(53, 447);
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.Size = new System.Drawing.Size(139, 25);
            this.ckbRemember.TabIndex = 3;
            this.ckbRemember.Text = "Me reconnaître";
            this.ckbRemember.UseVisualStyleBackColor = true;
            // 
            // lnkForgotPass
            // 
            this.lnkForgotPass.AutoSize = true;
            this.lnkForgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkForgotPass.Location = new System.Drawing.Point(250, 449);
            this.lnkForgotPass.Name = "lnkForgotPass";
            this.lnkForgotPass.Size = new System.Drawing.Size(159, 21);
            this.lnkForgotPass.TabIndex = 4;
            this.lnkForgotPass.TabStop = true;
            this.lnkForgotPass.Text = "Mot de passe oublié?";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(95, 524);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbxProfil
            // 
            this.cmbxProfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxProfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxProfil.DisplayMember = "prof_Nom";
            this.cmbxProfil.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbxProfil.FormattingEnabled = true;
            this.cmbxProfil.Location = new System.Drawing.Point(53, 380);
            this.cmbxProfil.Name = "cmbxProfil";
            this.cmbxProfil.Size = new System.Drawing.Size(169, 29);
            this.cmbxProfil.TabIndex = 6;
            this.cmbxProfil.Text = "Profil";
            this.cmbxProfil.ValueMember = "prof_ID";
            this.cmbxProfil.Enter += new System.EventHandler(this.cmbxProfil_Enter);
            this.cmbxProfil.Leave += new System.EventHandler(this.cmbxProfil_Leave);
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::g_Stock.Properties.Resources.Fermer_fenêtre_24;
            this.picExit.Location = new System.Drawing.Point(426, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(24, 24);
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 590);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.cmbxProfil);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnkForgotPass);
            this.Controls.Add(this.ckbRemember);
            this.Controls.Add(this.cmbxService);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Se connecter";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbxService;
        private System.Windows.Forms.CheckBox ckbRemember;
        private System.Windows.Forms.LinkLabel lnkForgotPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbxProfil;
        private System.Windows.Forms.PictureBox picExit;
    }
}