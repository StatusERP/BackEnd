using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Entities.CP.Tablas;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("MovBancos", Schema = Constants.Conjunto)]
    public class MovBancos:EntityBase
    {
        [Required(ErrorMessage = "La cuenta bancaria es requerida.")]
        public int CuentaBancoId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string TipoDocumento {get; set; }

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal Numero { get; set; }

        public Int16 ? SubTipo { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [StringLength(150)]
        public string ? PagaderoA { get; set; }

        [Required(ErrorMessage = "La referencia es requerida.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        public int ? ConcilAclaracionId { get; set; }
        public ConciliacionBancaria ConcilAclaracion { get; set; }

        public int ? ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public int ? DocTributarioId { get; set; }
        public DocTributario DocTributario { get; set; }

        public string ? Detalle { get; set; }

        public bool Confirmado { get; set; }

        [StringLength(2)]
        public string ? Origen { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        public bool Anulado { get; set; }

        [Required(ErrorMessage = "La fecha y la hora de creación son requeridas.")]
        public DateTime FechaHoraCreacion { get; set; }

        [Required(ErrorMessage = "El usuario de creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoAnulado { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public int ? ConciliacionId { get; set; }
        public ConciliacionBancaria ConciliacionBancaria { get; set; }

        public bool Impreso { get; set; }

        public int ? DocReportado { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoReportado { get; set; }

        [Required(ErrorMessage = "La clase de diferencia es requerida.")]
        [StringLength(1)]
        public string ClaseDif { get; set; }

        public bool AclaradaDif { get; set; }

        public int? DocAjuste { get; set; }

        [StringLength(3)]
        public string ? TipoDocAjuste { get; set; }

        [Column(TypeName = "decimal(28,0)")]
        public decimal ? NumeroDocAjuste { get; set; }

        [Required(ErrorMessage = "La clase de documento es requerida.")]
        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        [Required(ErrorMessage = "El modo de registro es requerido.")]
        [StringLength(1)]
        public string ModoRegistro { get; set; }

        public bool Liquidado { get; set; }

        public DateTime ? FechaHoraModificacion { get; set; }

        [StringLength(450)]
        public string ? UsuarioModific { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioLocal { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioDolar { get; set; }

        public DateTime ? FechaHoraAnulado { get; set; }

        [StringLength(450)]
        public string ? UsuarioAnulado { get; set; }

        [StringLength(250)]
        public string ? ReferenciaAnulado { get; set; }

        public bool Aprobado { get; set; }

        [StringLength(450)]
        public string ? UsuarioAprobacion { get; set; }

        public DateTime ? FechaAprobacion { get; set; }

        [StringLength(4)]
        public string ? TipoAsiento { get; set; }

        public int ? PaqueteId { get; set; }
        public PaqueteContable PaqueteContable { get; set; }

        public bool DependienteGP { get; set; }

        [StringLength(50)]
        public string ? DocumentoFiscal { get; set; }

        public DateTime ? FechaContable { get; set; }

        [StringLength(4)]
        public string ? CodImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Impuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? Imp1NoDes { get; set; }

        [StringLength(50)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(3)]
        public string ? TipoCF { get; set; }

        [StringLength(10)]
        public string ? MetodoPago { get; set; }
    }
}
