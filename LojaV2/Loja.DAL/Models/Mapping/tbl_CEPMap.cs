using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_CEPMap : EntityTypeConfiguration<tbl_CEP>
	{
		public tbl_CEPMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CEP, t.LOGRADOURO, t.BAIRRO_INICIAL, t.CIDADE, t.UF, t.TIPO });

			// Properties
			this.Property(t => t.CEP)
				.IsRequired()
                .HasMaxLength(9);

			this.Property(t => t.LOGRADOURO)
				.IsRequired()
                .HasMaxLength(100);

			this.Property(t => t.BAIRRO_INICIAL)
				.IsRequired()
                .HasMaxLength(100);

			this.Property(t => t.BAIRRO_FINAL)
				.HasMaxLength(100);

			this.Property(t => t.CIDADE)
				.IsRequired()
                .HasMaxLength(100);

			this.Property(t => t.UF)
				.IsRequired()
                .HasMaxLength(2);

			this.Property(t => t.TIPO)
				.IsRequired()
                .HasMaxLength(10);

			// Table & Column Mappings
			this.ToTable("tbl_CEP");
			this.Property(t => t.CEP).HasColumnName("CEP");
			this.Property(t => t.LOGRADOURO).HasColumnName("LOGRADOURO");
			this.Property(t => t.BAIRRO_INICIAL).HasColumnName("BAIRRO_INICIAL");
			this.Property(t => t.BAIRRO_FINAL).HasColumnName("BAIRRO_FINAL");
			this.Property(t => t.CIDADE).HasColumnName("CIDADE");
			this.Property(t => t.UF).HasColumnName("UF");
			this.Property(t => t.TIPO).HasColumnName("TIPO");
		}
	}
}
