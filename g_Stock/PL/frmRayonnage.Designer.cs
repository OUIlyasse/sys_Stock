namespace g_Stock.PL
{
    partial class frmRayonnage
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnArmSupprimer = new System.Windows.Forms.Button();
            this.gcArmoire = new DevExpress.XtraGrid.GridControl();
            this.gvArmoire = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnArmAjouter = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRayonnage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.gcRayonnage = new DevExpress.XtraGrid.GridControl();
            this.gvRayonnage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArmoire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArmoire)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRayonnage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRayonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtRayonnage);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 345);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnArmSupprimer);
            this.groupBox4.Controls.Add(this.gcArmoire);
            this.groupBox4.Controls.Add(this.btnArmAjouter);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 203);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Armoire";
            // 
            // btnArmSupprimer
            // 
            this.btnArmSupprimer.AutoSize = true;
            this.btnArmSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArmSupprimer.FlatAppearance.BorderSize = 0;
            this.btnArmSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmSupprimer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmSupprimer.Image = global::g_Stock.Properties.Resources.Supprimer_24;
            this.btnArmSupprimer.Location = new System.Drawing.Point(282, 13);
            this.btnArmSupprimer.Name = "btnArmSupprimer";
            this.btnArmSupprimer.Size = new System.Drawing.Size(30, 30);
            this.btnArmSupprimer.TabIndex = 2;
            this.btnArmSupprimer.UseVisualStyleBackColor = true;
            this.btnArmSupprimer.Click += new System.EventHandler(this.btnArmSupprimer_Click);
            // 
            // gcArmoire
            // 
            this.gcArmoire.Location = new System.Drawing.Point(6, 49);
            this.gcArmoire.MainView = this.gvArmoire;
            this.gcArmoire.Name = "gcArmoire";
            this.gcArmoire.Size = new System.Drawing.Size(344, 148);
            this.gcArmoire.TabIndex = 1;
            this.gcArmoire.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArmoire});
            // 
            // gvArmoire
            // 
            this.gvArmoire.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvArmoire.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvArmoire.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvArmoire.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.DetailTip.Options.UseFont = true;
            this.gvArmoire.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.Empty.Options.UseFont = true;
            this.gvArmoire.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.EvenRow.Options.UseFont = true;
            this.gvArmoire.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvArmoire.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.FilterPanel.Options.UseFont = true;
            this.gvArmoire.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.FixedLine.Options.UseFont = true;
            this.gvArmoire.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.FocusedCell.Options.UseFont = true;
            this.gvArmoire.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.FocusedRow.Options.UseFont = true;
            this.gvArmoire.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.FooterPanel.Options.UseFont = true;
            this.gvArmoire.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.GroupButton.Options.UseFont = true;
            this.gvArmoire.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.GroupFooter.Options.UseFont = true;
            this.gvArmoire.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvArmoire.Appearance.GroupPanel.Options.UseFont = true;
            this.gvArmoire.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.GroupRow.Options.UseFont = true;
            this.gvArmoire.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvArmoire.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvArmoire.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvArmoire.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.HorzLine.Options.UseFont = true;
            this.gvArmoire.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.OddRow.Options.UseFont = true;
            this.gvArmoire.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.Preview.Options.UseFont = true;
            this.gvArmoire.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.Row.Options.UseFont = true;
            this.gvArmoire.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.RowSeparator.Options.UseFont = true;
            this.gvArmoire.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvArmoire.Appearance.SelectedRow.Options.UseFont = true;
            this.gvArmoire.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.TopNewRow.Options.UseFont = true;
            this.gvArmoire.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.VertLine.Options.UseFont = true;
            this.gvArmoire.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvArmoire.Appearance.ViewCaption.Options.UseFont = true;
            this.gvArmoire.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvArmoire.GridControl = this.gcArmoire;
            this.gvArmoire.Name = "gvArmoire";
            this.gvArmoire.OptionsBehavior.Editable = false;
            this.gvArmoire.OptionsView.ShowGroupPanel = false;
            this.gvArmoire.OptionsView.ShowIndicator = false;
            this.gvArmoire.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvArmoire_RowClick);
            this.gvArmoire.DoubleClick += new System.EventHandler(this.gvArmoire_DoubleClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Code";
            this.gridColumn3.FieldName = "arm_ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Armoire";
            this.gridColumn5.FieldName = "arm_Nom";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 157;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Description";
            this.gridColumn6.FieldName = "arm_Description";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 233;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Code Rayonnage";
            this.gridColumn7.FieldName = "arm_ID";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // btnArmAjouter
            // 
            this.btnArmAjouter.AutoSize = true;
            this.btnArmAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArmAjouter.FlatAppearance.BorderSize = 0;
            this.btnArmAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmAjouter.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmAjouter.Image = global::g_Stock.Properties.Resources.Plus_24;
            this.btnArmAjouter.Location = new System.Drawing.Point(320, 13);
            this.btnArmAjouter.Name = "btnArmAjouter";
            this.btnArmAjouter.Size = new System.Drawing.Size(30, 30);
            this.btnArmAjouter.TabIndex = 0;
            this.btnArmAjouter.UseVisualStyleBackColor = true;
            this.btnArmAjouter.Click += new System.EventHandler(this.btnArmAjouter_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(239, 53);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rayonnage";
            // 
            // txtRayonnage
            // 
            this.txtRayonnage.Location = new System.Drawing.Point(116, 27);
            this.txtRayonnage.Name = "txtRayonnage";
            this.txtRayonnage.Size = new System.Drawing.Size(239, 28);
            this.txtRayonnage.TabIndex = 1;
            this.txtRayonnage.Validating += new System.ComponentModel.CancelEventHandler(this.txtRayonnage_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLigne);
            this.groupBox2.Controls.Add(this.gcRayonnage);
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
            this.lblLigne.Location = new System.Drawing.Point(215, 24);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLigne.Size = new System.Drawing.Size(47, 14);
            this.lblLigne.TabIndex = 2;
            this.lblLigne.Text = "ligne";
            this.lblLigne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gcRayonnage
            // 
            this.gcRayonnage.Location = new System.Drawing.Point(6, 41);
            this.gcRayonnage.MainView = this.gvRayonnage;
            this.gcRayonnage.Name = "gcRayonnage";
            this.gcRayonnage.Size = new System.Drawing.Size(392, 295);
            this.gcRayonnage.TabIndex = 0;
            this.gcRayonnage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRayonnage});
            // 
            // gvRayonnage
            // 
            this.gvRayonnage.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvRayonnage.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvRayonnage.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvRayonnage.Appearance.DetailTip.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.DetailTip.Options.UseFont = true;
            this.gvRayonnage.Appearance.Empty.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.Empty.Options.UseFont = true;
            this.gvRayonnage.Appearance.EvenRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.EvenRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvRayonnage.Appearance.FilterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.FilterPanel.Options.UseFont = true;
            this.gvRayonnage.Appearance.FixedLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.FixedLine.Options.UseFont = true;
            this.gvRayonnage.Appearance.FocusedCell.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.FocusedCell.Options.UseFont = true;
            this.gvRayonnage.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.FocusedRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.FooterPanel.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.FooterPanel.Options.UseFont = true;
            this.gvRayonnage.Appearance.GroupButton.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.GroupButton.Options.UseFont = true;
            this.gvRayonnage.Appearance.GroupFooter.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.GroupFooter.Options.UseFont = true;
            this.gvRayonnage.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRayonnage.Appearance.GroupPanel.Options.UseFont = true;
            this.gvRayonnage.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.GroupRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRayonnage.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRayonnage.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.HorzLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.HorzLine.Options.UseFont = true;
            this.gvRayonnage.Appearance.OddRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.OddRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.Preview.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.Preview.Options.UseFont = true;
            this.gvRayonnage.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.Row.Options.UseFont = true;
            this.gvRayonnage.Appearance.RowSeparator.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.RowSeparator.Options.UseFont = true;
            this.gvRayonnage.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRayonnage.Appearance.SelectedRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.TopNewRow.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.TopNewRow.Options.UseFont = true;
            this.gvRayonnage.Appearance.VertLine.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.VertLine.Options.UseFont = true;
            this.gvRayonnage.Appearance.ViewCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.gvRayonnage.Appearance.ViewCaption.Options.UseFont = true;
            this.gvRayonnage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4});
            this.gvRayonnage.GridControl = this.gcRayonnage;
            this.gvRayonnage.Name = "gvRayonnage";
            this.gvRayonnage.OptionsBehavior.Editable = false;
            this.gvRayonnage.OptionsFind.AlwaysVisible = true;
            this.gvRayonnage.OptionsFind.ShowClearButton = false;
            this.gvRayonnage.OptionsFind.ShowFindButton = false;
            this.gvRayonnage.OptionsView.ShowAutoFilterRow = true;
            this.gvRayonnage.OptionsView.ShowGroupPanel = false;
            this.gvRayonnage.OptionsView.ShowIndicator = false;
            this.gvRayonnage.DoubleClick += new System.EventHandler(this.gvRayonnage_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "rayo_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Rayonnage";
            this.gridColumn2.FieldName = "rayo_Nom";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 157;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Description";
            this.gridColumn4.FieldName = "rayo_Description";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 233;
            // 
            // frmRayonnage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmRayonnage";
            this.Text = "Rayonnage";
            this.Load += new System.EventHandler(this.frmRayonnage_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArmoire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArmoire)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRayonnage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRayonnage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRayonnage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLigne;
        private DevExpress.XtraGrid.GridControl gcRayonnage;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRayonnage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnArmAjouter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArmoire;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        public DevExpress.XtraGrid.GridControl gcArmoire;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Button btnArmSupprimer;
    }
}