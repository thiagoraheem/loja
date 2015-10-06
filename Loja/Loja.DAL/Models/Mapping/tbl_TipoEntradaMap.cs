using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
    public class tbl_TipoEntradaMap : EntityTypeConfiguration<tbl_TipoEntrada>
    {
        public tbl_TipoEntradaMap()
        {
            // Primary Key
            this.HasKey(t => t.CodTipoEntrada);

            // Properties
            this.Property(t => t.DesTipoEntrada)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_TipoEntrada");
            this.Property(t => t.CodTipoEntrada).HasColumnName("CodTipoEntrada");
            this.Property(t => t.DesTipoEntrada).HasColumnName("DesTipoEntrada");
            this.Property(t => t.flgMovimentaEstoque).HasColumnName("flgMovimentaEstoque");
        }
    }
}
