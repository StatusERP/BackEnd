using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class TipoTarjetaConfiguration : IEntityTypeConfiguration<TipoTarjeta>
    {
        public void Configure(EntityTypeBuilder<TipoTarjeta> builder)
        {
            builder
                .HasIndex(p => new { p.CodTipoTarjeta }, "IxCodTipoTarjeta")
                .IsUnique();
        }
    }
}