using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_TipoVendaMap : EntityTypeConfiguration<tbl_TipoVenda>
	{
		public tbl_TipoVendaMap()
		{
			// Primary Key
			this.HasKey(t => t.CodTipoVenda);

			// Properties
			this.Property(t => t.DesTipoVenda)
				.HasMaxLength(50);

			// Table & Column Mappings
			this.ToTable("tbl_TipoVenda");
			this.Property(t => t.CodTipoVenda).HasColumnName("CodTipoVenda");
			this.Property(t => t.DesTipoVenda).HasColumnName("DesTipoVenda");
			this.Property(t => t.flgAtivo).HasColumnName("flgAtivo");
			this.Property(t => t.flgAVista).HasColumnName("flgAVista");
			this.Property(t => t.QtdDias).HasColumnName("QtdDias");
		}
	}
}
