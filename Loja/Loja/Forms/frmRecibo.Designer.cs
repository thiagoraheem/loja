namespace Loja
{
    partial class frmRecibo
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
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
			this.txtValor = new DevExpress.XtraEditors.CalcEdit();
			this.txtExtenso = new DevExpress.XtraEditors.TextEdit();
			this.txtNome = new DevExpress.XtraEditors.TextEdit();
			this.txtReferente = new DevExpress.XtraEditors.MemoEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtenso.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReferente.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(49, 8);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(28, 13);
			this.labelControl1.TabIndex = 6;
			this.labelControl1.Text = "Valor:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(34, 36);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(43, 13);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Extenso:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(46, 63);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(31, 13);
			this.labelControl3.TabIndex = 8;
			this.labelControl3.Text = "Nome:";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(24, 90);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(53, 13);
			this.labelControl4.TabIndex = 9;
			this.labelControl4.Text = "Referente:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Location = new System.Drawing.Point(370, 165);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(289, 165);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 4;
			this.btnImprimir.Text = "&Imprimir";
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// txtValor
			// 
			this.txtValor.EnterMoveNextControl = true;
			this.txtValor.Location = new System.Drawing.Point(94, 5);
			this.txtValor.Name = "txtValor";
			this.txtValor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtValor.Properties.Mask.EditMask = "c";
			this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtValor.Size = new System.Drawing.Size(351, 20);
			this.txtValor.TabIndex = 0;
			this.txtValor.Validated += new System.EventHandler(this.txtValor_Validated);
			// 
			// txtExtenso
			// 
			this.txtExtenso.EnterMoveNextControl = true;
			this.txtExtenso.Location = new System.Drawing.Point(94, 33);
			this.txtExtenso.Name = "txtExtenso";
			this.txtExtenso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtExtenso.Size = new System.Drawing.Size(351, 20);
			this.txtExtenso.TabIndex = 1;
			// 
			// txtNome
			// 
			this.txtNome.EnterMoveNextControl = true;
			this.txtNome.Location = new System.Drawing.Point(94, 60);
			this.txtNome.Name = "txtNome";
			this.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Size = new System.Drawing.Size(351, 20);
			this.txtNome.TabIndex = 2;
			// 
			// txtReferente
			// 
			this.txtReferente.EnterMoveNextControl = true;
			this.txtReferente.Location = new System.Drawing.Point(94, 87);
			this.txtReferente.Name = "txtReferente";
			this.txtReferente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferente.Size = new System.Drawing.Size(351, 72);
			this.txtReferente.TabIndex = 3;
			// 
			// frmRecibo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(457, 200);
			this.Controls.Add(this.txtReferente);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtExtenso);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmRecibo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recibo";
			((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtenso.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReferente.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
		private DevExpress.XtraEditors.SimpleButton btnImprimir;
        public DevExpress.XtraEditors.CalcEdit txtValor;
        public DevExpress.XtraEditors.TextEdit txtExtenso;
		public DevExpress.XtraEditors.TextEdit txtNome;
		public DevExpress.XtraEditors.MemoEdit txtReferente;
    }
}