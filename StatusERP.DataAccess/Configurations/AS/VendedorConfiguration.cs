using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class VendedorConfiguration : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder
                .HasIndex(p => new { p.CodVendedor }, "IxCodVendedor")
                .IsUnique();

        }
    }
}
