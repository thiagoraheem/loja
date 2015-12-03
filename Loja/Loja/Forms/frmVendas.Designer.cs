namespace Loja
{
	partial class frmVendas
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
			this.grdItens = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCodigoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrBruto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdDados = new DevExpress.XtraGrid.GridControl();
			this.relVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.relVendas = new Loja.relVendas();
			this.gridDados = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodVenda = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtdeItens = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFlgStatusNFE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.cmbStatusNFE = new DevExpress.XtraEditors.ComboBoxEdit();
			this.btnImprimirResumo = new DevExpress.XtraEditors.SimpleButton();
			this.btnReimprimir = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.btnEstornar = new DevExpress.XtraEditors.SimpleButton();
			this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
			this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
			this.txtDatFim = new DevExpress.XtraEditors.DateEdit();
			this.txtDatInicio = new DevExpress.XtraEditors.DateEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
			this.tbl_SaidaTableAdapter1 = new Loja.relVendasTableAdapters.tbl_SaidaTableAdapter();
			this.tbl_SaidaItensTableAdapter1 = new Loja.relVendasTableAdapters.tbl_SaidaItensTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.grdItens)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.relVendasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.relVendas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbStatusNFE.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// grdItens
			// 
			this.grdItens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodProduto,
            this.colCodigoProduto,
            this.colDesProduto,
            this.colQtdProduto,
            this.colVlrUnitario,
            this.colVlrFinal,
            this.colVlrDesconto,
            this.colVlrBruto});
			this.grdItens.GridControl = this.grdDados;
			this.grdItens.Name = "grdItens";
			// 
			// colCodProduto
			// 
			this.colCodProduto.Caption = "Cód. Produto";
			this.colCodProduto.FieldName = "codigounico";
			this.colCodProduto.Name = "colCodProduto";
			// 
			// colCodigoProduto
			// 
			this.colCodigoProduto.Caption = "Código Fabr.";
			this.colCodigoProduto.FieldName = "CodProduto";
			this.colCodigoProduto.Name = "colCodigoProduto";
			this.colCodigoProduto.Visible = true;
			this.colCodigoProduto.VisibleIndex = 0;
			this.colCodigoProduto.Width = 147;
			// 
			// colDesProduto
			// 
			this.colDesProduto.Caption = "Descrição";
			this.colDesProduto.FieldName = "DesProduto";
			this.colDesProduto.Name = "colDesProduto";
			this.colDesProduto.Visible = true;
			this.colDesProduto.VisibleIndex = 1;
			this.colDesProduto.Width = 323;
			// 
			// colQtdProduto
			// 
			this.colQtdProduto.Caption = "Qtde.";
			this.colQtdProduto.FieldName = "Quantidade";
			this.colQtdProduto.Name = "colQtdProduto";
			this.colQtdProduto.Visible = true;
			this.colQtdProduto.VisibleIndex = 2;
			this.colQtdProduto.Width = 43;
			// 
			// colVlrUnitario
			// 
			this.colVlrUnitario.Caption = "Vlr. Unitário";
			this.colVlrUnitario.FieldName = "VlrUnitario";
			this.colVlrUnitario.Name = "colVlrUnitario";
			this.colVlrUnitario.Visible = true;
			this.colVlrUnitario.VisibleIndex = 3;
			this.colVlrUnitario.Width = 120;
			// 
			// colVlrFinal
			// 
			this.colVlrFinal.Caption = "Valor Total";
			this.colVlrFinal.FieldName = "VlrFinal";
			this.colVlrFinal.Name = "colVlrFinal";
			this.colVlrFinal.Visible = true;
			this.colVlrFinal.VisibleIndex = 4;
			this.colVlrFinal.Width = 116;
			// 
			// colVlrDesconto
			// 
			this.colVlrDesconto.Caption = "Desconto";
			this.colVlrDesconto.FieldName = "VlrDesconto";
			this.colVlrDesconto.Name = "colVlrDesconto";
			this.colVlrDesconto.Visible = true;
			this.colVlrDesconto.VisibleIndex = 5;
			this.colVlrDesconto.Width = 107;
			// 
			// colVlrBruto
			// 
			this.colVlrBruto.Caption = "Valor Bruto";
			this.colVlrBruto.FieldName = "VlrBruto";
			this.colVlrBruto.Name = "colVlrBruto";
			this.colVlrBruto.Visible = true;
			this.colVlrBruto.VisibleIndex = 6;
			this.colVlrBruto.Width = 222;
			// 
			// grdDados
			// 
			this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdDados.DataMember = "tbl_Saida";
			this.grdDados.DataSource = this.relVendasBindingSource;
			gridLevelNode2.LevelTemplate = this.grdItens;
			gridLevelNode2.RelationName = "FK_tbl_SaidaItens_tbl_Saida";
			this.grdDados.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
			this.grdDados.Location = new System.Drawing.Point(12, 12);
			this.grdDados.MainView = this.gridDados;
			this.grdDados.Name = "grdDados";
			this.grdDados.Size = new System.Drawing.Size(666, 283);
			this.grdDados.TabIndex = 1;
			this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDados,
            this.grdItens});
			// 
			// relVendasBindingSource
			// 
			this.relVendasBindingSource.DataSource = this.relVendas;
			this.relVendasBindingSource.Position = 0;
			// 
			// relVendas
			// 
			this.relVendas.DataSetName = "relVendas";
			this.relVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridDados
			// 
			this.gridDados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodVenda,
            this.colData,
            this.colQtdeItens,
            this.colVlrTotal,
            this.colCliente,
            this.colFlgStatusNFE});
			this.gridDados.GridControl = this.grdDados;
			this.gridDados.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "DatSaida", this.colData, "")});
			this.gridDados.Name = "gridDados";
			this.gridDados.OptionsDetail.ShowDetailTabs = false;
			this.gridDados.OptionsView.ShowFooter = true;
			this.gridDados.OptionsView.ShowGroupPanel = false;
			this.gridDados.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
			// 
			// colCodVenda
			// 
			this.colCodVenda.Caption = "NF";
			this.colCodVenda.FieldName = "CodVenda";
			this.colCodVenda.Name = "colCodVenda";
			this.colCodVenda.Visible = true;
			this.colCodVenda.VisibleIndex = 0;
			this.colCodVenda.Width = 84;
			// 
			// colData
			// 
			this.colData.Caption = "Data";
			this.colData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colData.FieldName = "Data";
			this.colData.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colData.Name = "colData";
			this.colData.OptionsColumn.AllowEdit = false;
			this.colData.OptionsColumn.ReadOnly = true;
			this.colData.Visible = true;
			this.colData.VisibleIndex = 1;
			this.colData.Width = 244;
			// 
			// colQtdeItens
			// 
			this.colQtdeItens.Caption = "Qtde. Itens";
			this.colQtdeItens.FieldName = "QtdItens";
			this.colQtdeItens.Name = "colQtdeItens";
			this.colQtdeItens.Visible = true;
			this.colQtdeItens.VisibleIndex = 2;
			this.colQtdeItens.Width = 104;
			// 
			// colVlrTotal
			// 
			this.colVlrTotal.Caption = "Vlr. Total";
			this.colVlrTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colVlrTotal.FieldName = "ValorTotal";
			this.colVlrTotal.Name = "colVlrTotal";
			this.colVlrTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colVlrTotal.Visible = true;
			this.colVlrTotal.VisibleIndex = 3;
			this.colVlrTotal.Width = 308;
			// 
			// colCliente
			// 
			this.colCliente.Caption = "Cliente";
			this.colCliente.FieldName = "NomCliente";
			this.colCliente.Name = "colCliente";
			this.colCliente.Visible = true;
			this.colCliente.VisibleIndex = 4;
			this.colCliente.Width = 338;
			// 
			// colFlgStatusNFE
			// 
			this.colFlgStatusNFE.Caption = "Status";
			this.colFlgStatusNFE.FieldName = "FlgStatusNFE";
			this.colFlgStatusNFE.Name = "colFlgStatusNFE";
			this.colFlgStatusNFE.Visible = true;
			this.colFlgStatusNFE.VisibleIndex = 5;
			// 
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.btnCancelar);
			this.groupControl1.Controls.Add(this.cmbStatusNFE);
			this.groupControl1.Controls.Add(this.btnImprimirResumo);
			this.groupControl1.Controls.Add(this.btnReimprimir);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.btnEstornar);
			this.groupControl1.Controls.Add(this.btnImprimir);
			this.groupControl1.Controls.Add(this.btnConsultar);
			this.groupControl1.Controls.Add(this.txtDatFim);
			this.groupControl1.Controls.Add(this.txtDatInicio);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.btnRetornar);
			this.groupControl1.Location = new System.Drawing.Point(12, 301);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(666, 125);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Opções e Filtros";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Location = new System.Drawing.Point(505, 69);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar &NFE";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// cmbStatusNFE
			// 
			this.cmbStatusNFE.Location = new System.Drawing.Point(243, 43);
			this.cmbStatusNFE.Name = "cmbStatusNFE";
			this.cmbStatusNFE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbStatusNFE.Properties.Items.AddRange(new object[] {
            "E - Emitida",
            "A - Aprovada",
            "C - Contingência",
            "X - Cancelada"});
			this.cmbStatusNFE.Size = new System.Drawing.Size(168, 20);
			this.cmbStatusNFE.TabIndex = 14;
			// 
			// btnImprimirResumo
			// 
			this.btnImprimirResumo.Location = new System.Drawing.Point(119, 69);
			this.btnImprimirResumo.Name = "btnImprimirResumo";
			this.btnImprimirResumo.Size = new System.Drawing.Size(104, 23);
			this.btnImprimirResumo.TabIndex = 13;
			this.btnImprimirResumo.Text = "I&mprimir Resumo";
			this.btnImprimirResumo.Click += new System.EventHandler(this.btnImprimirResumo_Click);
			// 
			// btnReimprimir
			// 
			this.btnReimprimir.Location = new System.Drawing.Point(9, 97);
			this.btnReimprimir.Name = "btnReimprimir";
			this.btnReimprimir.Size = new System.Drawing.Size(102, 23);
			this.btnReimprimir.TabIndex = 12;
			this.btnReimprimir.Text = "Re-Imprimir &DANFE";
			this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(243, 24);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(68, 13);
			this.labelControl3.TabIndex = 11;
			this.labelControl3.Text = "Status da NFE";
			// 
			// btnEstornar
			// 
			this.btnEstornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEstornar.Enabled = false;
			this.btnEstornar.Location = new System.Drawing.Point(505, 97);
			this.btnEstornar.Name = "btnEstornar";
			this.btnEstornar.Size = new System.Drawing.Size(75, 23);
			this.btnEstornar.TabIndex = 8;
			this.btnEstornar.Text = "&Estornar";
			this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(9, 69);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(104, 23);
			this.btnImprimir.TabIndex = 7;
			this.btnImprimir.Text = "&Imprimir Relatório";
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConsultar.Location = new System.Drawing.Point(424, 97);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 4;
			this.btnConsultar.Text = "&Consultar";
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// txtDatFim
			// 
			this.txtDatFim.EditValue = null;
			this.txtDatFim.Location = new System.Drawing.Point(115, 43);
			this.txtDatFim.Name = "txtDatFim";
			this.txtDatFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDatFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.txtDatFim.Size = new System.Drawing.Size(100, 20);
			this.txtDatFim.TabIndex = 3;
			// 
			// txtDatInicio
			// 
			this.txtDatInicio.EditValue = null;
			this.txtDatInicio.Location = new System.Drawing.Point(9, 43);
			this.txtDatInicio.Name = "txtDatInicio";
			this.txtDatInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDatInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.txtDatInicio.Size = new System.Drawing.Size(100, 20);
			this.txtDatInicio.TabIndex = 2;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(91, 24);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(36, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Período";
			// 
			// btnRetornar
			// 
			this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRetornar.Location = new System.Drawing.Point(586, 97);
			this.btnRetornar.Name = "btnRetornar";
			this.btnRetornar.Size = new System.Drawing.Size(75, 23);
			this.btnRetornar.TabIndex = 0;
			this.btnRetornar.Text = "&Retornar";
			this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
			// 
			// tbl_SaidaTableAdapter1
			// 
			this.tbl_SaidaTableAdapter1.ClearBeforeFill = true;
			// 
			// tbl_SaidaItensTableAdapter1
			// 
			this.tbl_SaidaItensTableAdapter1.ClearBeforeFill = true;
			// 
			// frmVendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnRetornar;
			this.ClientSize = new System.Drawing.Size(690, 438);
			this.Controls.Add(this.grdDados);
			this.Controls.Add(this.groupControl1);
			this.Name = "frmVendas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vendas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmVendas_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdItens)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.relVendasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.relVendas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbStatusNFE.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnRetornar;
		private DevExpress.XtraGrid.GridControl grdDados;
		private DevExpress.XtraGrid.Views.Grid.GridView gridDados;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.DateEdit txtDatFim;
		private DevExpress.XtraEditors.DateEdit txtDatInicio;
		private DevExpress.XtraGrid.Columns.GridColumn colData;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrTotal;
		private DevExpress.XtraEditors.SimpleButton btnEstornar;
		private DevExpress.XtraEditors.SimpleButton btnImprimir;
		private DevExpress.XtraEditors.SimpleButton btnConsultar;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraGrid.Columns.GridColumn colCodVenda;
		private DevExpress.XtraGrid.Views.Grid.GridView grdItens;
		private DevExpress.XtraGrid.Columns.GridColumn colCodProduto;
		private DevExpress.XtraGrid.Columns.GridColumn colCodigoProduto;
		private DevExpress.XtraGrid.Columns.GridColumn colQtdProduto;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrUnitario;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
		private DevExpress.XtraGrid.Columns.GridColumn colCliente;
		private DevExpress.XtraGrid.Columns.GridColumn colQtdeItens;
		private DevExpress.XtraEditors.SimpleButton btnReimprimir;
		private System.Windows.Forms.BindingSource relVendasBindingSource;
		private relVendas relVendas;
		private relVendasTableAdapters.tbl_SaidaTableAdapter tbl_SaidaTableAdapter1;
		private relVendasTableAdapters.tbl_SaidaItensTableAdapter tbl_SaidaItensTableAdapter1;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrDesconto;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrBruto;
		private DevExpress.XtraGrid.Columns.GridColumn colDesProduto;
		private DevExpress.XtraEditors.SimpleButton btnImprimirResumo;
		private DevExpress.XtraGrid.Columns.GridColumn colFlgStatusNFE;
		private DevExpress.XtraEditors.ComboBoxEdit cmbStatusNFE;
		private DevExpress.XtraEditors.SimpleButton btnCancelar;
	}
}