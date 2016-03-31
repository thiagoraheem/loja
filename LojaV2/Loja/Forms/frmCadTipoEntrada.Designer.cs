namespace Loja
{
    partial class frmCadTipoEntrada
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
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.gridDados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.chkMovimenta = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMovimenta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDados.Location = new System.Drawing.Point(12, 43);
            this.grdDados.MainView = this.gridDados;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(407, 289);
            this.grdDados.TabIndex = 6;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDados});
            // 
            // gridDados
            // 
            this.gridDados.ActiveFilterEnabled = false;
            this.gridDados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescricao,
            this.colMovimenta});
            this.gridDados.GridControl = this.grdDados;
            this.gridDados.Name = "gridDados";
            this.gridDados.OptionsBehavior.Editable = false;
            this.gridDados.OptionsBehavior.ReadOnly = true;
            this.gridDados.OptionsCustomization.AllowFilter = false;
            this.gridDados.OptionsCustomization.AllowGroup = false;
            this.gridDados.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridDados.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridDados.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridDados.OptionsView.ShowGroupPanel = false;
            this.gridDados.DoubleClick += new System.EventHandler(this.gridDados_DoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "CodTipoEntrada";
            this.colCodigo.Name = "colCodigo";
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "DesTipoEntrada";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 0;
            this.colDescricao.Width = 179;
            // 
            // colMovimenta
            // 
            this.colMovimenta.Caption = "Ativo";
            this.colMovimenta.FieldName = "flgMovimentaEstoque";
            this.colMovimenta.Name = "colMovimenta";
            this.colMovimenta.Visible = true;
            this.colMovimenta.VisibleIndex = 1;
            this.colMovimenta.Width = 69;
            // 
            // txtDescricao
            // 
            this.txtDescricao.EnterMoveNextControl = true;
            this.txtDescricao.Location = new System.Drawing.Point(82, 10);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // chkMovimenta
            // 
            this.chkMovimenta.EnterMoveNextControl = true;
            this.chkMovimenta.Location = new System.Drawing.Point(197, 10);
            this.chkMovimenta.Name = "chkMovimenta";
            this.chkMovimenta.Properties.Caption = "Movimenta estoque";
            this.chkMovimenta.Size = new System.Drawing.Size(75, 19);
            this.chkMovimenta.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Descrição:";
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.Location = new System.Drawing.Point(182, 338);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(263, 338);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRetornar.Location = new System.Drawing.Point(344, 338);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 3;
            this.btnRetornar.Text = "&Retornar";
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(101, 338);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCadTipoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRetornar;
            this.ClientSize = new System.Drawing.Size(431, 373);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkMovimenta);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.grdDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadTipoEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Entrada";
            this.Load += new System.EventHandler(this.frmCadTipoEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMovimenta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDados;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimenta;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.CheckEdit chkMovimenta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGravar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnRetornar;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
    }
}