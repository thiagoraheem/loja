using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Loja.DAL.Models.Mapping;
using CodeFirstStoreFunctions;
using System.Data.Entity.Core.Objects;
using System;

namespace Loja.DAL.Models
{
	public partial class LojaContext : DbContext
	{
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
				var cOrca = new ObjectParameter("CodOrca", codOrcamento);

				((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spc_ApagarOrcamento", cOrca);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public void spc_AlterarOrcamento(string codOrca, int codProduto, double qtde, double vlrUnitario)
		{
			try
			{
				var cOrca = new ObjectParameter("CodOrca", codOrca);
				var cProduto = new ObjectParameter("CodProduto", codProduto);
				var qtd = new ObjectParameter("Quantidade", qtde);
				var vUnitario = new ObjectParameter("VlrUnitario", vlrUnitario);

				((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spc_AlterarOrcamento", cOrca, cProduto, qtd, vUnitario);
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

	}
}
