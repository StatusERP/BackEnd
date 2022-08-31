using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class ArticuloPrecioConfiguration : IEntityTypeConfiguration<ArticuloPrecio>
    {
        public void Configure(EntityTypeBuilder<ArticuloPrecio> builder)
        {
            builder
               .HasIndex(p => new { p.VersionNivelId, p.ArticuloId, p.VersionArticulo}, "IxVersionNivel_Articulo_VersionArticulo")
               .IsUnique();
        }
    }
}
