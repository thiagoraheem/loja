namespace Loja.Forms
{
	partial class frmOrcamento
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
			this.gridOrcamento = new DevExpress.XtraGrid.GridControl();
			this.gridViewOrcamento = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOrCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrcodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVlrOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lblCodOrca = new DevExpress.XtraEditors.LabelControl();
			this.txtCodOrca = new DevExpress.XtraEditors.TextEdit();
			this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewOrcamento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCodOrca.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridOrcamento
			// 
			this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridOrcamento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridOrcamento.Location = new System.Drawing.Point(12, 47);
			this.gridOrcamento.MainView = this.gridViewOrcamento;
			this.gridOrcamento.Name = "gridOrcamento";
			this.gridOrcamento.Size = new System.Drawing.Size(880, 364);
			this.gridOrcamento.TabIndex = 2;
			this.gridOrcamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrcamento});
			// 
			// gridViewOrcamento
			// 
			this.gridViewOrcamento.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewOrcamento.Appearance.FooterPanel.Options.UseFont = true;
			this.gridViewOrcamento.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewOrcamento.Appearance.Row.Options.UseFont = true;
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
			this.gridViewOrcamento.OptionsBehavior.Editable = false;
			this.gridViewOrcamento.OptionsView.ShowFooter = true;
			this.gridViewOrcamento.OptionsView.ShowGroupPanel = false;
			// 
			// colOrCodProduto
			// 
			this.colOrCodProduto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colOrCodProduto.AppearanceCell.Options.UseFont = true;
			this.colOrCodProduto.Caption = "Código";
			this.colOrCodProduto.FieldName = "CodProduto";
			this.colOrCodProduto.Name = "colOrCodProduto";
			this.colOrCodProduto.OptionsColumn.AllowEdit = false;
			this.colOrCodProduto.Visible = true;
			this.colOrCodProduto.VisibleIndex = 0;
			this.colOrCodProduto.Width = 134;
			// 
			// colOrDesProduto
			// 
			this.colOrDesProduto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colOrDesProduto.AppearanceCell.Options.UseFont = true;
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
			this.colQuantidade.Caption = "Qtde";
			this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colQuantidade.FieldName = "Quantidade";
			this.colQuantidade.Name = "colQuantidade";
			this.colQuantidade.Visible = true;
			this.colQuantidade.VisibleIndex = 2;
			this.colQuantidade.Width = 35;
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
			this.colValor.Width = 127;
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
			this.colVlrFinal.Width = 145;
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
			this.colVlrOriginal.Visible = true;
			this.colVlrOriginal.VisibleIndex = 5;
			this.colVlrOriginal.Width = 105;
			// 
			// lblCodOrca
			// 
			this.lblCodOrca.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodOrca.Location = new System.Drawing.Point(12, 12);
			this.lblCodOrca.Name = "lblCodOrca";
			this.lblCodOrca.Size = new System.Drawing.Size(148, 25);
			this.lblCodOrca.TabIndex = 3;
			this.lblCodOrca.Text = "No. Orçamento:";
			// 
			// txtCodOrca
			// 
			this.txtCodOrca.Location = new System.Drawing.Point(166, 9);
			this.txtCodOrca.Name = "txtCodOrca";
			this.txtCodOrca.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodOrca.Properties.Appearance.Options.UseFont = true;
			this.txtCodOrca.Properties.ReadOnly = true;
			this.txtCodOrca.Size = new System.Drawing.Size(100, 32);
			this.txtCodOrca.TabIndex = 4;
			// 
			// btnFechar
			// 
			this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnFechar.Location = new System.Drawing.Point(728, 13);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(164, 23);
			this.btnFechar.TabIndex = 5;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// frmOrcamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnFechar;
			this.ClientSize = new System.Drawing.Size(904, 423);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.txtCodOrca);
			this.Controls.Add(this.lblCodOrca);
			this.Controls.Add(this.gridOrcamento);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "frmOrcamento";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orçamento";
			this.TopMost = true;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOrcamento_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewOrcamento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCodOrca.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridOrcamento;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrcamento;
		private DevExpress.XtraGrid.Columns.GridColumn colOrCodProduto;
		private DevExpress.XtraGrid.Columns.GridColumn colOrDesProduto;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
		private DevExpress.XtraGrid.Columns.GridColumn colValor;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
		private DevExpress.XtraGrid.Columns.GridColumn colOrcodigounico;
		private DevExpress.XtraGrid.Columns.GridColumn colVlrOriginal;
		private DevExpress.XtraEditors.LabelControl lblCodOrca;
		private DevExpress.XtraEditors.TextEdit txtCodOrca;
		private DevExpress.XtraEditors.SimpleButton btnFechar;
	}
}