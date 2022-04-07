using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("SubTiposDocCB", Schema = Constants.Conjunto)]
    public class SubTipoDocCB:EntityBase
    {
        [Required(ErrorMessage = "El de tipo de documento CB es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El subtipo de documento CB es requerido.")]
        public Int16 SubTipo { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }

        [StringLength(4)]
        public string ? TipoAsiento { get; set; }

        [StringLength(4)]
        public string ? Paquete { get; set; }

        [StringLength(2)]
        public string ? TipoServicio { get; set; }

        [StringLength(10)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(20)]
        public string ? RubroCF { get; set; }

        [StringLength(20)]
        public string ? RubroPadre { get; set; }

        [StringLength(20)]
        public string ? FlujoCaja { get; set; }

        [StringLength(1)]
        public string ? NaturalezaCF { get; set; }
    }
}
