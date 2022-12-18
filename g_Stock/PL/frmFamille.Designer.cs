namespace g_Stock.PL
{
    partial class frmFamille
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
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcFamille = new DevExpress.XtraGrid.GridControl();
            this.gvFamille = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamille)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcFamille);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(416, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 345);
            this.groupBox2.TabIndex = 1;
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
            // gcFamille
            // 
            this.gcFamille.Location = new System.Drawing.Point(6, 41);
            this.gcFamille.MainView = this.gvFamille;
            this.gcFamille.Name = "gcFamille";
            this.gcFamille.Size = new System.Drawing.Size(392, 295);
            this.gcFamille.TabIndex = 0;
            this.gcFamille.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFamille});
            // 
            // gvFamille
            // 
            this.gvFamille.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvFamille.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvFamille.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvFamille.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.DetailTip.Options.UseFont = true;
            this.gvFamille.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.Empty.Options.UseFont = true;
            this.gvFamille.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.EvenRow.Options.UseFont = true;
            this.gvFamille.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvFamille.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.FilterPanel.Options.UseFont = true;
            this.gvFamille.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.FixedLine.Options.UseFont = true;
            this.gvFamille.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.FocusedCell.Options.UseFont = true;
            this.gvFamille.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.FocusedRow.Options.UseFont = true;
            this.gvFamille.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.FooterPanel.Options.UseFont = true;
            this.gvFamille.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.GroupButton.Options.UseFont = true;
            this.gvFamille.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.GroupFooter.Options.UseFont = true;
            this.gvFamille.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFamille.Appearance.GroupPanel.Options.UseFont = true;
            this.gvFamille.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.GroupRow.Options.UseFont = true;
            this.gvFamille.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFamille.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvFamille.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvFamille.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.HorzLine.Options.UseFont = true;
            this.gvFamille.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.OddRow.Options.UseFont = true;
            this.gvFamille.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.Preview.Options.UseFont = true;
            this.gvFamille.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.Row.Options.UseFont = true;
            this.gvFamille.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.RowSeparator.Options.UseFont = true;
            this.gvFamille.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFamille.Appearance.SelectedRow.Options.UseFont = true;
            this.gvFamille.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.TopNewRow.Options.UseFont = true;
            this.gvFamille.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.VertLine.Options.UseFont = true;
            this.gvFamille.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvFamille.Appearance.ViewCaption.Options.UseFont = true;
            this.gvFamille.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvFamille.GridControl = this.gcFamille;
            this.gvFamille.Name = "gvFamille";
            this.gvFamille.OptionsBehavior.Editable = false;
            this.gvFamille.OptionsFind.AlwaysVisible = true;
            this.gvFamille.OptionsFind.ShowClearButton = false;
            this.gvFamille.OptionsFind.ShowFindButton = false;
            this.gvFamille.OptionsView.ShowAutoFilterRow = true;
            this.gvFamille.OptionsView.ShowGroupPanel = false;
            this.gvFamille.OptionsView.ShowIndicator = false;
            this.gvFamille.DoubleClick += new System.EventHandler(this.gvFamille_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "fam_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Famille";
            this.gridColumn2.FieldName = "fam_Nom";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Description";
            this.gridColumn3.FieldName = "fam_Descripction";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFamille);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 345);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 157);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(239, 90);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Famille";
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(116, 96);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(239, 28);
            this.txtFamille.TabIndex = 0;
            this.txtFamille.Validating += new System.ComponentModel.CancelEventHandler(this.txtFamille_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFamille
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFamille";
            this.Text = "Famille";
            this.Load += new System.EventHandler(this.frmFamille_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamille)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamille;
        private DevExpress.XtraGrid.GridControl gcFamille;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFamille;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label lblLigne;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}