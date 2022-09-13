namespace Loja.Forms
{
	partial class frmResumo
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
			this.txtQtdProdutos = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtQtdItens = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtValorProdutos = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtValorBruto = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtQtdProdutos.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQtdItens.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValorProdutos.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValorBruto.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtQtdProdutos
			// 
			this.txtQtdProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQtdProdutos.Location = new System.Drawing.Point(147, 28);
			this.txtQtdProdutos.Name = "txtQtdProdutos";
			this.txtQtdProdutos.Properties.Mask.EditMask = "c2";
			this.txtQtdProdutos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtQtdProdutos.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtQtdProdutos.Size = new System.Drawing.Size(100, 20);
			this.txtQtdProdutos.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl1.Location = new System.Drawing.Point(58, 31);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(68, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Qtd. Produtos";
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl2.Location = new System.Drawing.Point(58, 57);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(50, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Qtd. Itens";
			// 
			// txtQtdItens
			// 
			this.txtQtdItens.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQtdItens.Location = new System.Drawing.Point(147, 54);
			this.txtQtdItens.Name = "txtQtdItens";
			this.txtQtdItens.Properties.Mask.EditMask = "c2";
			this.txtQtdItens.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtQtdItens.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtQtdItens.Size = new System.Drawing.Size(100, 20);
			this.txtQtdItens.TabIndex = 2;
			// 
			// labelControl3
			// 
			this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl3.Location = new System.Drawing.Point(58, 83);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(70, 13);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Valor Produtos";
			// 
			// txtValorProdutos
			// 
			this.txtValorProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtValorProdutos.Location = new System.Drawing.Point(147, 80);
			this.txtValorProdutos.Name = "txtValorProdutos";
			this.txtValorProdutos.Properties.Mask.EditMask = "c2";
			this.txtValorProdutos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtValorProdutos.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtValorProdutos.Size = new System.Drawing.Size(100, 20);
			this.txtValorProdutos.TabIndex = 4;
			// 
			// labelControl4
			// 
			this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl4.Location = new System.Drawing.Point(58, 109);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(53, 13);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = "Valor Bruto";
			// 
			// txtValorBruto
			// 
			this.txtValorBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtValorBruto.Location = new System.Drawing.Point(147, 106);
			this.txtValorBruto.Name = "txtValorBruto";
			this.txtValorBruto.Properties.Mask.EditMask = "c2";
			this.txtValorBruto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtValorBruto.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtValorBruto.Size = new System.Drawing.Size(100, 20);
			this.txtValorBruto.TabIndex = 6;
			// 
			// frmResumo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 163);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.txtValorBruto);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.txtValorProdutos);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.txtQtdItens);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtQtdProdutos);
			this.Name = "frmResumo";
			this.Text = "Resumo Loja";
			this.Load += new System.EventHandler(this.frmResumo_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmResumo_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.txtQtdProdutos.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQtdItens.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValorProdutos.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValorBruto.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtQtdProdutos;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtQtdItens;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtValorProdutos;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txtValorBruto;
	}
}