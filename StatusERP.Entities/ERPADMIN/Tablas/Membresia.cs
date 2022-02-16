namespace StatusERP.Entities.ERPADMIN.Tablas
{
    public class Membresia:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
