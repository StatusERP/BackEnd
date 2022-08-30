using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("Clientes", Schema = Constants.Conjunto)]
    public class Cliente:EntityBase
    {
        [StringLength(20)]
        public string CodCliente { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        public int? DetalleDireccionId { get; set; }
        [ForeignKey(nameof(DetalleDireccionId))]
        public DetalleDireccion detalleDireccion { get; set; }

        [StringLength(150)]
        public string ? Alias { get; set; }

        [StringLength(30)]
        public string Contacto { get; set; }

        [StringLength(30)]
        public string Cargo { get; set; }

        public string ? Direccion { get; set; }

        [StringLength(8)]
        public string? DirEmbarqueDefault { get; set; }

        [StringLength(50)]
        public string ? Telefono1 { get; set; }

        [StringLength(50)]
        public string ? Telefono2 { get; set; }

        public int DocTributarioId { get; set; }
        [ForeignKey(nameof(DocTributarioId))]
        public DocTributario DocTributario { get; set; }

        public DateTime FechaIngreso { get; set; }

        public bool Multimoneda { get; set; }

        public int MonedaId { get; set; }
        [ForeignKey(nameof(MonedaId))]
        public Moneda Moneda { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Saldo { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoDolar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCredito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SaldoNoCargos { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? LimiteCredito { get; set; }

        public bool ExcederLimite { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TasaInteres { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal TasaInteresesMora { get; set; }   

        public DateTime FechaUltMora { get; set; }

        public DateTime FechaUltMov { get; set; }

        public int CondicionPagoId { get; set; }
        [ForeignKey(nameof(CondicionPagoId))]
        public CondicionPago CondicionPago { get; set; }

        public int NivelPrecioId { get; set; }
        [ForeignKey(nameof(NivelPrecioId))]
        public NivelPrecio NivelPrecio { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Descuento { get; set; }

        public bool AceptaBackorder { get; set; }

        public int PaisId { get; set; }
        [ForeignKey(nameof(PaisId))]
        public Pais Pais{ get; set; }

        public int ZonaId { get; set; }
        [ForeignKey(nameof(ZonaId))]
        public Zona  Zona { get; set; }

        public int RutaId { get; set; }
        [ForeignKey(nameof(RutaId))]
        public Ruta Ruta { get; set; }

        public int? VendedorId { get; set; }
        [ForeignKey(nameof(VendedorId))]
        public Vendedor Vendedor { get; set; }

        public int CobradorId { get; set; }
        [ForeignKey(nameof(CobradorId))]
        public Cobrador Cobrador { get; set; }

        public bool AceptaFracciones { get; set; }

        public bool Activo { get; set; }

        public bool ExentoImpuestos { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ExencionImp1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ExencionImp2 { get; set; }

        public bool CobroJudicial { get; set; }

        public int CategoriaClienteId { get; set; }
        [ForeignKey(nameof(CategoriaClienteId))]
        public CategoriaCliente CategoriaCliente { get; set; }

        [StringLength(1)]
        public string ? ClaseABC { get; set; }

        public Int16 DiasAbastecimien { get; set; }

        public bool UsaTarjeta { get; set; }

        [StringLength(20)]
        public string ? TarjetaCredito { get; set; }

        public int? TipoTarjetaId { get; set; }
        [ForeignKey(nameof(TipoTarjetaId))]
        public TipoTarjeta TipoTarjeta { get; set; }

        public DateTime ? FechaVenceTar { get; set; }

        [StringLength(250)]
        public string ? Email { get; set; }

        public bool RequiereOC { get; set; }

        public bool EsCorporacion { get; set; }

        public int? CliCorporacAsocId { get; set; }
        [ForeignKey(nameof(CliCorporacAsocId))]
        public Cliente CliCorporacAsoc { get; set; }

        public bool RegistrarDocsACorp { get; set; }

        public bool UsarDirEmbCorp { get; set; }

        public bool AplicacAbiertas { get; set; }

        public bool VerifLimCredCorp { get; set; }

        public bool UsarDescCorp { get; set; }

        [StringLength(1)]
        public string DocAGenerar { get; set; }

        [StringLength(40)]
        public string ? Rubro1Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro2Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro3Cliente { get; set; }

        public bool TieneConvenio { get; set; }

        public string ? Notas { get; set; }

        public Int16 DiasPromedAtraso { get; set; }

        [StringLength(50)]
        public string ? Rubro1Cli { get; set; }

        [StringLength(50)]
        public string ? Rubro2Cli { get; set; }

        [StringLength(50)]
        public string ? Rubro3Cli { get; set; }

        [StringLength(50)]
        public string ? Rubro4Cli { get; set; }

        [StringLength(50)]
        public string ? Rubro5Cli { get; set; }

        public bool AsocObligContFact { get; set; }

        [StringLength(40)]
        public string ? Rubro4Cliente { get; set; }

        [StringLength(40)]
        public string? Rubro5Cliente { get; set; }

        [StringLength(40)]
        public string? Rubro6Cliente { get; set; }

        [StringLength(40)]
        public string? Rubro7Cliente { get; set; }

        [StringLength(40)]
        public string? Rubro8Cliente { get; set; }

        [StringLength(40)]
        public string? Rubro9Cliente { get; set; }

        [StringLength(40)]
        public string? Rubro10Cliente { get; set; }

        public bool UsarPreciosCorp { get; set; }

        public bool UsarExencImpCorp { get; set;  }

        [StringLength(13)]
        public string ? DiasDeCobro { get; set; }

        [StringLength(1)]
        public string AjusteFechaCobro { get; set; }

        [StringLength(250)]
        public string ? Ubicacion { get; set; }

        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        [StringLength(1)]
        public string Local { get; set; }

        [StringLength(1)]
        public string ? TipoContribuyente { get; set; }

        [StringLength(40)]
        public string ? Rubro11Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro12Cliente { get; set; }
        
        [StringLength(40)]
        public string ? Rubro13Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro14Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro15Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro16Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro17Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro18Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro19Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro20Cliente { get; set; }
       
        public bool AceptaDocElectronico {get; set;}

        public bool ConfirmaDocElectronico { get; set;}

        [StringLength(250)]
        public string ? EmailDocElectronico { get; set;}

        [StringLength(250)]
        public string ? EmailPedEDI { get; set; }

        public bool AceptaDocEDI { get; set; }

        public bool NotificarErrorEDI { get; set; }

        [StringLength(250)]
        public string ? EmailErrorPedEDI { get; set; }

        public int? ImpuestoId { get; set; }
        [ForeignKey(nameof(ImpuestoId))]
        public Impuesto Impuesto { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica1 { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica2 { get; set; }

        public bool Moroso { get; set; }

        public bool ModifNombEnFac { get; set;}

        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTrans { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransLocal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransDolar { get; set; }

        public bool ParticipaFlujoCaja { get; set; }

        [StringLength(250)]
        public string ? UsuarioCreacion { get; set; }

        public DateTime ? FechaHoraCreacion { get; set; }

        [StringLength(250)]
        public string ? UsuarioUltMod { get; set; }   

        public DateTime ? FchHoraUltMod { get; set; }

        [StringLength(250)]
        public string ? EmailDocElectronicoCopia { get; set; }

        public bool DetallarKits { get; set; }

        [StringLength(20)]
        public string ? XSLTPersonalizado { get; set; }

        [StringLength(20)]
        public string ? NombreAddenda { get; set; }

        [Column(TypeName = "decimal(28,12)")]
        public decimal ? GeoLatitud { get; set; }

        [Column(TypeName = "decimal(28,12)")]
        public decimal ? GeoLongitud { get; set; }

        [StringLength(25)]
        public string ? SubTipoDoc { get; set; }

        [StringLength(254)]
        public string ? PassAPIRecepcion { get; set; }

        public int? TipoImpuestoId { get; set; }
        [ForeignKey(nameof(TipoImpuestoId))]
        public TipoImpuesto TipoImpuesto { get; set; }

        public bool EsExtranjero { get; set; }

        [StringLength(20)]
        public string? XSLTPersonalizadoCredito { get; set; }
        
        [StringLength(10)]
        public string ? TipoGenerar { get; set; }

        [StringLength(10)]
        public string ? TipoPersoneria { get; set; }

        public int? MetodoPagoId { get; set; }
        [ForeignKey(nameof(MetodoPagoId))]
        public MetodoPago MetodoPago { get; set; }

        public bool EsAgentePercepcion { get; set; }

        public bool EsBuenContribuyente { get; set; }
    }
}
