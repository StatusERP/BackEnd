using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CP.Tablas
{
    [Table("SubTipoDocCP", Schema = Constants.Conjunto)]
    public class SubTipoDocCP:EntityBase
    {
        [Required(ErrorMessage = "El SubTipo es requerido.")]
        public Int16 SubTipo { get; set; }

        [Required(ErrorMessage = "El Tipo es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(25)]
        public string Descripcion { get; set; }

        [StringLength(3)]
        public string ? TipoCB { get; set; }

        public Int16 ? SubTipoCB { get; set; }

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

        [StringLength(10)]
        public string ? TipoPago { get; set; }

        [StringLength(50)]
        public string ? CodigoHacienda { get; set; }
     }
}
