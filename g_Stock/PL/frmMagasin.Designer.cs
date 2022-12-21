namespace g_Stock.PL
{
    partial class frmMagasin
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMagasin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcMagasin = new DevExpress.XtraGrid.GridControl();
            this.gvMagasin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMagasin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMagasin)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtVille);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMagasin);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 345);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(116, 127);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(239, 28);
            this.txtVille.TabIndex = 1;
            this.txtVille.Text = "Agadir";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 184);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(239, 90);
            this.txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Magasin";
            // 
            // txtMagasin
            // 
            this.txtMagasin.Location = new System.Drawing.Point(116, 70);
            this.txtMagasin.Name = "txtMagasin";
            this.txtMagasin.Size = new System.Drawing.Size(239, 28);
            this.txtMagasin.TabIndex = 0;
            this.txtMagasin.Validating += new System.ComponentModel.CancelEventHandler(this.txtMagasin_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcMagasin);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(416, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 345);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichage";
            // 
            // lblLigne
            // 
            this.lblLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLigne.Location = new System.Drawing.Point(179, 24);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLigne.Size = new System.Drawing.Size(47, 14);
            this.lblLigne.TabIndex = 2;
            this.lblLigne.Text = "ligne";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gcMagasin
            // 
            this.gcMagasin.Location = new System.Drawing.Point(6, 41);
            this.gcMagasin.MainView = this.gvMagasin;
            this.gcMagasin.Name = "gcMagasin";
            this.gcMagasin.Size = new System.Drawing.Size(392, 295);
            this.gcMagasin.TabIndex = 0;
            this.gcMagasin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMagasin});
            // 
            // gvMagasin
            // 
            this.gvMagasin.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvMagasin.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvMagasin.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvMagasin.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.DetailTip.Options.UseFont = true;
            this.gvMagasin.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.Empty.Options.UseFont = true;
            this.gvMagasin.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.EvenRow.Options.UseFont = true;
            this.gvMagasin.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvMagasin.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.FilterPanel.Options.UseFont = true;
            this.gvMagasin.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.FixedLine.Options.UseFont = true;
            this.gvMagasin.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.FocusedCell.Options.UseFont = true;
            this.gvMagasin.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMagasin.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.FooterPanel.Options.UseFont = true;
            this.gvMagasin.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.GroupButton.Options.UseFont = true;
            this.gvMagasin.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.GroupFooter.Options.UseFont = true;
            this.gvMagasin.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMagasin.Appearance.GroupPanel.Options.UseFont = true;
            this.gvMagasin.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.GroupRow.Options.UseFont = true;
            this.gvMagasin.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMagasin.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMagasin.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvMagasin.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.HorzLine.Options.UseFont = true;
            this.gvMagasin.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.OddRow.Options.UseFont = true;
            this.gvMagasin.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.Preview.Options.UseFont = true;
            this.gvMagasin.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.Row.Options.UseFont = true;
            this.gvMagasin.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.RowSeparator.Options.UseFont = true;
            this.gvMagasin.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMagasin.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMagasin.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.TopNewRow.Options.UseFont = true;
            this.gvMagasin.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.VertLine.Options.UseFont = true;
            this.gvMagasin.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvMagasin.Appearance.ViewCaption.Options.UseFont = true;
            this.gvMagasin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3});
            this.gvMagasin.GridControl = this.gcMagasin;
            this.gvMagasin.Name = "gvMagasin";
            this.gvMagasin.OptionsBehavior.Editable = false;
            this.gvMagasin.OptionsFind.AlwaysVisible = true;
            this.gvMagasin.OptionsFind.ShowClearButton = false;
            this.gvMagasin.OptionsFind.ShowFindButton = false;
            this.gvMagasin.OptionsView.ShowAutoFilterRow = true;
            this.gvMagasin.OptionsView.ShowGroupPanel = false;
            this.gvMagasin.OptionsView.ShowIndicator = false;
            this.gvMagasin.DoubleClick += new System.EventHandler(this.gvMagasin_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "mags_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Magasin";
            this.gridColumn2.FieldName = "mags_Magasin";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ville";
            this.gridColumn4.FieldName = "mags_Ville";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Description";
            this.gridColumn3.FieldName = "mags_Description";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // frmMagasin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMagasin";
            this.Text = "Magasin";
            this.Load += new System.EventHandler(this.frmMagasin_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMagasin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMagasin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMagasin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLigne;
        private DevExpress.XtraGrid.GridControl gcMagasin;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMagasin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVille;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}