using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.FA.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CC.Tablas
{
    [Table("DocumentosCC", Schema = Constants.Conjunto)]
    public class DocumentosCC:EntityBase
    {
        [Required(ErrorMessage ="El número de documento es requerido.")]
        [StringLength(50)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string ? Contrarecibo { get; set; }

        [Required(ErrorMessage = "La aplicación es requerida.")]
        [StringLength(250)]
        public string Aplicacion { get; set; }

        [Required(ErrorMessage = "La fecha del documento es requerida.")]
        public DateTime FechaDocumento { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El saldo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "El monto en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoLocal { get; set; }

        [Required(ErrorMessage = "El saldo en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoLocal { get; set; }

        [Required(ErrorMessage = "El monto en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDolar { get; set; }

        [Required(ErrorMessage = "El saldo en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoDolar { get; set; }

        [Required(ErrorMessage = "El monto en la moneda del cliente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoCliente { get; set; }

        [Required(ErrorMessage = "El saldo en la moneda del cliente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCliente { get; set; }

        [Required(ErrorMessage = "El tipo de cambio original es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioMoneda { get; set; }

        [Required(ErrorMessage = "El tipo de cambio original en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioDolar { get; set; }

        [Required(ErrorMessage = "El tipo de cambio original en la moneda del cliente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioCliente { get; set; }

        [Required(ErrorMessage = "El tipo de cambio actual en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambActLoc { get; set; }

        [Required(ErrorMessage = "El tipo de cambio actual en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambActDol { get; set; }

        [Required(ErrorMessage = "El tipo de cambio actual en la moneda del cliente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambActCli { get; set; }

        [Required(ErrorMessage = "El subtotal es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "El descuento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Descuento { get; set; }

        [Required(ErrorMessage = "El impuesto 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto1 { get; set; }

        [Required(ErrorMessage = "El impuesto 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto2 { get; set; }

        [Required(ErrorMessage = "El rubro 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Rubro1 { get; set; }

        [Required(ErrorMessage = "El rubro 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Rubro2 { get; set; }

        [Required(ErrorMessage = "El monto de la retención es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoRetencion { get; set; }

        [Required(ErrorMessage = "El saldo de la retención es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoRetencion { get; set; }

        public bool Dependiente { get; set; }

        [Required(ErrorMessage = "La fecha del último crédito es requerida.")]
        public DateTime FechaUltCredito { get; set; }

        public bool CargadoDeFact { get; set; }

        public bool Aprobado { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        public bool AsientoPendiente { get; set; }

        [Required(ErrorMessage = "La fecha de la última modificación es requerida.")]
        public DateTime FechaUltMod { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "La clase de documento es requerida.")]
        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es requerida.")]
        public DateTime FechaVence { get; set; }

        [Required(ErrorMessage = "El número de parcialidades es requerido.")]
        public Int16 NumParcialidades { get; set; }

        public DateTime ? FechaRevision { get; set; }

        public int ? CobradorId { get; set; }
        public Cobrador Cobrador { get; set; }

        [Required(ErrorMessage = "El usuario de la última modificación es requerido.")]
        [StringLength(450)]
        public string UsuarioUltMod { get; set; }

        [Required(ErrorMessage = "La condición de pago es requerida.")]
        [StringLength(4)]
        public string CondicionPago { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        [StringLength(20)]
        public string ? CtaBancaria { get; set; }

        public int ? VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        [Required(ErrorMessage = "El cliente reporte es requerido.")]
        [StringLength(20)]
        public string ClienteReporte { get; set; }

        [Required(ErrorMessage = "El cliente origen es requerido.")]
        [StringLength(20)]
        public string ClienteOrigen { get; set; }

        [Required(ErrorMessage = "El cliente es requerido.")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Int16 ? Subtipo { get; set; }

        [Required(ErrorMessage = "El porcentaje de interés corriente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcIntCte { get; set; }

        [StringLength(3)]
        public string ? TipoDocOrigen { get; set; }

        [StringLength(50)]
        public string ? DocDocOrigen { get; set; }

        public DateTime ? FechaAnul { get; set; }

        [StringLength(450)]
        public string ? AudUsuarioAnul { get; set; }

        public DateTime ? AudFechaAnul { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? NumDocCB { get; set; }

        public DateTime ? FechaCobro { get; set; }

        [StringLength(80)]
        public string ? AuditoriaCobro { get; set; }

        public DateTime ? FechaSeguimiento { get; set; }

        [StringLength(250)]
        public string ? ObservacionesCobro { get; set; }

        [StringLength(450)]
        public string ? UsuarioAprobacion { get; set; }

        public DateTime ? FechaAprobacion { get; set; }

        public bool ? Anulado { get; set; }

        [StringLength(4)]
        public string ? CodigoImpuesto { get; set; }

        public int ? PaisId { get; set; }
        public Pais Pais { get; set; }

        public int ? DivisionGeografica1Id { get; set; }
        public DivGeografica1 DivGeografica1 { get; set; }

        public int ? DivisionGeografica2Id { get; set; }
        public DivGeografica2 DivGeografica2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? BaseImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? BaseImpuesto2 { get; set; }

        public bool DependienteGP { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTrans { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransLocal { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransDolar { get; set; }

        public DateTime ? FechaProyectada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcRecuperacion { get; set; }

        [StringLength(4)]
        public string ? TipoAsiento { get; set; }

        [StringLength(4)]
        public string ? Paquete { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en la moneda del ciente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransCli { get; set; }

        [StringLength(50)]
        public string ? DocumentoFiscal { get; set; }

        public bool Facturado { get; set; }

        public bool GeneraDocFE { get; set; }

        [StringLength(4)]
        public string ? TasaImpositiva { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaImpositivaPorc { get; set; }

        [StringLength(4)]
        public string ? TasaCre1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaCre1Porc { get; set; }

        [StringLength(4)]
        public string ? TasaCre2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaCre2Porc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaGanOcasionalPorc { get; set; }

        public int ? EntidadFinancieraId { get; set; }
        public EntidadFinanciera EntidadFinanciera { get; set; }

        [StringLength(50)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(20)]
        public string ? CuentaOrigen { get; set; }

        [StringLength(3)]
        public string ? UsoCFDI { get; set; }

        [StringLength(20)]
        public string ? ClaveUnidad { get; set; }

        [StringLength(200)]
        public string ? ClaveProdServi { get; set; }

        [StringLength(3)]
        public string ? FormaPago { get; set; }

        [StringLength(200)]
        public string ? TipoRelacion { get; set; }

        [StringLength(50)]
        public string ? ClaveReferenciaDE { get; set; }

        public DateTime ? FechaReferenciaDE { get; set; }

        [StringLength(2)]
        public string ? JustiDevHacienda { get; set; }

        [StringLength(3)]
        public string ? Incoterms { get; set; }

        [StringLength(10)]
        public string ? Consecutivo { get; set; }

        [StringLength(4)]
        public string ? TipoOperacion { get; set; }

        [StringLength(4)]
        public string ? ClavePSPub { get; set; }

        [StringLength(50)]
        public string ? ClaveDE { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto1 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa1 { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto2 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa2 { get; set; }

        [StringLength(10)]
        public string ? ActividadComercial { get; set; }

        [StringLength(2)]
        public string ? Cancelacion { get; set; }

        [StringLength(20)]
        public string ? EstadoCancelacion { get; set; }

        public bool TieneRelacionados { get; set; }

        [StringLength(4)]
        public string ? ItemHacienda { get; set;}

        [StringLength(25)]
        public string ? Prefijo { get; set; }

        public DateTime? FechaInicioResolucion { get; set; }

        public DateTime? FechaFinResolucion { get; set; }

        [StringLength(80)]
        public string ? ClaveTecnica { get; set; }

        public int ? MatriculaMercantil { get; set; }

        public bool EsFacturaReemplazo { get; set; }

        [StringLength(50)]
        public string? FacturaOriginalReemplazo { get; set; }

        [StringLength(4)]
        public string ? TipoReferenciaDE { get; set; }

        [StringLength(10)]
        public string ? ConsecutivoFTC { get; set; }

        [StringLength(50)]
        public string ? NumeroFTC { get; set; }

        [StringLength(20)]
        public string ? NITTransportador { get; set; }

        [StringLength(2)]
        public string ? CodigoReferenciaDE { get; set;}

        [StringLength(50)]
        public string ? NCFModificado { get; set; }

        [StringLength(100)]
        public string ? NumOCExenta { get; set; }

        [StringLength(100)]
        public string ? NumConsRegExo { get; set; }

        [StringLength(100)]
        public string ? NumIrsedeAgrGan { get; set; }

        [StringLength(30)]
        public string ? ADWMTipoNC { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }

        [StringLength(10)]
        public string ? MetodoPago { get; set; }

        [StringLength(10)]
        public string ? TipoFactura { get; set; }

        [StringLength(2)]
        public string ? TipoDescuento { get; set; }

        [StringLength(2)]
        public string ? TipoNC { get; set; }

        [StringLength(2)]
        public string? TipoND { get; set; }

        [StringLength(30)]
        public string? NumeroOrden { get; set; }

        public DateTime ? FechaOrden { get; set; }

        [StringLength(4)]
        public string? TipoImpuesto { get; set; }

        [StringLength(4)]
        public string? TipoDetrac { get; set; }

        [StringLength(4)]
        public string? ActDetrac { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcDetrac { get; set; }

        [StringLength(40)]
        public string ? GUUIDOriginal { get; set; }

        [StringLength(3)]
        public string ? ClaseDocES { get; set; }

        [StringLength(22)]
        public string ? Resolucion { get; set; }

        [StringLength(13)]
        public string ? Serie { get; set; }

        [StringLength(20)]
        public string ? ControlInterno { get; set; }

        [StringLength(22)]
        public string ? SerieNumero { get; set; }
     }
}
