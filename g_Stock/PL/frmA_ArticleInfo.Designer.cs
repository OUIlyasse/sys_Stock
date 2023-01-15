namespace g_Stock.PL
{
    partial class frmA_ArticleInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAu = new System.Windows.Forms.Label();
            this.lblDu = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cmbxMode = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcArticle = new DevExpress.XtraGrid.GridControl();
            this.gvArticle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPass = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // lblAu
            // 
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(198, 49);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(29, 21);
            this.lblAu.TabIndex = 14;
            this.lblAu.Text = "Au";
            this.lblAu.Visible = false;
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
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(233, 45);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(126, 28);
            this.dtp2.TabIndex = 12;
            this.dtp2.Visible = false;
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
            this.cmbxMode.Location = new System.Drawing.Point(375, 45);
            this.cmbxMode.Name = "cmbxMode";
            this.cmbxMode.Size = new System.Drawing.Size(158, 29);
            this.cmbxMode.TabIndex = 9;
            this.cmbxMode.Text = "Identifiant";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(353, 28);
            this.txtSearch.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcArticle);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 328);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // lblLigne
            // 
            this.lblLigne.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // gcArticle
            // 
            this.gcArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcArticle.Location = new System.Drawing.Point(6, 41);
            this.gcArticle.MainView = this.gvArticle;
            this.gcArticle.Name = "gcArticle";
            this.gcArticle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPass,
            this.dtDate});
            this.gcArticle.Size = new System.Drawing.Size(796, 281);
            this.gcArticle.TabIndex = 0;
            this.gcArticle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticle});
            // 
            // gvArticle
            // 
            this.gvArticle.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvArticle.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvArticle.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvArticle.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.DetailTip.Options.UseFont = true;
            this.gvArticle.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.Empty.Options.UseFont = true;
            this.gvArticle.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.EvenRow.Options.UseFont = true;
            this.gvArticle.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvArticle.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.FilterPanel.Options.UseFont = true;
            this.gvArticle.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.FixedLine.Options.UseFont = true;
            this.gvArticle.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.FocusedCell.Options.UseFont = true;
            this.gvArticle.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.FocusedRow.Options.UseFont = true;
            this.gvArticle.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.FooterPanel.Options.UseFont = true;
            this.gvArticle.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.GroupButton.Options.UseFont = true;
            this.gvArticle.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.GroupFooter.Options.UseFont = true;
            this.gvArticle.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvArticle.Appearance.GroupPanel.Options.UseFont = true;
            this.gvArticle.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.GroupRow.Options.UseFont = true;
            this.gvArticle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvArticle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvArticle.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvArticle.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.HorzLine.Options.UseFont = true;
            this.gvArticle.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.OddRow.Options.UseFont = true;
            this.gvArticle.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.Preview.Options.UseFont = true;
            this.gvArticle.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.Row.Options.UseFont = true;
            this.gvArticle.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.RowSeparator.Options.UseFont = true;
            this.gvArticle.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvArticle.Appearance.SelectedRow.Options.UseFont = true;
            this.gvArticle.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.TopNewRow.Options.UseFont = true;
            this.gvArticle.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.VertLine.Options.UseFont = true;
            this.gvArticle.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArticle.Appearance.ViewCaption.Options.UseFont = true;
            this.gvArticle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6});
            this.gvArticle.GridControl = this.gcArticle;
            this.gvArticle.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "fam_Nom", null, "(Total: {0})")});
            this.gvArticle.Name = "gvArticle";
            this.gvArticle.OptionsBehavior.Editable = false;
            this.gvArticle.OptionsFind.AlwaysVisible = true;
            this.gvArticle.OptionsFind.ShowClearButton = false;
            this.gvArticle.OptionsFind.ShowFindButton = false;
            this.gvArticle.OptionsView.ShowAutoFilterRow = true;
            this.gvArticle.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "art_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Désignation";
            this.gridColumn2.FieldName = "art_Designation";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Description";
            this.gridColumn3.ColumnEdit = this.dtDate;
            this.gridColumn3.FieldName = "art_Description";
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Famille";
            this.gridColumn5.FieldName = "fam_Nom";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Unité";
            this.gridColumn6.FieldName = "unit_M_Abreviation";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Appearance.Options.UseFont = true;
            this.txtPass.AutoHeight = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // frmA_ArticleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmA_ArticleInfo";
            this.Text = "Article";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmA_ArticleInfo_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cmbxMode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblLigne;
        public DevExpress.XtraGrid.GridControl gcArticle;
        public DevExpress.XtraGrid.Views.Grid.GridView gvArticle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPass;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}