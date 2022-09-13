namespace Loja.Reports
{
	partial class relOrcamento
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
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relOrcamento));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.lblEmpresa = new DevExpress.XtraReports.UI.XRLabel();
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
			this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.CodOrca = new DevExpress.XtraReports.Parameters.Parameter();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15});
			this.Detail.HeightF = 16.74999F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.StyleName = "DataField";
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel10
			// 
			this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.CodProduto")});
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(174.8367F, 15F);
			this.xrLabel10.StylePriority.UseBorders = false;
			this.xrLabel10.Text = "xrLabel10";
			// 
			// xrLabel11
			// 
			this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.DescProduto")});
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(184.8367F, 0F);
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(283.0181F, 15F);
			this.xrLabel11.StylePriority.UseBorders = false;
			this.xrLabel11.Text = "xrLabel11";
			// 
			// xrLabel12
			// 
			this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.DesLocal")});
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(467.8549F, 0F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(48.46753F, 15F);
			this.xrLabel12.StylePriority.UseBorders = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "xrLabel12";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel13
			// 
			this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.Quantidade")});
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(516.3224F, 0F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(49.77399F, 15F);
			this.xrLabel13.StylePriority.UseBorders = false;
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "xrLabel13";
			this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel14
			// 
			this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.VlrUnitario", "{0:R$ 0.00}")});
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(566.0964F, 0F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(91.79572F, 15F);
			this.xrLabel14.StylePriority.UseBorders = false;
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "xrLabel14";
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel15
			// 
			this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.PF", "{0:R$ 0.00}")});
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(657.8921F, 0F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(94.10785F, 15F);
			this.xrLabel15.StylePriority.UseTextAlignment = false;
			xrSummary1.FormatString = "{0:R$0.00}";
			this.xrLabel15.Summary = xrSummary1;
			this.xrLabel15.Text = "xrLabel15";
			this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// groupHeaderBand1
			// 
			this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPageInfo1});
			this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CodOrca", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.groupHeaderBand1.HeightF = 39.99999F;
			this.groupHeaderBand1.Level = 1;
			this.groupHeaderBand1.Name = "groupHeaderBand1";
			// 
			// xrLabel16
			// 
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.xrLabel16.ForeColor = System.Drawing.Color.Navy;
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(530.536F, 0F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(72.38983F, 30F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseForeColor = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "Data:";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel2
			// 
			this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.CodOrca")});
			this.xrLabel2.Font = new System.Drawing.Font("Arial", 18F);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(219.8367F, 0F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(86.875F, 33.74999F);
			this.xrLabel2.StyleName = "DataField";
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 0F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(203.8367F, 33.74999F);
			this.xrLabel1.StyleName = "FieldCaption";
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.Text = "Orçamento Nro.:";
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.xrPageInfo1.ForeColor = System.Drawing.Color.Black;
			this.xrPageInfo1.Format = "{0:dd/MM/yyyy}";
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(614.3842F, 0F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(137.6157F, 30F);
			this.xrPageInfo1.StyleName = "PageInfo";
			this.xrPageInfo1.StylePriority.UseFont = false;
			this.xrPageInfo1.StylePriority.UseForeColor = false;
			// 
			// groupHeaderBand2
			// 
			this.groupHeaderBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLine1,
            this.xrLine2});
			this.groupHeaderBand2.HeightF = 33.11113F;
			this.groupHeaderBand2.Name = "groupHeaderBand2";
			this.groupHeaderBand2.StyleName = "FieldCaption";
			// 
			// xrLabel3
			// 
			this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10F, 7.000001F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(174.8367F, 20F);
			this.xrLabel3.StylePriority.UseBorders = false;
			this.xrLabel3.Text = "Código";
			// 
			// xrLabel4
			// 
			this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(184.8367F, 7.000005F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(283.0181F, 20F);
			this.xrLabel4.StylePriority.UseBorders = false;
			this.xrLabel4.Text = "Descrição";
			// 
			// xrLabel5
			// 
			this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(467.8549F, 7.000005F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(48.46753F, 20F);
			this.xrLabel5.StylePriority.UseBorders = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "Local";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrLabel6
			// 
			this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(516.3224F, 7F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(49.77399F, 20F);
			this.xrLabel6.StylePriority.UseBorders = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "Qtde";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel7
			// 
			this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Right;
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(566.0964F, 7.000005F);
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(91.79572F, 20F);
			this.xrLabel7.StylePriority.UseBorders = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "Vlr. Unitario";
			this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel8
			// 
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(657.892F, 7F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(94.10791F, 20F);
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "Vlr. Total ";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLine1
			// 
			this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(5.999979F, 4.999987F);
			this.xrLine1.Name = "xrLine1";
			this.xrLine1.SizeF = new System.Drawing.SizeF(745.9999F, 2.000018F);
			// 
			// xrLine2
			// 
			this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(5.999978F, 27F);
			this.xrLine2.Name = "xrLine2";
			this.xrLine2.SizeF = new System.Drawing.SizeF(745.9999F, 2.083332F);
			// 
			// pageFooterBand1
			// 
			this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrPageInfo2});
			this.pageFooterBand1.HeightF = 32.99997F;
			this.pageFooterBand1.Name = "pageFooterBand1";
			// 
			// xrLabel9
			// 
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.xrLabel9.ForeColor = System.Drawing.Color.Navy;
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(219.8367F, 9.999974F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(285.0724F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseForeColor = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "Valores sujeitos a alteração";
			this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.Format = "Página {0} de {1}";
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(576.7315F, 5.99999F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(175.2685F, 23F);
			this.xrPageInfo2.StyleName = "PageInfo";
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lblEmpresa.SizeF = new System.Drawing.SizeF(296.7117F, 33F);
			this.lblEmpresa.StyleName = "Title";
			this.lblEmpresa.Text = "AUTO PADRÃO PEÇAS";
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
			this.topMarginBand1.HeightF = 43F;
			this.topMarginBand1.Name = "topMarginBand1";
			// 
			// bottomMarginBand1
			// 
			this.bottomMarginBand1.HeightF = 15.44444F;
			this.bottomMarginBand1.Name = "bottomMarginBand1";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLine3,
            this.xrLabel19,
            this.xrLabel18});
			this.GroupFooter1.HeightF = 44.44444F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// xrLine4
			// 
			this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(5.999979F, 33.28705F);
			this.xrLine4.Name = "xrLine4";
			this.xrLine4.SizeF = new System.Drawing.SizeF(746F, 6.25F);
			// 
			// xrLine3
			// 
			this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 2.083333F);
			this.xrLine3.Name = "xrLine3";
			this.xrLine3.SizeF = new System.Drawing.SizeF(746F, 6.25F);
			// 
			// xrLabel19
			// 
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
			this.xrLabel19.ForeColor = System.Drawing.Color.Navy;
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(497.8039F, 10.00002F);
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(117.2942F, 23.28702F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseForeColor = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "Vlr. Total:";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel18
			// 
			this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tbl_Orcamento.PF")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(630.0092F, 10.00002F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(121.9908F, 23F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			xrSummary2.FormatString = "{0:R$ 0.00}";
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.xrLabel18.Summary = xrSummary2;
			this.xrLabel18.Text = "xrLabel18";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// CodOrca
			// 
			this.CodOrca.Description = "Número do Orçamento";
			this.CodOrca.Name = "CodOrca";
			this.CodOrca.Visible = false;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblEmpresa,
            this.xrLine5});
			this.PageHeader.HeightF = 54.16667F;
			this.PageHeader.Name = "PageHeader";
			// 
			// xrLine5
			// 
			this.xrLine5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(5.999979F, 47.91667F);
			this.xrLine5.Name = "xrLine5";
			this.xrLine5.SizeF = new System.Drawing.SizeF(746.0001F, 6.25F);
			this.xrLine5.StylePriority.UseBorderDashStyle = false;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "LojaContext";
			this.sqlDataSource1.Name = "sqlDataSource1";
			customSqlQuery1.Name = "tbl_Orcamento";
			customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// relOrcamento
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.pageFooterBand1,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.GroupFooter1,
            this.PageHeader});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "tbl_Orcamento";
			this.DataSource = this.sqlDataSource1;
			this.FilterString = "[CodOrca] = ?CodOrca";
			this.Margins = new System.Drawing.Printing.Margins(32, 43, 43, 15);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CodOrca});
			this.RequestParameters = false;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
			this.Version = "15.1";
			this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.relOrcamento_BeforePrint);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.XRLabel xrLabel10;
		private DevExpress.XtraReports.UI.XRLabel xrLabel11;
		private DevExpress.XtraReports.UI.XRLabel xrLabel12;
		private DevExpress.XtraReports.UI.XRLabel xrLabel13;
		private DevExpress.XtraReports.UI.XRLabel xrLabel14;
		private DevExpress.XtraReports.UI.XRLabel xrLabel15;
		private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
		private DevExpress.XtraReports.UI.XRLabel xrLabel6;
		private DevExpress.XtraReports.UI.XRLabel xrLabel7;
		private DevExpress.XtraReports.UI.XRLabel xrLabel8;
		private DevExpress.XtraReports.UI.XRLine xrLine1;
		private DevExpress.XtraReports.UI.XRLine xrLine2;
		private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
		private DevExpress.XtraReports.UI.XRLabel lblEmpresa;
		private DevExpress.XtraReports.UI.XRControlStyle Title;
		private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
		private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
		private DevExpress.XtraReports.UI.XRControlStyle DataField;
		private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
		private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
		private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel19;
		private DevExpress.XtraReports.UI.XRLabel xrLabel18;
		private DevExpress.XtraReports.Parameters.Parameter CodOrca;
		private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		private DevExpress.XtraReports.UI.XRLabel xrLabel16;
		private DevExpress.XtraReports.UI.XRLine xrLine3;
		private DevExpress.XtraReports.UI.XRLine xrLine4;
		private DevExpress.XtraReports.UI.XRLine xrLine5;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel9;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
	}
}
