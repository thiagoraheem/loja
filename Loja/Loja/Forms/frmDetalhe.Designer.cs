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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.imgFoto = new DevExpress.XtraEditors.PictureEdit();
            this.txtCodProduto = new DevExpress.XtraEditors.TextEdit();
            this.txtFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.txtDesLocal = new DevExpress.XtraEditors.TextEdit();
            this.txtQtdEstoque = new DevExpress.XtraEditors.TextEdit();
            this.txtDesProduto = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDesconto = new DevExpress.XtraEditors.CalcEdit();
            this.txtVlrUnitario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesLocal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(52, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(27, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descrição:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(49, 179);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fornec.:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(251, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 23);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Local:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(42, 245);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 23);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Estoque:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(224, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 23);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Preço:";
            // 
            // imgFoto
            // 
            this.imgFoto.Location = new System.Drawing.Point(420, 29);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(254, 296);
            this.imgFoto.TabIndex = 6;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(132, 31);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Properties.Appearance.Options.UseFont = true;
            this.txtCodProduto.Properties.ReadOnly = true;
            this.txtCodProduto.Size = new System.Drawing.Size(282, 30);
            this.txtCodProduto.TabIndex = 7;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(132, 177);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Properties.Appearance.Options.UseFont = true;
            this.txtFornecedor.Properties.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(100, 30);
            this.txtFornecedor.TabIndex = 9;
            // 
            // txtDesLocal
            // 
            this.txtDesLocal.Location = new System.Drawing.Point(314, 175);
            this.txtDesLocal.Name = "txtDesLocal";
            this.txtDesLocal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesLocal.Properties.Appearance.Options.UseFont = true;
            this.txtDesLocal.Properties.ReadOnly = true;
            this.txtDesLocal.Size = new System.Drawing.Size(100, 30);
            this.txtDesLocal.TabIndex = 10;
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Location = new System.Drawing.Point(132, 239);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdEstoque.Properties.Appearance.Options.UseFont = true;
            this.txtQtdEstoque.Properties.ReadOnly = true;
            this.txtQtdEstoque.Size = new System.Drawing.Size(77, 30);
            this.txtQtdEstoque.TabIndex = 11;
            // 
            // txtDesProduto
            // 
            this.txtDesProduto.Location = new System.Drawing.Point(132, 90);
            this.txtDesProduto.Name = "txtDesProduto";
            this.txtDesProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProduto.Properties.Appearance.Options.UseFont = true;
            this.txtDesProduto.Properties.ReadOnly = true;
            this.txtDesProduto.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesProduto.Size = new System.Drawing.Size(282, 58);
            this.txtDesProduto.TabIndex = 13;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtDesProduto);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtQtdEstoque);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtDesLocal);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtFornecedor);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCodProduto);
            this.groupControl1.Controls.Add(this.imgFoto);
            this.groupControl1.Controls.Add(this.txtDesconto);
            this.groupControl1.Controls.Add(this.txtVlrUnitario);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(682, 330);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "DETALHES DO PRODUTO";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(85, 298);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(199, 23);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Preço com desconto:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(290, 289);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Properties.Appearance.Options.UseBackColor = true;
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDesconto.Properties.Mask.EditMask = "c2";
            this.txtDesconto.Properties.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(124, 36);
            this.txtDesconto.TabIndex = 15;
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.Location = new System.Drawing.Point(290, 236);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtVlrUnitario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrUnitario.Properties.Appearance.Options.UseBackColor = true;
            this.txtVlrUnitario.Properties.Appearance.Options.UseFont = true;
            this.txtVlrUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVlrUnitario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVlrUnitario.Properties.Mask.EditMask = "c2";
            this.txtVlrUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVlrUnitario.Properties.ReadOnly = true;
            this.txtVlrUnitario.Size = new System.Drawing.Size(124, 36);
            this.txtVlrUnitario.TabIndex = 12;
            // 
            // frmDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 330);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetalhe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesLocal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).EndInit();
            this.ResumeLayout(false);

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