namespace Loja.Forms
{
    partial class frmHistoricoNfceAuditoria
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grdLogs = new DevExpress.XtraGrid.GridControl();
            this.gridViewLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTimestamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colException = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimparLogs = new System.Windows.Forms.Button();
            this.btnLimparAlertas = new System.Windows.Forms.Button();
            this.lblPendentes = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.grpDetalhe = new System.Windows.Forms.GroupBox();
            this.txtDetalhe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.grpDetalhe.SuspendLayout();
            this.SuspendLayout();
            //
            // grdLogs
            //
            this.grdLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLogs.Location = new System.Drawing.Point(12, 45);
            this.grdLogs.MainView = this.gridViewLogs;
            this.grdLogs.Name = "grdLogs";
            this.grdLogs.Size = new System.Drawing.Size(960, 380);
            this.grdLogs.TabIndex = 0;
            this.grdLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLogs});
            //
            // gridViewLogs
            //
            this.gridViewLogs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimestamp,
            this.colLevel,
            this.colEvent,
            this.colSaleId,
            this.colStatus,
            this.colDetail,
            this.colException});
            this.gridViewLogs.GridControl = this.grdLogs;
            this.gridViewLogs.Name = "gridViewLogs";
            this.gridViewLogs.OptionsBehavior.Editable = false;
            this.gridViewLogs.OptionsBehavior.ReadOnly = true;
            this.gridViewLogs.OptionsView.ColumnAutoWidth = false;
            this.gridViewLogs.OptionsView.ShowGroupPanel = false;
            this.gridViewLogs.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewLogs_RowClick);
            //
            // colTimestamp
            //
            this.colTimestamp.Caption = "Horário";
            this.colTimestamp.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colTimestamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTimestamp.FieldName = "Timestamp";
            this.colTimestamp.Name = "colTimestamp";
            this.colTimestamp.Visible = true;
            this.colTimestamp.VisibleIndex = 0;
            this.colTimestamp.Width = 150;
            //
            // colLevel
            //
            this.colLevel.Caption = "Nível";
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 1;
            this.colLevel.Width = 70;
            //
            // colEvent
            //
            this.colEvent.Caption = "Evento";
            this.colEvent.FieldName = "Event";
            this.colEvent.Name = "colEvent";
            this.colEvent.Visible = true;
            this.colEvent.VisibleIndex = 2;
            this.colEvent.Width = 200;
            //
            // colSaleId
            //
            this.colSaleId.Caption = "Venda";
            this.colSaleId.FieldName = "SaleId";
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.Visible = true;
            this.colSaleId.VisibleIndex = 3;
            this.colSaleId.Width = 80;
            //
            // colStatus
            //
            this.colStatus.Caption = "Status NF";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            this.colStatus.Width = 80;
            //
            // colDetail
            //
            this.colDetail.Caption = "Detalhe";
            this.colDetail.FieldName = "Detail";
            this.colDetail.Name = "colDetail";
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 5;
            this.colDetail.Width = 300;
            //
            // colException
            //
            this.colException.Caption = "Exceção";
            this.colException.FieldName = "Exception";
            this.colException.Name = "colException";
            this.colException.Width = 220;
            //
            // btnAtualizar
            //
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(588, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 27);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            //
            // btnLimparLogs
            //
            this.btnLimparLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparLogs.Location = new System.Drawing.Point(714, 12);
            this.btnLimparLogs.Name = "btnLimparLogs";
            this.btnLimparLogs.Size = new System.Drawing.Size(120, 27);
            this.btnLimparLogs.TabIndex = 2;
            this.btnLimparLogs.Text = "Limpar Logs Antigos";
            this.btnLimparLogs.UseVisualStyleBackColor = true;
            this.btnLimparLogs.Click += new System.EventHandler(this.btnLimparLogs_Click);
            //
            // btnLimparAlertas
            //
            this.btnLimparAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparAlertas.Location = new System.Drawing.Point(840, 12);
            this.btnLimparAlertas.Name = "btnLimparAlertas";
            this.btnLimparAlertas.Size = new System.Drawing.Size(132, 27);
            this.btnLimparAlertas.TabIndex = 3;
            this.btnLimparAlertas.Text = "Zerar Alertas do Dia";
            this.btnLimparAlertas.UseVisualStyleBackColor = true;
            this.btnLimparAlertas.Click += new System.EventHandler(this.btnLimparAlertas_Click);
            //
            // lblPendentes
            //
            this.lblPendentes.AutoSize = true;
            this.lblPendentes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendentes.ForeColor = System.Drawing.Color.Maroon;
            this.lblPendentes.Location = new System.Drawing.Point(12, 18);
            this.lblPendentes.Name = "lblPendentes";
            this.lblPendentes.Size = new System.Drawing.Size(146, 13);
            this.lblPendentes.TabIndex = 4;
            this.lblPendentes.Text = "Alertas silenciados hoje: 0";
            //
            // lblDias
            //
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(200, 19);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(68, 13);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Exibir últimos";
            //
            // numDias
            //
            this.numDias.Location = new System.Drawing.Point(270, 15);
            this.numDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(60, 20);
            this.numDias.TabIndex = 6;
            this.numDias.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDias.ValueChanged += new System.EventHandler(this.numDias_ValueChanged);
            //
            // grpDetalhe
            //
            this.grpDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetalhe.Controls.Add(this.txtDetalhe);
            this.grpDetalhe.Location = new System.Drawing.Point(12, 431);
            this.grpDetalhe.Name = "grpDetalhe";
            this.grpDetalhe.Size = new System.Drawing.Size(960, 140);
            this.grpDetalhe.TabIndex = 7;
            this.grpDetalhe.TabStop = false;
            this.grpDetalhe.Text = "Detalhe do registro selecionado";
            //
            // txtDetalhe
            //
            this.txtDetalhe.BackColor = System.Drawing.Color.White;
            this.txtDetalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetalhe.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDetalhe.Location = new System.Drawing.Point(3, 17);
            this.txtDetalhe.Multiline = true;
            this.txtDetalhe.Name = "txtDetalhe";
            this.txtDetalhe.ReadOnly = true;
            this.txtDetalhe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalhe.Size = new System.Drawing.Size(954, 120);
            this.txtDetalhe.TabIndex = 0;
            //
            // frmHistoricoNfceAuditoria
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 583);
            this.Controls.Add(this.grpDetalhe);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblPendentes);
            this.Controls.Add(this.btnLimparAlertas);
            this.Controls.Add(this.btnLimparLogs);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.grdLogs);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "frmHistoricoNfceAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Auditoria NFC-e";
            this.Load += new System.EventHandler(this.frmHistoricoNfceAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.grpDetalhe.ResumeLayout(false);
            this.grpDetalhe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLogs;
        private DevExpress.XtraGrid.Columns.GridColumn colTimestamp;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colEvent;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleId;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colException;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimparLogs;
        private System.Windows.Forms.Button btnLimparAlertas;
        private System.Windows.Forms.Label lblPendentes;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.GroupBox grpDetalhe;
        private System.Windows.Forms.TextBox txtDetalhe;
    }
}
