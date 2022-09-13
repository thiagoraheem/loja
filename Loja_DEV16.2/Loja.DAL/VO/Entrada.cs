using System;
using System.Collections.Generic;
using System.ComponentModel;
using Loja.DAL.Models;

namespace Loja.DAL.VO
{
	public partial class Entrada : INotifyPropertyChanged
	{
		private int codEntrada;
		public int CodEntrada { get { return codEntrada; } set { codEntrada = value; NotifyPropertyChanged("CodEntrada"); } }

		private string docEntrada;
		public string DocEntrada { get { return docEntrada; } set { docEntrada = value; NotifyPropertyChanged("DocEntrada"); } }

		private string serieNota;
		public string SerieNota { get { return serieNota; } set { serieNota = value; NotifyPropertyChanged("SerieNota"); } }

		private DateTime? datEmissao;
		public Nullable<System.DateTime> DatEmissao { get { return datEmissao; } set { datEmissao = value; NotifyPropertyChanged("DatEmissao"); } }

		private DateTime datEntrada;
		public System.DateTime DatEntrada { get { return datEntrada; } set { datEntrada = value; NotifyPropertyChanged("DatEntrada"); } }

		private int codTipoEntrada;
		public int CodTipoEntrada { get { return codTipoEntrada; } set { codTipoEntrada = value; NotifyPropertyChanged("CodTipoEntrada"); } }
		
		private string cnpj;
		public string CNPJ { get { return cnpj; } set { cnpj = value; NotifyPropertyChanged("CNPJ"); } }
		
		private string cpf;
		public string CPF { get { return cpf; } set { cpf = value; NotifyPropertyChanged("CPF"); } }
		
		private string nome;
		public string Nome { get { return nome; } set { nome = value; NotifyPropertyChanged("Nome"); } }
		

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
