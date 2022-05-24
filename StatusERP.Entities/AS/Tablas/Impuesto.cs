using StatusERP.Entities.CG.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.AS.Tablas

{
    [Table("Impuestos", Schema = Constants.Conjunto)]
    public class Impuesto:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodImpuesto { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto2 { get; set; }

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

        public bool ContabDevImp1 { get; set; }

        public bool ContabDevImp2 { get; set; }

        public int? CtroCtaImp1GenId { get; set; }
        [ForeignKey(nameof(CtroCtaImp1GenId))]
        public CentroCuenta Imp1Gen { get; set; }

        public int? CtroCtaImp2GenId { get; set; }
        [ForeignKey(nameof(CtroCtaImp2GenId))]
        public CentroCuenta Imp2Gen { get; set; }

        public int? CtroCtaImp1GenVtsId { get; set; }
        [ForeignKey(nameof(CtroCtaImp1GenVtsId))]
        public CentroCuenta Imp1GenVts { get; set; }

        public int? CtroCtaImp2GenVtsId { get; set; }
        [ForeignKey(nameof(CtroCtaImp2GenVtsId))]
        public CentroCuenta Imp2GenVts { get; set; }

        public int? CtroCtaImp1DescCompId { get; set; }
        [ForeignKey(nameof(CtroCtaImp1DescCompId))]
        public CentroCuenta Imp1DescComp { get; set; }

        public int? CtroCtaImp2DescCompId { get; set; }
        [ForeignKey(nameof(CtroCtaImp2DescCompId))]
        public CentroCuenta Imp2DescComp { get; set; }

        public int? CtroCtaImp1DevCompId { get; set; }
        [ForeignKey(nameof(CtroCtaImp1DevCompId))]
        public CentroCuenta Imp1DevComp { get; set; }

        public int? CtroCtaImp2DevCompId { get; set; }
        [ForeignKey(nameof(CtroCtaImp2DevCompId))]
        public CentroCuenta Imp2DevComp { get; set; }

        public int? CtroCtaImp1DevVtsId { get; set; }
        [ForeignKey(nameof(CtroCtaImp1DevVtsId))]
        public CentroCuenta Imp1DevVts { get; set; }

        public int? CtroCtaImp2DevVtsId { get; set; }
        [ForeignKey(nameof(CtroCtaImp2DevVtsId))]
        public CentroCuenta Imp2DevVts { get; set; }

        public int? TipoImpuesto1Id { get; set; }
        [ForeignKey(nameof(TipoImpuesto1Id))]
        public TipoImpuesto TipoImpuesto1 { get; set; }

        public int? TipoImpuesto2Id { get; set; }
        [ForeignKey(nameof(TipoImpuesto2Id))]
        public TipoImpuesto TipoImpuesto2 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa1 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa2 { get; set; }

        public bool Activo { get; set; }
    }
}
