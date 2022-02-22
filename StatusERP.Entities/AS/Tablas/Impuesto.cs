using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    public class Impuesto:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodImpuesto { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto1 { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto2 { get; set; }

        [Required]
        public bool UsaImpuesto2Cantidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Impuesto2Cantidad { get; set; }

        [Required]
        [StringLength(1)]
        public string CalculoImp2 { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoContabImp1 { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoContabImp2 { get; set; }

        [Required]
        public bool ContabDevImp1 { get; set; }

        [Required]
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

        [Required]
        public bool Activo { get; set; }

    }
}
