using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("DetTransCB", Schema = Constants.Conjunto)]
    public class DetTransCB : EntityBase
    {
        [Required(ErrorMessage = "El consecutivo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Consecutivo { get; set; }

        [Required(ErrorMessage = "La cuenta origen es requerida.")]
        public int CuentaOrigenId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El tipo origen es requerido.")]
        [StringLength(3)]
        public string TipoOrigen { get; set; }

        [Required(ErrorMessage = "El número origen es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal NumeroOrigen { get; set; }

        [Required(ErrorMessage = "La cuenta destino es requerida.")]
        [StringLength(50)]
        public string CuentaDestino { get; set; }

        [Required(ErrorMessage = "El tipo de documento de destino es requerido.")]
        [StringLength(3)]
        public string TipoDestino { get; set; }

        [Required(ErrorMessage = "El número de documento de destino es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal NumeroDestino { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoComision { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TipoCambio { get; set; }

        [Required(ErrorMessage = "El monto de la tansferencia en la moneda origen es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoOrigen { get; set; }

        [Required(ErrorMessage = "El monto de la transferencia en la moneda destino es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDestino { get; set; }

        [Required(ErrorMessage = "La compañía destino es requerida.")]
        [StringLength(10)]
        public string CompaniaDestino { get; set; }

        [StringLength(1)]
        public string ? TipoMov { get; set; }

        [StringLength(150)]
        public string ? Beneficiario { get; set; }

        public int ? DocTributarioId { get; set; }
        public DocTributario DocTributario { get; set; }

        [StringLength(100)]
        public string ? Concepto { get; set; }

        public int ? EntidadFinacieraId { get; set; }
        public EntidadFinanciera EntidadFinanciera { get; set; }

        public int ? MonedaId { get; set; }
        public Moneda Moneda { get; set; }

        [StringLength(100)]
        public string? Rubro1DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro2DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro3DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro4DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro5DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro6DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro7DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro8DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro9DetTrans { get; set; }

        [StringLength(100)]
        public string? Rubro10DetTrans { get; set; }

        public int ? CtrCierreTercerosId { get; set; }
        public CentroCosto CentroCosto { get; set; }

        public int ? CtaCierreTerceros { get; set; }
        public CuentaContable CuentaContable { get; set; }

        [StringLength(10)]
        public string ? MetodoPago { get; set; }
    }
}
