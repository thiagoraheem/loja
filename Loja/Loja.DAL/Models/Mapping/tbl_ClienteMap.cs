using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_ClienteMap : EntityTypeConfiguration<tbl_Cliente>
	{
		public tbl_ClienteMap()
		{
			// Primary Key
			this.HasKey(t => t.CodCliente);

			// Properties
			this.Property(t => t.NomCliente)
				.HasMaxLength(200);

			this.Property(t => t.NumCPF)
				.HasMaxLength(14);

			this.Property(t => t.NumCNPJ)
				.HasMaxLength(20);

			this.Property(t => t.NumTelefone)
				.HasMaxLength(20);

			this.Property(t => t.Endereco)
				.HasMaxLength(50);

			this.Property(t => t.Numero)
				.HasMaxLength(10);

			this.Property(t => t.Bairro)
				.HasMaxLength(30);

			this.Property(t => t.Cidade)
				.HasMaxLength(30);

			this.Property(t => t.Estado)
				.HasMaxLength(20);

			this.Property(t => t.Pais)
				.HasMaxLength(20);

			this.Property(t => t.Email)
				.HasMaxLength(100);

			// Table & Column Mappings
			this.ToTable("tbl_Cliente");
			this.Property(t => t.CodCliente).HasColumnName("CodCliente");
			this.Property(t => t.NomCliente).HasColumnName("NomCliente");
			this.Property(t => t.NumCPF).HasColumnName("NumCPF");
			this.Property(t => t.NumCNPJ).HasColumnName("NumCNPJ");
			this.Property(t => t.NumTelefone).HasColumnName("NumTelefone");
			this.Property(t => t.Endereco).HasColumnName("Endereco");
			this.Property(t => t.Numero).HasColumnName("Numero");
			this.Property(t => t.Bairro).HasColumnName("Bairro");
			this.Property(t => t.Cidade).HasColumnName("Cidade");
			this.Property(t => t.Estado).HasColumnName("Estado");
			this.Property(t => t.Pais).HasColumnName("Pais");
			this.Property(t => t.Email).HasColumnName("Email");
		}
	}
}
