using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CP.Tablas

{
    [Table("DocumentosCP", Schema = Constants.Conjunto)]
    public class DocumentoCP:EntityBase
    {
        [Required(ErrorMessage ="El código de proveedor es requerido.")]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required(ErrorMessage ="El número de documento es requerido.")]
        [StringLength(50)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        public bool EmbarqueAprobado { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TipoCambLiqLoc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TipoCambLiqDol { get; set; }

        [Required(ErrorMessage = "La fecha del documento es requerida.")]
        public DateTime FechaDocumento { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [StringLength(2)]
        public string ? TipoProrrateo { get; set; }

        [StringLength(20)]
        public string ? Etiqueta { get; set; }

        [Required(ErrorMessage = "El tipo de embarque es requerida.")]
        [StringLength(1)]
        public string TipoEmbarque { get; set; }

        [Required(ErrorMessage = "La aplicación es requerida.")]
        [StringLength(250)]
        public string Aplicacion { get; set; }

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

        [Required(ErrorMessage = "El monto en dolares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoDolar { get; set; }

        [Required(ErrorMessage = "El saldo en dolares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoDolar { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en la moneda del documento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioMoneda { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioDolar { get; set; }

        [Required(ErrorMessage = "La fecha del último crédito es requerida.")]
        public DateTime FechaUltCredito { get; set; }

        public bool ChequeImpreso { get; set; }

        public bool Aprobado { get; set; }

        [Required(ErrorMessage = "La condición del documento es requerida.")]
        [StringLength(1)]
        public string Seleccionado { get; set; }

        public bool Congelado { get; set; }

        [Required(ErrorMessage = "El monto en la moneda del proveedor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoProv { get; set; }

        [Required(ErrorMessage = "El saldo en la moneda del proveedor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoProv { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en la moneda del proveedor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioProv { get; set; }

        [Required(ErrorMessage = "El subtotal es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SubTotal { get; set; }

        [Required(ErrorMessage = "El monto del descuento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Descuento { get; set; }

        [Required(ErrorMessage = "El monto del impuesto 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto1 { get; set; }

        [Required(ErrorMessage = "El monto del impuesto 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto2 { get; set; }

        [Required(ErrorMessage = "El monto del rubro 1 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Rubro1 { get; set; }

        [Required(ErrorMessage = "El monto del rubro 2 es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Rubro2 { get; set; }

        [Required(ErrorMessage = "La fecha de la última modificación es requerida.")]
        public DateTime FechaUltMod { get; set; }

        [Required(ErrorMessage = "El monto de la retención es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoRetencion { get; set; }

        [Required(ErrorMessage = "El saldo de la retención es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoRetencion { get; set; }

        public bool Dependiente { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        public bool AsientoPendiente { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "El tipo de cambio actual en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambActLoc { get; set; }

        [Required(ErrorMessage = "El tipo de cambio actual en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambActDol { get; set; }

        [Required(ErrorMessage = "El tipo de cambio actual en la moneda del proveedor es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambActProv { get; set; }

        public bool DocumentoEmbarque { get; set; }

        public DateTime ? FechaRevision { get; set; }

        [StringLength(15)]
        public string? LiquidacCompra { get; set; }

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
        public string ? ChequeCuenta { get; set; }

        public int ? QuedanId { get; set; }
        public Quedan Quedan { get; set; }

        public Int16 ? SubTipo { get; set; }

        [Required(ErrorMessage = "La fecha vence es requerida.")]
        public DateTime FechaVence { get; set; }

        public DateTime ? FechaAnul { get; set; }

        [StringLength(450)]
        public string ? AudUsuarioAnul { get; set; }

        public DateTime? AudFechaAnul { get; set; }

        [StringLength(450)]
        public string ? UsuarioAprobacion { get; set; }

        public DateTime ? FechaAprobacion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoPago { get; set; }

        [StringLength(450)]
        public string ? Usuario { get; set; }

        [StringLength(20)]
        public string ? CuentaBanco { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TipoCambio { get; set; }

        public bool Anulado { get; set; }

        [StringLength(4)]
        public string ? CodigoImpuesto { get; set; }

        public int ? PaisId { get; set; }
        public Pais Pais { get; set;  }

        public int? DivisionGeografica1Id { get; set; }
        public DivGeografica1 DivGeografica1 { get; set; }

        public int? DivisionGeografica2Id { get; set; }
        public DivGeografica2 DivGeografica2 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? BaseImpuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? BaseImpuesto2 { get; set; }

        public bool DependienteGP { get; set; }

        [Required(ErrorMessage ="El saldo de la transacción es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTrans { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransLocal { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransDolar { get; set; }

        public DateTime? FechaProyectada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? Imp1AsumidoDesc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? Imp1AsumidoNoDesc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? Imp1RetenidoDesc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? Imp1RetenidoNoDesc { get; set; }

        [StringLength(4)]
        public string ? TipoAsiento { get; set; }

        [StringLength(4)]
        public string ? Paquete { get; set; }

        [StringLength(50)]
        public string ? DocumentoFiscal { get; set; }

        [StringLength(1)]
        public string ? EstadoEnvio { get; set; }

        [StringLength(4)]
        public string ? ConceptoME { get; set; }

        [Required(ErrorMessage = "La clase de documento es requerida.")]
        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        [Required(ErrorMessage = "El porcentaje de interés corriente es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PorcIntCte { get; set; }

        [Required(ErrorMessage = "El número de parcialidades es requerido.")]
        public Int16 NumParcialidades { get; set; }

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

        public bool GeneraDocFE { get; set; }

        [StringLength(50)]
        public string ? DocumentoGlobal { get; set; }

        public DateTime ? FechaCAI { get; set; }

        [StringLength(50)]
        public string ? CAI { get; set; }

        [StringLength(4)]
        public string ?TipoImpuesto1 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa1 { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto2 { get; set; }

        [StringLength(2)]
        public string ? TipoTarifa2 { get; set; }

        [StringLength(10)]
        public string ? ConsecutivoDoc { get; set; }

        [StringLength(50)]
        public string ? ClaveDE { get; set; }

        [StringLength(2)]
        public string ? TipoAfectacionIVA { get; set; }

        [StringLength(4)]
        public string ? TipoImpuestoAfectacion { get; set; }

        [StringLength(2)]
        public string ? TipoTarifaAfectacion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcAfectacionIVA { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoTotalImpuestoAcreditar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoTotalGastoAplicable { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoProporcionalidad { get; set; }

        [StringLength(10)]
        public string ? ActividadComercial { get; set; }

        [StringLength(4)]
        public string ? ItemHacienda { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SubTotalBienes { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SubTotalServicios { get; set; }

        [StringLength(50)]
        public string ? NCFModificado { get; set; }

        [StringLength(20)]
        public string ? DestinoITBis { get; set; }

        [StringLength(2)]
        public string ? TipoDocReferencia { get; set; }

        [StringLength(50)]
        public string ? ClaveReferencia { get; set; }

        public DateTime ? FechaEmisionReferencia { get; set; }

        [StringLength(2)]
        public string ? CodigoReferencia { get; set; }

        [StringLength(180)]
        public string ? RazonReferencia { get; set; }

        [StringLength(10)]
        public string ? TipoPago { get; set; }

        [StringLength(10)]
        public string ? MetodoPago { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoReferencia { get; set; }

        public bool GeneDocDetrac { get; set; }

        [StringLength(4)]
        public string ? TipoDetrac { get; set; }

        [StringLength(4)]
        public string ? ActDetrac { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcDetrac { get; set; }

        [Required(ErrorMessage = "El estado del documento es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? AdValorem { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? ValorAduana { get; set; }

        [StringLength(12)]
        public string ? Aduana { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DeducCostoEnajena { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? RentaNeta { get; set; }

        [StringLength(4)]
        public string ? TipoRenta { get; set; }

        [StringLength(4)]
        public string ? ModalidadServicio { get; set; }

        public int ? AnioDua { get; set; }

        [StringLength(4)]
        public string ? Clasificacion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? MontoNoGravado { get; set; }

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
