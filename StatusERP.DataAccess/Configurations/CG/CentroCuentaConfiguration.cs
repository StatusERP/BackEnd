using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Configurations.CG
{
    public class CentroCuentaConfiguration : IEntityTypeConfiguration<CentroCuenta>
    {
        public void Configure(EntityTypeBuilder<CentroCuenta> builder)
        {
            builder
                .HasIndex(p => new { p.CentroCostoId, p.CuentaContableId}, "IxCentroIdCuentaId")
                .IsUnique();

            builder
                .HasIndex(p => new { p.CodCentroCosto, p.CodCuentaContable}, "IxCentroCodCuentaCod")
                .IsUnique();

        }
    }
}