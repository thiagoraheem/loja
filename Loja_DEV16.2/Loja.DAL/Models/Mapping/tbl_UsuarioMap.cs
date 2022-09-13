using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_UsuarioMap : EntityTypeConfiguration<tbl_Usuario>
	{
		public tbl_UsuarioMap()
		{
			// Primary Key
			this.HasKey(t => t.CODIGO);

			// Properties
			this.Property(t => t.CODIGO)
				.IsRequired()
                .HasMaxLength(3);

			this.Property(t => t.NOME)
				.HasMaxLength(10);

			this.Property(t => t.TSENHA)
				.HasMaxLength(6);

			this.Property(t => t.STATUS)
				.HasMaxLength(10);

			this.Property(t => t.NIVEL)
				.HasMaxLength(1);

			// Table & Column Mappings
			this.ToTable("tbl_Usuario");
			this.Property(t => t.CODIGO).HasColumnName("CODIGO");
			this.Property(t => t.NOME).HasColumnName("NOME");
			this.Property(t => t.TSENHA).HasColumnName("TSENHA");
			this.Property(t => t.STATUS).HasColumnName("STATUS");
			this.Property(t => t.NIVEL).HasColumnName("NIVEL");
		}
	}
}
