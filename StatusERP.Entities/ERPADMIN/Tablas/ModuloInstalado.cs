using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas

{
    [Table("ModuloInstalado", Schema = "ERPADMIN")]
    public class ModuloInstalado:EntityBase

    {
        [Required(ErrorMessage = "El conjunto es requerido.")]
        [StringLength(10)]
        public string Conjunto { get; set; }
        
        [Required(ErrorMessage = "La accion es requerida.")]
        public int Accion { get; set; }
    }
}