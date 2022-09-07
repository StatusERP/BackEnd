using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class PedidoDetConfiguration : IEntityTypeConfiguration<PedidoDet>
    {
        public void Configure(EntityTypeBuilder<PedidoDet> builder)
        {
            builder
               .HasIndex(p => new { p.PedidoEncId, p.PedidoLinea }, "IxPedidoEnc_PedidoLinea")
               .IsUnique();
        }
    }
}
