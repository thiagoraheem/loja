namespace Loja.Reports
{
    partial class relRecibo
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblEmpresaAssinatura = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lblData = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.Extenso = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.Referente = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Nome = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.VlrTotal = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTelefone = new DevExpress.XtraReports.UI.XRLabel();
            this.lblInscEstadual = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCnpj = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEndereco = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEmpresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblCidade = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEstado = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblEstado,
            this.lblCidade,
            this.lblEmpresaAssinatura,
            this.xrLine1,
            this.lblData,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.lblTelefone,
            this.lblInscEstadual,
            this.lblCnpj,
            this.lblEndereco,
            this.lblEmpresa,
            this.xrLabel1,
            this.xrShape1});
            this.Detail.HeightF = 545.7916F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblEmpresaAssinatura
            // 
            this.lblEmpresaAssinatura.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F);
            this.lblEmpresaAssinatura.LocationFloat = new DevExpress.Utils.PointFloat(12.08337F, 454.5834F);
            this.lblEmpresaAssinatura.Name = "lblEmpresaAssinatura";
            this.lblEmpresaAssinatura.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEmpresaAssinatura.SizeF = new System.Drawing.SizeF(680.5833F, 23F);
            this.lblEmpresaAssinatura.StylePriority.UseFont = false;
            this.lblEmpresaAssinatura.StylePriority.UseTextAlignment = false;
            this.lblEmpresaAssinatura.Text = "Auto Padrão Peças";
            this.lblEmpresaAssinatura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(162.0834F, 441.0417F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(375.375F, 13.54166F);
            // 
            // lblData
            // 
            this.lblData.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.lblData.LocationFloat = new DevExpress.Utils.PointFloat(12.08337F, 379.125F);
            this.lblData.Name = "lblData";
            this.lblData.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblData.SizeF = new System.Drawing.SizeF(680.5833F, 23F);
            this.lblData.StylePriority.UseFont = false;
            this.lblData.StylePriority.UseTextAlignment = false;
            this.lblData.Text = "lblData";
            this.lblData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Extenso, "Text", "")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(142.7083F, 255.2083F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(547.8751F, 42.79169F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Extenso
            // 
            this.Extenso.Description = "Valor por extenso";
            this.Extenso.Name = "Extenso";
            this.Extenso.Visible = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Referente, "Text", "")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(142.7083F, 308.2083F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(547.875F, 44.875F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            // 
            // Referente
            // 
            this.Referente.Description = "Recibo referente a?";
            this.Referente.Name = "Referente";
            this.Referente.Visible = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Nome, "Text", "")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(142.7083F, 216.7083F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(547.875F, 23.00005F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel7";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Nome
            // 
            this.Nome.Description = "Nome do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.Visible = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 308.2083F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(122.2917F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Referente a";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 255.2083F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(122.2917F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "a quantida de";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.VlrTotal, "Text", "{0:R$ 0.00}")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(582.2502F, 180.1666F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(108.3332F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // VlrTotal
            // 
            this.VlrTotal.Description = "Valor do Recibo";
            this.VlrTotal.Name = "VlrTotal";
            this.VlrTotal.Type = typeof(decimal);
            this.VlrTotal.ValueInfo = "0";
            this.VlrTotal.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(482.2502F, 180.1666F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "VALOR:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 216.7083F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(122.2917F, 23.00002F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Recebi(emos) de ";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblTelefone
            // 
            this.lblTelefone.LocationFloat = new DevExpress.Utils.PointFloat(546.8334F, 10.00001F);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTelefone.SizeF = new System.Drawing.SizeF(143.75F, 23F);
            this.lblTelefone.StylePriority.UseTextAlignment = false;
            this.lblTelefone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblInscEstadual
            // 
            this.lblInscEstadual.LocationFloat = new DevExpress.Utils.PointFloat(385.3752F, 61.20837F);
            this.lblInscEstadual.Name = "lblInscEstadual";
            this.lblInscEstadual.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblInscEstadual.SizeF = new System.Drawing.SizeF(305.2082F, 23F);
            this.lblInscEstadual.StylePriority.UseTextAlignment = false;
            this.lblInscEstadual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblCnpj
            // 
            this.lblCnpj.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 61.20837F);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCnpj.SizeF = new System.Drawing.SizeF(328.125F, 23F);
            // 
            // lblEndereco
            // 
            this.lblEndereco.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 38.20836F);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEndereco.SizeF = new System.Drawing.SizeF(680.5833F, 23F);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblEmpresa.ForeColor = System.Drawing.Color.Navy;
            this.lblEmpresa.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 10.00001F);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEmpresa.SizeF = new System.Drawing.SizeF(255.2083F, 28.20834F);
            this.lblEmpresa.StylePriority.UseFont = false;
            this.lblEmpresa.StylePriority.UseForeColor = false;
            this.lblEmpresa.Text = "AUTO PADRÃO PEÇAS";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.BorderWidth = 4;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Arial", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 125.625F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(680.5834F, 42.79169F);
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Recibo\r\n";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrShape1
            // 
            this.xrShape1.LineWidth = 2;
            this.xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.Shape = shapeRectangle1;
            this.xrShape1.SizeF = new System.Drawing.SizeF(703.125F, 509.7917F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 32F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblCidade
            // 
            this.lblCidade.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 84.20836F);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCidade.SizeF = new System.Drawing.SizeF(328.125F, 23F);
            // 
            // lblEstado
            // 
            this.lblEstado.LocationFloat = new DevExpress.Utils.PointFloat(385.3752F, 84.20836F);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEstado.SizeF = new System.Drawing.SizeF(305.2082F, 23F);
            // 
            // relRecibo
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new DevExpress.Drawing.DXMargins(57, 82, 50, 32);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.VlrTotal,
            this.Extenso,
            this.Nome,
            this.Referente});
            this.Version = "12.2";
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.relRecibo_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRShape xrShape1;
        private DevExpress.XtraReports.UI.XRLabel lblEmpresa;
        private DevExpress.XtraReports.Parameters.Parameter VlrTotal;
        private DevExpress.XtraReports.Parameters.Parameter Extenso;
        private DevExpress.XtraReports.Parameters.Parameter Nome;
        private DevExpress.XtraReports.Parameters.Parameter Referente;
        private DevExpress.XtraReports.UI.XRLabel lblTelefone;
        private DevExpress.XtraReports.UI.XRLabel lblInscEstadual;
        private DevExpress.XtraReports.UI.XRLabel lblCnpj;
        private DevExpress.XtraReports.UI.XRLabel lblEndereco;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel lblEmpresaAssinatura;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lblData;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel lblEstado;
        private DevExpress.XtraReports.UI.XRLabel lblCidade;
    }
}
