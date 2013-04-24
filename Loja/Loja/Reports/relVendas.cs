﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Loja.Reports
{
    public partial class relVendas : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime _DatIni;
        private DateTime _DatFim;
        private int _CodProduto;
        private int _CodTipoVenda;

        public relVendas(DateTime DatIni, DateTime DatFim, int CodProduto, int CodTipoVenda)
        {
            InitializeComponent();

            this._DatIni = DatIni;
            this._DatFim = DatFim;
            this._CodProduto = CodProduto;
            this._CodTipoVenda = CodTipoVenda;

        }

        private void relVendas_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
