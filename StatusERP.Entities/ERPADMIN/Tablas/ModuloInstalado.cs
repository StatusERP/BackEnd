using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas

{
    [Table("ModuloInstalado", Schema = "ERPADMIN")]
    public class ModuloInstalado:EntityBase

    {
        [Required(ErrorMessage = "Debe especificar un conjunto.")]
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
        
        [Required(ErrorMessage = "La acción es requerida.")]
        public int AccionId { get; set; }
        public Accion Accion { get; set; }
    }
}