namespace g_Stock.PL
{
    partial class frmUtilisateur
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcUtilisateur = new DevExpress.XtraGrid.GridControl();
            this.gvUtilisateur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPass = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxMode = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lblDu = new System.Windows.Forms.Label();
            this.lblAu = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcUtilisateur);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 328);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // lblLigne
            // 
            this.lblLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLigne.Location = new System.Drawing.Point(381, 19);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLigne.Size = new System.Drawing.Size(47, 14);
            this.lblLigne.TabIndex = 2;
            this.lblLigne.Text = "ligne";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gcUtilisateur
            // 
            this.gcUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUtilisateur.Location = new System.Drawing.Point(6, 41);
            this.gcUtilisateur.MainView = this.gvUtilisateur;
            this.gcUtilisateur.Name = "gcUtilisateur";
            this.gcUtilisateur.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPass,
            this.dtDate});
            this.gcUtilisateur.Size = new System.Drawing.Size(796, 281);
            this.gcUtilisateur.TabIndex = 0;
            this.gcUtilisateur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUtilisateur});
            // 
            // gvUtilisateur
            // 
            this.gvUtilisateur.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvUtilisateur.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvUtilisateur.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvUtilisateur.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.DetailTip.Options.UseFont = true;
            this.gvUtilisateur.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.Empty.Options.UseFont = true;
            this.gvUtilisateur.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.EvenRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvUtilisateur.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.FilterPanel.Options.UseFont = true;
            this.gvUtilisateur.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.FixedLine.Options.UseFont = true;
            this.gvUtilisateur.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.FocusedCell.Options.UseFont = true;
            this.gvUtilisateur.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.FocusedRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.FooterPanel.Options.UseFont = true;
            this.gvUtilisateur.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.GroupButton.Options.UseFont = true;
            this.gvUtilisateur.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.GroupFooter.Options.UseFont = true;
            this.gvUtilisateur.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUtilisateur.Appearance.GroupPanel.Options.UseFont = true;
            this.gvUtilisateur.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.GroupRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUtilisateur.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUtilisateur.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.HorzLine.Options.UseFont = true;
            this.gvUtilisateur.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.OddRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.Preview.Options.UseFont = true;
            this.gvUtilisateur.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.Row.Options.UseFont = true;
            this.gvUtilisateur.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.RowSeparator.Options.UseFont = true;
            this.gvUtilisateur.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUtilisateur.Appearance.SelectedRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.TopNewRow.Options.UseFont = true;
            this.gvUtilisateur.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.VertLine.Options.UseFont = true;
            this.gvUtilisateur.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvUtilisateur.Appearance.ViewCaption.Options.UseFont = true;
            this.gvUtilisateur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvUtilisateur.GridControl = this.gcUtilisateur;
            this.gvUtilisateur.Name = "gvUtilisateur";
            this.gvUtilisateur.OptionsBehavior.Editable = false;
            this.gvUtilisateur.OptionsFind.AlwaysVisible = true;
            this.gvUtilisateur.OptionsFind.ShowClearButton = false;
            this.gvUtilisateur.OptionsFind.ShowFindButton = false;
            this.gvUtilisateur.OptionsView.ShowAutoFilterRow = true;
            this.gvUtilisateur.OptionsView.ShowGroupPanel = false;
            this.gvUtilisateur.OptionsView.ShowIndicator = false;
            this.gvUtilisateur.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvUtilisateur_RowClick);
            this.gvUtilisateur.DoubleClick += new System.EventHandler(this.gvUtilisateur_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "util_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nom";
            this.gridColumn2.FieldName = "util_Nom";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Date création";
            this.gridColumn3.ColumnEdit = this.dtDate;
            this.gridColumn3.FieldName = "util_Date";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // dtDate
            // 
            this.dtDate.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtDate.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Appearance.Options.UseFont = true;
            this.dtDate.AutoHeight = false;
            this.dtDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.CalendarDateEditing = false;
            this.dtDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Mask.EditMask = "dd/MM/yyyy";
            this.dtDate.Name = "dtDate";
            this.dtDate.ReadOnly = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Identifiant";
            this.gridColumn4.FieldName = "util_Identifiant";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mot de passe";
            this.gridColumn5.ColumnEdit = this.txtPass;
            this.gridColumn5.FieldName = "util_MotPasse";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Appearance.Options.UseFont = true;
            this.txtPass.AutoHeight = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Service";
            this.gridColumn6.FieldName = "svc_Nom";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Profil";
            this.gridColumn7.FieldName = "prof_Nom";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(331, 28);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAu);
            this.groupBox1.Controls.Add(this.lblDu);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.cmbxMode);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // cmbxMode
            // 
            this.cmbxMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxMode.FormattingEnabled = true;
            this.cmbxMode.Items.AddRange(new object[] {
            "Nom",
            "Identifiant",
            "Date",
            "Service",
            "Profil"});
            this.cmbxMode.Location = new System.Drawing.Point(366, 45);
            this.cmbxMode.Name = "cmbxMode";
            this.cmbxMode.Size = new System.Drawing.Size(167, 29);
            this.cmbxMode.TabIndex = 9;
            this.cmbxMode.Text = "Identifiant";
            this.cmbxMode.SelectedIndexChanged += new System.EventHandler(this.cmbxMode_SelectedIndexChanged);
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(42, 45);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(126, 28);
            this.dtp1.TabIndex = 11;
            this.dtp1.Visible = false;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(224, 45);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(126, 28);
            this.dtp2.TabIndex = 12;
            this.dtp2.Visible = false;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // lblDu
            // 
            this.lblDu.AutoSize = true;
            this.lblDu.Location = new System.Drawing.Point(6, 49);
            this.lblDu.Name = "lblDu";
            this.lblDu.Size = new System.Drawing.Size(30, 21);
            this.lblDu.TabIndex = 13;
            this.lblDu.Text = "Du";
            this.lblDu.Visible = false;
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(189, 49);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(29, 21);
            this.lblAu.TabIndex = 14;
            this.lblAu.Text = "Au";
            this.lblAu.Visible = false;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmUtilisateur";
            this.Text = "Utilisateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtDate;
        public DevExpress.XtraGrid.GridControl gcUtilisateur;
        public System.Windows.Forms.Label lblLigne;
        public DevExpress.XtraGrid.Views.Grid.GridView gvUtilisateur;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxMode;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}