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
            this.txtDocEntrada = new DevExpress.XtraEditors.TextEdit();
            this.txtDatEntrada = new DevExpress.XtraEditors.DateEdit();
            this.cmbProduto = new DevExpress.XtraEditors.LookUpEdit();
            this.txtQuantidade = new DevExpress.XtraEditors.CalcEdit();
            this.txtVlrUnitario = new DevExpress.XtraEditors.CalcEdit();
            this.cmbTipoEntrada = new DevExpress.XtraEditors.LookUpEdit();
            this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrTotal = new DevExpress.XtraEditors.CalcEdit();
            this.chkContinuar = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPercentual = new DevExpress.XtraEditors.CalcEdit();
            this.txtVlrFinal = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCodProduto = new DevExpress.XtraEditors.LookUpEdit();
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.gridDados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVlrUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatEntrada.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkContinuar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocEntrada
            // 
            this.txtDocEntrada.EnterMoveNextControl = true;
            this.txtDocEntrada.Location = new System.Drawing.Point(141, 12);
            this.txtDocEntrada.Name = "txtDocEntrada";
            this.txtDocEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDocEntrada.TabIndex = 0;
            this.txtDocEntrada.Validated += new System.EventHandler(this.txtDocEntrada_Validated);
            // 
            // txtDatEntrada
            // 
            this.txtDatEntrada.EditValue = null;
            this.txtDatEntrada.EnterMoveNextControl = true;
            this.txtDatEntrada.Location = new System.Drawing.Point(141, 39);
            this.txtDatEntrada.Name = "txtDatEntrada";
            this.txtDatEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDatEntrada.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDatEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDatEntrada.TabIndex = 1;
            // 
            // cmbProduto
            // 
            this.cmbProduto.EnterMoveNextControl = true;
            this.cmbProduto.Location = new System.Drawing.Point(247, 75);
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
            this.cmbProduto.Size = new System.Drawing.Size(327, 20);
            this.cmbProduto.TabIndex = 12;
            this.cmbProduto.Validated += new System.EventHandler(this.cmbProduto_Validated);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.EnterMoveNextControl = true;
            this.txtQuantidade.Location = new System.Drawing.Point(141, 106);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.EditValueChanged += new System.EventHandler(this.txtQuantidade_EditValueChanged);
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.EnterMoveNextControl = true;
            this.txtVlrUnitario.Location = new System.Drawing.Point(141, 133);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVlrUnitario.Properties.Mask.EditMask = "c";
            this.txtVlrUnitario.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVlrUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtVlrUnitario.TabIndex = 4;
            this.txtVlrUnitario.EditValueChanged += new System.EventHandler(this.txtVlrUnitario_EditValueChanged);
            // 
            // cmbTipoEntrada
            // 
            this.cmbTipoEntrada.EnterMoveNextControl = true;
            this.cmbTipoEntrada.Location = new System.Drawing.Point(141, 185);
            this.cmbTipoEntrada.Name = "cmbTipoEntrada";
            this.cmbTipoEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoEntrada.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodTipoEntrada", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesTipoEntrada", "Descrição")});
            this.cmbTipoEntrada.Properties.DisplayMember = "DesTipoVenda";
            this.cmbTipoEntrada.Properties.NullText = "[Selecione um tipo]";
            this.cmbTipoEntrada.Properties.ValueMember = "CodTipoVenda";
            this.cmbTipoEntrada.Size = new System.Drawing.Size(132, 20);
            this.cmbTipoEntrada.TabIndex = 6;
            this.cmbTipoEntrada.Visible = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRetornar.Location = new System.Drawing.Point(499, 424);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.Text = "&Retornar";
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.Location = new System.Drawing.Point(418, 424);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Nota Fiscal:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Data:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Produto:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Quantidade:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Vlr. Unitário:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(29, 162);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Vlr. Total:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 188);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Tipo de Entrada:";
            this.labelControl7.Visible = false;
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(141, 159);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVlrTotal.Properties.Mask.EditMask = "c";
            this.txtVlrTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVlrTotal.Properties.ReadOnly = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(100, 20);
            this.txtVlrTotal.TabIndex = 17;
            this.txtVlrTotal.TabStop = false;
            // 
            // chkContinuar
            // 
            this.chkContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkContinuar.Location = new System.Drawing.Point(287, 428);
            this.chkContinuar.Name = "chkContinuar";
            this.chkContinuar.Properties.Caption = "Fechar ao gravar";
            this.chkContinuar.Size = new System.Drawing.Size(125, 19);
            this.chkContinuar.TabIndex = 21;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(258, 136);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Percentual:";
            // 
            // txtPercentual
            // 
            this.txtPercentual.EnterMoveNextControl = true;
            this.txtPercentual.Location = new System.Drawing.Point(329, 133);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPercentual.Properties.Mask.EditMask = "P";
            this.txtPercentual.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercentual.Size = new System.Drawing.Size(100, 20);
            this.txtPercentual.TabIndex = 5;
            this.txtPercentual.Validated += new System.EventHandler(this.txtPercentual_Validated);
            // 
            // txtVlrFinal
            // 
            this.txtVlrFinal.Location = new System.Drawing.Point(329, 159);
            this.txtVlrFinal.Name = "txtVlrFinal";
            this.txtVlrFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVlrFinal.Properties.Mask.EditMask = "c";
            this.txtVlrFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVlrFinal.Properties.ReadOnly = true;
            this.txtVlrFinal.Size = new System.Drawing.Size(100, 20);
            this.txtVlrFinal.TabIndex = 19;
            this.txtVlrFinal.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(266, 162);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Vlr. Final:";
            // 
            // cmbCodProduto
            // 
            this.cmbCodProduto.EnterMoveNextControl = true;
            this.cmbCodProduto.Location = new System.Drawing.Point(141, 75);
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
            this.cmbCodProduto.Size = new System.Drawing.Size(100, 20);
            this.cmbCodProduto.TabIndex = 2;
            this.cmbCodProduto.Validated += new System.EventHandler(this.cmbCodProduto_Validated);
            // 
            // grdDados
            // 
            this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDados.Location = new System.Drawing.Point(12, 188);
            this.grdDados.MainView = this.gridDados;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(562, 230);
            this.grdDados.TabIndex = 22;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDados});
            // 
            // gridDados
            // 
            this.gridDados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colData,
            this.colCodProduto,
            this.colDesProduto,
            this.colVlrUnitario,
            this.colQuantidade,
            this.colVlrFinal,
            this.colCodigounico,
            this.colDocEntrada});
            this.gridDados.GridControl = this.grdDados;
            this.gridDados.GroupPanelText = "Arraste uma coluna aqui para agrupar";
            this.gridDados.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "DatSaida", this.colData, "")});
            this.gridDados.Name = "gridDados";
            this.gridDados.OptionsView.ShowFooter = true;
            // 
            // colData
            // 
            this.colData.Caption = "Data";
            this.colData.DisplayFormat.FormatString = "d";
            this.colData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData.FieldName = "DatEntrada";
            this.colData.GroupFormat.FormatString = "d";
            this.colData.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData.Name = "colData";
            this.colData.OptionsColumn.AllowEdit = false;
            this.colData.OptionsColumn.ReadOnly = true;
            this.colData.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 72;
            // 
            // colCodProduto
            // 
            this.colCodProduto.Caption = "Código";
            this.colCodProduto.FieldName = "CodProduto";
            this.colCodProduto.Name = "colCodProduto";
            this.colCodProduto.Visible = true;
            this.colCodProduto.VisibleIndex = 1;
            this.colCodProduto.Width = 117;
            // 
            // colDesProduto
            // 
            this.colDesProduto.Caption = "Descrição";
            this.colDesProduto.FieldName = "DesProduto";
            this.colDesProduto.Name = "colDesProduto";
            this.colDesProduto.Visible = true;
            this.colDesProduto.VisibleIndex = 2;
            this.colDesProduto.Width = 267;
            // 
            // colVlrUnitario
            // 
            this.colVlrUnitario.Caption = "Vlr. Unit.";
            this.colVlrUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVlrUnitario.FieldName = "VlrUnitario";
            this.colVlrUnitario.Name = "colVlrUnitario";
            this.colVlrUnitario.Visible = true;
            this.colVlrUnitario.VisibleIndex = 3;
            this.colVlrUnitario.Width = 73;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Qtde.";
            this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidade.FieldName = "QtdProduto";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 4;
            this.colQuantidade.Width = 49;
            // 
            // colVlrFinal
            // 
            this.colVlrFinal.Caption = "Vlr. Final";
            this.colVlrFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVlrFinal.FieldName = "VlrTotal";
            this.colVlrFinal.Name = "colVlrFinal";
            this.colVlrFinal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colVlrFinal.Visible = true;
            this.colVlrFinal.VisibleIndex = 5;
            this.colVlrFinal.Width = 70;
            // 
            // colCodigounico
            // 
            this.colCodigounico.Caption = "Código Único";
            this.colCodigounico.FieldName = "codigounico";
            this.colCodigounico.Name = "colCodigounico";
            // 
            // colDocEntrada
            // 
            this.colDocEntrada.Caption = "Documento";
            this.colDocEntrada.FieldName = "DocEntrada";
            this.colDocEntrada.Name = "colDocEntrada";
            this.colDocEntrada.Visible = true;
            this.colDocEntrada.VisibleIndex = 6;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.EnterMoveNextControl = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(329, 104);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFornecedor.Properties.DisplayMember = "Fornecedor";
            this.cmbFornecedor.Properties.NullText = "Selecione um fornecedor";
            this.cmbFornecedor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbFornecedor.Properties.ValueMember = "Fornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(245, 20);
            this.cmbFornecedor.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(252, 107);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(59, 13);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Fornecedor:";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRetornar;
            this.ClientSize = new System.Drawing.Size(586, 459);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.grdDados);
            this.Controls.Add(this.cmbCodProduto);
            this.Controls.Add(this.txtVlrFinal);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.chkContinuar);
            this.Controls.Add(this.txtVlrTotal);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cmbTipoEntrada);
            this.Controls.Add(this.txtVlrUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.txtDatEntrada);
            this.Controls.Add(this.txtDocEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produtos";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatEntrada.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkContinuar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDocEntrada;
        private DevExpress.XtraEditors.DateEdit txtDatEntrada;
        private DevExpress.XtraEditors.LookUpEdit cmbProduto;
        private DevExpress.XtraEditors.CalcEdit txtQuantidade;
        private DevExpress.XtraEditors.CalcEdit txtVlrUnitario;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoEntrada;
        private DevExpress.XtraEditors.SimpleButton btnRetornar;
        private DevExpress.XtraEditors.SimpleButton btnGravar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit txtVlrTotal;
        private DevExpress.XtraEditors.CheckEdit chkContinuar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CalcEdit txtPercentual;
        private DevExpress.XtraEditors.CalcEdit txtVlrFinal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit cmbCodProduto;
        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDados;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigounico;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntrada;
        private DevExpress.XtraEditors.LookUpEdit cmbFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}