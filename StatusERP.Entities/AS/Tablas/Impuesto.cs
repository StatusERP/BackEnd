using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Impuestos", Schema = Constants.Conjunto)]
    public class Impuesto:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el Código del Impuesto")]
        [StringLength(4)]
        public string CodImpuesto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Descripciónl Impuesto")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar valor del Impuesto 1")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto1 { get; set; }

        [Required(ErrorMessage = "Se requiere especificar valor del Impuesto 2")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto2 { get; set; }

        public bool UsaImpuesto2Cantidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Impuesto2Cantidad { get; set; }

        [Required(ErrorMessage = "Se requiere especificar cáculo Impuesto 2")]
        [StringLength(1)]
        public string CalculoImp2 { get; set; }

        [Required(ErrorMessage = "Se requiere indicar tipo de contabilización del Impuesto1")]
        [StringLength(1)]
        public string TipoContabImp1 { get; set; }

        [Required(ErrorMessage = "Se requiere indicar tipo de contabilización del Impuesto2")]
        [StringLength(1)]
        public string TipoContabImp2 { get; set; }

        public bool ContabDevImp1 { get; set; }

        public bool ContabDevImp2 { get; set; }

        [StringLength(25)]
        public string ? CtrImp1Gen { get; set; }

        [StringLength(25)]
        public string ? CtaImp1Gen { get; set; }

        [StringLength(25)]
        public string ? CtrImp2Gen { get; set; }

        [StringLength(25)]
        public string? CtaImp2Gen { get; set; }

        [StringLength(25)]
        public string ? CtrImp1GenVts { get; set; }

        [StringLength(25)]
        public string ? CtaImp1GenVts { get; set; }

        [StringLength(25)]
        public string ? CtrImp2GenVts { get; set; }

        [StringLength(25)]
        public string ? CtaImp2GenVts { get; set; }

        [StringLength(25)]
        public string? CtrImp1DesComp { get; set; }

        [StringLength(25)]
        public string ? CtaImp1DesComp { get; set; }

        [StringLength(25)]
        public string ? CtrImp2DesComp { get; set; }

        [StringLength(25)]
        public string ? CtaImp2DesComp { get; set; }

        [StringLength(25)]
        public string ? CtrImp1DevComp { get; set; }

        [StringLength(25)]
        public string ? CtaImp1DevComp { get; set; }

        [StringLength(25)]
        public string ? CtrImp2DevComp { get; set; }

        [StringLength(25)]
        public string ? CtaImp2DevComp { get; set; }

        [StringLength(25)]
        public string ? CtrImp1DevVentas { get; set; }

        [StringLength(25)]
        public string ? CtaImp1DevVentas { get; set; }

        [StringLength(25)]
        public string ? CtrImp2DevVentas { get; set; }

        [StringLength(25)]
        public string ? CtaImp2DevVentas { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto1 { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto2 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa1 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa2 { get; set; }

        public bool Activo { get; set; }
    }
}
