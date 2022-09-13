using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_SaidaMap : EntityTypeConfiguration<tbl_Saida>
	{
		public tbl_SaidaMap()
		{
			// Primary Key
			this.HasKey(t => t.CodVenda);

			// Properties
			this.Property(t => t.CodVenda)
				.IsRequired()
                .HasMaxLength(10);

			this.Property(t => t.FlgStatusNFE)
				.IsFixedLength()
                .HasMaxLength(10);

			this.Property(t => t.ChaveSefaz)
				.HasMaxLength(50);

			this.Property(t => t.FlgStatusNota)
				.IsFixedLength()
                .HasMaxLength(1);

			this.Property(t => t.NumProtocolo)
				.IsFixedLength()
				.HasMaxLength(15);

			// Table & Column Mappings
			this.ToTable("tbl_Saida");
			this.Property(t => t.CodVenda).HasColumnName("CodVenda");
			this.Property(t => t.Data).HasColumnName("Data");
			this.Property(t => t.ValorTotal).HasColumnName("ValorTotal");
			this.Property(t => t.QtdItens).HasColumnName("QtdItens");
			this.Property(t => t.FlgStatusNFE).HasColumnName("FlgStatusNFE");
			this.Property(t => t.ChaveSefaz).HasColumnName("ChaveSefaz");
			this.Property(t => t.FlgStatusNota).HasColumnName("FlgStatusNota");
			this.Property(t => t.CodTipoVenda).HasColumnName("CodTipoVenda");
			this.Property(t => t.CodCliente).HasColumnName("CodCliente");
			this.Property(t => t.NumProtocolo).HasColumnName("NumProtocolo");


			// Relationships
			this.HasOptional(t => t.tbl_TipoVenda)
				.WithMany(t => t.tbl_Saida)
				.HasForeignKey(d => d.CodTipoVenda);

		}
	}
}
