namespace Loja
{
    partial class frmPrincipal
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
			DevExpress.XtraSplashScreen.SplashScreenManager mgrSplash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Loja.frmApresentacao), true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			this.navbarImageListLarge = new System.Windows.Forms.ImageList();
			this.navbarImageList = new System.Windows.Forms.ImageList();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
			this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer();
			this.btnModoEdicao = new DevExpress.XtraBars.BarButtonItem();
			this.iExit = new DevExpress.XtraBars.BarButtonItem();
			this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer();
			this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.ribbonImageCollection = new DevExpress.Utils.ImageCollection();
			this.iAbout = new DevExpress.XtraBars.BarButtonItem();
			this.siStatus = new DevExpress.XtraBars.BarStaticItem();
			this.siInfo = new DevExpress.XtraBars.BarStaticItem();
			this.iBoldFontStyle = new DevExpress.XtraBars.BarButtonItem();
			this.iItalicFontStyle = new DevExpress.XtraBars.BarButtonItem();
			this.iUnderlinedFontStyle = new DevExpress.XtraBars.BarButtonItem();
			this.iLeftTextAlign = new DevExpress.XtraBars.BarButtonItem();
			this.iCenterTextAlign = new DevExpress.XtraBars.BarButtonItem();
			this.iRightTextAlign = new DevExpress.XtraBars.BarButtonItem();
			this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.lblQtdProduto = new DevExpress.XtraBars.BarStaticItem();
			this.lblQtdItens = new DevExpress.XtraBars.BarStaticItem();
			this.btnRecarregarDados = new DevExpress.XtraBars.BarButtonItem();
			this.txtQtdItem = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtValorTotal = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
			this.btnFinalizarVenda = new DevExpress.XtraBars.BarButtonItem();
			this.btnFazerBackup = new DevExpress.XtraBars.BarButtonItem();
			this.cmbCodOrca = new DevExpress.XtraBars.BarEditItem();
			this.repCodOrca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.btnExcluirOrca = new DevExpress.XtraBars.BarButtonItem();
			this.btnVendaRapida = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection();
			this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.formatRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl();
			this.gridProdutos = new DevExpress.XtraGrid.GridControl();
			this.gridViewProduto = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRefAntiga = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFornecedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
			this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
			this.grpCadastros = new DevExpress.XtraNavBar.NavBarGroup();
			this.btnCadastrar = new DevExpress.XtraNavBar.NavBarItem();
			this.btnCadTipoEntrada = new DevExpress.XtraNavBar.NavBarItem();
			this.btnCadTipoVenda = new DevExpress.XtraNavBar.NavBarItem();
			this.grpOperacoes = new DevExpress.XtraNavBar.NavBarGroup();
			this.btnVender = new DevExpress.XtraNavBar.NavBarItem();
			this.btnEntrada = new DevExpress.XtraNavBar.NavBarItem();
			this.btnRecibo = new DevExpress.XtraNavBar.NavBarItem();
			this.btnReajustar = new DevExpress.XtraNavBar.NavBarItem();
			this.grpRelatorios = new DevExpress.XtraNavBar.NavBarGroup();
			this.btnEstMinimo = new DevExpress.XtraNavBar.NavBarItem();
			this.btnRelVendas = new DevExpress.XtraNavBar.NavBarItem();
			this.btnRelEntradas = new DevExpress.XtraNavBar.NavBarItem();
			this.btnOrcamentos = new DevExpress.XtraNavBar.NavBarItem();
			this.btnCadCliente = new DevExpress.XtraNavBar.NavBarItem();
			this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.gridOrcamento = new DevExpress.XtraGrid.GridControl();
			this.gridViewOrcamento = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOrCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrcodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
			this.popupControlContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCodOrca)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
			this.splitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewOrcamento)).BeginInit();
			this.SuspendLayout();
			// 
			// navbarImageListLarge
			// 
			this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
			this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
			this.navbarImageListLarge.Images.SetKeyName(0, "Mail_16x16.png");
			this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_16x16.png");
			this.navbarImageListLarge.Images.SetKeyName(2, "pasta_papel_16x16.png");
			this.navbarImageListLarge.Images.SetKeyName(3, "pasta_mao_16x16.png");
			this.navbarImageListLarge.Images.SetKeyName(4, "Cadastros_16x16.png");
			this.navbarImageListLarge.Images.SetKeyName(5, "10693_64x64.png");
			// 
			// navbarImageList
			// 
			this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
			this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png");
			this.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png");
			this.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png");
			this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
			this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
			this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
			this.navbarImageList.Images.SetKeyName(6, "AddTableHS.png");
			this.navbarImageList.Images.SetKeyName(7, "CheckGrammarHS.png");
			this.navbarImageList.Images.SetKeyName(8, "NewCardHS.png");
			this.navbarImageList.Images.SetKeyName(9, "1365051401_Business.png");
			this.navbarImageList.Images.SetKeyName(10, "10693_16x16.png");
			// 
			// ribbonControl
			// 
			this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
			this.ribbonControl.ApplicationButtonText = null;
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Images = this.ribbonImageCollection;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iExit,
            this.iAbout,
            this.siStatus,
            this.siInfo,
            this.iBoldFontStyle,
            this.iItalicFontStyle,
            this.iUnderlinedFontStyle,
            this.iLeftTextAlign,
            this.iCenterTextAlign,
            this.iRightTextAlign,
            this.rgbiSkins,
            this.lblQtdProduto,
            this.lblQtdItens,
            this.btnRecarregarDados,
            this.txtQtdItem,
            this.txtValorTotal,
            this.btnImprimir,
            this.btnFinalizarVenda,
            this.btnFazerBackup,
            this.cmbCodOrca,
            this.btnExcluirOrca,
            this.btnModoEdicao,
            this.btnVendaRapida});
			this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MaxItemId = 79;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.helpRibbonPage});
			this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repCodOrca});
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl.Size = new System.Drawing.Size(978, 143);
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
			// 
			// appMenu
			// 
			this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
			this.appMenu.ItemLinks.Add(this.btnModoEdicao);
			this.appMenu.ItemLinks.Add(this.iExit);
			this.appMenu.Name = "appMenu";
			this.appMenu.Ribbon = this.ribbonControl;
			this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
			this.appMenu.ShowRightPane = true;
			// 
			// popupControlContainer2
			// 
			this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.popupControlContainer2.Appearance.Options.UseBackColor = true;
			this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.popupControlContainer2.Location = new System.Drawing.Point(238, 289);
			this.popupControlContainer2.Name = "popupControlContainer2";
			this.popupControlContainer2.Ribbon = this.ribbonControl;
			this.popupControlContainer2.Size = new System.Drawing.Size(118, 28);
			this.popupControlContainer2.TabIndex = 3;
			this.popupControlContainer2.Visible = false;
			// 
			// btnModoEdicao
			// 
			this.btnModoEdicao.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.btnModoEdicao.Caption = "Modo Edição";
			this.btnModoEdicao.Id = 77;
			this.btnModoEdicao.LargeImageIndex = 7;
			this.btnModoEdicao.Name = "btnModoEdicao";
			this.btnModoEdicao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModoEdicao_ItemClick);
			// 
			// iExit
			// 
			this.iExit.Caption = "Sair";
			this.iExit.Description = "Fechar o sistema";
			this.iExit.Hint = "Fechar o sistema";
			this.iExit.Id = 20;
			this.iExit.ImageIndex = 6;
			this.iExit.LargeImageIndex = 6;
			this.iExit.Name = "iExit";
			this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
			// 
			// popupControlContainer1
			// 
			this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.popupControlContainer1.Appearance.Options.UseBackColor = true;
			this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.popupControlContainer1.Controls.Add(this.someLabelControl2);
			this.popupControlContainer1.Controls.Add(this.someLabelControl1);
			this.popupControlContainer1.Location = new System.Drawing.Point(111, 197);
			this.popupControlContainer1.Name = "popupControlContainer1";
			this.popupControlContainer1.Ribbon = this.ribbonControl;
			this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
			this.popupControlContainer1.TabIndex = 2;
			this.popupControlContainer1.Visible = false;
			// 
			// someLabelControl2
			// 
			this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
			this.someLabelControl2.Name = "someLabelControl2";
			this.someLabelControl2.Size = new System.Drawing.Size(98, 13);
			this.someLabelControl2.TabIndex = 0;
			this.someLabelControl2.Text = "Controle de Estoque";
			// 
			// someLabelControl1
			// 
			this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
			this.someLabelControl1.Name = "someLabelControl1";
			this.someLabelControl1.Size = new System.Drawing.Size(39, 13);
			this.someLabelControl1.TabIndex = 0;
			this.someLabelControl1.Text = "Loja 1.0";
			// 
			// ribbonImageCollection
			// 
			this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
			this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
			this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
			// 
			// iAbout
			// 
			this.iAbout.Caption = "Sobre";
			this.iAbout.Description = "Exibir um resumo sobre o programa";
			this.iAbout.Hint = "Exibir um resumo sobre o programa";
			this.iAbout.Id = 24;
			this.iAbout.ImageIndex = 8;
			this.iAbout.LargeImageIndex = 8;
			this.iAbout.Name = "iAbout";
			// 
			// siStatus
			// 
			this.siStatus.Caption = "Sistema para controle de loja    Versão 1.0";
			this.siStatus.Id = 31;
			this.siStatus.Name = "siStatus";
			this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// siInfo
			// 
			this.siInfo.Caption = "F1 - 8 | F2 - Descrição | F3 - 12 | F4 - 15 | F5 - 5 | F6 - 0 | F7 - 10";
			this.siInfo.Id = 32;
			this.siInfo.Name = "siInfo";
			this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// iBoldFontStyle
			// 
			this.iBoldFontStyle.Caption = "Bold";
			this.iBoldFontStyle.Id = 53;
			this.iBoldFontStyle.ImageIndex = 9;
			this.iBoldFontStyle.Name = "iBoldFontStyle";
			// 
			// iItalicFontStyle
			// 
			this.iItalicFontStyle.Caption = "Italic";
			this.iItalicFontStyle.Id = 54;
			this.iItalicFontStyle.ImageIndex = 10;
			this.iItalicFontStyle.Name = "iItalicFontStyle";
			// 
			// iUnderlinedFontStyle
			// 
			this.iUnderlinedFontStyle.Caption = "Underlined";
			this.iUnderlinedFontStyle.Id = 55;
			this.iUnderlinedFontStyle.ImageIndex = 11;
			this.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle";
			// 
			// iLeftTextAlign
			// 
			this.iLeftTextAlign.Caption = "Left";
			this.iLeftTextAlign.Id = 57;
			this.iLeftTextAlign.ImageIndex = 12;
			this.iLeftTextAlign.Name = "iLeftTextAlign";
			// 
			// iCenterTextAlign
			// 
			this.iCenterTextAlign.Caption = "Center";
			this.iCenterTextAlign.Id = 58;
			this.iCenterTextAlign.ImageIndex = 13;
			this.iCenterTextAlign.Name = "iCenterTextAlign";
			// 
			// iRightTextAlign
			// 
			this.iRightTextAlign.Caption = "Right";
			this.iRightTextAlign.Id = 59;
			this.iRightTextAlign.ImageIndex = 14;
			this.iRightTextAlign.Name = "iRightTextAlign";
			// 
			// rgbiSkins
			// 
			this.rgbiSkins.Caption = "Skins";
			// 
			// 
			// 
			this.rgbiSkins.Gallery.AllowHoverImages = true;
			this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
			this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
			this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.rgbiSkins.Gallery.ColumnCount = 4;
			this.rgbiSkins.Gallery.FixedHoverImageSize = false;
			this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
			this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
			this.rgbiSkins.Gallery.RowCount = 4;
			this.rgbiSkins.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiSkins_Gallery_ItemClick);
			this.rgbiSkins.Id = 60;
			this.rgbiSkins.Name = "rgbiSkins";
			// 
			// lblQtdProduto
			// 
			this.lblQtdProduto.Caption = "Qtd. Produtos:";
			this.lblQtdProduto.Id = 62;
			this.lblQtdProduto.Name = "lblQtdProduto";
			this.lblQtdProduto.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// lblQtdItens
			// 
			this.lblQtdItens.Caption = "Qtd. Itens:";
			this.lblQtdItens.Id = 64;
			this.lblQtdItens.Name = "lblQtdItens";
			this.lblQtdItens.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// btnRecarregarDados
			// 
			this.btnRecarregarDados.Caption = "Atualizar Dados";
			this.btnRecarregarDados.Id = 65;
			this.btnRecarregarDados.LargeImageIndex = 3;
			this.btnRecarregarDados.Name = "btnRecarregarDados";
			this.btnRecarregarDados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecarregarDados_ItemClick);
			// 
			// txtQtdItem
			// 
			this.txtQtdItem.Caption = "Itens:         ";
			this.txtQtdItem.Edit = this.repositoryItemTextEdit1;
			this.txtQtdItem.EditValue = "";
			this.txtQtdItem.Id = 66;
			this.txtQtdItem.Name = "txtQtdItem";
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// txtValorTotal
			// 
			this.txtValorTotal.Caption = "Valor Total:";
			this.txtValorTotal.Edit = this.repositoryItemTextEdit2;
			this.txtValorTotal.EditValue = "";
			this.txtValorTotal.Id = 68;
			this.txtValorTotal.Name = "txtValorTotal";
			// 
			// repositoryItemTextEdit2
			// 
			this.repositoryItemTextEdit2.AutoHeight = false;
			this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
			// 
			// btnImprimir
			// 
			this.btnImprimir.Caption = "Imprimir";
			this.btnImprimir.Enabled = false;
			this.btnImprimir.Id = 69;
			this.btnImprimir.LargeImageIndex = 9;
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImprimir_ItemClick);
			// 
			// btnFinalizarVenda
			// 
			this.btnFinalizarVenda.Caption = "Efetuar Venda";
			this.btnFinalizarVenda.Enabled = false;
			this.btnFinalizarVenda.Id = 70;
			this.btnFinalizarVenda.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
			this.btnFinalizarVenda.LargeImageIndex = 11;
			this.btnFinalizarVenda.Name = "btnFinalizarVenda";
			this.btnFinalizarVenda.ShortcutKeyDisplayString = "<F12>";
			this.btnFinalizarVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFinalizarVenda_ItemClick);
			// 
			// btnFazerBackup
			// 
			this.btnFazerBackup.Caption = "Copiar de Loja";
			this.btnFazerBackup.Id = 72;
			this.btnFazerBackup.LargeImageIndex = 10;
			this.btnFazerBackup.Name = "btnFazerBackup";
			this.btnFazerBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFazerBackup_ItemClick);
			// 
			// cmbCodOrca
			// 
			this.cmbCodOrca.Caption = "Orçamento:";
			this.cmbCodOrca.Edit = this.repCodOrca;
			this.cmbCodOrca.EditValue = "";
			this.cmbCodOrca.Id = 74;
			this.cmbCodOrca.Name = "cmbCodOrca";
			this.cmbCodOrca.Tag = "";
			this.cmbCodOrca.Width = 75;
			this.cmbCodOrca.EditValueChanged += new System.EventHandler(this.cmbCodOrca_EditValueChanged);
			// 
			// repCodOrca
			// 
			this.repCodOrca.AutoHeight = false;
			this.repCodOrca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.repCodOrca.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Orçamento"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Itens")});
			this.repCodOrca.DisplayMember = "Codigo";
			this.repCodOrca.Name = "repCodOrca";
			this.repCodOrca.NullText = "[Sem seleção]";
			this.repCodOrca.ValueMember = "Codigo";
			this.repCodOrca.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repCodOrca_ButtonClick);
			// 
			// btnExcluirOrca
			// 
			this.btnExcluirOrca.Caption = "Excluir";
			this.btnExcluirOrca.Enabled = false;
			this.btnExcluirOrca.Id = 75;
			this.btnExcluirOrca.LargeImageIndex = 12;
			this.btnExcluirOrca.Name = "btnExcluirOrca";
			this.btnExcluirOrca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcluirOrca_ItemClick);
			// 
			// btnVendaRapida
			// 
			this.btnVendaRapida.Caption = "Venda Rápida";
			this.btnVendaRapida.Id = 78;
			this.btnVendaRapida.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11);
			this.btnVendaRapida.LargeImageIndex = 13;
			this.btnVendaRapida.Name = "btnVendaRapida";
			this.btnVendaRapida.ShortcutKeyDisplayString = "<F11>";
			this.btnVendaRapida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVendaRapida_ItemClick);
			// 
			// ribbonImageCollectionLarge
			// 
			this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
			this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
			this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(9, "PrintHS.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(10, "SaveAllHS.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(11, "1365051122_shopcartapply_128x128.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(12, "Trashcan_full.png");
			this.ribbonImageCollectionLarge.Images.SetKeyName(13, "1368833657_shopcartdown_48x48.png");
			// 
			// homeRibbonPage
			// 
			this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup,
            this.formatRibbonPageGroup,
            this.ribbonPageGroup1,
            this.skinsRibbonPageGroup,
            this.ribbonPageGroup2,
            this.exitRibbonPageGroup});
			this.homeRibbonPage.Name = "homeRibbonPage";
			this.homeRibbonPage.Text = "Principal";
			// 
			// fileRibbonPageGroup
			// 
			this.fileRibbonPageGroup.ItemLinks.Add(this.btnRecarregarDados);
			this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
			this.fileRibbonPageGroup.Text = "Operações Rápidas";
			// 
			// formatRibbonPageGroup
			// 
			this.formatRibbonPageGroup.ItemLinks.Add(this.lblQtdProduto);
			this.formatRibbonPageGroup.ItemLinks.Add(this.lblQtdItens);
			this.formatRibbonPageGroup.Name = "formatRibbonPageGroup";
			this.formatRibbonPageGroup.Text = "Dados da Loja";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.cmbCodOrca);
			this.ribbonPageGroup1.ItemLinks.Add(this.txtQtdItem);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnExcluirOrca);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnImprimir);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnFinalizarVenda, "F12");
			this.ribbonPageGroup1.ItemLinks.Add(this.btnVendaRapida, "F11");
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Orçamento";
			// 
			// skinsRibbonPageGroup
			// 
			this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
			this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
			this.skinsRibbonPageGroup.ShowCaptionButton = false;
			this.skinsRibbonPageGroup.Text = "Skins";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnFazerBackup);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Opções";
			// 
			// exitRibbonPageGroup
			// 
			this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
			this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
			this.exitRibbonPageGroup.Text = "Sair";
			// 
			// helpRibbonPage
			// 
			this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
			this.helpRibbonPage.Name = "helpRibbonPage";
			this.helpRibbonPage.Text = "Ajuda";
			// 
			// helpRibbonPageGroup
			// 
			this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
			this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
			this.helpRibbonPageGroup.Text = "Help";
			// 
			// repositoryItemGridLookUpEdit1
			// 
			this.repositoryItemGridLookUpEdit1.AutoHeight = false;
			this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
			this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
			// 
			// repositoryItemGridLookUpEdit1View
			// 
			this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
			this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// repositoryItemTextEdit3
			// 
			this.repositoryItemTextEdit3.AutoHeight = false;
			this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
			this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 586);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbonControl;
			this.ribbonStatusBar.Size = new System.Drawing.Size(978, 31);
			// 
			// gridProdutos
			// 
			this.gridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridProdutos.Location = new System.Drawing.Point(0, 0);
			this.gridProdutos.MainView = this.gridViewProduto;
			this.gridProdutos.Name = "gridProdutos";
			this.gridProdutos.Size = new System.Drawing.Size(847, 276);
			this.gridProdutos.TabIndex = 0;
			this.gridProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduto});
			this.gridProdutos.DoubleClick += new System.EventHandler(this.gridProdutos_DoubleClick);
			this.gridProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridProdutos_KeyDown);
			// 
			// gridViewProduto
			// 
			this.gridViewProduto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.gridViewProduto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodProduto,
            this.colDesProduto,
            this.colLocal,
            this.colQtdProduto,
            this.colRefAntiga,
            this.colFornecedor,
            this.colCodigounico});
			this.gridViewProduto.GridControl = this.gridProdutos;
			this.gridViewProduto.GroupPanelText = "Arraste uma coluna aqui para agrupar";
			this.gridViewProduto.Name = "gridViewProduto";
			this.gridViewProduto.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridViewProduto.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridViewProduto.OptionsBehavior.Editable = false;
			this.gridViewProduto.OptionsBehavior.ReadOnly = true;
			this.gridViewProduto.OptionsFind.FindNullPrompt = "Digite o texto a pesquisar";
			this.gridViewProduto.OptionsView.EnableAppearanceEvenRow = true;
			this.gridViewProduto.OptionsView.ShowAutoFilterRow = true;
			// 
			// colCodProduto
			// 
			this.colCodProduto.Caption = "Código";
			this.colCodProduto.FieldName = "CodProduto";
			this.colCodProduto.Name = "colCodProduto";
			this.colCodProduto.Visible = true;
			this.colCodProduto.VisibleIndex = 0;
			this.colCodProduto.Width = 116;
			// 
			// colDesProduto
			// 
			this.colDesProduto.Caption = "Descrição";
			this.colDesProduto.FieldName = "DesProduto";
			this.colDesProduto.Name = "colDesProduto";
			this.colDesProduto.Visible = true;
			this.colDesProduto.VisibleIndex = 1;
			this.colDesProduto.Width = 388;
			// 
			// colLocal
			// 
			this.colLocal.Caption = "Local";
			this.colLocal.FieldName = "DesLocal";
			this.colLocal.Name = "colLocal";
			this.colLocal.Visible = true;
			this.colLocal.VisibleIndex = 2;
			// 
			// colQtdProduto
			// 
			this.colQtdProduto.Caption = "Estoque";
			this.colQtdProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colQtdProduto.FieldName = "QtdProduto";
			this.colQtdProduto.Name = "colQtdProduto";
			this.colQtdProduto.Visible = true;
			this.colQtdProduto.VisibleIndex = 3;
			// 
			// colRefAntiga
			// 
			this.colRefAntiga.Caption = "Ref. Antiga";
			this.colRefAntiga.FieldName = "CodRefAntiga";
			this.colRefAntiga.Name = "colRefAntiga";
			this.colRefAntiga.Visible = true;
			this.colRefAntiga.VisibleIndex = 4;
			this.colRefAntiga.Width = 100;
			// 
			// colFornecedor
			// 
			this.colFornecedor.Caption = "Fornecedor";
			this.colFornecedor.FieldName = "DesFornecedor";
			this.colFornecedor.Name = "colFornecedor";
			this.colFornecedor.Visible = true;
			this.colFornecedor.VisibleIndex = 5;
			this.colFornecedor.Width = 50;
			// 
			// colCodigounico
			// 
			this.colCodigounico.Caption = "Código Único";
			this.colCodigounico.FieldName = "codigounico";
			this.colCodigounico.Name = "colCodigounico";
			// 
			// navBarControl
			// 
			this.navBarControl.ActiveGroup = this.grpOperacoes;
			this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.grpOperacoes,
            this.grpRelatorios,
            this.grpCadastros});
			this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnVender,
            this.btnCadastrar,
            this.btnEntrada,
            this.btnRecibo,
            this.btnRelVendas,
            this.btnRelEntradas,
            this.btnOrcamentos,
            this.btnReajustar,
            this.btnEstMinimo,
            this.btnCadTipoVenda,
            this.btnCadTipoEntrada,
            this.btnCadCliente});
			this.navBarControl.LargeImages = this.navbarImageListLarge;
			this.navBarControl.Location = new System.Drawing.Point(0, 0);
			this.navBarControl.Name = "navBarControl";
			this.navBarControl.OptionsNavPane.AllowOptionsMenuItem = true;
			this.navBarControl.OptionsNavPane.ExpandedWidth = 114;
			this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
			this.navBarControl.Size = new System.Drawing.Size(114, 431);
			this.navBarControl.SmallImages = this.navbarImageList;
			this.navBarControl.StoreDefaultPaintStyleName = true;
			this.navBarControl.TabIndex = 0;
			// 
			// grpCadastros
			// 
			this.grpCadastros.Caption = "Cadastros";
			this.grpCadastros.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCadastrar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCadTipoEntrada),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCadTipoVenda),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCadCliente)});
			this.grpCadastros.LargeImageIndex = 4;
			this.grpCadastros.Name = "grpCadastros";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Caption = "Produto";
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.SmallImageIndex = 6;
			this.btnCadastrar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCadastrar_LinkClicked);
			// 
			// btnCadTipoEntrada
			// 
			this.btnCadTipoEntrada.Caption = "Tipo de Entrada";
			this.btnCadTipoEntrada.Name = "btnCadTipoEntrada";
			this.btnCadTipoEntrada.SmallImageIndex = 6;
			this.btnCadTipoEntrada.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCadTipoEntrada_LinkClicked);
			// 
			// btnCadTipoVenda
			// 
			this.btnCadTipoVenda.Caption = "Tipo de Venda";
			this.btnCadTipoVenda.Name = "btnCadTipoVenda";
			this.btnCadTipoVenda.SmallImageIndex = 6;
			this.btnCadTipoVenda.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCadTipoVenda_LinkClicked);
			// 
			// grpOperacoes
			// 
			this.grpOperacoes.Caption = "Operações";
			this.grpOperacoes.Expanded = true;
			this.grpOperacoes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnVender),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCadastrar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnEntrada),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnRecibo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnReajustar)});
			this.grpOperacoes.LargeImageIndex = 3;
			this.grpOperacoes.Name = "grpOperacoes";
			// 
			// btnVender
			// 
			this.btnVender.Caption = "Vender";
			this.btnVender.Name = "btnVender";
			this.btnVender.SmallImageIndex = 0;
			this.btnVender.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnVender_LinkClicked);
			// 
			// btnEntrada
			// 
			this.btnEntrada.Caption = "Entrada";
			this.btnEntrada.Name = "btnEntrada";
			this.btnEntrada.SmallImageIndex = 2;
			this.btnEntrada.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnEntrada_LinkClicked);
			// 
			// btnRecibo
			// 
			this.btnRecibo.Caption = "Recibo";
			this.btnRecibo.Name = "btnRecibo";
			this.btnRecibo.SmallImageIndex = 8;
			this.btnRecibo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnRecibo_LinkClicked);
			// 
			// btnReajustar
			// 
			this.btnReajustar.Caption = "Reajustar $";
			this.btnReajustar.Name = "btnReajustar";
			this.btnReajustar.SmallImageIndex = 9;
			this.btnReajustar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnReajustar_LinkClicked);
			// 
			// grpRelatorios
			// 
			this.grpRelatorios.Caption = "Relatórios";
			this.grpRelatorios.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnEstMinimo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnRelVendas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnRelEntradas)});
			this.grpRelatorios.LargeImageIndex = 2;
			this.grpRelatorios.Name = "grpRelatorios";
			// 
			// btnEstMinimo
			// 
			this.btnEstMinimo.Caption = "Est. Mínimo";
			this.btnEstMinimo.Name = "btnEstMinimo";
			this.btnEstMinimo.SmallImageIndex = 0;
			this.btnEstMinimo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnEstMinimo_LinkClicked);
			// 
			// btnRelVendas
			// 
			this.btnRelVendas.Caption = "Vendas";
			this.btnRelVendas.Name = "btnRelVendas";
			this.btnRelVendas.SmallImageIndex = 4;
			this.btnRelVendas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnRelVendas_LinkClicked);
			// 
			// btnRelEntradas
			// 
			this.btnRelEntradas.Caption = "Entradas";
			this.btnRelEntradas.Name = "btnRelEntradas";
			this.btnRelEntradas.SmallImageIndex = 5;
			this.btnRelEntradas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnRelEntradas_LinkClicked);
			// 
			// btnOrcamentos
			// 
			this.btnOrcamentos.Caption = "Orçamentos";
			this.btnOrcamentos.Name = "btnOrcamentos";
			this.btnOrcamentos.SmallImageIndex = 7;
			// 
			// btnCadCliente
			// 
			this.btnCadCliente.Caption = "Clientes";
			this.btnCadCliente.LargeImageIndex = 5;
			this.btnCadCliente.Name = "btnCadCliente";
			this.btnCadCliente.SmallImageIndex = 10;
			toolTipTitleItem1.Text = "Dica";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Cadastro de Clientes";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.btnCadCliente.SuperTip = superToolTip1;
			this.btnCadCliente.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCadCliente_LinkClicked);
			// 
			// splitContainerControl
			// 
			this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl.Location = new System.Drawing.Point(0, 143);
			this.splitContainerControl.Name = "splitContainerControl";
			this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
			this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
			this.splitContainerControl.Panel1.Text = "Panel1";
			this.splitContainerControl.Panel2.Controls.Add(this.gridOrcamento);
			this.splitContainerControl.Panel2.Controls.Add(this.gridProdutos);
			this.splitContainerControl.Panel2.Text = "Panel2";
			this.splitContainerControl.Size = new System.Drawing.Size(978, 443);
			this.splitContainerControl.SplitterPosition = 114;
			this.splitContainerControl.TabIndex = 0;
			this.splitContainerControl.Text = "splitContainerControl1";
			// 
			// gridOrcamento
			// 
			this.gridOrcamento.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridOrcamento.Location = new System.Drawing.Point(0, 282);
			this.gridOrcamento.MainView = this.gridViewOrcamento;
			this.gridOrcamento.MenuManager = this.ribbonControl;
			this.gridOrcamento.Name = "gridOrcamento";
			this.gridOrcamento.Size = new System.Drawing.Size(847, 149);
			this.gridOrcamento.TabIndex = 1;
			this.gridOrcamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrcamento});
			this.gridOrcamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridOrcamento_KeyDown);
			// 
			// gridViewOrcamento
			// 
			this.gridViewOrcamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrCodProduto,
            this.colOrDesProduto,
            this.colQuantidade,
            this.colValor,
            this.colVlrFinal,
            this.colOrcodigounico,
            this.colVlrOriginal});
			this.gridViewOrcamento.GridControl = this.gridOrcamento;
			this.gridViewOrcamento.GroupPanelText = "Orçamento";
			this.gridViewOrcamento.Name = "gridViewOrcamento";
			this.gridViewOrcamento.OptionsView.ShowFooter = true;
			this.gridViewOrcamento.OptionsView.ShowGroupPanel = false;
			this.gridViewOrcamento.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrcamento_CellValueChanged);
			// 
			// colOrCodProduto
			// 
			this.colOrCodProduto.Caption = "Código";
			this.colOrCodProduto.FieldName = "CodProduto";
			this.colOrCodProduto.Name = "colOrCodProduto";
			this.colOrCodProduto.OptionsColumn.AllowEdit = false;
			this.colOrCodProduto.Visible = true;
			this.colOrCodProduto.VisibleIndex = 0;
			this.colOrCodProduto.Width = 108;
			// 
			// colOrDesProduto
			// 
			this.colOrDesProduto.Caption = "Descrição";
			this.colOrDesProduto.FieldName = "DescProduto";
			this.colOrDesProduto.Name = "colOrDesProduto";
			this.colOrDesProduto.OptionsColumn.AllowEdit = false;
			this.colOrDesProduto.Visible = true;
			this.colOrDesProduto.VisibleIndex = 1;
			this.colOrDesProduto.Width = 325;
			// 
			// colQuantidade
			// 
			this.colQuantidade.Caption = "Quantidade";
			this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colQuantidade.FieldName = "Quantidade";
			this.colQuantidade.Name = "colQuantidade";
			this.colQuantidade.Visible = true;
			this.colQuantidade.VisibleIndex = 2;
			this.colQuantidade.Width = 79;
			// 
			// colValor
			// 
			this.colValor.Caption = "Valor Unit.";
			this.colValor.DisplayFormat.FormatString = "c2";
			this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colValor.FieldName = "VlrUnitario";
			this.colValor.Name = "colValor";
			this.colValor.Visible = true;
			this.colValor.VisibleIndex = 3;
			this.colValor.Width = 156;
			// 
			// colVlrFinal
			// 
			this.colVlrFinal.Caption = "Vlr. Total";
			this.colVlrFinal.DisplayFormat.FormatString = "c2";
			this.colVlrFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colVlrFinal.FieldName = "PF";
			this.colVlrFinal.Name = "colVlrFinal";
			this.colVlrFinal.OptionsColumn.AllowEdit = false;
			this.colVlrFinal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PF", "{0:c2}")});
			this.colVlrFinal.Visible = true;
			this.colVlrFinal.VisibleIndex = 4;
			this.colVlrFinal.Width = 142;
			// 
			// colOrcodigounico
			// 
			this.colOrcodigounico.Caption = "Código Único";
			this.colOrcodigounico.FieldName = "codigounico";
			this.colOrcodigounico.Name = "colOrcodigounico";
			// 
			// colVlrOriginal
			// 
			this.colVlrOriginal.Caption = "Vlr. Original";
			this.colVlrOriginal.DisplayFormat.FormatString = "C2";
			this.colVlrOriginal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colVlrOriginal.FieldName = "VlrCusto";
			this.colVlrOriginal.Name = "colVlrOriginal";
			this.colVlrOriginal.OptionsColumn.AllowEdit = false;
			this.colVlrOriginal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VlrCusto", "{0:c2}")});
			this.colVlrOriginal.Visible = true;
			this.colVlrOriginal.VisibleIndex = 5;
			this.colVlrOriginal.Width = 142;
			// 
			// frmPrincipal
			// 
			this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 617);
			this.Controls.Add(this.popupControlContainer2);
			this.Controls.Add(this.popupControlContainer1);
			this.Controls.Add(this.splitContainerControl);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbonControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmPrincipal";
			this.Ribbon = this.ribbonControl;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "Sistema para controle de Loja";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
			this.popupControlContainer1.ResumeLayout(false);
			this.popupControlContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCodOrca)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
			this.splitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewOrcamento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.BarButtonItem iBoldFontStyle;
        private DevExpress.XtraBars.BarButtonItem iItalicFontStyle;
        private DevExpress.XtraBars.BarButtonItem iUnderlinedFontStyle;
        private DevExpress.XtraBars.BarButtonItem iLeftTextAlign;
        private DevExpress.XtraBars.BarButtonItem iCenterTextAlign;
        private DevExpress.XtraBars.BarButtonItem iRightTextAlign;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup formatRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraBars.BarStaticItem lblQtdProduto;
        private DevExpress.XtraBars.BarStaticItem lblQtdItens;
        private DevExpress.XtraBars.BarButtonItem btnRecarregarDados;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem txtQtdItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarEditItem txtValorTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.BarButtonItem btnFinalizarVenda;
        private DevExpress.XtraGrid.GridControl gridProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colLocal;
        private DevExpress.XtraGrid.Columns.GridColumn colQtdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colRefAntiga;
        private DevExpress.XtraGrid.Columns.GridColumn colFornecedor;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup grpOperacoes;
        private DevExpress.XtraNavBar.NavBarItem btnVender;
        private DevExpress.XtraNavBar.NavBarItem btnCadastrar;
        private DevExpress.XtraNavBar.NavBarItem btnEntrada;
        private DevExpress.XtraNavBar.NavBarItem btnRecibo;
        private DevExpress.XtraNavBar.NavBarGroup grpRelatorios;
        private DevExpress.XtraNavBar.NavBarItem btnRelVendas;
        private DevExpress.XtraNavBar.NavBarItem btnRelEntradas;
        private DevExpress.XtraNavBar.NavBarItem btnOrcamentos;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraGrid.GridControl gridOrcamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrcamento;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colOrCodProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colOrDesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
        private DevExpress.XtraBars.BarButtonItem btnFazerBackup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem cmbCodOrca;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCodOrca;
        private DevExpress.XtraNavBar.NavBarItem btnReajustar;
        private DevExpress.XtraNavBar.NavBarItem btnEstMinimo;
        private DevExpress.XtraNavBar.NavBarGroup grpCadastros;
        private DevExpress.XtraNavBar.NavBarItem btnCadTipoEntrada;
        private DevExpress.XtraNavBar.NavBarItem btnCadTipoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigounico;
        private DevExpress.XtraGrid.Columns.GridColumn colOrcodigounico;
        private DevExpress.XtraBars.BarButtonItem btnExcluirOrca;
        private DevExpress.XtraBars.BarButtonItem btnModoEdicao;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrOriginal;
        private DevExpress.XtraBars.BarButtonItem btnVendaRapida;
		private DevExpress.XtraNavBar.NavBarItem btnCadCliente;

    }
}
