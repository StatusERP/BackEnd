using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CP.Tablas
{
    public class RetencionDocCP:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
