using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Loja.DAL.Models.Mapping
{
	public class tbl_ParametrosMap : EntityTypeConfiguration<tbl_Parametros>
	{
		public tbl_ParametrosMap()
		{
			// Primary Key
			this.HasKey(t => t.EmpresaNome);

			// Properties
			this.Property(t => t.EmpresaNome)
				.IsRequired()
                .HasMaxLength(50);

			this.Property(t => t.EmpresaEndereco)
				.HasMaxLength(50);

			this.Property(t => t.EmpresaTelefone)
				.HasMaxLength(15);

			this.Property(t => t.EmpresaEmail)
				.HasMaxLength(25);

			this.Property(t => t.EmpresaWebSite)
				.HasMaxLength(30);

			this.Property(t => t.EmpresaSlogan)
				.HasMaxLength(50);

			this.Property(t => t.EmpresaCNPJ)
				.IsFixedLength()
                .HasMaxLength(18);

			this.Property(t => t.EmpresaInscEstadual)
				.HasMaxLength(15);

			// Table & Column Mappings
			this.ToTable("tbl_Parametros");
			this.Property(t => t.EmpresaNome).HasColumnName("EmpresaNome");
			this.Property(t => t.EmpresaEndereco).HasColumnName("EmpresaEndereco");
			this.Property(t => t.EmpresaTelefone).HasColumnName("EmpresaTelefone");
			this.Property(t => t.EmpresaEmail).HasColumnName("EmpresaEmail");
			this.Property(t => t.EmpresaWebSite).HasColumnName("EmpresaWebSite");
			this.Property(t => t.EmpresaSlogan).HasColumnName("EmpresaSlogan");
			this.Property(t => t.EmpresaLogotipo).HasColumnName("EmpresaLogotipo");
			this.Property(t => t.EmpresaCNPJ).HasColumnName("EmpresaCNPJ");
			this.Property(t => t.EmpresaInscEstadual).HasColumnName("EmpresaInscEstadual");
			this.Property(t => t.SisCodVenda).HasColumnName("SisCodVenda");
			this.Property(t => t.SisNumNF).HasColumnName("SisNumNF");
		}
	}
}
