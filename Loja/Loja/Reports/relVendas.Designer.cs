namespace Loja.Reports
{
    partial class relVendas
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
			this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.lblEmpresa = new DevExpress.XtraReports.UI.XRLabel();
			this.lblEndereco = new DevExpress.XtraReports.UI.XRLabel();
			this.lblTelefone = new DevExpress.XtraReports.UI.XRLabel();
			this.tbl_SaidaTableAdapter1 = new Loja.relVendasTableAdapters.tbl_SaidaTableAdapter();
			this.relVendas1 = new Loja.relVendas();
			this.tbl_SaidaItensTableAdapter1 = new Loja.relVendasTableAdapters.tbl_SaidaItensTableAdapter();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			((System.ComponentModel.ISupportInitialize)(this.relVendas1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.Detail.HeightF = 28.20832F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.StyleName = "DataField";
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// pageFooterBand1
			// 
			this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
			this.pageFooterBand1.HeightF = 34.2083F;
			this.pageFooterBand1.Name = "pageFooterBand1";
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
			this.xrPageInfo1.StyleName = "PageInfo";
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.Format = "Page {0} of {1}";
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
			this.xrPageInfo2.StyleName = "PageInfo";
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel13
			// 
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 87.24995F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(728.9999F, 33F);
			this.xrLabel13.StyleName = "Title";
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "Relatório de Vendas";
			this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.Title.ForeColor = System.Drawing.Color.Navy;
			this.Title.Name = "Title";
			// 
			// FieldCaption
			// 
			this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
			this.FieldCaption.BorderColor = System.Drawing.Color.Black;
			this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.FieldCaption.BorderWidth = 1F;
			this.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.FieldCaption.ForeColor = System.Drawing.Color.Navy;
			this.FieldCaption.Name = "FieldCaption";
			// 
			// PageInfo
			// 
			this.PageInfo.BackColor = System.Drawing.Color.Transparent;
			this.PageInfo.BorderColor = System.Drawing.Color.Black;
			this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.PageInfo.BorderWidth = 1F;
			this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.PageInfo.ForeColor = System.Drawing.Color.Navy;
			this.PageInfo.Name = "PageInfo";
			// 
			// DataField
			// 
			this.DataField.BackColor = System.Drawing.Color.Transparent;
			this.DataField.BorderColor = System.Drawing.Color.Black;
			this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DataField.BorderWidth = 1F;
			this.DataField.Font = new System.Drawing.Font("Arial", 8F);
			this.DataField.ForeColor = System.Drawing.Color.Black;
			this.DataField.Name = "DataField";
			this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			// 
			// topMarginBand1
			// 
			this.topMarginBand1.HeightF = 39F;
			this.topMarginBand1.Name = "topMarginBand1";
			// 
			// bottomMarginBand1
			// 
			this.bottomMarginBand1.HeightF = 28F;
			this.bottomMarginBand1.Name = "bottomMarginBand1";
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblEmpresa,
            this.lblEndereco,
            this.lblTelefone,
            this.xrLabel13});
			this.PageHeader.HeightF = 157.2083F;
			this.PageHeader.Name = "PageHeader";
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblEmpresa.SizeF = new System.Drawing.SizeF(296.7117F, 33F);
			this.lblEmpresa.StyleName = "Title";
			this.lblEmpresa.Text = "AUTO PADRÃO PEÇAS";
			// 
			// lblEndereco
			// 
			this.lblEndereco.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lblEndereco.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.45829F);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblEndereco.SizeF = new System.Drawing.SizeF(395.67F, 23F);
			this.lblEndereco.Text = "Rua Parintins, 186 - Cachoeirinha - Cep: 69065-050";
			// 
			// lblTelefone
			// 
			this.lblTelefone.LocationFloat = new DevExpress.Utils.PointFloat(500.2316F, 44.45829F);
			this.lblTelefone.Multiline = true;
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblTelefone.SizeF = new System.Drawing.SizeF(175.2684F, 23F);
			this.lblTelefone.Text = "\r\n";
			// 
			// tbl_SaidaTableAdapter1
			// 
			this.tbl_SaidaTableAdapter1.ClearBeforeFill = true;
			// 
			// relVendas1
			// 
			this.relVendas1.DataSetName = "relVendas";
			this.relVendas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbl_SaidaItensTableAdapter1
			// 
			this.tbl_SaidaItensTableAdapter1.ClearBeforeFill = true;
			// 
			// xrTable1
			// 
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(243F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(486F, 25F);
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 11.5D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Saida.CodVenda")});
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.Text = "xrTableCell4";
			this.xrTableCell4.Weight = 0.13717421124828533D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Saida.Data")});
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.Text = "xrTableCell5";
			this.xrTableCell5.Weight = 0.13717421124828533D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Saida.FlgStatusNFE")});
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.Text = "xrTableCell6";
			this.xrTableCell6.Weight = 0.13717421124828533D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Saida.FlgStatusNota")});
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.Text = "xrTableCell7";
			this.xrTableCell7.Weight = 0.13717421124828533D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Saida.QtdItens")});
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Text = "xrTableCell8";
			this.xrTableCell8.Weight = 0.13717421124828533D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Saida.ValorTotal")});
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.Text = "xrTableCell9";
			this.xrTableCell9.Weight = 0.13717421124828533D;
			// 
			// relVendas
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.pageFooterBand1,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.PageHeader});
			this.DataAdapter = this.tbl_SaidaTableAdapter1;
			this.DataMember = "tbl_Saida";
			this.DataSource = this.relVendas1;
			this.Margins = new System.Drawing.Printing.Margins(60, 61, 39, 28);
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
			this.Version = "15.1";
			this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.relVendas_BeforePrint);
			((System.ComponentModel.ISupportInitialize)(this.relVendas1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
		private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel lblEmpresa;
        private DevExpress.XtraReports.UI.XRLabel lblEndereco;
        private DevExpress.XtraReports.UI.XRLabel lblTelefone;
		private relVendasTableAdapters.tbl_SaidaTableAdapter tbl_SaidaTableAdapter1;
		private Loja.relVendas relVendas1;
		private relVendasTableAdapters.tbl_SaidaItensTableAdapter tbl_SaidaItensTableAdapter1;
		private DevExpress.XtraReports.UI.XRTable xrTable1;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
    }
}
