using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class PedidoEncConfiguration : IEntityTypeConfiguration<PedidoEnc>
    {
        public void Configure(EntityTypeBuilder<PedidoEnc> builder)
        {
            builder
               .HasIndex(p => new { p.Pedido}, "IxPedido")
               .IsUnique();
        }
    }
}
