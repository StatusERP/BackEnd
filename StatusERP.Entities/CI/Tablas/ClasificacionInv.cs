using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    public class ClasificacionInv:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
