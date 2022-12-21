namespace g_Stock.PL
{
    partial class frmA_Utilisateur
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.cmbxAfficher = new System.Windows.Forms.CheckBox();
            this.cmbxProfil = new System.Windows.Forms.ComboBox();
            this.cmbxService = new System.Windows.Forms.ComboBox();
            this.txtRepeter = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnProfil);
            this.groupBox3.Controls.Add(this.btnService);
            this.groupBox3.Controls.Add(this.cmbxAfficher);
            this.groupBox3.Controls.Add(this.cmbxProfil);
            this.groupBox3.Controls.Add(this.cmbxService);
            this.groupBox3.Controls.Add(this.txtRepeter);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Controls.Add(this.txtIdentifiant);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNom);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(808, 345);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnProfil
            // 
            this.btnProfil.AutoSize = true;
            this.btnProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Image = global::g_Stock.Properties.Resources.Plus_30;
            this.btnProfil.Location = new System.Drawing.Point(766, 246);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(36, 36);
            this.btnProfil.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnProfil, "Ajouter un profil");
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnService
            // 
            this.btnService.AutoSize = true;
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Image = global::g_Stock.Properties.Resources.Plus_30;
            this.btnService.Location = new System.Drawing.Point(766, 154);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(36, 36);
            this.btnService.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnService, "Ajouter un service");
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // cmbxAfficher
            // 
            this.cmbxAfficher.AutoSize = true;
            this.cmbxAfficher.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAfficher.Location = new System.Drawing.Point(231, 192);
            this.cmbxAfficher.Name = "cmbxAfficher";
            this.cmbxAfficher.Size = new System.Drawing.Size(86, 25);
            this.cmbxAfficher.TabIndex = 6;
            this.cmbxAfficher.Text = "Afficher";
            this.cmbxAfficher.UseVisualStyleBackColor = true;
            this.cmbxAfficher.CheckedChanged += new System.EventHandler(this.cmbxAfficher_CheckedChanged);
            // 
            // cmbxProfil
            // 
            this.cmbxProfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxProfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxProfil.DisplayMember = "prof_Nom";
            this.cmbxProfil.FormattingEnabled = true;
            this.cmbxProfil.Location = new System.Drawing.Point(564, 250);
            this.cmbxProfil.Name = "cmbxProfil";
            this.cmbxProfil.Size = new System.Drawing.Size(199, 29);
            this.cmbxProfil.TabIndex = 5;
            this.cmbxProfil.Text = "--------------";
            this.cmbxProfil.ValueMember = "prof_ID";
            // 
            // cmbxService
            // 
            this.cmbxService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxService.DisplayMember = "svc_Nom";
            this.cmbxService.FormattingEnabled = true;
            this.cmbxService.Location = new System.Drawing.Point(564, 158);
            this.cmbxService.Name = "cmbxService";
            this.cmbxService.Size = new System.Drawing.Size(199, 29);
            this.cmbxService.TabIndex = 4;
            this.cmbxService.Text = "---------";
            this.cmbxService.ValueMember = "svc_ID";
            // 
            // txtRepeter
            // 
            this.txtRepeter.Location = new System.Drawing.Point(220, 250);
            this.txtRepeter.Name = "txtRepeter";
            this.txtRepeter.Size = new System.Drawing.Size(220, 28);
            this.txtRepeter.TabIndex = 3;
            this.txtRepeter.UseSystemPasswordChar = true;
            this.txtRepeter.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepeter_Validating);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(220, 158);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 28);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(564, 66);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(220, 28);
            this.txtIdentifiant.TabIndex = 1;
            this.txtIdentifiant.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdentifiant_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Profil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repeter le Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identifiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(220, 66);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(220, 28);
            this.txtNom.TabIndex = 0;
            // 
            // frmA_Utilisateur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmA_Utilisateur";
            this.Load += new System.EventHandler(this.frmA_Utilisateur_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbxProfil;
        private System.Windows.Forms.ComboBox cmbxService;
        private System.Windows.Forms.TextBox txtRepeter;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.CheckBox cmbxAfficher;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}