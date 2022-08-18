using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class DetalleDireccionConfiguration : IEntityTypeConfiguration<DetalleDireccion>
    {
        public void Configure(EntityTypeBuilder<DetalleDireccion> builder)
        {
            builder
                .HasIndex(p => new { p.CodDetalleDireccion }, "IxCodDetalleDireccion")
                .IsUnique();

        }
    }
}