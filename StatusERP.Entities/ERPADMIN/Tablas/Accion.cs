using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("Accion", Schema = "ERPADMIN")]
    public class Accion:EntityBase
    {
        [Column("Accion")]
        [Required(ErrorMessage = "Número de Acción es requerido.")]
        public int CodAccion { get; set; }

        [Required(ErrorMessage = "Nombre de la Acción es requerido.")]
        [StringLength(40)]
        public string NombreAccion { get; set; }

        [Required(ErrorMessage = "Descripción de la Acción es requerida.")]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un nombre de constante.")]
        [StringLength(18)]
        public string  NombreConstante { get; set; }

        public bool EsModulo { get; set; }

        public bool EsEstandar { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el Tipo.")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un subtipo.")]
        [StringLength(1)]
        public string Subtipo { get; set; }

        [StringLength(30)]
        public string ? Tabla { get; set; }

        [StringLength(1024)]
        public string ? Invocacion { get; set; }
    }
}
