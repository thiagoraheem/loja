namespace Loja
{
	partial class frmCadCliente
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
			this.txtNomCliente = new DevExpress.XtraEditors.TextEdit();
			this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
			this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
			this.txtNumCPF = new DevExpress.XtraEditors.TextEdit();
			this.txtNumCNPJ = new DevExpress.XtraEditors.TextEdit();
			this.txtNumTelefone = new DevExpress.XtraEditors.TextEdit();
			this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
			this.txtNumero = new DevExpress.XtraEditors.TextEdit();
			this.txtBairro = new DevExpress.XtraEditors.TextEdit();
			this.txtCidade = new DevExpress.XtraEditors.TextEdit();
			this.txtEstado = new DevExpress.XtraEditors.TextEdit();
			this.txtPais = new DevExpress.XtraEditors.TextEdit();
			this.txtEmail = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.txtCEP = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomCliente.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCPF.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCNPJ.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumTelefone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPais.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(47, 24);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(31, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Nome:";
			// 
			// txtNomCliente
			// 
			this.txtNomCliente.EnterMoveNextControl = true;
			this.txtNomCliente.Location = new System.Drawing.Point(97, 21);
			this.txtNomCliente.Name = "txtNomCliente";
			this.txtNomCliente.Size = new System.Drawing.Size(311, 20);
			this.txtNomCliente.TabIndex = 1;
			// 
			// btnGravar
			// 
			this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnGravar.Location = new System.Drawing.Point(263, 208);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(75, 23);
			this.btnGravar.TabIndex = 22;
			this.btnGravar.Text = "&Gravar";
			this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
			// 
			// btnRetornar
			// 
			this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRetornar.Location = new System.Drawing.Point(344, 208);
			this.btnRetornar.Name = "btnRetornar";
			this.btnRetornar.Size = new System.Drawing.Size(75, 23);
			this.btnRetornar.TabIndex = 23;
			this.btnRetornar.Text = "&Retornar";
			// 
			// txtNumCPF
			// 
			this.txtNumCPF.EditValue = "";
			this.txtNumCPF.EnterMoveNextControl = true;
			this.txtNumCPF.Location = new System.Drawing.Point(97, 48);
			this.txtNumCPF.Name = "txtNumCPF";
			this.txtNumCPF.Properties.Mask.EditMask = "999.999.999-99";
			this.txtNumCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
			this.txtNumCPF.Size = new System.Drawing.Size(116, 20);
			this.txtNumCPF.TabIndex = 3;
			// 
			// txtNumCNPJ
			// 
			this.txtNumCNPJ.EditValue = "";
			this.txtNumCNPJ.EnterMoveNextControl = true;
			this.txtNumCNPJ.Location = new System.Drawing.Point(286, 47);
			this.txtNumCNPJ.Name = "txtNumCNPJ";
			this.txtNumCNPJ.Properties.Mask.EditMask = "99.999.999/9999-99";
			this.txtNumCNPJ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
			this.txtNumCNPJ.Size = new System.Drawing.Size(122, 20);
			this.txtNumCNPJ.TabIndex = 5;
			// 
			// txtNumTelefone
			// 
			this.txtNumTelefone.EnterMoveNextControl = true;
			this.txtNumTelefone.Location = new System.Drawing.Point(97, 73);
			this.txtNumTelefone.Name = "txtNumTelefone";
			this.txtNumTelefone.Properties.Mask.EditMask = "(999) 90000-0000";
			this.txtNumTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
			this.txtNumTelefone.Size = new System.Drawing.Size(100, 20);
			this.txtNumTelefone.TabIndex = 7;
			// 
			// txtEndereco
			// 
			this.txtEndereco.EnterMoveNextControl = true;
			this.txtEndereco.Location = new System.Drawing.Point(97, 99);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(187, 20);
			this.txtEndereco.TabIndex = 11;
			// 
			// txtNumero
			// 
			this.txtNumero.EnterMoveNextControl = true;
			this.txtNumero.Location = new System.Drawing.Point(344, 99);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(64, 20);
			this.txtNumero.TabIndex = 13;
			// 
			// txtBairro
			// 
			this.txtBairro.EnterMoveNextControl = true;
			this.txtBairro.Location = new System.Drawing.Point(97, 125);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(138, 20);
			this.txtBairro.TabIndex = 15;
			// 
			// txtCidade
			// 
			this.txtCidade.EnterMoveNextControl = true;
			this.txtCidade.Location = new System.Drawing.Point(295, 125);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(113, 20);
			this.txtCidade.TabIndex = 17;
			// 
			// txtEstado
			// 
			this.txtEstado.EnterMoveNextControl = true;
			this.txtEstado.Location = new System.Drawing.Point(97, 151);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(138, 20);
			this.txtEstado.TabIndex = 19;
			// 
			// txtPais
			// 
			this.txtPais.EnterMoveNextControl = true;
			this.txtPais.Location = new System.Drawing.Point(297, 151);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(111, 20);
			this.txtPais.TabIndex = 21;
			// 
			// txtEmail
			// 
			this.txtEmail.EnterMoveNextControl = true;
			this.txtEmail.Location = new System.Drawing.Point(259, 73);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(149, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(55, 51);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(23, 13);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "CPF:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(32, 77);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(46, 13);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Telefone:";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(29, 103);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(49, 13);
			this.labelControl4.TabIndex = 10;
			this.labelControl4.Text = "Endereço:";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(46, 128);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(32, 13);
			this.labelControl5.TabIndex = 14;
			this.labelControl5.Text = "Bairro:";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(41, 155);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(37, 13);
			this.labelControl6.TabIndex = 18;
			this.labelControl6.Text = "Estado:";
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(221, 76);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(32, 13);
			this.labelControl7.TabIndex = 8;
			this.labelControl7.Text = "e-Mail:";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(261, 155);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(23, 13);
			this.labelControl8.TabIndex = 20;
			this.labelControl8.Text = "País:";
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(252, 128);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(37, 13);
			this.labelControl9.TabIndex = 16;
			this.labelControl9.Text = "Cidade:";
			// 
			// labelControl10
			// 
			this.labelControl10.Location = new System.Drawing.Point(297, 103);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(41, 13);
			this.labelControl10.TabIndex = 12;
			this.labelControl10.Text = "Número:";
			// 
			// labelControl11
			// 
			this.labelControl11.Location = new System.Drawing.Point(251, 50);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(29, 13);
			this.labelControl11.TabIndex = 4;
			this.labelControl11.Text = "CNPJ:";
			// 
			// labelControl12
			// 
			this.labelControl12.Location = new System.Drawing.Point(55, 180);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(23, 13);
			this.labelControl12.TabIndex = 24;
			this.labelControl12.Text = "CEP:";
			// 
			// txtCEP
			// 
			this.txtCEP.EditValue = "";
			this.txtCEP.EnterMoveNextControl = true;
			this.txtCEP.Location = new System.Drawing.Point(97, 177);
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Properties.Mask.EditMask = "00000-000";
			this.txtCEP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
			this.txtCEP.Size = new System.Drawing.Size(116, 20);
			this.txtCEP.TabIndex = 25;
			// 
			// frmCadCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 243);
			this.Controls.Add(this.labelControl12);
			this.Controls.Add(this.txtCEP);
			this.Controls.Add(this.labelControl11);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.labelControl9);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPais);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtNumTelefone);
			this.Controls.Add(this.txtNumCNPJ);
			this.Controls.Add(this.txtNumCPF);
			this.Controls.Add(this.btnRetornar);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.txtNomCliente);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmCadCliente";
			this.Text = "Cadastro de Cliente";
			((System.ComponentModel.ISupportInitialize)(this.txtNomCliente.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCPF.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumCNPJ.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumTelefone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPais.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtNomCliente;
		private DevExpress.XtraEditors.SimpleButton btnGravar;
		private DevExpress.XtraEditors.SimpleButton btnRetornar;
		private DevExpress.XtraEditors.TextEdit txtNumCPF;
		private DevExpress.XtraEditors.TextEdit txtNumCNPJ;
		private DevExpress.XtraEditors.TextEdit txtNumTelefone;
		private DevExpress.XtraEditors.TextEdit txtEndereco;
		private DevExpress.XtraEditors.TextEdit txtNumero;
		private DevExpress.XtraEditors.TextEdit txtBairro;
		private DevExpress.XtraEditors.TextEdit txtCidade;
		private DevExpress.XtraEditors.TextEdit txtEstado;
		private DevExpress.XtraEditors.TextEdit txtPais;
		private DevExpress.XtraEditors.TextEdit txtEmail;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.LabelControl labelControl12;
		private DevExpress.XtraEditors.TextEdit txtCEP;
	}
}