namespace g_Stock.Master
{
    partial class frmMain
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnFamille = new DevExpress.XtraBars.BarButtonItem();
            this.btnService = new DevExpress.XtraBars.BarButtonItem();
            this.btnProfil = new DevExpress.XtraBars.BarButtonItem();
            this.btnUtilisateur = new DevExpress.XtraBars.BarButtonItem();
            this.btnMagasin = new DevExpress.XtraBars.BarButtonItem();
            this.btnRayonnage = new DevExpress.XtraBars.BarButtonItem();
            this.btnArticle = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblUser = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mdi_Manager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lblService = new DevExpress.XtraBars.BarStaticItem();
            this.lblProfil = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdi_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockWindowTabFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnFamille,
            this.btnService,
            this.btnProfil,
            this.btnUtilisateur,
            this.btnMagasin,
            this.btnRayonnage,
            this.btnArticle,
            this.lblUser,
            this.btnLogin,
            this.lblService,
            this.lblProfil});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFamille),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnService),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProfil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUtilisateur),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMagasin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRayonnage),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnArticle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogin)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnFamille
            // 
            this.btnFamille.Caption = "&Famille";
            this.btnFamille.Id = 0;
            this.btnFamille.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamille.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFamille.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnFamille.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFamille_ItemClick);
            // 
            // btnService
            // 
            this.btnService.Caption = "&Service";
            this.btnService.Id = 1;
            this.btnService.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ItemAppearance.Normal.Options.UseFont = true;
            this.btnService.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnService.Name = "btnService";
            this.btnService.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.btnService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnService_ItemClick);
            // 
            // btnProfil
            // 
            this.btnProfil.Caption = "&Profil";
            this.btnProfil.Id = 2;
            this.btnProfil.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ItemAppearance.Normal.Options.UseFont = true;
            this.btnProfil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnProfil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProfil_ItemClick);
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.Caption = "&Utilisateur";
            this.btnUtilisateur.Id = 3;
            this.btnUtilisateur.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUtilisateur.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUtilisateur_ItemClick);
            // 
            // btnMagasin
            // 
            this.btnMagasin.Caption = "&Magasin";
            this.btnMagasin.Id = 4;
            this.btnMagasin.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagasin.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMagasin.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M));
            this.btnMagasin.Name = "btnMagasin";
            this.btnMagasin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMagasin_ItemClick);
            // 
            // btnRayonnage
            // 
            this.btnRayonnage.Caption = "&Rayonnage";
            this.btnRayonnage.Id = 5;
            this.btnRayonnage.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRayonnage.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRayonnage.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btnRayonnage.Name = "btnRayonnage";
            this.btnRayonnage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRayonnage_ItemClick);
            // 
            // btnArticle
            // 
            this.btnArticle.Caption = "&Article";
            this.btnArticle.Id = 6;
            this.btnArticle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArticle_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Login";
            this.btnLogin.Id = 10;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblProfil),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblService)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblUser
            // 
            this.lblUser.Caption = "---";
            this.lblUser.Id = 9;
            this.lblUser.ItemAppearance.Disabled.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemAppearance.Disabled.Options.UseFont = true;
            this.lblUser.ItemAppearance.Hovered.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemAppearance.Hovered.Options.UseFont = true;
            this.lblUser.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ItemAppearance.Normal.Options.UseFont = true;
            this.lblUser.ItemAppearance.Pressed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemAppearance.Pressed.Options.UseFont = true;
            this.lblUser.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.lblUser.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.lblUser.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.lblUser.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUser.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.lblUser.Name = "lblUser";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(900, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 562);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(900, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(900, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 532);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFamille)});
            this.bar1.Text = "Tools";
            // 
            // mdi_Manager
            // 
            this.mdi_Manager.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdi_Manager.Appearance.Options.UseFont = true;
            this.mdi_Manager.AppearancePage.Header.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdi_Manager.AppearancePage.Header.Options.UseFont = true;
            this.mdi_Manager.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.DarkBlue;
            this.mdi_Manager.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdi_Manager.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.mdi_Manager.AppearancePage.HeaderActive.Options.UseFont = true;
            this.mdi_Manager.AppearancePage.PageClient.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdi_Manager.AppearancePage.PageClient.Options.UseFont = true;
            this.mdi_Manager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.mdi_Manager.MdiParent = this;
            // 
            // lblService
            // 
            this.lblService.Caption = "---";
            this.lblService.Id = 11;
            this.lblService.ItemAppearance.Disabled.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemAppearance.Disabled.Options.UseFont = true;
            this.lblService.ItemAppearance.Hovered.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemAppearance.Hovered.Options.UseFont = true;
            this.lblService.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemAppearance.Normal.Options.UseFont = true;
            this.lblService.ItemAppearance.Pressed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemAppearance.Pressed.Options.UseFont = true;
            this.lblService.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.lblService.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.lblService.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.lblService.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblService.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.lblService.Name = "lblService";
            // 
            // lblProfil
            // 
            this.lblProfil.Caption = "---";
            this.lblProfil.Id = 12;
            this.lblProfil.ItemAppearance.Disabled.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemAppearance.Disabled.Options.UseFont = true;
            this.lblProfil.ItemAppearance.Hovered.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemAppearance.Hovered.Options.UseFont = true;
            this.lblProfil.ItemAppearance.Normal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemAppearance.Normal.Options.UseFont = true;
            this.lblProfil.ItemAppearance.Pressed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemAppearance.Pressed.Options.UseFont = true;
            this.lblProfil.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.lblProfil.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.lblProfil.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.lblProfil.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProfil.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.lblProfil.Name = "lblProfil";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdi_Manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnFamille;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnService;
        private DevExpress.XtraBars.BarButtonItem btnProfil;
        private DevExpress.XtraBars.BarButtonItem btnUtilisateur;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdi_Manager;
        private DevExpress.XtraBars.BarButtonItem btnMagasin;
        private DevExpress.XtraBars.BarButtonItem btnRayonnage;
        private DevExpress.XtraBars.BarButtonItem btnArticle;
        private DevExpress.XtraBars.BarStaticItem lblUser;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarStaticItem lblProfil;
        private DevExpress.XtraBars.BarStaticItem lblService;
    }
}