namespace g_Stock.PL
{
    partial class frmProfil
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfil = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcProfil = new DevExpress.XtraGrid.GridControl();
            this.gvProfil = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtProfil);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 345);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(119, 158);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(244, 90);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profil";
            // 
            // txtProfil
            // 
            this.txtProfil.Location = new System.Drawing.Point(119, 97);
            this.txtProfil.Name = "txtProfil";
            this.txtProfil.Size = new System.Drawing.Size(244, 28);
            this.txtProfil.TabIndex = 0;
            this.txtProfil.Validating += new System.ComponentModel.CancelEventHandler(this.Profil_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcProfil);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 345);
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
            this.lblLigne.Location = new System.Drawing.Point(178, 24);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLigne.Size = new System.Drawing.Size(47, 14);
            this.lblLigne.TabIndex = 2;
            this.lblLigne.Text = "ligne";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gcProfil
            // 
            this.gcProfil.Location = new System.Drawing.Point(6, 41);
            this.gcProfil.MainView = this.gvProfil;
            this.gcProfil.Name = "gcProfil";
            this.gcProfil.Size = new System.Drawing.Size(392, 295);
            this.gcProfil.TabIndex = 0;
            this.gcProfil.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProfil});
            // 
            // gvProfil
            // 
            this.gvProfil.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvProfil.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvProfil.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvProfil.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.DetailTip.Options.UseFont = true;
            this.gvProfil.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.Empty.Options.UseFont = true;
            this.gvProfil.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.EvenRow.Options.UseFont = true;
            this.gvProfil.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvProfil.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.FilterPanel.Options.UseFont = true;
            this.gvProfil.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.FixedLine.Options.UseFont = true;
            this.gvProfil.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.FocusedCell.Options.UseFont = true;
            this.gvProfil.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.FocusedRow.Options.UseFont = true;
            this.gvProfil.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.FooterPanel.Options.UseFont = true;
            this.gvProfil.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.GroupButton.Options.UseFont = true;
            this.gvProfil.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.GroupFooter.Options.UseFont = true;
            this.gvProfil.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProfil.Appearance.GroupPanel.Options.UseFont = true;
            this.gvProfil.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.GroupRow.Options.UseFont = true;
            this.gvProfil.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProfil.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProfil.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvProfil.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.HorzLine.Options.UseFont = true;
            this.gvProfil.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.OddRow.Options.UseFont = true;
            this.gvProfil.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.Preview.Options.UseFont = true;
            this.gvProfil.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.Row.Options.UseFont = true;
            this.gvProfil.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.RowSeparator.Options.UseFont = true;
            this.gvProfil.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProfil.Appearance.SelectedRow.Options.UseFont = true;
            this.gvProfil.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.TopNewRow.Options.UseFont = true;
            this.gvProfil.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.VertLine.Options.UseFont = true;
            this.gvProfil.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvProfil.Appearance.ViewCaption.Options.UseFont = true;
            this.gvProfil.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvProfil.GridControl = this.gcProfil;
            this.gvProfil.Name = "gvProfil";
            this.gvProfil.OptionsBehavior.Editable = false;
            this.gvProfil.OptionsFind.AlwaysVisible = true;
            this.gvProfil.OptionsFind.ShowClearButton = false;
            this.gvProfil.OptionsFind.ShowFindButton = false;
            this.gvProfil.OptionsView.ShowAutoFilterRow = true;
            this.gvProfil.OptionsView.ShowGroupPanel = false;
            this.gvProfil.OptionsView.ShowIndicator = false;
            this.gvProfil.DoubleClick += new System.EventHandler(this.gvProfil_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "prof_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Profil";
            this.gridColumn2.FieldName = "prof_Nom";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Description";
            this.gridColumn3.FieldName = "prof_Description";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmProfil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLigne;
        private DevExpress.XtraGrid.GridControl gcProfil;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProfil;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}