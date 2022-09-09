using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class FacturaEncConfiguration : IEntityTypeConfiguration<FacturaEnc>
    {
        public void Configure(EntityTypeBuilder<FacturaEnc> builder)
        {
            builder
               .HasIndex(p => new { p.TipoDocumento, p.Factura}, "IxTipoDoc_Factura")
               .IsUnique();
        }
    }
}
