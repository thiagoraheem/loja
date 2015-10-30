using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Loja.DAL.Models.Mapping;
using CodeFirstStoreFunctions;

namespace Loja.DAL.Models
{
	public partial class LojaContext : DbContext
	{
		static LojaContext()
		{
			Database.SetInitializer<LojaContext>(null);
		}

		public LojaContext()
			: base("Name=LojaContext")
		{
			this.Configuration.LazyLoadingEnabled = false;
		}

		public DbSet<sysdiagram> sysdiagrams { get; set; }
		public DbSet<tbl_CEP> tbl_CEP { get; set; }
		public DbSet<tbl_Cliente> tbl_Cliente { get; set; }
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
			modelBuilder.Configurations.Add(new tbl_CEPMap());
			modelBuilder.Configurations.Add(new tbl_ClienteMap());
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
	}
}
