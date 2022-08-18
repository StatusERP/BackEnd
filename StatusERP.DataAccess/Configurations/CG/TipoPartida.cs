using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Configurations.CG
{
    public class TipoPartidaConfiguration : IEntityTypeConfiguration<TipoPartida>
    {
        public void Configure(EntityTypeBuilder<TipoPartida> builder)
        {
            builder
                .HasIndex(p => new { p.CodTipoPartida }, "IxCodPartida")
                .IsUnique();
        }
    }
}
