using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Loja
{
	class Util {
		// O método toExtenso recebe um valor do tipo decimal
		public static string toExtenso(decimal valor)
		{
			if (valor <= 0 | valor >= 1000000000000000)
				return "Valor não suportado pelo sistema.";
			else
			{
				string strValor = valor.ToString("000000000000000.00");
				string valor_por_extenso = string.Empty;
 
				for (int i = 0; i <= 15; i += 3)
				{
					valor_por_extenso += escreva_parte(Convert.ToDecimal(strValor.Substring(i, 3)));
					if (i == 0 & valor_por_extenso != string.Empty)
					{
						if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
							valor_por_extenso += " TRILHÃO" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
						else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
							valor_por_extenso += " TRILHÕES" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
					}
					else if (i == 3 & valor_por_extenso != string.Empty)
					{
						if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
							valor_por_extenso += " BILHÃO" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
						else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
							valor_por_extenso += " BILHÕES" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
					}
					else if (i == 6 & valor_por_extenso != string.Empty)
					{
						if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
							valor_por_extenso += " MILHÃO" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
						else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
							valor_por_extenso += " MILHÕES" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
					}
					else if (i == 9 & valor_por_extenso != string.Empty)
						if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
							valor_por_extenso += " MIL" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " E " : string.Empty);
 
					if (i == 12)
					{
						if (valor_por_extenso.Length > 8)
							if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "BILHÃO" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
								valor_por_extenso += " DE";
							else
								if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "BILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
									valor_por_extenso += " DE";
								else
									if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "TRILHÕES")
										valor_por_extenso += " DE";
 
						if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
							valor_por_extenso += " REAL";
						else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
							valor_por_extenso += " REAIS";
 
						if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
							valor_por_extenso += " E ";
					}
 
					if (i == 15)
						if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
							valor_por_extenso += " CENTAVO";
						else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
							valor_por_extenso += " CENTAVOS";
				}
				return valor_por_extenso;
			}
		}
 
		static string escreva_parte(decimal valor)
		{
			if (valor <= 0)
				return string.Empty;
			else
			{
				string montagem = string.Empty;
				if (valor > 0 & valor < 1)
				{
					valor *= 100;
				}
				string strValor = valor.ToString("000");
				int a = Convert.ToInt32(strValor.Substring(0, 1));
				int b = Convert.ToInt32(strValor.Substring(1, 1));
				int c = Convert.ToInt32(strValor.Substring(2, 1));
 
				if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
				else if (a == 2) montagem += "DUZENTOS";
				else if (a == 3) montagem += "TREZENTOS";
				else if (a == 4) montagem += "QUATROCENTOS";
				else if (a == 5) montagem += "QUINHENTOS";
				else if (a == 6) montagem += "SEISCENTOS";
				else if (a == 7) montagem += "SETECENTOS";
				else if (a == 8) montagem += "OITOCENTOS";
				else if (a == 9) montagem += "NOVECENTOS";
 
				if (b == 1)
				{
					if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
					else if (c == 1) montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
					else if (c == 2) montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
					else if (c == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
					else if (c == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
					else if (c == 5) montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
					else if (c == 6) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
					else if (c == 7) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
					else if (c == 8) montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
					else if (c == 9) montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";
				}
				else if (b == 2) montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
				else if (b == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
				else if (b == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
				else if (b == 5) montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
				else if (b == 6) montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
				else if (b == 7) montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
				else if (b == 8) montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
				else if (b == 9) montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";
 
				if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";
 
				if (strValor.Substring(1, 1) != "1")
					if (c == 1) montagem += "UM";
					else if (c == 2) montagem += "DOIS";
					else if (c == 3) montagem += "TRÊS";
					else if (c == 4) montagem += "QUATRO";
					else if (c == 5) montagem += "CINCO";
					else if (c == 6) montagem += "SEIS";
					else if (c == 7) montagem += "SETE";
					else if (c == 8) montagem += "OITO";
					else if (c == 9) montagem += "NOVE";
 
				return montagem;
			}
		}

		public static void MsgBox(String msg) {
			DevExpress.XtraEditors.XtraMessageBox.Show(msg, DevExpress.Utils.DefaultBoolean.True);
		}

		public static void MsgBox2(String msg)
		{
			//DevExpress.XtraEditors.XtraMessageBoxForm..XtraMessageBox.Show(msg);
		}

		public static void CopiarDoDbf()
		{
			OleDbConnection oConn = new OleDbConnection() { ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\Loja;Extended Properties=dBASE III;" };

			/*OdbcConnection oConn = new OdbcConnection()
			{
				ConnectionString = @"Driver={Microsoft Access dBase Driver (*.dbf, *.ndx, *.mdx)};SourceType=DBF;SourceDB=c:\LOJA\;Exclusive=No;  _
																	 Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;"
			};*/

			//OdbcConnection oConn = new OdbcConnection() { ConnectionString = Properties.Settings.Default.ConnDBF };
			SqlConnection oConn2 = new SqlConnection() { ConnectionString = Properties.Settings.Default.ConnLOJADBF };

			DataTable dt = new DataTable();
			try
			{
				oConn.Open();
				using (OleDbCommand oCmd = oConn.CreateCommand())
				//using (OdbcCommand oCmd = oConn.CreateCommand())
				{
					oCmd.CommandText = @"SELECT * FROM c:\Loja\CAD_PEC.dbf";
					dt.Load(oCmd.ExecuteReader());
				}
				oConn.Close();

				oConn2.Open();///this is my connection to the sql server

				//create a reader for the datatable
				SqlCommand exec1 = new SqlCommand("TRUNCATE TABLE CAD_PEC", oConn2);
				exec1.ExecuteNonQuery();

				using (DataTableReader reader = dt.CreateDataReader())
				{
					SqlBulkCopy sqlcpy = new SqlBulkCopy(oConn2) { DestinationTableName = "CAD_PEC" };
					//copy the datatable to the sql table
					sqlcpy.WriteToServer(dt);
					reader.Close();
				}

				SqlCommand exec = new SqlCommand("EXEC spc_AtualizaProdutos", oConn2);
				exec.ExecuteNonQuery();

				oConn2.Close();

			}
			catch (Exception ex) {
				MsgBox("Erro ao conectar ao DBF: " + ex.Message);
			}

		}

		public static string ComandoACBR(string comando)
		{
			var retorno = "";
			
			try
			{
				using (var cliente = new TcpClient())
				{
					String responseData = String.Empty;
					Byte[] data = new Byte[512];

					cliente.Connect("127.0.0.1", 3434);

					if (String.IsNullOrEmpty(comando)) { comando = "NFE.StatusServico"; }
					
					// concatena na string com o comando os códigos para o monitor entender
					comando += "\r\n.\r\n";

					// abre um stream para comunicação
					NetworkStream stream = cliente.GetStream();

					// lê o que possivelmente estiver sendo enviado pelo monitor
					Int32 bytes = stream.Read(data, 0, data.Length);

					// traduz os bytes em string
					responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);


					// Traduz a string para bytes
					data = System.Text.Encoding.ASCII.GetBytes(comando);

					// envia o comando
					stream.Write(data, 0, data.Length);
					stream.Flush();

					int i = -1;
					i = stream.Read(data, 0, 1);
					var letra = "";
					responseData = String.Empty;

					while (letra != ((char)3).ToString()) { 

						i = stream.Read(data, 0, 1);
						letra = System.Text.Encoding.ASCII.GetString(data, 0, i);
						if (letra != ((char)3).ToString())
						{
							responseData += letra;
						}

					}

					retorno = responseData;

					stream.Close();
					cliente.Close();

					return retorno;
				}
			}
			catch (Exception ex)
			{
				retorno += "ERRO: " + ex.Message;

				return retorno;
			}

		}

		/// <summary>
		///     Abre o diálogo de busca de arquivo com com os dados passados no parâmetro
		/// </summary>
		/// <param name="arquivoPadrao">Nome do arquivo padrão a ser exibido no diálogo</param>
		/// <param name="extensaoPadrao">Extensão de arquivo padrão a ser exibida no diálogo</param>
		/// <param name="filtro">Filtro de extensões a ser exibido no diálogo</param>
		/// <returns></returns>
		public static string BuscarArquivo(string titulo, string extensaoPadrao, string filtro, string arquivoPadrao = null)
		{
			var dlg = new OpenFileDialog
			{
				Title = titulo,
				FileName = arquivoPadrao,
				DefaultExt = extensaoPadrao,
				Filter = filtro
			};
			dlg.ShowDialog();
			return dlg.FileName;
		}

		public static string SemFormatacao(string texto)
		{

			return texto.Replace(".", "").Replace("/", "").Replace("-", "").Replace(",", "").Replace(":", "");

		}

		public static bool PingHost(string nameOrAddress)
		{
			bool pingable = false;
			System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();
			try
			{
				System.Net.NetworkInformation.PingReply reply = pinger.Send(nameOrAddress);
				pingable = reply.Status == System.Net.NetworkInformation.IPStatus.Success;
			}
			catch (System.Net.NetworkInformation.PingException)
			{
				// Discard PingExceptions and return false;
			}
			return pingable;
		}
	}
}
