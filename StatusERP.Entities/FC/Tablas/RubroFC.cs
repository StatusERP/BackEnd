using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("RubrosFC", Schema = Constants.Conjunto)]
    public class RubroFC:EntityBase
    {
        public bool Activo { get; set; }

        [Required(ErrorMessage = "Debe indicarse un código de flujo de caja.")]
        public int FlujoCajaId { get; set; }
        public FlujoCaja FlujoCaja { get; set; }

        public string ? Formula { get; set; }

        public string ? FormulaTXT { get; set; }

        [Required(ErrorMessage = "Debe indicarse la naturaleza.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        [Required(ErrorMessage = "Debe indicarse el nombre del rubro.")]
        [StringLength(80)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe indicarse el rubro hijo.")]
        [StringLength(20)]
        public string RubroHijo { get; set; }

        [Required(ErrorMessage = "Debe indicarse el rubro padre.")]
        [StringLength(20)]
        public string RubroPadre { get; set; }

        [Required(ErrorMessage = "Debe indicarse el tipo de rubro.")]
        [StringLength(1)]
        public string TipoRubro { get; set; }
    }
}
