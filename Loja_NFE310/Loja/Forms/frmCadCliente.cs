using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Loja.DAL.Models;
using Loja.DAL.DAO;

namespace Loja
{
	public partial class frmCadCliente : DevExpress.XtraEditors.XtraForm
	{
		tbl_Cliente cliente;

		public frmCadCliente()
		{
			InitializeComponent();

			cliente = new tbl_Cliente();
			cliente.FlgStatus = true;
		}

		public frmCadCliente(int codCliente) {

			InitializeComponent();

			CarregaCliente(codCliente);


		}

		void CarregaCliente(int codCliente) { 
		
			cliente = Consultas.ObterCliente(codCliente);

			txtNomCliente.Text = cliente.NomCliente;
			txtNumCPF.Text = cliente.NumCPF;
			txtNumCNPJ.Text = cliente.NumCNPJ;
			txtNumTelefone.Text = cliente.NumTelefone;
			txtEndereco.Text = cliente.Endereco;
			txtNumero.Text = cliente.Numero;
			txtBairro.Text = cliente.Bairro;
			txtCidade.Text = cliente.Cidade;
			txtEstado.Text = cliente.Estado;
			txtPais.Text = cliente.Pais;
			txtEmail.Text = cliente.Email;
			txtCEP.Text = cliente.CEP;

		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
			cliente.NomCliente = txtNomCliente.Text.Trim();
			cliente.NumCPF = txtNumCPF.Text;
			cliente.NumCNPJ = txtNumCNPJ.Text;
			cliente.NumTelefone = txtNumTelefone.Text;
			cliente.Endereco = txtEndereco.Text;
			cliente.Numero = txtNumero.Text;
			cliente.Bairro = txtBairro.Text;
			cliente.Cidade = txtCidade.Text;
			cliente.Estado = txtEstado.Text;
			cliente.Pais = txtPais.Text;
			cliente.Email = txtEmail.Text;
			cliente.CEP = txtCEP.Text;

			Cadastros.GravaCliente(cliente);

			Close();

		}

	}
}