namespace StatusERP.Entities.ERPADMIN.Tablas
{
    public class PrivilegioUsuario:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
