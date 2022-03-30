using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CC.Tablas
{
    [Table("SubTiposDocCC", Schema = Constants.Conjunto)]
    public class SubTipoDocCC:EntityBase
    {
        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El subtipo es requerido.")]
        public Int16 Subtipo { get; set; }

        [StringLength(3)]
        public string ? TipoCB { get; set; }

        public Int16 ? SubTipoCB { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(25)]
        public string Descripcion { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }

        public bool CalculaImp2 { get; set; }

        [StringLength(4)]
        public string ? TipoAsiento { get; set; }

        [StringLength(4)]
        public string ? Paquete { get; set; }

        [StringLength(2)]
        public string ? TipoServicio { get; set; }

        [StringLength(10)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(4)]
        public string ? ConceptoNC { get; set; }

        [StringLength(4)]
        public string ? ConceptoFAC { get; set; }

        [StringLength(4)]
        public string ? ConceptoND { get; set; }

        [StringLength(4)]
        public string ? TipoDoc { get; set; }

        [StringLength(50)]
        public string ? CodigoHacienda { get; set; }

        [StringLength(10)]
        public string ? TipoOperacFac { get; set; }

        [StringLength(10)]
        public string ? TipoOperacNC { get; set; }

        [StringLength(10)]
        public string ? TipoOperacND { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }

        [StringLength(10)]
        public string ? ConsecutivoFac { get; set; }
    }
}
