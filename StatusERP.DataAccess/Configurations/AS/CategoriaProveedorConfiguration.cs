using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class CategoriaProveedorConfiguration : IEntityTypeConfiguration<CategoriaProveedor>
    {
        public void Configure(EntityTypeBuilder<CategoriaProveedor> builder)
        {
            builder
                .HasIndex(p => new { p.CodCategoriaProveedor }, "IxCodCategoriaProveedor")
                .IsUnique();

        }
    }
}