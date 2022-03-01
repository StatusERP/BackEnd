using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("TablaCobradores", Schema = "PRUEBA")]
    public class Cobrador:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodCobrador{ get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string ? Email{ get; set; }

        [Required]
        public bool Activo { get; set; }    
    }
}
