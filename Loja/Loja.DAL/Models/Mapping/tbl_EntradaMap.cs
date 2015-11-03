using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_EntradaMap : EntityTypeConfiguration<tbl_Entrada>
	{
		public tbl_EntradaMap()
		{
			// Primary Key
			this.HasKey(t => t.CodEntrada);

			// Properties
			this.Property(t => t.DocEntrada)
				.IsRequired()
                .HasMaxLength(20);

			this.Property(t => t.SerieNota)
				.HasMaxLength(5);

			this.Property(t => t.CNPJ)
				.IsFixedLength()
                .HasMaxLength(14);

			this.Property(t => t.CPF)
				.IsFixedLength()
                .HasMaxLength(12);

			this.Property(t => t.Nome)
				.HasMaxLength(30);

			// Table & Column Mappings
			this.ToTable("tbl_Entrada");
			this.Property(t => t.CodEntrada).HasColumnName("CodEntrada");
			this.Property(t => t.DocEntrada).HasColumnName("DocEntrada");
			this.Property(t => t.SerieNota).HasColumnName("SerieNota");
			this.Property(t => t.DatEmissao).HasColumnName("DatEmissao");
			this.Property(t => t.DatEntrada).HasColumnName("DatEntrada");
			this.Property(t => t.CodTipoEntrada).HasColumnName("CodTipoEntrada");
			this.Property(t => t.CNPJ).HasColumnName("CNPJ");
			this.Property(t => t.CPF).HasColumnName("CPF");
			this.Property(t => t.Nome).HasColumnName("Nome");

			// Relationships
			this.HasRequired(t => t.tbl_TipoEntrada)
				.WithMany(t => t.tbl_Entrada)
				.HasForeignKey(d => d.CodTipoEntrada);

		}
	}
}
