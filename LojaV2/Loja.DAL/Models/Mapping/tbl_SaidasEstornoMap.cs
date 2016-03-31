using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_SaidasEstornoMap : EntityTypeConfiguration<tbl_SaidasEstorno>
	{
		public tbl_SaidasEstornoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CodVenda, t.codigounico, t.DatEstorno });

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
                .HasMaxLength(20);

			this.Property(t => t.DesProduto)
				.IsRequired()
                .HasMaxLength(30);

			this.Property(t => t.MotivoEstorno)
				.IsRequired()
                .HasMaxLength(50);

			// Table & Column Mappings
			this.ToTable("tbl_SaidasEstorno");
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
			this.Property(t => t.CodTipoVenda).HasColumnName("CodTipoVenda");
			this.Property(t => t.DatEstorno).HasColumnName("DatEstorno");
			this.Property(t => t.MotivoEstorno).HasColumnName("MotivoEstorno");
		}
	}
}
