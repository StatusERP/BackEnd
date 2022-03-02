using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace StatusERP.Entities.AS.Tablas
{
    [Table("Vendedores", Schema = Constants.Conjunto)]
    public class  Vendedor : EntityBase
    {
        [Column("Vendedor")]
        [Required(ErrorMessage = "Se requiere especificar el código del Vendedor.")]
        [StringLength(4)]
        public string CodVendedor { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Vendedor.")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string ? Email { get; set; }

        public bool Activo { get; set; }
       
    }
}