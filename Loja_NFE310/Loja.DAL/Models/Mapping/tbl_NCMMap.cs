using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_NCMMap : EntityTypeConfiguration<tbl_NCM>
	{
		public tbl_NCMMap()
		{
			// Primary Key
			this.HasKey(t => new { t.codigo, t.ex });

			// Properties
			this.Property(t => t.codigo)
				.IsRequired()
                .HasMaxLength(10);

			this.Property(t => t.ex)
				.IsRequired()
                .HasMaxLength(50);

			this.Property(t => t.tipo)
				.HasMaxLength(50);

			this.Property(t => t.descricao)
				.HasMaxLength(255);

			this.Property(t => t.chave)
				.HasMaxLength(10);

			this.Property(t => t.versao)
				.HasMaxLength(8);

			this.Property(t => t.fonte)
				.HasMaxLength(5);

			// Table & Column Mappings
			this.ToTable("tbl_NCM");
			this.Property(t => t.codigo).HasColumnName("codigo");
			this.Property(t => t.ex).HasColumnName("ex");
			this.Property(t => t.tipo).HasColumnName("tipo");
			this.Property(t => t.descricao).HasColumnName("descricao");
			this.Property(t => t.nacionalfederal).HasColumnName("nacionalfederal");
			this.Property(t => t.importadosfederal).HasColumnName("importadosfederal");
			this.Property(t => t.estadual).HasColumnName("estadual");
			this.Property(t => t.municipal).HasColumnName("municipal");
			this.Property(t => t.vigenciainicio).HasColumnName("vigenciainicio");
			this.Property(t => t.vigenciafim).HasColumnName("vigenciafim");
			this.Property(t => t.chave).HasColumnName("chave");
			this.Property(t => t.versao).HasColumnName("versao");
			this.Property(t => t.fonte).HasColumnName("fonte");
		}
	}
}
