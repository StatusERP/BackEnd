using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.FC.Tablas
{
    public class FlujoCaja:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
