namespace Loja.Forms
{
    partial class frmAuditorNF
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
            this.grdNotas = new DevExpress.XtraGrid.GridControl();
            this.gridViewNotas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInutilizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNotas
            // 
            this.grdNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNotas.Location = new System.Drawing.Point(12, 49);
            this.grdNotas.MainView = this.gridViewNotas;
            this.grdNotas.Name = "grdNotas";
            this.grdNotas.Size = new System.Drawing.Size(483, 200);
            this.grdNotas.TabIndex = 0;
            this.grdNotas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNotas});
            // 
            // gridViewNotas
            // 
            this.gridViewNotas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodVenda,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewNotas.GridControl = this.grdNotas;
            this.gridViewNotas.Name = "gridViewNotas";
            // 
            // colCodVenda
            // 
            this.colCodVenda.Caption = "Num. NF";
            this.colCodVenda.FieldName = "CodVenda";
            this.colCodVenda.Name = "colCodVenda";
            this.colCodVenda.Visible = true;
            this.colCodVenda.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Menor Nota";
            this.gridColumn1.FieldName = "MinVenda";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Maior Nota";
            this.gridColumn2.FieldName = "MaxVenda";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(407, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInutilizar
            // 
            this.btnInutilizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInutilizar.Location = new System.Drawing.Point(288, 12);
            this.btnInutilizar.Name = "btnInutilizar";
            this.btnInutilizar.Size = new System.Drawing.Size(107, 23);
            this.btnInutilizar.TabIndex = 2;
            this.btnInutilizar.Text = "&Inutilizar Número";
            this.btnInutilizar.UseVisualStyleBackColor = true;
            this.btnInutilizar.Click += new System.EventHandler(this.btnInutilizar_Click);
            // 
            // frmAuditorNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.btnInutilizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdNotas);
            this.Name = "frmAuditorNF";
            this.Text = "Auditor de NF";
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdNotas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNotas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnInutilizar;
        private DevExpress.XtraGrid.Columns.GridColumn colCodVenda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}