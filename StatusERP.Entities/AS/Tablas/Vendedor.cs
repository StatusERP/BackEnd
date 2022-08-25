using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace StatusERP.Entities.AS.Tablas
{
    [Table("Vendedores", Schema = Constants.Conjunto)]
    public class  Vendedor : EntityBase
    {
        [StringLength(4)]
        public string CodVendedor { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string ? Email { get; set; }

        [StringLength(15)]
        public string? Telefono { get; set; }

        public bool Activo { get; set; }

       
    }
}