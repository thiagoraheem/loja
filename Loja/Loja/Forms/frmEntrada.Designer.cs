namespace Loja
{
    partial class frmEntrada
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
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			this.colCodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lueProdutos = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.lcolCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lcolDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtDocEntrada = new DevExpress.XtraEditors.TextEdit();
			this.txtDatEmissao = new DevExpress.XtraEditors.DateEdit();
			this.cmbTipoEntrada = new DevExpress.XtraEditors.LookUpEdit();
			this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
			this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.chkContinuar = new DevExpress.XtraEditors.CheckEdit();
			this.grdDados = new DevExpress.XtraGrid.GridControl();
			this.gridDados = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNCM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrICMS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrICMSST = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPIS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCOFINS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCodOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDesOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPercentual = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDados = new DevExpress.XtraTab.XtraTabPage();
			this.txtNumOrdem = new DevExpress.XtraEditors.TextEdit();
			this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
			this.txtNCM = new DevExpress.XtraEditors.TextEdit();
			this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
			this.txtUnidade = new DevExpress.XtraEditors.TextEdit();
			this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
			this.cmbCodProduto = new DevExpress.XtraEditors.LookUpEdit();
			this.txtVlrFinal = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.txtPercentual = new DevExpress.XtraEditors.CalcEdit();
			this.txtVlrTotal = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrUnitario = new DevExpress.XtraEditors.CalcEdit();
			this.txtQuantidade = new DevExpress.XtraEditors.CalcEdit();
			this.cmbProduto = new DevExpress.XtraEditors.LookUpEdit();
			this.tabImpostos = new DevExpress.XtraTab.XtraTabPage();
			this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrCOFINS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrPercCOFINS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrBaseCOFINS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrPIS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrPercPIS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrBasePIS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrICMSST = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrPercICMSST = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrBaseICMSST = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrICMS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrPercICMS = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrBaseICMS = new DevExpress.XtraEditors.CalcEdit();
			this.cmbFornecedor = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnImportarXML = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.txtArquivoXML = new DevExpress.XtraEditors.ButtonEdit();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.btnCarregarNF = new DevExpress.XtraEditors.SimpleButton();
			this.txtNumChave = new DevExpress.XtraEditors.TextEdit();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.txtNome = new DevExpress.XtraEditors.TextEdit();
			this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.txtNumCNPJ = new DevExpress.XtraEditors.TextEdit();
			this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.txtSerieNota = new DevExpress.XtraEditors.TextEdit();
			this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcluirItem = new DevExpress.XtraEditors.SimpleButton();
			this.btnAlterarItem = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.lueProdutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDocEntrada.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatEmissao.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatEmissao.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipoEntrada.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkContinuar.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.tabDados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNumOrdem.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnidade.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCodProduto.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrFinal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbProduto.Properties)).BeginInit();
			this.tabImpostos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrCOFINS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercCOFINS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseCOFINS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPIS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercPIS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBasePIS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrICMSST.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercICMSST.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMSST.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrICMS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercICMS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtArquivoXML.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumChave.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCNPJ.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSerieNota.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// colCodigounico
			// 
			this.colCodigounico.Caption = "Código Único";
			this.colCodigounico.ColumnEdit = this.lueProdutos;
			this.colCodigounico.FieldName = "codigounico";
			this.colCodigounico.Name = "colCodigounico";
			this.colCodigounico.Visible = true;
			this.colCodigounico.VisibleIndex = 11;
			// 
			// lueProdutos
			// 
			this.lueProdutos.AutoHeight = false;
			this.lueProdutos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lueProdutos.DisplayMember = "CodProduto";
			this.lueProdutos.Name = "lueProdutos";
			this.lueProdutos.NullText = "[Selecione um produto]";
			this.lueProdutos.ValueMember = "codigounico";
			this.lueProdutos.View = this.repositoryItemSearchLookUpEdit1View;
			// 
			// repositoryItemSearchLookUpEdit1View
			// 
			this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.lcolCodProduto,
            this.lcolDesProduto});
			this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
			this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// lcolCodProduto
			// 
			this.lcolCodProduto.Caption = "Código";
			this.lcolCodProduto.FieldName = "CodProduto";
			this.lcolCodProduto.Name = "lcolCodProduto";
			this.lcolCodProduto.Visible = true;
			this.lcolCodProduto.VisibleIndex = 0;
			// 
			// lcolDesProduto
			// 
			this.lcolDesProduto.Caption = "Decrição";
			this.lcolDesProduto.FieldName = "DesProduto";
			this.lcolDesProduto.Name = "lcolDesProduto";
			this.lcolDesProduto.Visible = true;
			this.lcolDesProduto.VisibleIndex = 1;
			// 
			// txtDocEntrada
			// 
			this.txtDocEntrada.EnterMoveNextControl = true;
			this.txtDocEntrada.Location = new System.Drawing.Point(83, 23);
			this.txtDocEntrada.Name = "txtDocEntrada";
			this.txtDocEntrada.Properties.MaxLength = 20;
			this.txtDocEntrada.Size = new System.Drawing.Size(79, 20);
			this.txtDocEntrada.TabIndex = 0;
			this.txtDocEntrada.Validated += new System.EventHandler(this.txtDocEntrada_Validated);
			// 
			// txtDatEmissao
			// 
			this.txtDatEmissao.EditValue = null;
			this.txtDatEmissao.EnterMoveNextControl = true;
			this.txtDatEmissao.Location = new System.Drawing.Point(355, 23);
			this.txtDatEmissao.Name = "txtDatEmissao";
			this.txtDatEmissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDatEmissao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.txtDatEmissao.Size = new System.Drawing.Size(100, 20);
			this.txtDatEmissao.TabIndex = 1;
			// 
			// cmbTipoEntrada
			// 
			this.cmbTipoEntrada.EnterMoveNextControl = true;
			this.cmbTipoEntrada.Location = new System.Drawing.Point(569, 23);
			this.cmbTipoEntrada.Name = "cmbTipoEntrada";
			this.cmbTipoEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbTipoEntrada.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodTipoEntrada", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesTipoEntrada", "Descrição")});
			this.cmbTipoEntrada.Properties.DisplayMember = "DesTipoVenda";
			this.cmbTipoEntrada.Properties.NullText = "[Selecione um tipo]";
			this.cmbTipoEntrada.Properties.ValueMember = "CodTipoVenda";
			this.cmbTipoEntrada.Size = new System.Drawing.Size(142, 20);
			this.cmbTipoEntrada.TabIndex = 21;
			this.cmbTipoEntrada.Visible = false;
			// 
			// btnRetornar
			// 
			this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRetornar.Location = new System.Drawing.Point(662, 440);
			this.btnRetornar.Name = "btnRetornar";
			this.btnRetornar.Size = new System.Drawing.Size(75, 23);
			this.btnRetornar.TabIndex = 8;
			this.btnRetornar.Text = "&Retornar";
			this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
			// 
			// btnGravar
			// 
			this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGravar.Location = new System.Drawing.Point(662, 411);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(75, 23);
			this.btnGravar.TabIndex = 7;
			this.btnGravar.Text = "&Gravar";
			this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(21, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(56, 13);
			this.labelControl1.TabIndex = 9;
			this.labelControl1.Text = "Nota Fiscal:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(281, 26);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(68, 13);
			this.labelControl2.TabIndex = 10;
			this.labelControl2.Text = "Data Emissão:";
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(483, 26);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(80, 13);
			this.labelControl7.TabIndex = 24;
			this.labelControl7.Text = "Tipo de Entrada:";
			this.labelControl7.Visible = false;
			// 
			// chkContinuar
			// 
			this.chkContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkContinuar.Location = new System.Drawing.Point(531, 442);
			this.chkContinuar.Name = "chkContinuar";
			this.chkContinuar.Properties.Caption = "Fechar ao gravar";
			this.chkContinuar.Size = new System.Drawing.Size(125, 19);
			this.chkContinuar.TabIndex = 0;
			// 
			// grdDados
			// 
			this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdDados.Location = new System.Drawing.Point(12, 267);
			this.grdDados.MainView = this.gridDados;
			this.grdDados.Name = "grdDados";
			this.grdDados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueProdutos});
			this.grdDados.Size = new System.Drawing.Size(720, 120);
			this.grdDados.TabIndex = 23;
			this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDados});
			this.grdDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDados_KeyDown);
			// 
			// gridDados
			// 
			this.gridDados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigounico,
            this.colCodProduto,
            this.colDesProduto,
            this.colUnidade,
            this.colVlrUnitario,
            this.colQuantidade,
            this.colVlrTotal,
            this.colNCM,
            this.colVlrICMS,
            this.colVlrICMSST,
            this.colPIS,
            this.colCOFINS,
            this.colCodOriginal,
            this.colDesOriginal,
            this.colPercentual,
            this.colVlrFinal});
			gridFormatRule1.ApplyToRow = true;
			gridFormatRule1.Column = this.colCodigounico;
			gridFormatRule1.Name = "naoCadastrado1";
			formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue1.PredefinedName = "Não cadastrado";
			formatConditionRuleValue1.Value1 = "-1";
			formatConditionRuleValue1.Value2 = "";
			gridFormatRule1.Rule = formatConditionRuleValue1;
			this.gridDados.FormatRules.Add(gridFormatRule1);
			this.gridDados.GridControl = this.grdDados;
			this.gridDados.GroupPanelText = "Arraste uma coluna aqui para agrupar";
			this.gridDados.Name = "gridDados";
			this.gridDados.OptionsCustomization.AllowGroup = false;
			this.gridDados.OptionsView.ShowFooter = true;
			this.gridDados.OptionsView.ShowGroupPanel = false;
			this.gridDados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridDados_CellValueChanged);
			// 
			// colCodProduto
			// 
			this.colCodProduto.Caption = "Código";
			this.colCodProduto.FieldName = "CodProduto";
			this.colCodProduto.Name = "colCodProduto";
			this.colCodProduto.OptionsColumn.AllowEdit = false;
			this.colCodProduto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodProduto", "Total de itens: {0}")});
			this.colCodProduto.Visible = true;
			this.colCodProduto.VisibleIndex = 0;
			this.colCodProduto.Width = 117;
			// 
			// colDesProduto
			// 
			this.colDesProduto.Caption = "Descrição";
			this.colDesProduto.FieldName = "DesProduto";
			this.colDesProduto.Name = "colDesProduto";
			this.colDesProduto.OptionsColumn.AllowEdit = false;
			this.colDesProduto.Visible = true;
			this.colDesProduto.VisibleIndex = 1;
			this.colDesProduto.Width = 267;
			// 
			// colUnidade
			// 
			this.colUnidade.Caption = "Unidade";
			this.colUnidade.FieldName = "Unidade";
			this.colUnidade.Name = "colUnidade";
			this.colUnidade.OptionsColumn.AllowEdit = false;
			this.colUnidade.Visible = true;
			this.colUnidade.VisibleIndex = 2;
			// 
			// colVlrUnitario
			// 
			this.colVlrUnitario.Caption = "Vlr. Unit.";
			this.colVlrUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colVlrUnitario.FieldName = "VlrUnitario";
			this.colVlrUnitario.Name = "colVlrUnitario";
			this.colVlrUnitario.OptionsColumn.AllowEdit = false;
			this.colVlrUnitario.Visible = true;
			this.colVlrUnitario.VisibleIndex = 3;
			this.colVlrUnitario.Width = 73;
			// 
			// colQuantidade
			// 
			this.colQuantidade.Caption = "Qtde.";
			this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colQuantidade.FieldName = "Quantidade";
			this.colQuantidade.Name = "colQuantidade";
			this.colQuantidade.OptionsColumn.AllowEdit = false;
			this.colQuantidade.Visible = true;
			this.colQuantidade.VisibleIndex = 4;
			this.colQuantidade.Width = 49;
			// 
			// colVlrTotal
			// 
			this.colVlrTotal.Caption = "Vlr. Total";
			this.colVlrTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colVlrTotal.FieldName = "VlrTotal";
			this.colVlrTotal.Name = "colVlrTotal";
			this.colVlrTotal.OptionsColumn.AllowEdit = false;
			this.colVlrTotal.OptionsColumn.ReadOnly = true;
			this.colVlrTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VlrFinal", "", "Valor total da nota")});
			this.colVlrTotal.Visible = true;
			this.colVlrTotal.VisibleIndex = 5;
			this.colVlrTotal.Width = 70;
			// 
			// colNCM
			// 
			this.colNCM.Caption = "NCM";
			this.colNCM.FieldName = "NCM";
			this.colNCM.Name = "colNCM";
			this.colNCM.OptionsColumn.AllowEdit = false;
			this.colNCM.Visible = true;
			this.colNCM.VisibleIndex = 6;
			// 
			// colVlrICMS
			// 
			this.colVlrICMS.Caption = "Vlr. ICMS";
			this.colVlrICMS.FieldName = "VlrICMS";
			this.colVlrICMS.Name = "colVlrICMS";
			this.colVlrICMS.OptionsColumn.AllowEdit = false;
			this.colVlrICMS.Visible = true;
			this.colVlrICMS.VisibleIndex = 7;
			// 
			// colVlrICMSST
			// 
			this.colVlrICMSST.Caption = "ICMS ST";
			this.colVlrICMSST.FieldName = "VlrICMSST";
			this.colVlrICMSST.Name = "colVlrICMSST";
			this.colVlrICMSST.OptionsColumn.AllowEdit = false;
			this.colVlrICMSST.Visible = true;
			this.colVlrICMSST.VisibleIndex = 8;
			// 
			// colPIS
			// 
			this.colPIS.Caption = "PIS";
			this.colPIS.FieldName = "VlrPIS";
			this.colPIS.Name = "colPIS";
			// 
			// colCOFINS
			// 
			this.colCOFINS.Caption = "COFINS";
			this.colCOFINS.FieldName = "VlrCOFINS";
			this.colCOFINS.Name = "colCOFINS";
			// 
			// colCodOriginal
			// 
			this.colCodOriginal.Caption = "Cód. Orig.";
			this.colCodOriginal.FieldName = "CodOriginal";
			this.colCodOriginal.Name = "colCodOriginal";
			this.colCodOriginal.OptionsColumn.AllowEdit = false;
			this.colCodOriginal.Visible = true;
			this.colCodOriginal.VisibleIndex = 9;
			// 
			// colDesOriginal
			// 
			this.colDesOriginal.Caption = "Desc. Original";
			this.colDesOriginal.FieldName = "DesOriginal";
			this.colDesOriginal.Name = "colDesOriginal";
			this.colDesOriginal.OptionsColumn.AllowEdit = false;
			this.colDesOriginal.Visible = true;
			this.colDesOriginal.VisibleIndex = 10;
			// 
			// colPercentual
			// 
			this.colPercentual.Caption = "Percent.";
			this.colPercentual.FieldName = "Percentual";
			this.colPercentual.Name = "colPercentual";
			this.colPercentual.Visible = true;
			this.colPercentual.VisibleIndex = 12;
			// 
			// colVlrFinal
			// 
			this.colVlrFinal.Caption = "Vlr. Final";
			this.colVlrFinal.FieldName = "VlrFinal";
			this.colVlrFinal.Name = "colVlrFinal";
			this.colVlrFinal.Visible = true;
			this.colVlrFinal.VisibleIndex = 13;
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xtraTabControl1.Location = new System.Drawing.Point(12, 96);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.tabDados;
			this.xtraTabControl1.Size = new System.Drawing.Size(725, 142);
			this.xtraTabControl1.TabIndex = 31;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDados,
            this.tabImpostos});
			// 
			// tabDados
			// 
			this.tabDados.Controls.Add(this.txtNumOrdem);
			this.tabDados.Controls.Add(this.labelControl30);
			this.tabDados.Controls.Add(this.txtNCM);
			this.tabDados.Controls.Add(this.labelControl29);
			this.tabDados.Controls.Add(this.txtUnidade);
			this.tabDados.Controls.Add(this.labelControl28);
			this.tabDados.Controls.Add(this.cmbCodProduto);
			this.tabDados.Controls.Add(this.txtVlrFinal);
			this.tabDados.Controls.Add(this.labelControl9);
			this.tabDados.Controls.Add(this.labelControl8);
			this.tabDados.Controls.Add(this.txtPercentual);
			this.tabDados.Controls.Add(this.txtVlrTotal);
			this.tabDados.Controls.Add(this.labelControl6);
			this.tabDados.Controls.Add(this.labelControl5);
			this.tabDados.Controls.Add(this.labelControl4);
			this.tabDados.Controls.Add(this.labelControl3);
			this.tabDados.Controls.Add(this.txtVlrUnitario);
			this.tabDados.Controls.Add(this.txtQuantidade);
			this.tabDados.Controls.Add(this.cmbProduto);
			this.tabDados.Name = "tabDados";
			this.tabDados.Size = new System.Drawing.Size(719, 114);
			this.tabDados.Text = "Dados Produto";
			// 
			// txtNumOrdem
			// 
			this.txtNumOrdem.EditValue = "1";
			this.txtNumOrdem.EnterMoveNextControl = true;
			this.txtNumOrdem.Location = new System.Drawing.Point(452, 33);
			this.txtNumOrdem.Name = "txtNumOrdem";
			this.txtNumOrdem.Size = new System.Drawing.Size(79, 20);
			this.txtNumOrdem.TabIndex = 40;
			// 
			// labelControl30
			// 
			this.labelControl30.Location = new System.Drawing.Point(393, 36);
			this.labelControl30.Name = "labelControl30";
			this.labelControl30.Size = new System.Drawing.Size(53, 13);
			this.labelControl30.TabIndex = 41;
			this.labelControl30.Text = "Sequëncia:";
			// 
			// txtNCM
			// 
			this.txtNCM.EnterMoveNextControl = true;
			this.txtNCM.Location = new System.Drawing.Point(270, 33);
			this.txtNCM.Name = "txtNCM";
			this.txtNCM.Size = new System.Drawing.Size(79, 20);
			this.txtNCM.TabIndex = 38;
			// 
			// labelControl29
			// 
			this.labelControl29.Location = new System.Drawing.Point(238, 36);
			this.labelControl29.Name = "labelControl29";
			this.labelControl29.Size = new System.Drawing.Size(26, 13);
			this.labelControl29.TabIndex = 39;
			this.labelControl29.Text = "NCM:";
			// 
			// txtUnidade
			// 
			this.txtUnidade.EnterMoveNextControl = true;
			this.txtUnidade.Location = new System.Drawing.Point(81, 33);
			this.txtUnidade.Name = "txtUnidade";
			this.txtUnidade.Size = new System.Drawing.Size(79, 20);
			this.txtUnidade.TabIndex = 36;
			// 
			// labelControl28
			// 
			this.labelControl28.Location = new System.Drawing.Point(32, 36);
			this.labelControl28.Name = "labelControl28";
			this.labelControl28.Size = new System.Drawing.Size(43, 13);
			this.labelControl28.TabIndex = 37;
			this.labelControl28.Text = "Unidade:";
			// 
			// cmbCodProduto
			// 
			this.cmbCodProduto.EnterMoveNextControl = true;
			this.cmbCodProduto.Location = new System.Drawing.Point(82, 8);
			this.cmbCodProduto.Name = "cmbCodProduto";
			this.cmbCodProduto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
			this.cmbCodProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbCodProduto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodProduto", 30, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProduto", 100, "Descrição"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesLocal", 10, "Local"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QtdProduto", 10, "Est.")});
			this.cmbCodProduto.Properties.DisplayMember = "CodProduto";
			this.cmbCodProduto.Properties.NullText = "[Código]";
			this.cmbCodProduto.Properties.PopupFormMinSize = new System.Drawing.Size(400, 0);
			this.cmbCodProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cmbCodProduto.Properties.ValueMember = "codigounico";
			this.cmbCodProduto.Size = new System.Drawing.Size(182, 20);
			this.cmbCodProduto.TabIndex = 21;
			// 
			// txtVlrFinal
			// 
			this.txtVlrFinal.Location = new System.Drawing.Point(270, 85);
			this.txtVlrFinal.Name = "txtVlrFinal";
			this.txtVlrFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrFinal.Properties.Mask.EditMask = "c";
			this.txtVlrFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrFinal.Properties.ReadOnly = true;
			this.txtVlrFinal.Size = new System.Drawing.Size(100, 20);
			this.txtVlrFinal.TabIndex = 35;
			this.txtVlrFinal.TabStop = false;
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(219, 88);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(45, 13);
			this.labelControl9.TabIndex = 34;
			this.labelControl9.Text = "Vlr. Final:";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(20, 88);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(55, 13);
			this.labelControl8.TabIndex = 31;
			this.labelControl8.Text = "Percentual:";
			// 
			// txtPercentual
			// 
			this.txtPercentual.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txtPercentual.EnterMoveNextControl = true;
			this.txtPercentual.Location = new System.Drawing.Point(81, 85);
			this.txtPercentual.Name = "txtPercentual";
			this.txtPercentual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPercentual.Properties.Mask.EditMask = "P0";
			this.txtPercentual.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtPercentual.Size = new System.Drawing.Size(100, 20);
			this.txtPercentual.TabIndex = 25;
			// 
			// txtVlrTotal
			// 
			this.txtVlrTotal.Location = new System.Drawing.Point(452, 59);
			this.txtVlrTotal.Name = "txtVlrTotal";
			this.txtVlrTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrTotal.Properties.Mask.EditMask = "c";
			this.txtVlrTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrTotal.Properties.ReadOnly = true;
			this.txtVlrTotal.Size = new System.Drawing.Size(100, 20);
			this.txtVlrTotal.TabIndex = 33;
			this.txtVlrTotal.TabStop = false;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(399, 62);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(47, 13);
			this.labelControl6.TabIndex = 32;
			this.labelControl6.Text = "Vlr. Total:";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(204, 62);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(60, 13);
			this.labelControl5.TabIndex = 30;
			this.labelControl5.Text = "Vlr. Unitário:";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(16, 62);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(60, 13);
			this.labelControl4.TabIndex = 28;
			this.labelControl4.Text = "Quantidade:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(34, 11);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(42, 13);
			this.labelControl3.TabIndex = 26;
			this.labelControl3.Text = "Produto:";
			// 
			// txtVlrUnitario
			// 
			this.txtVlrUnitario.EnterMoveNextControl = true;
			this.txtVlrUnitario.Location = new System.Drawing.Point(270, 59);
			this.txtVlrUnitario.Name = "txtVlrUnitario";
			this.txtVlrUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrUnitario.Properties.Mask.EditMask = "c";
			this.txtVlrUnitario.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrUnitario.Size = new System.Drawing.Size(100, 20);
			this.txtVlrUnitario.TabIndex = 24;
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.EnterMoveNextControl = true;
			this.txtQuantidade.Location = new System.Drawing.Point(81, 59);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
			this.txtQuantidade.TabIndex = 22;
			// 
			// cmbProduto
			// 
			this.cmbProduto.EnterMoveNextControl = true;
			this.cmbProduto.Location = new System.Drawing.Point(270, 8);
			this.cmbProduto.Name = "cmbProduto";
			this.cmbProduto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
			this.cmbProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbProduto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodProduto", 30, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProduto", 100, "Descrição"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesLocal", 10, "Local"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QtdProduto", 10, "Est.")});
			this.cmbProduto.Properties.DisplayMember = "DesProduto";
			this.cmbProduto.Properties.NullText = "[Selecione um produto]";
			this.cmbProduto.Properties.PopupFormMinSize = new System.Drawing.Size(400, 0);
			this.cmbProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cmbProduto.Properties.ValueMember = "codigounico";
			this.cmbProduto.Size = new System.Drawing.Size(354, 20);
			this.cmbProduto.TabIndex = 27;
			this.cmbProduto.Validated += new System.EventHandler(this.cmbProduto_Validated);
			// 
			// tabImpostos
			// 
			this.tabImpostos.Controls.Add(this.labelControl25);
			this.tabImpostos.Controls.Add(this.txtVlrCOFINS);
			this.tabImpostos.Controls.Add(this.labelControl26);
			this.tabImpostos.Controls.Add(this.txtVlrPercCOFINS);
			this.tabImpostos.Controls.Add(this.labelControl27);
			this.tabImpostos.Controls.Add(this.txtVlrBaseCOFINS);
			this.tabImpostos.Controls.Add(this.labelControl22);
			this.tabImpostos.Controls.Add(this.txtVlrPIS);
			this.tabImpostos.Controls.Add(this.labelControl23);
			this.tabImpostos.Controls.Add(this.txtVlrPercPIS);
			this.tabImpostos.Controls.Add(this.labelControl24);
			this.tabImpostos.Controls.Add(this.txtVlrBasePIS);
			this.tabImpostos.Controls.Add(this.labelControl19);
			this.tabImpostos.Controls.Add(this.txtVlrICMSST);
			this.tabImpostos.Controls.Add(this.labelControl20);
			this.tabImpostos.Controls.Add(this.txtVlrPercICMSST);
			this.tabImpostos.Controls.Add(this.labelControl21);
			this.tabImpostos.Controls.Add(this.txtVlrBaseICMSST);
			this.tabImpostos.Controls.Add(this.labelControl18);
			this.tabImpostos.Controls.Add(this.txtVlrICMS);
			this.tabImpostos.Controls.Add(this.labelControl17);
			this.tabImpostos.Controls.Add(this.txtVlrPercICMS);
			this.tabImpostos.Controls.Add(this.labelControl16);
			this.tabImpostos.Controls.Add(this.txtVlrBaseICMS);
			this.tabImpostos.Name = "tabImpostos";
			this.tabImpostos.Size = new System.Drawing.Size(719, 114);
			this.tabImpostos.Text = "Impostos";
			// 
			// labelControl25
			// 
			this.labelControl25.Location = new System.Drawing.Point(479, 87);
			this.labelControl25.Name = "labelControl25";
			this.labelControl25.Size = new System.Drawing.Size(61, 13);
			this.labelControl25.TabIndex = 54;
			this.labelControl25.Text = "Vlr. COFINS:";
			// 
			// txtVlrCOFINS
			// 
			this.txtVlrCOFINS.EnterMoveNextControl = true;
			this.txtVlrCOFINS.Location = new System.Drawing.Point(551, 84);
			this.txtVlrCOFINS.Name = "txtVlrCOFINS";
			this.txtVlrCOFINS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrCOFINS.Properties.Mask.EditMask = "c";
			this.txtVlrCOFINS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrCOFINS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrCOFINS.TabIndex = 53;
			// 
			// labelControl26
			// 
			this.labelControl26.Location = new System.Drawing.Point(252, 87);
			this.labelControl26.Name = "labelControl26";
			this.labelControl26.Size = new System.Drawing.Size(89, 13);
			this.labelControl26.TabIndex = 52;
			this.labelControl26.Text = "Vlr. Perc. COFINS:";
			// 
			// txtVlrPercCOFINS
			// 
			this.txtVlrPercCOFINS.EnterMoveNextControl = true;
			this.txtVlrPercCOFINS.Location = new System.Drawing.Point(350, 84);
			this.txtVlrPercCOFINS.Name = "txtVlrPercCOFINS";
			this.txtVlrPercCOFINS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrPercCOFINS.Properties.Mask.EditMask = "c";
			this.txtVlrPercCOFINS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrPercCOFINS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrPercCOFINS.TabIndex = 51;
			// 
			// labelControl27
			// 
			this.labelControl27.Location = new System.Drawing.Point(10, 87);
			this.labelControl27.Name = "labelControl27";
			this.labelControl27.Size = new System.Drawing.Size(87, 13);
			this.labelControl27.TabIndex = 50;
			this.labelControl27.Text = "Vlr. Base COFINS:";
			// 
			// txtVlrBaseCOFINS
			// 
			this.txtVlrBaseCOFINS.EnterMoveNextControl = true;
			this.txtVlrBaseCOFINS.Location = new System.Drawing.Point(109, 84);
			this.txtVlrBaseCOFINS.Name = "txtVlrBaseCOFINS";
			this.txtVlrBaseCOFINS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrBaseCOFINS.Properties.Mask.EditMask = "c";
			this.txtVlrBaseCOFINS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrBaseCOFINS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrBaseCOFINS.TabIndex = 49;
			// 
			// labelControl22
			// 
			this.labelControl22.Location = new System.Drawing.Point(479, 61);
			this.labelControl22.Name = "labelControl22";
			this.labelControl22.Size = new System.Drawing.Size(39, 13);
			this.labelControl22.TabIndex = 48;
			this.labelControl22.Text = "Vlr. PIS:";
			// 
			// txtVlrPIS
			// 
			this.txtVlrPIS.EnterMoveNextControl = true;
			this.txtVlrPIS.Location = new System.Drawing.Point(551, 58);
			this.txtVlrPIS.Name = "txtVlrPIS";
			this.txtVlrPIS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrPIS.Properties.Mask.EditMask = "c";
			this.txtVlrPIS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrPIS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrPIS.TabIndex = 47;
			// 
			// labelControl23
			// 
			this.labelControl23.Location = new System.Drawing.Point(252, 61);
			this.labelControl23.Name = "labelControl23";
			this.labelControl23.Size = new System.Drawing.Size(67, 13);
			this.labelControl23.TabIndex = 46;
			this.labelControl23.Text = "Vlr. Perc. PIS:";
			// 
			// txtVlrPercPIS
			// 
			this.txtVlrPercPIS.EnterMoveNextControl = true;
			this.txtVlrPercPIS.Location = new System.Drawing.Point(350, 58);
			this.txtVlrPercPIS.Name = "txtVlrPercPIS";
			this.txtVlrPercPIS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrPercPIS.Properties.Mask.EditMask = "c";
			this.txtVlrPercPIS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrPercPIS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrPercPIS.TabIndex = 45;
			// 
			// labelControl24
			// 
			this.labelControl24.Location = new System.Drawing.Point(10, 61);
			this.labelControl24.Name = "labelControl24";
			this.labelControl24.Size = new System.Drawing.Size(65, 13);
			this.labelControl24.TabIndex = 44;
			this.labelControl24.Text = "Vlr. Base PIS:";
			// 
			// txtVlrBasePIS
			// 
			this.txtVlrBasePIS.EnterMoveNextControl = true;
			this.txtVlrBasePIS.Location = new System.Drawing.Point(109, 58);
			this.txtVlrBasePIS.Name = "txtVlrBasePIS";
			this.txtVlrBasePIS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrBasePIS.Properties.Mask.EditMask = "c";
			this.txtVlrBasePIS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrBasePIS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrBasePIS.TabIndex = 43;
			// 
			// labelControl19
			// 
			this.labelControl19.Location = new System.Drawing.Point(479, 35);
			this.labelControl19.Name = "labelControl19";
			this.labelControl19.Size = new System.Drawing.Size(63, 13);
			this.labelControl19.TabIndex = 42;
			this.labelControl19.Text = "Vlr. ICMS ST:";
			// 
			// txtVlrICMSST
			// 
			this.txtVlrICMSST.EnterMoveNextControl = true;
			this.txtVlrICMSST.Location = new System.Drawing.Point(551, 32);
			this.txtVlrICMSST.Name = "txtVlrICMSST";
			this.txtVlrICMSST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrICMSST.Properties.Mask.EditMask = "c";
			this.txtVlrICMSST.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrICMSST.Size = new System.Drawing.Size(100, 20);
			this.txtVlrICMSST.TabIndex = 41;
			// 
			// labelControl20
			// 
			this.labelControl20.Location = new System.Drawing.Point(252, 35);
			this.labelControl20.Name = "labelControl20";
			this.labelControl20.Size = new System.Drawing.Size(91, 13);
			this.labelControl20.TabIndex = 40;
			this.labelControl20.Text = "Vlr. Perc. ICMS ST:";
			// 
			// txtVlrPercICMSST
			// 
			this.txtVlrPercICMSST.EnterMoveNextControl = true;
			this.txtVlrPercICMSST.Location = new System.Drawing.Point(350, 32);
			this.txtVlrPercICMSST.Name = "txtVlrPercICMSST";
			this.txtVlrPercICMSST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrPercICMSST.Properties.Mask.EditMask = "c";
			this.txtVlrPercICMSST.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrPercICMSST.Size = new System.Drawing.Size(100, 20);
			this.txtVlrPercICMSST.TabIndex = 39;
			// 
			// labelControl21
			// 
			this.labelControl21.Location = new System.Drawing.Point(10, 35);
			this.labelControl21.Name = "labelControl21";
			this.labelControl21.Size = new System.Drawing.Size(89, 13);
			this.labelControl21.TabIndex = 38;
			this.labelControl21.Text = "Vlr. Base ICMS ST:";
			// 
			// txtVlrBaseICMSST
			// 
			this.txtVlrBaseICMSST.EnterMoveNextControl = true;
			this.txtVlrBaseICMSST.Location = new System.Drawing.Point(109, 32);
			this.txtVlrBaseICMSST.Name = "txtVlrBaseICMSST";
			this.txtVlrBaseICMSST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrBaseICMSST.Properties.Mask.EditMask = "c";
			this.txtVlrBaseICMSST.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrBaseICMSST.Size = new System.Drawing.Size(100, 20);
			this.txtVlrBaseICMSST.TabIndex = 37;
			// 
			// labelControl18
			// 
			this.labelControl18.Location = new System.Drawing.Point(479, 9);
			this.labelControl18.Name = "labelControl18";
			this.labelControl18.Size = new System.Drawing.Size(48, 13);
			this.labelControl18.TabIndex = 36;
			this.labelControl18.Text = "Vlr. ICMS:";
			// 
			// txtVlrICMS
			// 
			this.txtVlrICMS.EnterMoveNextControl = true;
			this.txtVlrICMS.Location = new System.Drawing.Point(551, 6);
			this.txtVlrICMS.Name = "txtVlrICMS";
			this.txtVlrICMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrICMS.Properties.Mask.EditMask = "c";
			this.txtVlrICMS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrICMS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrICMS.TabIndex = 35;
			// 
			// labelControl17
			// 
			this.labelControl17.Location = new System.Drawing.Point(252, 9);
			this.labelControl17.Name = "labelControl17";
			this.labelControl17.Size = new System.Drawing.Size(76, 13);
			this.labelControl17.TabIndex = 34;
			this.labelControl17.Text = "Vlr. Perc. ICMS:";
			// 
			// txtVlrPercICMS
			// 
			this.txtVlrPercICMS.EnterMoveNextControl = true;
			this.txtVlrPercICMS.Location = new System.Drawing.Point(350, 6);
			this.txtVlrPercICMS.Name = "txtVlrPercICMS";
			this.txtVlrPercICMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrPercICMS.Properties.Mask.EditMask = "c";
			this.txtVlrPercICMS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrPercICMS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrPercICMS.TabIndex = 33;
			// 
			// labelControl16
			// 
			this.labelControl16.Location = new System.Drawing.Point(10, 9);
			this.labelControl16.Name = "labelControl16";
			this.labelControl16.Size = new System.Drawing.Size(74, 13);
			this.labelControl16.TabIndex = 32;
			this.labelControl16.Text = "Vlr. Base ICMS:";
			// 
			// txtVlrBaseICMS
			// 
			this.txtVlrBaseICMS.EnterMoveNextControl = true;
			this.txtVlrBaseICMS.Location = new System.Drawing.Point(109, 6);
			this.txtVlrBaseICMS.Name = "txtVlrBaseICMS";
			this.txtVlrBaseICMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrBaseICMS.Properties.Mask.EditMask = "c";
			this.txtVlrBaseICMS.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrBaseICMS.Size = new System.Drawing.Size(100, 20);
			this.txtVlrBaseICMS.TabIndex = 31;
			// 
			// cmbFornecedor
			// 
			this.cmbFornecedor.EnterMoveNextControl = true;
			this.cmbFornecedor.Location = new System.Drawing.Point(569, 49);
			this.cmbFornecedor.Name = "cmbFornecedor";
			this.cmbFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbFornecedor.Properties.DisplayMember = "Fornecedor";
			this.cmbFornecedor.Properties.NullText = "Selecione um fornecedor";
			this.cmbFornecedor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cmbFornecedor.Properties.ValueMember = "Fornecedor";
			this.cmbFornecedor.Size = new System.Drawing.Size(142, 20);
			this.cmbFornecedor.TabIndex = 23;
			// 
			// labelControl10
			// 
			this.labelControl10.Location = new System.Drawing.Point(504, 52);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(59, 13);
			this.labelControl10.TabIndex = 29;
			this.labelControl10.Text = "Fornecedor:";
			// 
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.btnImportarXML);
			this.groupControl1.Controls.Add(this.labelControl12);
			this.groupControl1.Controls.Add(this.txtArquivoXML);
			this.groupControl1.Controls.Add(this.labelControl11);
			this.groupControl1.Controls.Add(this.btnCarregarNF);
			this.groupControl1.Controls.Add(this.txtNumChave);
			this.groupControl1.Location = new System.Drawing.Point(12, 393);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(499, 73);
			this.groupControl1.TabIndex = 32;
			this.groupControl1.Text = "Importar NF";
			// 
			// btnImportarXML
			// 
			this.btnImportarXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportarXML.Location = new System.Drawing.Point(418, 47);
			this.btnImportarXML.Name = "btnImportarXML";
			this.btnImportarXML.Size = new System.Drawing.Size(75, 23);
			this.btnImportarXML.TabIndex = 36;
			this.btnImportarXML.Text = "Importar...";
			this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
			// 
			// labelControl12
			// 
			this.labelControl12.Location = new System.Drawing.Point(16, 52);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(101, 13);
			this.labelControl12.TabIndex = 35;
			this.labelControl12.Text = "Importar de Arquivo:";
			// 
			// txtArquivoXML
			// 
			this.txtArquivoXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArquivoXML.Location = new System.Drawing.Point(123, 49);
			this.txtArquivoXML.Name = "txtArquivoXML";
			this.txtArquivoXML.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.txtArquivoXML.Size = new System.Drawing.Size(289, 20);
			this.txtArquivoXML.TabIndex = 34;
			this.txtArquivoXML.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtArquivoXML_ButtonClick);
			// 
			// labelControl11
			// 
			this.labelControl11.Location = new System.Drawing.Point(31, 26);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(86, 13);
			this.labelControl11.TabIndex = 33;
			this.labelControl11.Text = "Chave de acesso:";
			// 
			// btnCarregarNF
			// 
			this.btnCarregarNF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCarregarNF.Location = new System.Drawing.Point(418, 21);
			this.btnCarregarNF.Name = "btnCarregarNF";
			this.btnCarregarNF.Size = new System.Drawing.Size(75, 23);
			this.btnCarregarNF.TabIndex = 32;
			this.btnCarregarNF.Text = "Carregar...";
			this.btnCarregarNF.Click += new System.EventHandler(this.btnCarregarNF_Click);
			// 
			// txtNumChave
			// 
			this.txtNumChave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumChave.EditValue = "";
			this.txtNumChave.Location = new System.Drawing.Point(123, 23);
			this.txtNumChave.Name = "txtNumChave";
			this.txtNumChave.Size = new System.Drawing.Size(289, 20);
			this.txtNumChave.TabIndex = 31;
			// 
			// groupControl2
			// 
			this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl2.Controls.Add(this.cmbFornecedor);
			this.groupControl2.Controls.Add(this.labelControl10);
			this.groupControl2.Controls.Add(this.txtNome);
			this.groupControl2.Controls.Add(this.labelControl15);
			this.groupControl2.Controls.Add(this.txtNumCNPJ);
			this.groupControl2.Controls.Add(this.labelControl14);
			this.groupControl2.Controls.Add(this.txtSerieNota);
			this.groupControl2.Controls.Add(this.labelControl13);
			this.groupControl2.Controls.Add(this.labelControl7);
			this.groupControl2.Controls.Add(this.txtDocEntrada);
			this.groupControl2.Controls.Add(this.txtDatEmissao);
			this.groupControl2.Controls.Add(this.cmbTipoEntrada);
			this.groupControl2.Controls.Add(this.labelControl1);
			this.groupControl2.Controls.Add(this.labelControl2);
			this.groupControl2.Location = new System.Drawing.Point(12, 12);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(725, 78);
			this.groupControl2.TabIndex = 33;
			this.groupControl2.Text = "Capa da Nota";
			// 
			// txtNome
			// 
			this.txtNome.EnterMoveNextControl = true;
			this.txtNome.Location = new System.Drawing.Point(357, 49);
			this.txtNome.Name = "txtNome";
			this.txtNome.Properties.MaxLength = 50;
			this.txtNome.Size = new System.Drawing.Size(120, 20);
			this.txtNome.TabIndex = 29;
			// 
			// labelControl15
			// 
			this.labelControl15.Location = new System.Drawing.Point(276, 52);
			this.labelControl15.Name = "labelControl15";
			this.labelControl15.Size = new System.Drawing.Size(75, 13);
			this.labelControl15.TabIndex = 30;
			this.labelControl15.Text = "Nome Empresa:";
			// 
			// txtNumCNPJ
			// 
			this.txtNumCNPJ.EditValue = "";
			this.txtNumCNPJ.EnterMoveNextControl = true;
			this.txtNumCNPJ.Location = new System.Drawing.Point(82, 49);
			this.txtNumCNPJ.Name = "txtNumCNPJ";
			this.txtNumCNPJ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumCNPJ.Properties.Appearance.Options.UseFont = true;
			this.txtNumCNPJ.Properties.Mask.EditMask = "([0-9]{3}[\\.][0-9]{3}[\\.][0-9]{3}[-][0-9]{2})|([0-9]{2}[\\.][0-9]{3}[\\.][0-9]{3}[\\" +
    "/][0-9]{4}[-][0-9]{2})";
			this.txtNumCNPJ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.txtNumCNPJ.Properties.MaxLength = 14;
			this.txtNumCNPJ.Size = new System.Drawing.Size(177, 20);
			this.txtNumCNPJ.TabIndex = 27;
			// 
			// labelControl14
			// 
			this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl14.Location = new System.Drawing.Point(47, 52);
			this.labelControl14.Name = "labelControl14";
			this.labelControl14.Size = new System.Drawing.Size(29, 13);
			this.labelControl14.TabIndex = 28;
			this.labelControl14.Text = "CNPJ:";
			// 
			// txtSerieNota
			// 
			this.txtSerieNota.EnterMoveNextControl = true;
			this.txtSerieNota.Location = new System.Drawing.Point(218, 23);
			this.txtSerieNota.Name = "txtSerieNota";
			this.txtSerieNota.Properties.MaxLength = 5;
			this.txtSerieNota.Size = new System.Drawing.Size(41, 20);
			this.txtSerieNota.TabIndex = 25;
			// 
			// labelControl13
			// 
			this.labelControl13.Location = new System.Drawing.Point(184, 26);
			this.labelControl13.Name = "labelControl13";
			this.labelControl13.Size = new System.Drawing.Size(28, 13);
			this.labelControl13.TabIndex = 26;
			this.labelControl13.Text = "Série:";
			// 
			// btnIncluir
			// 
			this.btnIncluir.Location = new System.Drawing.Point(657, 239);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 34;
			this.btnIncluir.Text = "&Incluir Item";
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// btnExcluirItem
			// 
			this.btnExcluirItem.Location = new System.Drawing.Point(576, 239);
			this.btnExcluirItem.Name = "btnExcluirItem";
			this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
			this.btnExcluirItem.TabIndex = 35;
			this.btnExcluirItem.Text = "&Excluir Item";
			this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
			// 
			// btnAlterarItem
			// 
			this.btnAlterarItem.Location = new System.Drawing.Point(495, 239);
			this.btnAlterarItem.Name = "btnAlterarItem";
			this.btnAlterarItem.Size = new System.Drawing.Size(75, 23);
			this.btnAlterarItem.TabIndex = 36;
			this.btnAlterarItem.Text = "&Alterar Item";
			// 
			// frmEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnRetornar;
			this.ClientSize = new System.Drawing.Size(749, 475);
			this.Controls.Add(this.btnAlterarItem);
			this.Controls.Add(this.btnExcluirItem);
			this.Controls.Add(this.btnIncluir);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.xtraTabControl1);
			this.Controls.Add(this.grdDados);
			this.Controls.Add(this.chkContinuar);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.btnRetornar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmEntrada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Entrada de Produtos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmEntrada_Load);
			((System.ComponentModel.ISupportInitialize)(this.lueProdutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDocEntrada.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatEmissao.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatEmissao.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipoEntrada.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkContinuar.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.tabDados.ResumeLayout(false);
			this.tabDados.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNumOrdem.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnidade.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCodProduto.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrFinal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbProduto.Properties)).EndInit();
			this.tabImpostos.ResumeLayout(false);
			this.tabImpostos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrCOFINS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercCOFINS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseCOFINS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPIS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercPIS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBasePIS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrICMSST.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercICMSST.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMSST.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrICMS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrPercICMS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtArquivoXML.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumChave.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			this.groupControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCNPJ.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSerieNota.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDocEntrada;
		private DevExpress.XtraEditors.DateEdit txtDatEmissao;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoEntrada;
        private DevExpress.XtraEditors.SimpleButton btnRetornar;
        private DevExpress.XtraEditors.SimpleButton btnGravar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.CheckEdit chkContinuar;
        private DevExpress.XtraGrid.GridControl grdDados;
		private DevExpress.XtraGrid.Views.Grid.GridView gridDados;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colCodigounico;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDados;
		private DevExpress.XtraEditors.LookUpEdit cmbFornecedor;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.LookUpEdit cmbCodProduto;
		private DevExpress.XtraEditors.CalcEdit txtVlrFinal;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.CalcEdit txtPercentual;
		private DevExpress.XtraEditors.CalcEdit txtVlrTotal;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.CalcEdit txtVlrUnitario;
		private DevExpress.XtraEditors.CalcEdit txtQuantidade;
		private DevExpress.XtraEditors.LookUpEdit cmbProduto;
		private DevExpress.XtraTab.XtraTabPage tabImpostos;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnImportarXML;
		private DevExpress.XtraEditors.LabelControl labelControl12;
		private DevExpress.XtraEditors.ButtonEdit txtArquivoXML;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.SimpleButton btnCarregarNF;
		private DevExpress.XtraEditors.TextEdit txtNumChave;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.TextEdit txtSerieNota;
		private DevExpress.XtraEditors.LabelControl labelControl13;
		private DevExpress.XtraEditors.TextEdit txtNome;
		private DevExpress.XtraEditors.LabelControl labelControl15;
		private DevExpress.XtraEditors.TextEdit txtNumCNPJ;
		private DevExpress.XtraEditors.LabelControl labelControl14;
		private DevExpress.XtraEditors.LabelControl labelControl25;
		private DevExpress.XtraEditors.CalcEdit txtVlrCOFINS;
		private DevExpress.XtraEditors.LabelControl labelControl26;
		private DevExpress.XtraEditors.CalcEdit txtVlrPercCOFINS;
		private DevExpress.XtraEditors.LabelControl labelControl27;
		private DevExpress.XtraEditors.CalcEdit txtVlrBaseCOFINS;
		private DevExpress.XtraEditors.LabelControl labelControl22;
		private DevExpress.XtraEditors.CalcEdit txtVlrPIS;
		private DevExpress.XtraEditors.LabelControl labelControl23;
		private DevExpress.XtraEditors.CalcEdit txtVlrPercPIS;
		private DevExpress.XtraEditors.LabelControl labelControl24;
		private DevExpress.XtraEditors.CalcEdit txtVlrBasePIS;
		private DevExpress.XtraEditors.LabelControl labelControl19;
		private DevExpress.XtraEditors.CalcEdit txtVlrICMSST;
		private DevExpress.XtraEditors.LabelControl labelControl20;
		private DevExpress.XtraEditors.CalcEdit txtVlrPercICMSST;
		private DevExpress.XtraEditors.LabelControl labelControl21;
		private DevExpress.XtraEditors.CalcEdit txtVlrBaseICMSST;
		private DevExpress.XtraEditors.LabelControl labelControl18;
		private DevExpress.XtraEditors.CalcEdit txtVlrICMS;
		private DevExpress.XtraEditors.LabelControl labelControl17;
		private DevExpress.XtraEditors.CalcEdit txtVlrPercICMS;
		private DevExpress.XtraEditors.LabelControl labelControl16;
		private DevExpress.XtraEditors.CalcEdit txtVlrBaseICMS;
		private DevExpress.XtraEditors.TextEdit txtNCM;
		private DevExpress.XtraEditors.LabelControl labelControl29;
		private DevExpress.XtraEditors.TextEdit txtUnidade;
		private DevExpress.XtraEditors.LabelControl labelControl28;
		private DevExpress.XtraEditors.SimpleButton btnIncluir;
		private DevExpress.XtraEditors.SimpleButton btnExcluirItem;
		private DevExpress.XtraEditors.SimpleButton btnAlterarItem;
		private DevExpress.XtraEditors.TextEdit txtNumOrdem;
		private DevExpress.XtraEditors.LabelControl labelControl30;
		private DevExpress.XtraGrid.Columns.GridColumn colUnidade;
		private DevExpress.XtraGrid.Columns.GridColumn colNCM;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrICMS;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrICMSST;
		private DevExpress.XtraGrid.Columns.GridColumn colPIS;
		private DevExpress.XtraGrid.Columns.GridColumn colCOFINS;
		private DevExpress.XtraGrid.Columns.GridColumn colCodOriginal;
		private DevExpress.XtraGrid.Columns.GridColumn colDesOriginal;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lueProdutos;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn lcolCodProduto;
		private DevExpress.XtraGrid.Columns.GridColumn lcolDesProduto;
		private DevExpress.XtraGrid.Columns.GridColumn colPercentual;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
    }
}