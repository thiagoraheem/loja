using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_EntradaItensMap : EntityTypeConfiguration<tbl_EntradaItens>
	{
		public tbl_EntradaItensMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CodEntrada, t.codigounico });

			// Properties
			this.Property(t => t.CodEntrada)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			this.Property(t => t.codigounico)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			this.Property(t => t.CodProduto)
				.HasMaxLength(20);

			this.Property(t => t.DesProduto)
				.HasMaxLength(50);

			this.Property(t => t.NCM)
				.IsFixedLength()
                .HasMaxLength(8);

			this.Property(t => t.Unidade)
				.HasMaxLength(15);

			// Table & Column Mappings
			this.ToTable("tbl_EntradaItens");
			this.Property(t => t.CodEntrada).HasColumnName("CodEntrada");
			this.Property(t => t.codigounico).HasColumnName("codigounico");
			this.Property(t => t.NumOrdem).HasColumnName("NumOrdem");
			this.Property(t => t.CodProduto).HasColumnName("CodProduto");
			this.Property(t => t.DesProduto).HasColumnName("DesProduto");
			this.Property(t => t.NCM).HasColumnName("NCM");
			this.Property(t => t.Unidade).HasColumnName("Unidade");
			this.Property(t => t.Quantidade).HasColumnName("Quantidade");
			this.Property(t => t.VlrUnitario).HasColumnName("VlrUnitario");
			this.Property(t => t.VlrFinal).HasColumnName("VlrFinal");
			this.Property(t => t.VlrBaseICMS).HasColumnName("VlrBaseICMS");
			this.Property(t => t.VlrPercICMS).HasColumnName("VlrPercICMS");
			this.Property(t => t.VlrICMS).HasColumnName("VlrICMS");
			this.Property(t => t.VlrBaseICMSST).HasColumnName("VlrBaseICMSST");
			this.Property(t => t.VlrPercICMSST).HasColumnName("VlrPercICMSST");
			this.Property(t => t.VlrICMSST).HasColumnName("VlrICMSST");
			this.Property(t => t.VlrBasePIS).HasColumnName("VlrBasePIS");
			this.Property(t => t.VlrPercPIS).HasColumnName("VlrPercPIS");
			this.Property(t => t.VlrPIS).HasColumnName("VlrPIS");
			this.Property(t => t.VlrBaseCOFINS).HasColumnName("VlrBaseCOFINS");
			this.Property(t => t.VlrPercCOFINS).HasColumnName("VlrPercCOFINS");
			this.Property(t => t.VlrCOFINS).HasColumnName("VlrCOFINS");

			// Relationships
			this.HasRequired(t => t.tbl_Entrada)
				.WithMany(t => t.tbl_EntradaItens)
				.HasForeignKey(d => d.CodEntrada);

		}
	}
}
