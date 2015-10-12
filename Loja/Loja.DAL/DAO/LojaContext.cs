using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Loja.DAL.Models.Mapping;
using CodeFirstStoreFunctions;
using System.Data.Entity.Core.Objects;
using System;
using System.Data.SqlClient;

namespace Loja.DAL.Models
{
	public partial class LojaContext : DbContext
	{

		public ObjectResult<string> spc_AdicionarOrcamento(string codOrcamento, int codProduto)
		{
			try
			{
				var cOrca = new ObjectParameter("CodOrca", codOrcamento);
				var cProduto = new ObjectParameter("CodProduto", codProduto);

				return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spc_AdicionarOrcamento", cOrca, cProduto);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public void spc_ApagarOrcamento(string codOrcamento)
		{
			try
			{
				var cOrca = new SqlParameter("@Original_CodOrca", codOrcamento);

				((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("spc_ApagarOrcamento @Original_CodOrca", cOrca);
			}
			catch (Exception ex)
			{
				if (ex.InnerException == null) { 
					throw new Exception(ex.Message);
				}
				else {
					throw new Exception(ex.InnerException.Message);
				}
			}

		}

		public void spc_AlterarOrcamento(string codOrca, int codProduto, double qtde, double vlrUnitario)
		{
			try
			{
				var cOrca = new SqlParameter("@CodOrca", codOrca);
				var cProduto = new SqlParameter("@CodProduto", codProduto);
				var qtd = new SqlParameter("@Quantidade", qtde);
				var vUnitario = new SqlParameter("@VlrUnitario", vlrUnitario);
				
				this.Database.ExecuteSqlCommand("spc_AlterarOrcamento @CodOrca, @CodProduto, @Quantidade, @VlrUnitario", cOrca, cProduto, qtd, vUnitario);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		
		public void spc_EstornaVenda(int codVenda, int codProduto, string desMotivo)
		{
			try
			{
				var cVenda = new ObjectParameter("CodVenda", codVenda);
				var cProduto = new ObjectParameter("CodProduto", codProduto);
				var dMotivo = new ObjectParameter("DesMotivo", desMotivo);

				((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spc_EstornaVenda", cVenda, cProduto, dMotivo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public void spc_DescontoVenda(string codOrca, decimal desconto)
		{
			try
			{
				var cOrca = new ObjectParameter("CodOrca", codOrca);
				var desc = new ObjectParameter("Desconto", desconto);

				((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spc_DescontoVenda", cOrca, desc);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public ObjectResult<int> spc_FinalizaVenda(string codOrca, int codTipoVenda, string flgApagarOrca)
		{
			try
			{
				var cOrca = new ObjectParameter("CodOrca", codOrca);
				var cTipoVenda = new ObjectParameter("CodTipoVenda", codTipoVenda);
				var fApagarOrca = new ObjectParameter("flgApagarOrca", flgApagarOrca);

				return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("spc_FinalizaVenda", cOrca, cTipoVenda, fApagarOrca);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}


		public ObjectResult<int> spc_AdicionarEntrada(string docEntrada, DateTime datEntrada, int codProduto, double qtdProduto, decimal vlrUnitario, int codTipoEntrada, double percentual, string desFornecedor)
		{
			try
			{
				var dEntrada = new ObjectParameter("DocEntrada", docEntrada);
				var dataEntrada = new ObjectParameter("DatEntrada", datEntrada);
				var cProduto = new ObjectParameter("CodProduto", codProduto);
				var qProduto = new ObjectParameter("QtdProduto", qtdProduto);
				var vUnitario = new ObjectParameter("VlrUnitario", vlrUnitario);
				var cTipoEntrada = new ObjectParameter("CodTipoEntrada", codTipoEntrada);
				var perce = new ObjectParameter("Percentual", percentual);
				var dFornecedor = new ObjectParameter("DesFornecedor", desFornecedor);

				return ((IObjectContextAdapter)this).ObjectContext
					.ExecuteFunction<int>("spc_AdicionarEntrada", dEntrada, dataEntrada, cProduto, qProduto, vUnitario, cTipoEntrada, perce, dFornecedor);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public void spc_AlterarEntrada(string docEntrada, DateTime datEntrada, int codigounico, double quantidade, double vlrUnitario)
		{
			try
			{
				var dEntrada = new ObjectParameter("DocEntrada", docEntrada);
				var dataEntrada = new ObjectParameter("DatEntrada", datEntrada);
				var cProduto = new ObjectParameter("CodProduto", codigounico);
				var qProduto = new ObjectParameter("QtdProduto", quantidade);
				var vUnitario = new ObjectParameter("VlrUnitario", vlrUnitario);

				((IObjectContextAdapter)this).ObjectContext
					.ExecuteFunction<int>("spc_AlterarEntrada", dEntrada, dataEntrada, cProduto, qProduto, vUnitario);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}


		public void spc_ManutProduto(int codigounico, string codProduto, string desProduto, string desLocal, double vlrUnitario,
									double qtdProduto, double vlrCusto, double vlrPercent, double estMinimo, string desFornecedor,
									string codRefAntiga, double vlrUltPreco, byte[] imagem)
		{
			try
			{
				var codigo = new ObjectParameter("@codigounico", codigounico);
				var cProduto = new ObjectParameter("@codProduto", codProduto);
				var dProduto = new ObjectParameter("@desProduto", desProduto);
				var dLocal = new ObjectParameter("@desLocal", desLocal);
				var vUnitario = new ObjectParameter("@VlrUnitario", vlrUnitario);

				var qProduto = new ObjectParameter("@qtdProduto", qtdProduto);
				var vCusto = new ObjectParameter("@vlrCusto", vlrCusto);
				var vPercent = new ObjectParameter("@vlrPercent", vlrPercent);
				var eMinimo = new ObjectParameter("@estMinimo", estMinimo);
				var dFornecedor = new ObjectParameter("@desFornecedor", desFornecedor);
				var cRefAntiga = new ObjectParameter("@codRefAntiga", codRefAntiga);
				var vUltPreco = new ObjectParameter("@vlrUltPreco", vlrUltPreco);
				var img = new ObjectParameter("@imagem", imagem);

				this.Database.ExecuteSqlCommand("spc_ManutProduto @codigounico, @codProduto, @desProduto, @desLocal, @VlrUnitario, @qtdProduto, @vlrCusto, @vlrPercent, @estMinimo, @desFornecedor, @codRefAntiga, @vlrUltPreco, @imagem", 
					codigo, cProduto, dProduto, dLocal, vUnitario, qProduto, vCusto,
					vPercent, eMinimo, dFornecedor, cRefAntiga, vUltPreco, img);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}


		public ObjectResult<int> spc_Reajuste(decimal porcentagem, string desFornecedor)
		{
			try
			{
				var perc = new ObjectParameter("Porcentagem", porcentagem);
				var dFornecedor = new ObjectParameter("DesFornecedor", desFornecedor);

				return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int>("spc_Reajuste", perc, dFornecedor);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
	}
}
