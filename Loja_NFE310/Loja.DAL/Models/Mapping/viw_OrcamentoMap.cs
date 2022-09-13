using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class viw_OrcamentoMap : EntityTypeConfiguration<viw_Orcamento>
	{
		public viw_OrcamentoMap()
		{
			// Primary Key
			this.HasKey(t => t.CodOrca);

			// Properties
			this.Property(t => t.CodOrca)
				.IsRequired()
                .HasMaxLength(5);

			this.Property(t => t.FlgStatus)
				.IsFixedLength()
                .HasMaxLength(1);

			// Table & Column Mappings
			this.ToTable("viw_Orcamento");
			this.Property(t => t.CodOrca).HasColumnName("CodOrca");
			this.Property(t => t.Itens).HasColumnName("Itens");
			this.Property(t => t.VlrTotal).HasColumnName("VlrTotal");
			this.Property(t => t.FlgStatus).HasColumnName("FlgStatus");
		}
	}
}
