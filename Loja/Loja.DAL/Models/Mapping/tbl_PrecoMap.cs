using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
    public class tbl_PrecoMap : EntityTypeConfiguration<tbl_Preco>
    {
        public tbl_PrecoMap()
        {
            // Primary Key
            this.HasKey(t => t.CodProduto);

            // Properties
            this.Property(t => t.CodProduto)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tbl_Preco");
            this.Property(t => t.CodProduto).HasColumnName("CodProduto");
            this.Property(t => t.VlrProduto).HasColumnName("VlrProduto");
            this.Property(t => t.DataAtualizacao).HasColumnName("DataAtualizacao");
        }
    }
}
