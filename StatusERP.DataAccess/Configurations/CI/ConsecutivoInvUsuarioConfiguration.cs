using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class ConsecutivoInvUsuarioConfiguration : IEntityTypeConfiguration<ConsecutivoInvUsuario>
    {
        public void Configure(EntityTypeBuilder<ConsecutivoInvUsuario> builder)
        {
            builder
                .HasIndex(p => new { p.Consecutivo, p.Usuario}, "IxConsecutivoInvUsuario");
        }
    }
}

