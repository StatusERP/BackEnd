using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class CategoriaClienteConfiguration : IEntityTypeConfiguration<CategoriaCliente>
    {
        public void Configure(EntityTypeBuilder<CategoriaCliente> builder)
        {
            builder
                .HasIndex(p => new { p.CodCategoriaCliente }, "IxCodCategoriaCliente")
                .IsUnique();

        }
    }
}