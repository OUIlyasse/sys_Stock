namespace g_Stock.PL
{
    partial class frmService
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
            this.txtService = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcService = new DevExpress.XtraGrid.GridControl();
            this.gvService = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtService);
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
            this.label1.Text = "Service";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(116, 96);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(239, 28);
            this.txtService.TabIndex = 0;
            this.txtService.Validating += new System.ComponentModel.CancelEventHandler(this.txtService_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcService);
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
            // gcService
            // 
            this.gcService.Location = new System.Drawing.Point(6, 41);
            this.gcService.MainView = this.gvService;
            this.gcService.Name = "gcService";
            this.gcService.Size = new System.Drawing.Size(392, 295);
            this.gcService.TabIndex = 0;
            this.gcService.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvService});
            // 
            // gvService
            // 
            this.gvService.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvService.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvService.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvService.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.DetailTip.Options.UseFont = true;
            this.gvService.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.Empty.Options.UseFont = true;
            this.gvService.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.EvenRow.Options.UseFont = true;
            this.gvService.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvService.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.FilterPanel.Options.UseFont = true;
            this.gvService.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.FixedLine.Options.UseFont = true;
            this.gvService.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.FocusedCell.Options.UseFont = true;
            this.gvService.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.FocusedRow.Options.UseFont = true;
            this.gvService.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.FooterPanel.Options.UseFont = true;
            this.gvService.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.GroupButton.Options.UseFont = true;
            this.gvService.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.GroupFooter.Options.UseFont = true;
            this.gvService.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvService.Appearance.GroupPanel.Options.UseFont = true;
            this.gvService.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.GroupRow.Options.UseFont = true;
            this.gvService.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvService.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvService.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvService.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.HorzLine.Options.UseFont = true;
            this.gvService.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.OddRow.Options.UseFont = true;
            this.gvService.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.Preview.Options.UseFont = true;
            this.gvService.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.Row.Options.UseFont = true;
            this.gvService.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.RowSeparator.Options.UseFont = true;
            this.gvService.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvService.Appearance.SelectedRow.Options.UseFont = true;
            this.gvService.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.TopNewRow.Options.UseFont = true;
            this.gvService.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.VertLine.Options.UseFont = true;
            this.gvService.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvService.Appearance.ViewCaption.Options.UseFont = true;
            this.gvService.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvService.GridControl = this.gcService;
            this.gvService.Name = "gvService";
            this.gvService.OptionsBehavior.Editable = false;
            this.gvService.OptionsFind.AlwaysVisible = true;
            this.gvService.OptionsFind.ShowClearButton = false;
            this.gvService.OptionsFind.ShowFindButton = false;
            this.gvService.OptionsView.ShowAutoFilterRow = true;
            this.gvService.OptionsView.ShowGroupPanel = false;
            this.gvService.OptionsView.ShowIndicator = false;
            this.gvService.DoubleClick += new System.EventHandler(this.gvService_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "svc_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Service";
            this.gridColumn2.FieldName = "svc_Nom";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Description";
            this.gridColumn3.FieldName = "svc_description";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Date création";
            this.gridColumn4.FieldName = "svc_Date";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLigne;
        private DevExpress.XtraGrid.GridControl gcService;
        private DevExpress.XtraGrid.Views.Grid.GridView gvService;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}