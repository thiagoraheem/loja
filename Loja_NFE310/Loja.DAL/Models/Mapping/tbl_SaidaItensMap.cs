using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_SaidaItensMap : EntityTypeConfiguration<tbl_SaidaItens>
	{
		public tbl_SaidaItensMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CodVenda, t.codigounico });

			// Properties
			this.Property(t => t.CodVenda)
				.IsRequired()
				.HasMaxLength(10);

			this.Property(t => t.codigounico)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			this.Property(t => t.CodOrcamento)
				.IsRequired()
				.HasMaxLength(5);

			this.Property(t => t.CodProduto)
				.IsRequired()
				.HasMaxLength(40);

			this.Property(t => t.DesProduto)
				.IsRequired()
				.HasMaxLength(60);

			// Table & Column Mappings
			this.ToTable("tbl_SaidaItens");
			this.Property(t => t.CodVenda).HasColumnName("CodVenda");
			this.Property(t => t.codigounico).HasColumnName("codigounico");
			this.Property(t => t.DatSaida).HasColumnName("DatSaida");
			this.Property(t => t.CodOrcamento).HasColumnName("CodOrcamento");
			this.Property(t => t.CodProduto).HasColumnName("CodProduto");
			this.Property(t => t.DesProduto).HasColumnName("DesProduto");
			this.Property(t => t.VlrUnitario).HasColumnName("VlrUnitario");
			this.Property(t => t.Quantidade).HasColumnName("Quantidade");
			this.Property(t => t.VlrCusto).HasColumnName("VlrCusto");
			this.Property(t => t.VlrFinal).HasColumnName("VlrFinal");
			this.Property(t => t.VlrDesconto).HasColumnName("VlrDesconto");
			this.Property(t => t.VlrImposto).HasColumnName("VlrImposto");

			// Relationships
			this.HasRequired(t => t.tbl_Produtos)
				.WithMany(t => t.tbl_SaidaItens)
				.HasForeignKey(d => d.codigounico);
			this.HasRequired(t => t.tbl_Saida)
				.WithMany(t => t.tbl_SaidaItens)
				.HasForeignKey(d => d.CodVenda);

		}
	}
}
