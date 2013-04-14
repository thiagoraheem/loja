﻿namespace Loja
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
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAplicarDesconto = new DevExpress.XtraEditors.SimpleButton();
            this.txtTroco = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDinheiro = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrTotal = new DevExpress.XtraEditors.CalcEdit();
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
            this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDinheiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).BeginInit();
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
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.btnAplicarDesconto);
            this.groupControl1.Controls.Add(this.txtTroco);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtDinheiro);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtVlrTotal);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmbTipoVenda);
            this.groupControl1.Controls.Add(this.btnFinalizarVenda);
            this.groupControl1.Controls.Add(this.chkApagarOrca);
            this.groupControl1.Controls.Add(this.chkEmitirRecibo);
            this.groupControl1.Controls.Add(this.txtDesconto);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 211);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(625, 222);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Dados da Venda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(509, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicarDesconto
            // 
            this.btnAplicarDesconto.Location = new System.Drawing.Point(384, 72);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(55, 32);
            this.btnAplicarDesconto.TabIndex = 13;
            this.btnAplicarDesconto.Text = "&Aplicar";
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.EnterMoveNextControl = true;
            this.txtTroco.Location = new System.Drawing.Point(277, 182);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Properties.Appearance.Options.UseFont = true;
            this.txtTroco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTroco.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTroco.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTroco.Properties.Mask.EditMask = "c2";
            this.txtTroco.Size = new System.Drawing.Size(162, 30);
            this.txtTroco.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(83, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 19);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Troco:";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.EnterMoveNextControl = true;
            this.txtDinheiro.Location = new System.Drawing.Point(277, 146);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Properties.Appearance.Options.UseFont = true;
            this.txtDinheiro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDinheiro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDinheiro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDinheiro.Properties.Mask.EditMask = "c2";
            this.txtDinheiro.Size = new System.Drawing.Size(162, 30);
            this.txtDinheiro.TabIndex = 3;
            this.txtDinheiro.Validated += new System.EventHandler(this.txtDinheiro_Validated);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(60, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 19);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Dinheiro:";
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.EnterMoveNextControl = true;
            this.txtVlrTotal.Location = new System.Drawing.Point(277, 110);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrTotal.Properties.Appearance.Options.UseFont = true;
            this.txtVlrTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVlrTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVlrTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVlrTotal.Properties.Mask.EditMask = "c2";
            this.txtVlrTotal.Size = new System.Drawing.Size(162, 30);
            this.txtVlrTotal.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(38, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 19);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Valor Total:";
            // 
            // cmbTipoVenda
            // 
            this.cmbTipoVenda.EnterMoveNextControl = true;
            this.cmbTipoVenda.Location = new System.Drawing.Point(150, 38);
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
            this.cmbTipoVenda.TabIndex = 0;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(509, 127);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(111, 42);
            this.btnFinalizarVenda.TabIndex = 5;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // chkApagarOrca
            // 
            this.chkApagarOrca.EditValue = true;
            this.chkApagarOrca.Location = new System.Drawing.Point(489, 75);
            this.chkApagarOrca.Name = "chkApagarOrca";
            this.chkApagarOrca.Properties.Caption = "Descartar Orçamento";
            this.chkApagarOrca.Size = new System.Drawing.Size(136, 19);
            this.chkApagarOrca.TabIndex = 7;
            // 
            // chkEmitirRecibo
            // 
            this.chkEmitirRecibo.EditValue = true;
            this.chkEmitirRecibo.Location = new System.Drawing.Point(489, 39);
            this.chkEmitirRecibo.Name = "chkEmitirRecibo";
            this.chkEmitirRecibo.Properties.Caption = "Emitir Recibo";
            this.chkEmitirRecibo.Size = new System.Drawing.Size(87, 19);
            this.chkEmitirRecibo.TabIndex = 6;
            // 
            // txtDesconto
            // 
            this.txtDesconto.EnterMoveNextControl = true;
            this.txtDesconto.Location = new System.Drawing.Point(277, 74);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDesconto.Properties.Mask.EditMask = "P";
            this.txtDesconto.Size = new System.Drawing.Size(100, 30);
            this.txtDesconto.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(54, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Desconto:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Forma de Pgto:";
            // 
            // gridOrcamento
            // 
            this.gridOrcamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridOrcamento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridOrcamento.Location = new System.Drawing.Point(0, 0);
            this.gridOrcamento.MainView = this.gridViewOrcamento;
            this.gridOrcamento.Name = "gridOrcamento";
            this.gridOrcamento.Size = new System.Drawing.Size(649, 205);
            this.gridOrcamento.TabIndex = 2;
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
            this.gridViewOrcamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrCodProduto,
            this.colOrDesProduto,
            this.colQuantidade,
            this.colValor,
            this.colVlrFinal});
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
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "VlrUnitario";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 97;
            // 
            // colVlrFinal
            // 
            this.colVlrFinal.Caption = "Vlr. Total";
            this.colVlrFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVlrFinal.FieldName = "PF";
            this.colVlrFinal.Name = "colVlrFinal";
            this.colVlrFinal.OptionsColumn.AllowEdit = false;
            this.colVlrFinal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colVlrFinal.Visible = true;
            this.colVlrFinal.VisibleIndex = 4;
            this.colVlrFinal.Width = 107;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(649, 445);
            this.Controls.Add(this.gridOrcamento);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmVenda";
            this.Text = "Finalizar Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDinheiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).EndInit();
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
        private DevExpress.XtraEditors.CalcEdit txtVlrTotal;
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
    }
}