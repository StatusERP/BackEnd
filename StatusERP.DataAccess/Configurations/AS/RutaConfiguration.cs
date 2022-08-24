using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class RutaConfiguration : IEntityTypeConfiguration<Ruta>
    {
        public void Configure(EntityTypeBuilder<Ruta> builder)
        {
            builder
                .HasIndex(p => new { p.CodRuta }, "IxCodRuta")
                .IsUnique();

        }
    }
}
