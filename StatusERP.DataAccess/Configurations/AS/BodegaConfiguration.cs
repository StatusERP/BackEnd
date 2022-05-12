using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class BodegaConfiguration : IEntityTypeConfiguration<Bodega> 
    {
        public void Configure(EntityTypeBuilder<Bodega> builder)
        {
           
        }
    }
}
