namespace Loja
{
	partial class frmClientes
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
			this.grdClientes = new DevExpress.XtraGrid.GridControl();
			this.grdViewDados = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomCliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumCPF = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumCNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumTelefone = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
			this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdViewDados)).BeginInit();
			this.SuspendLayout();
			// 
			// grdClientes
			// 
			this.grdClientes.Location = new System.Drawing.Point(12, 12);
			this.grdClientes.MainView = this.grdViewDados;
			this.grdClientes.Name = "grdClientes";
			this.grdClientes.Size = new System.Drawing.Size(614, 308);
			this.grdClientes.TabIndex = 0;
			this.grdClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewDados});
			// 
			// grdViewDados
			// 
			this.grdViewDados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colNomCliente,
            this.colNumCPF,
            this.colNumCNPJ,
            this.colNumTelefone});
			this.grdViewDados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.grdViewDados.GridControl = this.grdClientes;
			this.grdViewDados.Name = "grdViewDados";
			this.grdViewDados.OptionsBehavior.Editable = false;
			this.grdViewDados.OptionsView.AllowHtmlDrawHeaders = true;
			this.grdViewDados.OptionsView.ShowAutoFilterRow = true;
			this.grdViewDados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
			this.grdViewDados.DoubleClick += new System.EventHandler(this.grdViewDados_DoubleClick);
			// 
			// colCodigo
			// 
			this.colCodigo.Caption = "Código";
			this.colCodigo.FieldName = "CodCliente";
			this.colCodigo.Name = "colCodigo";
			this.colCodigo.Visible = true;
			this.colCodigo.VisibleIndex = 0;
			this.colCodigo.Width = 58;
			// 
			// colNomCliente
			// 
			this.colNomCliente.Caption = "Nome";
			this.colNomCliente.FieldName = "NomCliente";
			this.colNomCliente.Name = "colNomCliente";
			this.colNomCliente.Visible = true;
			this.colNomCliente.VisibleIndex = 1;
			this.colNomCliente.Width = 303;
			// 
			// colNumCPF
			// 
			this.colNumCPF.Caption = "CPF";
			this.colNumCPF.FieldName = "NumCPF";
			this.colNumCPF.Name = "colNumCPF";
			this.colNumCPF.Visible = true;
			this.colNumCPF.VisibleIndex = 2;
			this.colNumCPF.Width = 161;
			// 
			// colNumCNPJ
			// 
			this.colNumCNPJ.Caption = "CNPJ";
			this.colNumCNPJ.FieldName = "NumCNPJ";
			this.colNumCNPJ.Name = "colNumCNPJ";
			this.colNumCNPJ.Visible = true;
			this.colNumCNPJ.VisibleIndex = 3;
			this.colNumCNPJ.Width = 175;
			// 
			// colNumTelefone
			// 
			this.colNumTelefone.Caption = "Telefone";
			this.colNumTelefone.FieldName = "NumTelefone";
			this.colNumTelefone.Name = "colNumTelefone";
			this.colNumTelefone.Visible = true;
			this.colNumTelefone.VisibleIndex = 4;
			this.colNumTelefone.Width = 381;
			// 
			// btnNovo
			// 
			this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnNovo.Location = new System.Drawing.Point(387, 334);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 9;
			this.btnNovo.Text = "&Novo";
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnRetornar
			// 
			this.btnRetornar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRetornar.Location = new System.Drawing.Point(550, 334);
			this.btnRetornar.Name = "btnRetornar";
			this.btnRetornar.Size = new System.Drawing.Size(75, 23);
			this.btnRetornar.TabIndex = 10;
			this.btnRetornar.Text = "&Retornar";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnExcluir.Enabled = false;
			this.btnExcluir.Location = new System.Drawing.Point(469, 334);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "&Excluir";
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 367);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnRetornar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.grdClientes);
			this.Name = "frmClientes";
			this.Text = "Clientes";
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdViewDados)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdClientes;
		private DevExpress.XtraGrid.Views.Grid.GridView grdViewDados;
		private DevExpress.XtraEditors.SimpleButton btnNovo;
		private DevExpress.XtraEditors.SimpleButton btnRetornar;
		private DevExpress.XtraEditors.SimpleButton btnExcluir;
		private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
		private DevExpress.XtraGrid.Columns.GridColumn colNomCliente;
		private DevExpress.XtraGrid.Columns.GridColumn colNumCPF;
		private DevExpress.XtraGrid.Columns.GridColumn colNumCNPJ;
		private DevExpress.XtraGrid.Columns.GridColumn colNumTelefone;
	}
}