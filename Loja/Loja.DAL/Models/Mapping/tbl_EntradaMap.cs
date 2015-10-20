using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_EntradaMap : EntityTypeConfiguration<tbl_Entrada>
	{
		public tbl_EntradaMap()
		{
			// Primary Key
			this.HasKey(t => new { t.DocEntrada, t.DatEntrada, t.codigounico });

			// Properties
			this.Property(t => t.DocEntrada)
				.IsRequired()
                .HasMaxLength(15);

			this.Property(t => t.codigounico)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			this.Property(t => t.DesFornecedor)
				.HasMaxLength(10);

			// Table & Column Mappings
			this.ToTable("tbl_Entrada");
			this.Property(t => t.DocEntrada).HasColumnName("DocEntrada");
			this.Property(t => t.DatEntrada).HasColumnName("DatEntrada");
			this.Property(t => t.QtdProduto).HasColumnName("QtdProduto");
			this.Property(t => t.VlrUnitario).HasColumnName("VlrUnitario");
			this.Property(t => t.VlrTotal).HasColumnName("VlrTotal");
			this.Property(t => t.CodTipoEntrada).HasColumnName("CodTipoEntrada");
			this.Property(t => t.codigounico).HasColumnName("codigounico");
			this.Property(t => t.Percentual).HasColumnName("Percentual");
			this.Property(t => t.DesFornecedor).HasColumnName("DesFornecedor");

			// Relationships
			this.HasRequired(t => t.tbl_Produtos)
				.WithMany(t => t.tbl_Entrada)
				.HasForeignKey(d => d.codigounico);
			this.HasRequired(t => t.tbl_TipoEntrada)
				.WithMany(t => t.tbl_Entrada)
				.HasForeignKey(d => d.CodTipoEntrada);

		}
	}
}
