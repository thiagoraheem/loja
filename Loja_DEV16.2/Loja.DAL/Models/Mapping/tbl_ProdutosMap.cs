using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_ProdutosMap : EntityTypeConfiguration<tbl_Produtos>
	{
		public tbl_ProdutosMap()
		{
			// Primary Key
			this.HasKey(t => t.codigounico);

			// Properties
			this.Property(t => t.CodProduto)
				.IsRequired()
				.HasMaxLength(20);

			this.Property(t => t.DesProduto)
				.IsRequired()
				.HasMaxLength(60);

			this.Property(t => t.DesLocal)
				.IsRequired()
				.HasMaxLength(4);

			this.Property(t => t.DatCadastro)
				.HasMaxLength(10);

			this.Property(t => t.DesFornecedor)
				.HasMaxLength(10);

			this.Property(t => t.CodRefAntiga)
				.HasMaxLength(20);

			this.Property(t => t.NCM)
				.HasMaxLength(10);

			// Table & Column Mappings
			this.ToTable("tbl_Produtos");
			this.Property(t => t.CodProduto).HasColumnName("CodProduto");
			this.Property(t => t.DesProduto).HasColumnName("DesProduto");
			this.Property(t => t.DesLocal).HasColumnName("DesLocal");
			this.Property(t => t.VlrUnitario).HasColumnName("VlrUnitario");
			this.Property(t => t.QtdProduto).HasColumnName("QtdProduto");
			this.Property(t => t.VlrCusto).HasColumnName("VlrCusto");
			this.Property(t => t.VlrPercent).HasColumnName("VlrPercent");
			this.Property(t => t.EstMinimo).HasColumnName("EstMinimo");
			this.Property(t => t.DatCadastro).HasColumnName("DatCadastro");
			this.Property(t => t.DesFornecedor).HasColumnName("DesFornecedor");
			this.Property(t => t.CodRefAntiga).HasColumnName("CodRefAntiga");
			this.Property(t => t.DesFaz).HasColumnName("DesFaz");
			this.Property(t => t.VlrUltPreco).HasColumnName("VlrUltPreco");
			this.Property(t => t.Imagem).HasColumnName("Imagem");
			this.Property(t => t.codigounico).HasColumnName("codigounico");
			this.Property(t => t.NCM).HasColumnName("NCM");
			this.Property(t => t.VlrICMSST).HasColumnName("VlrICMSST");
		}
	}
}
