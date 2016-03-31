namespace Loja
{
    partial class frmVenda
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
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txtNome = new DevExpress.XtraEditors.TextEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.boxEnviando = new DevExpress.XtraEditors.PopupContainerControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.progressoNota = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.txtVlrTotal = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.cmbCliente = new DevExpress.XtraEditors.LookUpEdit();
			this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
			this.txtNumCPF = new DevExpress.XtraEditors.TextEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.cmbTipoDesconto = new DevExpress.XtraEditors.ComboBoxEdit();
			this.chkNFE = new DevExpress.XtraEditors.CheckEdit();
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.btnAplicarDesconto = new DevExpress.XtraEditors.SimpleButton();
			this.txtTroco = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtDinheiro = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtVlrFinal = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.cmbTipoVenda = new DevExpress.XtraEditors.LookUpEdit();
			this.btnFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
			this.chkApagarOrca = new DevExpress.XtraEditors.CheckEdit();
			this.chkEmitirRecibo = new DevExpress.XtraEditors.CheckEdit();
			this.txtDesconto = new DevExpress.XtraEditors.CalcEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridOrcamento = new DevExpress.XtraGrid.GridControl();
			this.gridViewOrcamento = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOrCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrBruto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrCusto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.boxEnviando)).BeginInit();
			this.boxEnviando.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressoNota.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCliente.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCPF.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipoDesconto.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkNFE.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDinheiro.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrFinal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipoVenda.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkApagarOrca.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEmitirRecibo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewOrcamento)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.labelControl10);
			this.groupControl1.Controls.Add(this.txtNome);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.boxEnviando);
			this.groupControl1.Controls.Add(this.txtVlrTotal);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.cmbCliente);
			this.groupControl1.Controls.Add(this.btnCliente);
			this.groupControl1.Controls.Add(this.txtNumCPF);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.cmbTipoDesconto);
			this.groupControl1.Controls.Add(this.chkNFE);
			this.groupControl1.Controls.Add(this.btnCancelar);
			this.groupControl1.Controls.Add(this.btnAplicarDesconto);
			this.groupControl1.Controls.Add(this.txtTroco);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.txtDinheiro);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.txtVlrFinal);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.cmbTipoVenda);
			this.groupControl1.Controls.Add(this.btnFinalizarVenda);
			this.groupControl1.Controls.Add(this.chkApagarOrca);
			this.groupControl1.Controls.Add(this.chkEmitirRecibo);
			this.groupControl1.Controls.Add(this.txtDesconto);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(12, 149);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(707, 330);
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "Dados da Venda";
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl10.Location = new System.Drawing.Point(354, 68);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(53, 19);
			this.labelControl10.TabIndex = 29;
			this.labelControl10.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.EditValue = "";
			this.txtNome.EnterMoveNextControl = true;
			this.txtNome.Location = new System.Drawing.Point(413, 62);
			this.txtNome.Name = "txtNome";
			this.txtNome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Properties.Appearance.Options.UseFont = true;
			this.txtNome.Properties.Mask.EditMask = "([0-9]{2}[\\.][0-9]{3}[\\.][0-9]{3}[\\/][0-9]{4}[-][0-9]{2})|([0-9]{3}[\\.][0-9]{3}[\\" +
    ".][0-9]{3}[-][0-9]{2})";
			this.txtNome.Size = new System.Drawing.Size(246, 30);
			this.txtNome.TabIndex = 2;
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl9.Location = new System.Drawing.Point(47, 68);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(88, 19);
			this.labelControl9.TabIndex = 27;
			this.labelControl9.Text = "CPF/CNPJ:";
			// 
			// boxEnviando
			// 
			this.boxEnviando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.boxEnviando.Controls.Add(this.labelControl8);
			this.boxEnviando.Controls.Add(this.progressoNota);
			this.boxEnviando.Location = new System.Drawing.Point(445, 101);
			this.boxEnviando.Name = "boxEnviando";
			this.boxEnviando.Size = new System.Drawing.Size(252, 51);
			this.boxEnviando.TabIndex = 26;
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(6, 4);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(81, 13);
			this.labelControl8.TabIndex = 27;
			this.labelControl8.Text = "Enviando nota...";
			// 
			// progressoNota
			// 
			this.progressoNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressoNota.EditValue = 0;
			this.progressoNota.Location = new System.Drawing.Point(6, 23);
			this.progressoNota.Name = "progressoNota";
			this.progressoNota.Size = new System.Drawing.Size(241, 24);
			this.progressoNota.TabIndex = 26;
			// 
			// txtVlrTotal
			// 
			this.txtVlrTotal.EnterMoveNextControl = true;
			this.txtVlrTotal.Location = new System.Drawing.Point(205, 134);
			this.txtVlrTotal.Name = "txtVlrTotal";
			this.txtVlrTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVlrTotal.Properties.Appearance.Options.UseFont = true;
			this.txtVlrTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtVlrTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtVlrTotal.Properties.Mask.EditMask = "c2";
			this.txtVlrTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrTotal.Size = new System.Drawing.Size(234, 30);
			this.txtVlrTotal.TabIndex = 4;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Location = new System.Drawing.Point(38, 140);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(97, 19);
			this.labelControl7.TabIndex = 23;
			this.labelControl7.Text = "Valor Total:";
			// 
			// cmbCliente
			// 
			this.cmbCliente.EnterMoveNextControl = true;
			this.cmbCliente.Location = new System.Drawing.Point(150, 26);
			this.cmbCliente.Name = "cmbCliente";
			this.cmbCliente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.cmbCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCliente.Properties.Appearance.Options.UseFont = true;
			this.cmbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomCliente", "Nome"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumCPF", "CPF"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumCNPJ", "CNPJ")});
			this.cmbCliente.Properties.DisplayMember = "NomCliente";
			this.cmbCliente.Properties.NullText = "Selecione um cliente";
			this.cmbCliente.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
			this.cmbCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cmbCliente.Properties.ValueMember = "CodCliente";
			this.cmbCliente.Size = new System.Drawing.Size(386, 30);
			this.cmbCliente.TabIndex = 0;
			this.cmbCliente.EditValueChanged += new System.EventHandler(this.cmbCliente_EditValueChanged);
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(542, 24);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(117, 33);
			this.btnCliente.TabIndex = 19;
			this.btnCliente.Text = "Cadastro de Clientes";
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// txtNumCPF
			// 
			this.txtNumCPF.EditValue = "";
			this.txtNumCPF.EnterMoveNextControl = true;
			this.txtNumCPF.Location = new System.Drawing.Point(150, 62);
			this.txtNumCPF.Name = "txtNumCPF";
			this.txtNumCPF.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumCPF.Properties.Appearance.Options.UseFont = true;
			this.txtNumCPF.Properties.Mask.EditMask = "([0-9]{2}[\\.][0-9]{3}[\\.][0-9]{3}[\\/][0-9]{4}[-][0-9]{2})|([0-9]{3}[\\.][0-9]{3}[\\" +
    ".][0-9]{3}[-][0-9]{2})";
			this.txtNumCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.txtNumCPF.Size = new System.Drawing.Size(177, 30);
			this.txtNumCPF.TabIndex = 1;
			this.txtNumCPF.EditValueChanged += new System.EventHandler(this.txtNumCPF_EditValueChanged);
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Location = new System.Drawing.Point(71, 29);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(64, 19);
			this.labelControl6.TabIndex = 17;
			this.labelControl6.Text = "Cliente:";
			// 
			// cmbTipoDesconto
			// 
			this.cmbTipoDesconto.EditValue = "R$";
			this.cmbTipoDesconto.Location = new System.Drawing.Point(311, 172);
			this.cmbTipoDesconto.Name = "cmbTipoDesconto";
			this.cmbTipoDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoDesconto.Properties.Appearance.Options.UseFont = true;
			this.cmbTipoDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbTipoDesconto.Properties.Items.AddRange(new object[] {
            "R$",
            "%"});
			this.cmbTipoDesconto.Size = new System.Drawing.Size(57, 30);
			this.cmbTipoDesconto.TabIndex = 6;
			// 
			// chkNFE
			// 
			this.chkNFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkNFE.EditValue = true;
			this.chkNFE.Location = new System.Drawing.Point(619, 209);
			this.chkNFE.Name = "chkNFE";
			this.chkNFE.Properties.Caption = "Emitir NFC-e";
			this.chkNFE.Size = new System.Drawing.Size(83, 19);
			this.chkNFE.TabIndex = 15;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Location = new System.Drawing.Point(591, 283);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(111, 42);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAplicarDesconto
			// 
			this.btnAplicarDesconto.Location = new System.Drawing.Point(384, 170);
			this.btnAplicarDesconto.Name = "btnAplicarDesconto";
			this.btnAplicarDesconto.Size = new System.Drawing.Size(55, 32);
			this.btnAplicarDesconto.TabIndex = 7;
			this.btnAplicarDesconto.Text = "&Aplicar";
			this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
			// 
			// txtTroco
			// 
			this.txtTroco.EnterMoveNextControl = true;
			this.txtTroco.Location = new System.Drawing.Point(205, 280);
			this.txtTroco.Name = "txtTroco";
			this.txtTroco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTroco.Properties.Appearance.Options.UseFont = true;
			this.txtTroco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTroco.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTroco.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTroco.Properties.Mask.EditMask = "c2";
			this.txtTroco.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtTroco.Size = new System.Drawing.Size(234, 30);
			this.txtTroco.TabIndex = 10;
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Location = new System.Drawing.Point(83, 286);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(52, 19);
			this.labelControl5.TabIndex = 12;
			this.labelControl5.Text = "Troco:";
			// 
			// txtDinheiro
			// 
			this.txtDinheiro.EnterMoveNextControl = true;
			this.txtDinheiro.Location = new System.Drawing.Point(205, 244);
			this.txtDinheiro.Name = "txtDinheiro";
			this.txtDinheiro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDinheiro.Properties.Appearance.Options.UseFont = true;
			this.txtDinheiro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDinheiro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtDinheiro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtDinheiro.Properties.Mask.EditMask = "c2";
			this.txtDinheiro.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtDinheiro.Size = new System.Drawing.Size(234, 30);
			this.txtDinheiro.TabIndex = 9;
			this.txtDinheiro.Validated += new System.EventHandler(this.txtDinheiro_Validated);
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Location = new System.Drawing.Point(60, 250);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(75, 19);
			this.labelControl4.TabIndex = 10;
			this.labelControl4.Text = "Dinheiro:";
			// 
			// txtVlrFinal
			// 
			this.txtVlrFinal.EnterMoveNextControl = true;
			this.txtVlrFinal.Location = new System.Drawing.Point(205, 208);
			this.txtVlrFinal.Name = "txtVlrFinal";
			this.txtVlrFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVlrFinal.Properties.Appearance.Options.UseFont = true;
			this.txtVlrFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtVlrFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtVlrFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtVlrFinal.Properties.Mask.EditMask = "c2";
			this.txtVlrFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtVlrFinal.Size = new System.Drawing.Size(234, 30);
			this.txtVlrFinal.TabIndex = 8;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Location = new System.Drawing.Point(38, 214);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(93, 19);
			this.labelControl3.TabIndex = 8;
			this.labelControl3.Text = "Valor Final:";
			// 
			// cmbTipoVenda
			// 
			this.cmbTipoVenda.EnterMoveNextControl = true;
			this.cmbTipoVenda.Location = new System.Drawing.Point(150, 98);
			this.cmbTipoVenda.Name = "cmbTipoVenda";
			this.cmbTipoVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoVenda.Properties.Appearance.Options.UseFont = true;
			this.cmbTipoVenda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbTipoVenda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", 70, "Descrição")});
			this.cmbTipoVenda.Properties.DisplayMember = "Descricao";
			this.cmbTipoVenda.Properties.ImmediatePopup = true;
			this.cmbTipoVenda.Properties.NullText = "";
			this.cmbTipoVenda.Properties.ValueMember = "Codigo";
			this.cmbTipoVenda.Size = new System.Drawing.Size(289, 30);
			this.cmbTipoVenda.TabIndex = 3;
			// 
			// btnFinalizarVenda
			// 
			this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinalizarVenda.Location = new System.Drawing.Point(591, 235);
			this.btnFinalizarVenda.Name = "btnFinalizarVenda";
			this.btnFinalizarVenda.Size = new System.Drawing.Size(111, 42);
			this.btnFinalizarVenda.TabIndex = 11;
			this.btnFinalizarVenda.Text = "Finalizar Venda";
			this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
			// 
			// chkApagarOrca
			// 
			this.chkApagarOrca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkApagarOrca.EditValue = true;
			this.chkApagarOrca.Location = new System.Drawing.Point(577, 184);
			this.chkApagarOrca.Name = "chkApagarOrca";
			this.chkApagarOrca.Properties.Caption = "Descartar Orçamento";
			this.chkApagarOrca.Size = new System.Drawing.Size(125, 19);
			this.chkApagarOrca.TabIndex = 7;
			// 
			// chkEmitirRecibo
			// 
			this.chkEmitirRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkEmitirRecibo.Location = new System.Drawing.Point(615, 159);
			this.chkEmitirRecibo.Name = "chkEmitirRecibo";
			this.chkEmitirRecibo.Properties.Caption = "Emitir Recibo";
			this.chkEmitirRecibo.Size = new System.Drawing.Size(87, 19);
			this.chkEmitirRecibo.TabIndex = 6;
			// 
			// txtDesconto
			// 
			this.txtDesconto.EnterMoveNextControl = true;
			this.txtDesconto.Location = new System.Drawing.Point(205, 172);
			this.txtDesconto.Name = "txtDesconto";
			this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesconto.Properties.Appearance.Options.UseFont = true;
			this.txtDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDesconto.Properties.Mask.EditMask = "n";
			this.txtDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtDesconto.Size = new System.Drawing.Size(100, 30);
			this.txtDesconto.TabIndex = 5;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Location = new System.Drawing.Point(54, 175);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(81, 19);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Desconto:";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Location = new System.Drawing.Point(12, 101);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(125, 19);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Forma de Pgto:";
			// 
			// gridOrcamento
			// 
			this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridOrcamento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridOrcamento.Location = new System.Drawing.Point(0, 0);
			this.gridOrcamento.MainView = this.gridViewOrcamento;
			this.gridOrcamento.Name = "gridOrcamento";
			this.gridOrcamento.Size = new System.Drawing.Size(730, 143);
			this.gridOrcamento.TabIndex = 0;
			this.gridOrcamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrcamento});
			// 
			// gridViewOrcamento
			// 
			this.gridViewOrcamento.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewOrcamento.Appearance.FooterPanel.Options.UseFont = true;
			this.gridViewOrcamento.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewOrcamento.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridViewOrcamento.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewOrcamento.Appearance.Row.Options.UseFont = true;
			this.gridViewOrcamento.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
			this.gridViewOrcamento.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White;
			this.gridViewOrcamento.Appearance.SelectedRow.Options.UseBackColor = true;
			this.gridViewOrcamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrCodProduto,
            this.colOrDesProduto,
            this.colQuantidade,
            this.colValor,
            this.colVlrBruto,
            this.colVlrDesconto,
            this.colVlrFinal,
            this.colVlrCusto,
            this.colCodigounico});
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
			this.colOrCodProduto.Width = 110;
			// 
			// colOrDesProduto
			// 
			this.colOrDesProduto.Caption = "Descrição";
			this.colOrDesProduto.FieldName = "DescProduto";
			this.colOrDesProduto.Name = "colOrDesProduto";
			this.colOrDesProduto.OptionsColumn.AllowEdit = false;
			this.colOrDesProduto.Visible = true;
			this.colOrDesProduto.VisibleIndex = 1;
			this.colOrDesProduto.Width = 262;
			// 
			// colQuantidade
			// 
			this.colQuantidade.Caption = "Qtde";
			this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colQuantidade.FieldName = "Quantidade";
			this.colQuantidade.Name = "colQuantidade";
			this.colQuantidade.Visible = true;
			this.colQuantidade.VisibleIndex = 2;
			this.colQuantidade.Width = 55;
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
			this.colValor.Width = 97;
			// 
			// colVlrBruto
			// 
			this.colVlrBruto.Caption = "Vlr. Bruto";
			this.colVlrBruto.FieldName = "VlrBruto";
			this.colVlrBruto.Name = "colVlrBruto";
			this.colVlrBruto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colVlrBruto.Visible = true;
			this.colVlrBruto.VisibleIndex = 4;
			// 
			// colVlrDesconto
			// 
			this.colVlrDesconto.Caption = "Desc.";
			this.colVlrDesconto.FieldName = "VlrDesconto";
			this.colVlrDesconto.Name = "colVlrDesconto";
			this.colVlrDesconto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colVlrDesconto.Visible = true;
			this.colVlrDesconto.VisibleIndex = 5;
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colVlrFinal.Visible = true;
			this.colVlrFinal.VisibleIndex = 6;
			this.colVlrFinal.Width = 107;
			// 
			// colVlrCusto
			// 
			this.colVlrCusto.Caption = "Vlr. Original";
			this.colVlrCusto.FieldName = "VlrCusto";
			this.colVlrCusto.Name = "colVlrCusto";
			this.colVlrCusto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			// 
			// colCodigounico
			// 
			this.colCodigounico.Caption = "Código único";
			this.colCodigounico.FieldName = "codigounico";
			this.colCodigounico.Name = "colCodigounico";
			// 
			// frmVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(731, 491);
			this.Controls.Add(this.gridOrcamento);
			this.Controls.Add(this.groupControl1);
			this.KeyPreview = true;
			this.Name = "frmVenda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Finalizar Venda";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmVenda_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.boxEnviando)).EndInit();
			this.boxEnviando.ResumeLayout(false);
			this.boxEnviando.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressoNota.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCliente.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCPF.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipoDesconto.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkNFE.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDinheiro.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVlrFinal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipoVenda.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkApagarOrca.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEmitirRecibo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewOrcamento)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit txtDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFinalizarVenda;
        private DevExpress.XtraEditors.CheckEdit chkApagarOrca;
        private DevExpress.XtraEditors.CheckEdit chkEmitirRecibo;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoVenda;
        private DevExpress.XtraEditors.CalcEdit txtVlrFinal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit txtTroco;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CalcEdit txtDinheiro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridOrcamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrcamento;
        private DevExpress.XtraGrid.Columns.GridColumn colOrCodProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colOrDesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
        private DevExpress.XtraEditors.SimpleButton btnAplicarDesconto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigounico;
		private DevExpress.XtraEditors.CheckEdit chkNFE;
		private DevExpress.XtraEditors.ComboBoxEdit cmbTipoDesconto;
		private DevExpress.XtraEditors.TextEdit txtNumCPF;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LookUpEdit cmbCliente;
		private DevExpress.XtraEditors.SimpleButton btnCliente;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrCusto;
		private DevExpress.XtraEditors.CalcEdit txtVlrTotal;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrDesconto;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrBruto;
		private DevExpress.XtraEditors.PopupContainerControl boxEnviando;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.MarqueeProgressBarControl progressoNota;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.TextEdit txtNome;
		private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}