namespace g_Stock.PL
{
    partial class frmArticleInfo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMAjouter = new System.Windows.Forms.Button();
            this.btnFamAjouter = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxFamille = new System.Windows.Forms.ComboBox();
            this.cmbxUnite = new System.Windows.Forms.ComboBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteImages = new System.Windows.Forms.Button();
            this.btnViewImages = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateImages = new System.Windows.Forms.Button();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ofdImages = new System.Windows.Forms.OpenFileDialog();
            this.txtAbreviation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAbreviation);
            this.groupBox2.Controls.Add(this.btnMAjouter);
            this.groupBox2.Controls.Add(this.btnFamAjouter);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbxFamille);
            this.groupBox2.Controls.Add(this.cmbxUnite);
            this.groupBox2.Controls.Add(this.txtDesignation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 345);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnMAjouter
            // 
            this.btnMAjouter.AutoSize = true;
            this.btnMAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMAjouter.FlatAppearance.BorderSize = 0;
            this.btnMAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAjouter.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAjouter.Image = global::g_Stock.Properties.Resources.Plus_24;
            this.btnMAjouter.Location = new System.Drawing.Point(463, 195);
            this.btnMAjouter.Name = "btnMAjouter";
            this.btnMAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnMAjouter.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnMAjouter, "Ajouter une Unité de mesure");
            this.btnMAjouter.UseVisualStyleBackColor = true;
            this.btnMAjouter.Click += new System.EventHandler(this.btnMAjouter_Click);
            // 
            // btnFamAjouter
            // 
            this.btnFamAjouter.AutoSize = true;
            this.btnFamAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamAjouter.FlatAppearance.BorderSize = 0;
            this.btnFamAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamAjouter.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamAjouter.Image = global::g_Stock.Properties.Resources.Plus_24;
            this.btnFamAjouter.Location = new System.Drawing.Point(463, 141);
            this.btnFamAjouter.Name = "btnFamAjouter";
            this.btnFamAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnFamAjouter.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnFamAjouter, "Ajouter une famille");
            this.btnFamAjouter.UseVisualStyleBackColor = true;
            this.btnFamAjouter.Click += new System.EventHandler(this.btnFamAjouter_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(191, 250);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(266, 70);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // cmbxFamille
            // 
            this.cmbxFamille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxFamille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxFamille.DisplayMember = "fam_Nom";
            this.cmbxFamille.FormattingEnabled = true;
            this.cmbxFamille.Location = new System.Drawing.Point(191, 142);
            this.cmbxFamille.Name = "cmbxFamille";
            this.cmbxFamille.Size = new System.Drawing.Size(266, 29);
            this.cmbxFamille.TabIndex = 2;
            this.cmbxFamille.ValueMember = "fam_ID";
            // 
            // cmbxUnite
            // 
            this.cmbxUnite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxUnite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxUnite.DisplayMember = "unit_M_Abreviation";
            this.cmbxUnite.FormattingEnabled = true;
            this.cmbxUnite.Location = new System.Drawing.Point(191, 196);
            this.cmbxUnite.Name = "cmbxUnite";
            this.cmbxUnite.Size = new System.Drawing.Size(266, 29);
            this.cmbxUnite.TabIndex = 3;
            this.cmbxUnite.ValueMember = "unit_M_ID";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(191, 36);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(266, 28);
            this.txtDesignation.TabIndex = 0;
            this.txtDesignation.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesignation_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unité de mesure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Famille";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Désignation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteImages);
            this.groupBox3.Controls.Add(this.btnViewImages);
            this.groupBox3.Controls.Add(this.btnDeleteItem);
            this.groupBox3.Controls.Add(this.btnUpdateImages);
            this.groupBox3.Controls.Add(this.btnParcourir);
            this.groupBox3.Controls.Add(this.lbImages);
            this.groupBox3.Location = new System.Drawing.Point(566, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 345);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pièces jointes";
            // 
            // btnDeleteImages
            // 
            this.btnDeleteImages.AutoSize = true;
            this.btnDeleteImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteImages.FlatAppearance.BorderSize = 0;
            this.btnDeleteImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImages.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImages.Image = global::g_Stock.Properties.Resources.Supprimer_image_24;
            this.btnDeleteImages.Location = new System.Drawing.Point(124, 302);
            this.btnDeleteImages.Name = "btnDeleteImages";
            this.btnDeleteImages.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteImages.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnDeleteImages, "Supprimer image depuis la base de données");
            this.btnDeleteImages.UseVisualStyleBackColor = true;
            this.btnDeleteImages.Click += new System.EventHandler(this.btnDeleteImages_Click);
            // 
            // btnViewImages
            // 
            this.btnViewImages.AutoSize = true;
            this.btnViewImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewImages.FlatAppearance.BorderSize = 0;
            this.btnViewImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewImages.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewImages.Image = global::g_Stock.Properties.Resources.Projecteur_film_24;
            this.btnViewImages.Location = new System.Drawing.Point(204, 213);
            this.btnViewImages.Name = "btnViewImages";
            this.btnViewImages.Size = new System.Drawing.Size(30, 30);
            this.btnViewImages.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnViewImages, "Visionner les images");
            this.btnViewImages.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AutoSize = true;
            this.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Image = global::g_Stock.Properties.Resources.Moins_24;
            this.btnDeleteItem.Location = new System.Drawing.Point(204, 157);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteItem.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDeleteItem, "Supprimer les images depuis la liste");
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdateImages
            // 
            this.btnUpdateImages.AutoSize = true;
            this.btnUpdateImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateImages.FlatAppearance.BorderSize = 0;
            this.btnUpdateImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateImages.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateImages.Image = global::g_Stock.Properties.Resources.Synchroniser_24;
            this.btnUpdateImages.Location = new System.Drawing.Point(66, 302);
            this.btnUpdateImages.Name = "btnUpdateImages";
            this.btnUpdateImages.Size = new System.Drawing.Size(30, 30);
            this.btnUpdateImages.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnUpdateImages, "Modifier les images depuis la base de données");
            this.btnUpdateImages.UseVisualStyleBackColor = true;
            this.btnUpdateImages.Click += new System.EventHandler(this.btnUpdateImages_Click);
            // 
            // btnParcourir
            // 
            this.btnParcourir.AutoSize = true;
            this.btnParcourir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParcourir.FlatAppearance.BorderSize = 0;
            this.btnParcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcourir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcourir.Image = global::g_Stock.Properties.Resources.Dossier_images_24;
            this.btnParcourir.Location = new System.Drawing.Point(206, 101);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(30, 30);
            this.btnParcourir.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnParcourir, "Chosir des images");
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // lbImages
            // 
            this.lbImages.FormattingEnabled = true;
            this.lbImages.ItemHeight = 21;
            this.lbImages.Location = new System.Drawing.Point(18, 40);
            this.lbImages.Name = "lbImages";
            this.lbImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbImages.Size = new System.Drawing.Size(180, 256);
            this.lbImages.TabIndex = 0;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
            // 
            // ofdImages
            // 
            this.ofdImages.Multiselect = true;
            // 
            // txtAbreviation
            // 
            this.txtAbreviation.Location = new System.Drawing.Point(191, 89);
            this.txtAbreviation.MaxLength = 10;
            this.txtAbreviation.Name = "txtAbreviation";
            this.txtAbreviation.Size = new System.Drawing.Size(266, 28);
            this.txtAbreviation.TabIndex = 1;
            this.txtAbreviation.Validating += new System.ComponentModel.CancelEventHandler(this.txtAbreviation_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Abréviation";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmArticleInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmArticleInfo";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.frmArticleInfo_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbImages;
        private System.Windows.Forms.ComboBox cmbxFamille;
        private System.Windows.Forms.ComboBox cmbxUnite;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMAjouter;
        private System.Windows.Forms.Button btnFamAjouter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateImages;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Button btnDeleteImages;
        private System.Windows.Forms.Button btnViewImages;
        private System.Windows.Forms.OpenFileDialog ofdImages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAbreviation;
        private System.Windows.Forms.ErrorProvider epError;
    }
}