using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Loja.DAL.VO
{
	public partial class Produtos : INotifyPropertyChanged
	{

		private string _codProduto;
		public string CodProduto { get { return this._codProduto; } set { this._codProduto = value; NotifyPropertyChanged("CodProduto"); } }

		private string _desProduto;
		public string DesProduto { get { return this._desProduto; } set { this._desProduto = value; NotifyPropertyChanged("DesProduto"); } }

		private string _desLocal;
		public string DesLocal { get { return this._desLocal; } set { this._desLocal = value; NotifyPropertyChanged("DesLocal"); } }

		private double? _vlrUnitario;
		public Nullable<double> VlrUnitario { get { return this._vlrUnitario; } set { this._vlrUnitario = value; NotifyPropertyChanged("VlrUnitario"); } }

		private double? _qtdProduto;
		public Nullable<double> QtdProduto { get { return this._qtdProduto; } set { this._qtdProduto = value; NotifyPropertyChanged("QtdProduto"); } }

		private double? _vlrCusto;
		public Nullable<double> VlrCusto { get { return this._vlrCusto; } set { this._vlrCusto = value; NotifyPropertyChanged("VlrCusto"); } }

		private double? _vlrPercent;
		public Nullable<double> VlrPercent { get { return this._vlrPercent; } set { this._vlrPercent = value; NotifyPropertyChanged("VlrPercent"); } }

		private double? _estMinimo;
		public Nullable<double> EstMinimo { get { return this._estMinimo; } set { this._estMinimo = value; NotifyPropertyChanged("EstMinimo"); } }

		private string _datCadastro;
		public string DatCadastro
		{
			get { return this._datCadastro; }
			set
			{
				if (value != null && value.Length > 10)
				{
					this._datCadastro = value;
				}
				else
				{ 
					if(value != null)
					{ 
						this._datCadastro = value.Substring(0,10);
					}
					else
					{
						this._datCadastro = DateTime.Now.ToShortDateString();
					}
				}
				NotifyPropertyChanged("DatCadastro");
			}
		}

		private string _desFornecedor;
		public string DesFornecedor { get { return this._desFornecedor; } set { this._desFornecedor = value; NotifyPropertyChanged("DesFornecedor"); } }

		private string _codRefAntiga;
		public string CodRefAntiga { get { return this._codRefAntiga; } set { this._codRefAntiga = value; NotifyPropertyChanged("CodRefAntiga"); } }

		private double? _desFaz;
		public Nullable<double> DesFaz { get { return this._desFaz; } set { this._desFaz = value; NotifyPropertyChanged("DesFaz"); } }

		private double? _vlrUltPreco;
		public Nullable<double> VlrUltPreco { get { return this._vlrUltPreco; } set { this._vlrUltPreco = value; NotifyPropertyChanged("VlrUltPreco"); } }

		private byte[] _imagem;
		public byte[] Imagem { get { return this._imagem; } set { this._imagem = value; NotifyPropertyChanged("Imagem"); } }

		private int _codigounico;
		public int codigounico { get { return this._codigounico; } set { this._codigounico = value; NotifyPropertyChanged("codigounico"); } }

		private string _ncm;
		public string NCM { get { return this._ncm; } set { this._ncm = value; NotifyPropertyChanged("NCM"); } }

		private double? _vlrICMSST;
		public Nullable<double> VlrICMSST { get { return this._vlrICMSST; } set { this._vlrICMSST = value; NotifyPropertyChanged("VlrICMSST"); } }

		private void NotifyPropertyChanged(String propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
