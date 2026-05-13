namespace Loja
{
    partial class frmDetalhe
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
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			labelControl5 = new DevExpress.XtraEditors.LabelControl();
			labelControl6 = new DevExpress.XtraEditors.LabelControl();
			imgFoto = new DevExpress.XtraEditors.PictureEdit();
			txtCodProduto = new DevExpress.XtraEditors.TextEdit();
			txtFornecedor = new DevExpress.XtraEditors.TextEdit();
			txtDesLocal = new DevExpress.XtraEditors.TextEdit();
			txtQtdEstoque = new DevExpress.XtraEditors.TextEdit();
			txtDesProduto = new DevExpress.XtraEditors.MemoEdit();
			groupControl1 = new DevExpress.XtraEditors.GroupControl();
			labelControl7 = new DevExpress.XtraEditors.LabelControl();
			txtDesconto = new DevExpress.XtraEditors.CalcEdit();
			txtVlrUnitario = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)imgFoto.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtCodProduto.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtFornecedor.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtDesLocal.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtQtdEstoque.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtDesProduto.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
			groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txtDesconto.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtVlrUnitario.Properties).BeginInit();
			SuspendLayout();
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.Location = new System.Drawing.Point(51, 42);
			labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new System.Drawing.Size(92, 29);
			labelControl1.TabIndex = 0;
			labelControl1.Text = "Código:";
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl2.Appearance.Options.UseFont = true;
			labelControl2.Location = new System.Drawing.Point(18, 112);
			labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new System.Drawing.Size(125, 29);
			labelControl2.TabIndex = 1;
			labelControl2.Text = "Descrição:";
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl3.Appearance.Options.UseFont = true;
			labelControl3.Location = new System.Drawing.Point(45, 264);
			labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new System.Drawing.Size(98, 29);
			labelControl3.TabIndex = 2;
			labelControl3.Text = "Fornec.:";
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl4.Appearance.Options.UseFont = true;
			labelControl4.Location = new System.Drawing.Point(358, 264);
			labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new System.Drawing.Size(72, 29);
			labelControl4.TabIndex = 3;
			labelControl4.Text = "Local:";
			// 
			// labelControl5
			// 
			labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl5.Appearance.Options.UseFont = true;
			labelControl5.Location = new System.Drawing.Point(38, 330);
			labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl5.Name = "labelControl5";
			labelControl5.Size = new System.Drawing.Size(105, 29);
			labelControl5.TabIndex = 4;
			labelControl5.Text = "Estoque:";
			// 
			// labelControl6
			// 
			labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl6.Appearance.Options.UseFont = true;
			labelControl6.Location = new System.Drawing.Point(254, 330);
			labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl6.Name = "labelControl6";
			labelControl6.Size = new System.Drawing.Size(77, 29);
			labelControl6.TabIndex = 5;
			labelControl6.Text = "Preço:";
			// 
			// imgFoto
			// 
			imgFoto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			imgFoto.Location = new System.Drawing.Point(560, 36);
			imgFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			imgFoto.Name = "imgFoto";
			imgFoto.Properties.AllowScrollViaMouseDrag = true;
			imgFoto.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
			imgFoto.Properties.ReadOnly = true;
			imgFoto.Properties.ShowScrollBars = true;
			imgFoto.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
			imgFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			imgFoto.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
			imgFoto.Size = new System.Drawing.Size(382, 461);
			imgFoto.TabIndex = 6;
			// 
			// txtCodProduto
			// 
			txtCodProduto.Location = new System.Drawing.Point(154, 38);
			txtCodProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtCodProduto.Name = "txtCodProduto";
			txtCodProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtCodProduto.Properties.Appearance.Options.UseFont = true;
			txtCodProduto.Properties.ReadOnly = true;
			txtCodProduto.Size = new System.Drawing.Size(399, 36);
			txtCodProduto.TabIndex = 7;
			// 
			// txtFornecedor
			// 
			txtFornecedor.Location = new System.Drawing.Point(154, 260);
			txtFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtFornecedor.Name = "txtFornecedor";
			txtFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtFornecedor.Properties.Appearance.Options.UseFont = true;
			txtFornecedor.Properties.ReadOnly = true;
			txtFornecedor.Size = new System.Drawing.Size(117, 36);
			txtFornecedor.TabIndex = 9;
			// 
			// txtDesLocal
			// 
			txtDesLocal.Location = new System.Drawing.Point(436, 260);
			txtDesLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtDesLocal.Name = "txtDesLocal";
			txtDesLocal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtDesLocal.Properties.Appearance.Options.UseFont = true;
			txtDesLocal.Properties.ReadOnly = true;
			txtDesLocal.Size = new System.Drawing.Size(117, 36);
			txtDesLocal.TabIndex = 10;
			// 
			// txtQtdEstoque
			// 
			txtQtdEstoque.Location = new System.Drawing.Point(154, 326);
			txtQtdEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtQtdEstoque.Name = "txtQtdEstoque";
			txtQtdEstoque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtQtdEstoque.Properties.Appearance.Options.UseFont = true;
			txtQtdEstoque.Properties.ReadOnly = true;
			txtQtdEstoque.Size = new System.Drawing.Size(90, 36);
			txtQtdEstoque.TabIndex = 11;
			// 
			// txtDesProduto
			// 
			txtDesProduto.Location = new System.Drawing.Point(154, 111);
			txtDesProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtDesProduto.Name = "txtDesProduto";
			txtDesProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtDesProduto.Properties.Appearance.Options.UseFont = true;
			txtDesProduto.Properties.ReadOnly = true;
			txtDesProduto.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
			txtDesProduto.Size = new System.Drawing.Size(399, 136);
			txtDesProduto.TabIndex = 13;
			// 
			// groupControl1
			// 
			groupControl1.Controls.Add(labelControl7);
			groupControl1.Controls.Add(labelControl1);
			groupControl1.Controls.Add(txtDesProduto);
			groupControl1.Controls.Add(labelControl2);
			groupControl1.Controls.Add(labelControl3);
			groupControl1.Controls.Add(txtQtdEstoque);
			groupControl1.Controls.Add(labelControl4);
			groupControl1.Controls.Add(txtDesLocal);
			groupControl1.Controls.Add(labelControl5);
			groupControl1.Controls.Add(txtFornecedor);
			groupControl1.Controls.Add(labelControl6);
			groupControl1.Controls.Add(txtCodProduto);
			groupControl1.Controls.Add(imgFoto);
			groupControl1.Controls.Add(txtDesconto);
			groupControl1.Controls.Add(txtVlrUnitario);
			groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			groupControl1.Location = new System.Drawing.Point(0, 0);
			groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			groupControl1.Name = "groupControl1";
			groupControl1.Size = new System.Drawing.Size(955, 512);
			groupControl1.TabIndex = 14;
			groupControl1.Text = "DETALHES DO PRODUTO";
			// 
			// labelControl7
			// 
			labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl7.Appearance.Options.UseFont = true;
			labelControl7.Location = new System.Drawing.Point(80, 396);
			labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			labelControl7.Name = "labelControl7";
			labelControl7.Size = new System.Drawing.Size(251, 29);
			labelControl7.TabIndex = 14;
			labelControl7.Text = "Preço com desconto:";
			// 
			// txtDesconto
			// 
			txtDesconto.Location = new System.Drawing.Point(338, 387);
			txtDesconto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtDesconto.Name = "txtDesconto";
			txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
			txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtDesconto.Properties.Appearance.Options.UseBackColor = true;
			txtDesconto.Properties.Appearance.Options.UseFont = true;
			txtDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			txtDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			txtDesconto.Properties.Mask.EditMask = "c2";
			txtDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
			txtDesconto.Properties.ReadOnly = true;
			txtDesconto.Size = new System.Drawing.Size(215, 42);
			txtDesconto.TabIndex = 15;
			// 
			// txtVlrUnitario
			// 
			txtVlrUnitario.Location = new System.Drawing.Point(338, 323);
			txtVlrUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			txtVlrUnitario.Name = "txtVlrUnitario";
			txtVlrUnitario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
			txtVlrUnitario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			txtVlrUnitario.Properties.Appearance.Options.UseBackColor = true;
			txtVlrUnitario.Properties.Appearance.Options.UseFont = true;
			txtVlrUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			txtVlrUnitario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			txtVlrUnitario.Properties.Mask.EditMask = "C2";
			txtVlrUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			txtVlrUnitario.Properties.Mask.UseMaskAsDisplayFormat = true;
			txtVlrUnitario.Properties.ReadOnly = true;
			txtVlrUnitario.Size = new System.Drawing.Size(215, 42);
			txtVlrUnitario.TabIndex = 12;
			// 
			// frmDetalhe
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(955, 512);
			Controls.Add(groupControl1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			KeyPreview = true;
			Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			Name = "frmDetalhe";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			KeyDown += frmDetalhe_KeyDown;
			((System.ComponentModel.ISupportInitialize)imgFoto.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtCodProduto.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtFornecedor.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtDesLocal.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtQtdEstoque.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtDesProduto.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
			groupControl1.ResumeLayout(false);
			groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)txtDesconto.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtVlrUnitario.Properties).EndInit();
			ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit imgFoto;
        private DevExpress.XtraEditors.TextEdit txtCodProduto;
        private DevExpress.XtraEditors.TextEdit txtFornecedor;
        private DevExpress.XtraEditors.TextEdit txtDesLocal;
        private DevExpress.XtraEditors.TextEdit txtQtdEstoque;
        private DevExpress.XtraEditors.MemoEdit txtDesProduto;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit txtDesconto;
        private DevExpress.XtraEditors.TextEdit txtVlrUnitario;
    }
}