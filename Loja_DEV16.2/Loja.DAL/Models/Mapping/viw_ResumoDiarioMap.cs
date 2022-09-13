using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class viw_ResumoDiarioMap : EntityTypeConfiguration<viw_ResumoDiario>
	{
		public viw_ResumoDiarioMap()
		{
			// Primary Key
			this.HasKey(t => t.Data);

			// Properties
			this.Property(t => t.Mes)
				.IsFixedLength()
                .HasMaxLength(7);

			// Table & Column Mappings
			this.ToTable("viw_ResumoDiario");
			this.Property(t => t.Data).HasColumnName("Data");
			this.Property(t => t.ValorTotal).HasColumnName("ValorTotal");
			this.Property(t => t.Mes).HasColumnName("Mes");
		}
	}
}
