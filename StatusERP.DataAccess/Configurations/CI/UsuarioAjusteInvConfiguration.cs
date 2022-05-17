using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class UsuarioAjusteInvConfiguration : IEntityTypeConfiguration<UsuarioAjusteInv>
    {
        public void Configure(EntityTypeBuilder<UsuarioAjusteInv> builder)
        {
            builder
                .HasIndex(p => new { p.Usuario, p.AjusteConfig}, "IxUsuarioAjuste")
                .IsUnique();
        }
    }
}
