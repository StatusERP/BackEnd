using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.FC.Tablas
{
    public class RubroFC:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
