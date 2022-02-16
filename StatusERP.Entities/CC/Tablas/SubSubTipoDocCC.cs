using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CC.Tablas
{
    public class SubSubTipoDocCC:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
