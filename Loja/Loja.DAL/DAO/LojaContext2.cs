using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Loja.DAL.Models.Mapping;
using CodeFirstStoreFunctions;
using System.Data.Entity.Core.Objects;
using System;

namespace Loja.DAL.Models
{
    public partial class LojaContext2 : DbContext
    {
        static LojaContext2()
        {
            Database.SetInitializer<LojaContext>(null);
        }

        public LojaContext2()
            : base("Name=LojaContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tbl_Entrada> tbl_Entrada { get; set; }
        public DbSet<tbl_Orcamento> tbl_Orcamento { get; set; }
        public DbSet<tbl_Parametros> tbl_Parametros { get; set; }
        public DbSet<tbl_Preco> tbl_Preco { get; set; }
        public DbSet<tbl_Produtos> tbl_Produtos { get; set; }
        public DbSet<tbl_Saida> tbl_Saida { get; set; }
        public DbSet<tbl_SaidaItens> tbl_SaidaItens { get; set; }
        public DbSet<tbl_SaidasEstorno> tbl_SaidasEstorno { get; set; }
        public DbSet<tbl_TipoEntrada> tbl_TipoEntrada { get; set; }
        public DbSet<tbl_TipoVenda> tbl_TipoVenda { get; set; }
        public DbSet<tbl_Usuario> tbl_Usuario { get; set; }
        public DbSet<viw_Orcamento> viw_Orcamento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tbl_EntradaMap());
            modelBuilder.Configurations.Add(new tbl_OrcamentoMap());
            modelBuilder.Configurations.Add(new tbl_ParametrosMap());
            modelBuilder.Configurations.Add(new tbl_PrecoMap());
            modelBuilder.Configurations.Add(new tbl_ProdutosMap());
            modelBuilder.Configurations.Add(new tbl_SaidaMap());
            modelBuilder.Configurations.Add(new tbl_SaidaItensMap());
            modelBuilder.Configurations.Add(new tbl_SaidasEstornoMap());
            modelBuilder.Configurations.Add(new tbl_TipoEntradaMap());
            modelBuilder.Configurations.Add(new tbl_TipoVendaMap());
            modelBuilder.Configurations.Add(new tbl_UsuarioMap());
            modelBuilder.Configurations.Add(new viw_OrcamentoMap());

			modelBuilder.Conventions.Add(new FunctionsConvention<LojaContext>("dbo"));
        }

		public void spc_EstornaVenda(int codVenda, int codProduto, string desMotivo)
		{
			try
			{
				var cVenda = new ObjectParameter("CodVenda", codVenda);
				var cProduto = new ObjectParameter("CodProduto", codProduto);
				var dMotivo = new ObjectParameter("DesMotivo", desMotivo);

				//int result = this.Database.ExecuteSqlCommand("spc_EstornaVenda", codVenda);
				((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spc_EstornaVenda", cVenda, cProduto, dMotivo);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

    }
}
