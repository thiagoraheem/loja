using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_OrcamentoMap : EntityTypeConfiguration<tbl_Orcamento>
	{
		public tbl_OrcamentoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CodOrca, t.codigounico });

			// Properties
			this.Property(t => t.CodOrca)
				.IsRequired()
				.HasMaxLength(5);

			this.Property(t => t.CodProduto)
				.IsRequired()
				.HasMaxLength(20);

			this.Property(t => t.DescProduto)
				.HasMaxLength(60);

			this.Property(t => t.DesLocal)
				.HasMaxLength(4);

			this.Property(t => t.FlgStatus)
				.IsFixedLength()
				.HasMaxLength(1);

			this.Property(t => t.codigounico)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			// Table & Column Mappings
			this.ToTable("tbl_Orcamento");
			this.Property(t => t.CodOrca).HasColumnName("CodOrca");
			this.Property(t => t.CodProduto).HasColumnName("CodProduto");
			this.Property(t => t.DescProduto).HasColumnName("DescProduto");
			this.Property(t => t.Quantidade).HasColumnName("Quantidade");
			this.Property(t => t.VlrUnitario).HasColumnName("VlrUnitario");
			this.Property(t => t.VlrCusto).HasColumnName("VlrCusto");
			this.Property(t => t.DesLocal).HasColumnName("DesLocal");
			this.Property(t => t.PF).HasColumnName("PF");
			this.Property(t => t.FlgStatus).HasColumnName("FlgStatus");
			this.Property(t => t.DatOrca).HasColumnName("DatOrca");
			this.Property(t => t.codigounico).HasColumnName("codigounico");
			this.Property(t => t.VlrDesconto).HasColumnName("VlrDesconto");
			this.Property(t => t.VlrBruto).HasColumnName("VlrBruto");
		}
	}
}
