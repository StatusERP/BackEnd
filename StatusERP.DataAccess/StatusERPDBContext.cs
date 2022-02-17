using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess
{
    public class StatusERPDBContext:DbContext
    {
        public StatusERPDBContext()
        {

        }

        public StatusERPDBContext(DbContextOptions<StatusERPDBContext> options): base(options)
        {

        }
        public DbSet<Conjunto> Conjuntos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; } 
     
        public DbSet<Bodega> Bodega { get; set; }
    }
}