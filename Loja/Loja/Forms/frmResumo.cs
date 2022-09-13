using Loja.DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja.Forms
{
    public partial class frmResumo: Form
    {
        public frmResumo()
        {
            InitializeComponent();
        }

		private void frmResumo_Load(object sender, EventArgs e)
		{
			
			var dados1 = Consultas.ObterQtdeProdutos();
			var dados2 = Consultas.ObterQtdeItens();
			var dados3 = Consultas.ObterValorEstoque();
			var dados4 = Consultas.ObterValorEstoqueBruto();

			txtQtdItens.EditValue = dados2;
			txtQtdProdutos.EditValue = dados1;

			txtValorBruto.EditValue = dados4;
			txtValorProdutos.EditValue = dados3;
			
			
		}

		private void frmResumo_MouseClick(object sender, MouseEventArgs e)
		{
			this.Close();
		}
    }
}
