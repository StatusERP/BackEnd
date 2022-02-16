namespace StatusERP.Entities.ERPADMIN.Tablas
{
    public class Accion:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
