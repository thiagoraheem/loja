namespace Loja
{
    partial class frmReajuste
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmbFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPercentual = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.btnOk);
            this.groupControl1.Controls.Add(this.cmbFornecedor);
            this.groupControl1.Controls.Add(this.txtPercentual);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(213, 181);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Reajustar preços";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(133, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(52, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.EnterMoveNextControl = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(87, 89);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFornecedor.Properties.DisplayMember = "Fornecedor";
            this.cmbFornecedor.Properties.NullText = "Selecione um fornecedor";
            this.cmbFornecedor.Properties.ValueMember = "Fornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(111, 20);
            this.cmbFornecedor.TabIndex = 1;
            // 
            // txtPercentual
            // 
            this.txtPercentual.EnterMoveNextControl = true;
            this.txtPercentual.Location = new System.Drawing.Point(86, 42);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPercentual.Properties.Mask.EditMask = "P";
            this.txtPercentual.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercentual.Size = new System.Drawing.Size(112, 20);
            this.txtPercentual.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Fornecedor:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Percentual:";
            // 
            // frmReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(213, 181);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmReajuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reajustar preços";
            this.Load += new System.EventHandler(this.frmReajuste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LookUpEdit cmbFornecedor;
        private DevExpress.XtraEditors.CalcEdit txtPercentual;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}