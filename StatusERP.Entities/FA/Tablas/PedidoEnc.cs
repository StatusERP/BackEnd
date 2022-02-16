using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    public class PedidoEnc:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
