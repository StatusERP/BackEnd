using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("Clientes", Schema = Constants.Conjunto)]
    public class Cliente:EntityBase
    {
        [Required(ErrorMessage ="El código de cliente es requerido.")]
        [StringLength(20)]
        public string CodCliente { get; set; }

        [Required(ErrorMessage = "El nombre de cliente es requerido.")]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string ? Alias { get; set; }

        [Required(ErrorMessage = "El contacto de cliente es requerido.")]
        [StringLength(30)]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "El cargo es requerido.")]
        [StringLength(30)]
        public string Cargo { get; set; }

        public string ? Direccion { get; set; }
        
        [StringLength(8)]
        public string ? DirEmbarqueDefault { get; set; }

        [StringLength(50)]
        public string ? Telefono1 { get; set; }

        [StringLength(50)]
        public string ? Telefono2 { get; set; }


        public int ContribuyenteId { get; set; }
        public DocTributario DocTributario { get; set; }    

        [Required(ErrorMessage = "La fecha de ingreso es requerida.")]
        public DateTime FechaIngreso { get; set; }

        public bool Multimoneda { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El saldo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "El saldo en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoLocal { get; set; }

        [Required(ErrorMessage = "El saldo en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoDolar { get; set; }

        [Required(ErrorMessage = "El saldo disponible del crédito es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoCredito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SaldoNoCargos { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? LimiteCredito { get; set; }

        public bool ExcederLimite { get; set; }

        [Required(ErrorMessage = "La tasa de interés es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TasaInteres { get; set; }

        [Required(ErrorMessage = "La tasa de interés por mora es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TasaInteresesMora { get; set; }

        [Required(ErrorMessage = "La fecha de la última mora es requerida.")]
        public DateTime FechaUltMora { get; set; }

        [Required(ErrorMessage = "La fecha del último movimiento es requerida.")]
        public DateTime FechaUltMov { get; set; }

        [Required(ErrorMessage = "La condición de pago es requerida.")]
        [StringLength(4)]
        public string CondicionPago { get; set; }

        [Required(ErrorMessage = "El nivel precio es requerido.")]
        [StringLength(12)]
        public string NivelPrecio { get; set; }

        [Required(ErrorMessage = "El descuento es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Descuento { get; set; }

        [Required(ErrorMessage = "La moneda del nivel de precios es requerida.")]
        [StringLength(1)]
        public string MonedaNivel { get; set; }

        public bool AceptaBackorder { get; set; }

        [Required(ErrorMessage = "El país es requerido.")]
        [StringLength(4)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "La zona es requerida.")]
        [StringLength(4)]
        public string Zona { get; set; }

        [Required(ErrorMessage = "La ruta es requerida.")]
        [StringLength(4)]
        public string Ruta { get; set; }

        [StringLength(4)]
        public string ? Vendedor { get; set; }

        [Required(ErrorMessage = "El cobrador es requerido.")]
        [StringLength(4)]
        public string Cobrador { get; set; }

        public bool AceptaFracciones { get; set; }

        public bool Activo { get; set; }

        public bool ExentoImpuestos { get; set; }

        [Required(ErrorMessage = "Se debe indicar el porcentaje de exención que se aplicará al Impuesto 1.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExencionImp1 { get; set; }

        [Required(ErrorMessage = "Se debe indicar el porcentaje de exención que se aplicará al Impuesto 2.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExencionImp2 { get; set; }

        public bool CobroJudicial { get; set; }

        [Required(ErrorMessage = "El código de Categoría Cliente es requerido.")]
        [StringLength(8)]
        public string CategoriaCliente { get; set; }

        [StringLength(1)]
        public string ? ClaseABC { get; set; }

        [Required(ErrorMessage = "Los días de abastecimiento son requeridos.")]
        public Int16 DiasAbastecimien { get; set; }

        public bool UsaTarjeta { get; set; }

        [StringLength(20)]
        public string ? TarjetaCredito { get; set; }

        [StringLength(12)]
        public string ? TipoTarjeta { get; set; }

        public DateTime ? FechaVenceTar { get; set; }

        [StringLength(250)]
        public string ? Email { get; set; }

        public bool RequiereOC { get; set; }

        public bool EsCorporacion { get; set; }

        [StringLength(20)]
        public string ? CliCorporacAsoc { get; set; }

        public bool RegistrarDocsACorp { get; set; }

        public bool UsarDirEmbCorp { get; set; }

        public bool AplicacAbiertas { get; set; }

        public bool VerifLimCredCorp { get; set; }

        public bool UsarDescCorp { get; set; }

        [Required(ErrorMessage = "Se debe indicar el tipo de documento por omisión que se va a generar para el cliente.")]
        [StringLength(1)]
        public string DocAGenerar { get; set; }

        [StringLength(40)]
        public string ? Rubro1_Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro2_Cliente { get; set; }

        [StringLength(40)]
        public string ? Rubro3_Cliente { get; set; }

        public bool TieneConvenio { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "Los días promedio de atraso son requeridos.")]
        public Int16 DiasPromAtraso { get; set; }

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

        [Required(ErrorMessage = "Debe indicarse el tipo de ajuste de la fecha cobro.")]
        [StringLength(1)]
        public string AjusteFechaCobro { get; set; }

        [StringLength(250)]
        public string ? Ubicacion { get; set; }

        [Required(ErrorMessage = "La clase de documento es requerida.")]
        [StringLength(1)]
        public string ClaseDocumento { get; set; }

        [Required(ErrorMessage = "Se debe indicar si el cliente es local o del exterior.")]
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

        [StringLength(4)]
        public string ? ModeloRetencion { get; set; }

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

        [StringLength(4)]
        public string ? CodigoImpuesto { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica1 { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica2 { get; set; }


        [StringLength(12)]
        public string ? RegimenTrib { get; set; }

        public bool Moroso { get; set; }

        public bool ModifNombEnFac { get; set;}

        [Required(ErrorMessage = "El saldo transaccional es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTrans { get; set; }

        [Required(ErrorMessage = "El saldo transaccional en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransLocal { get; set; }

        [Required(ErrorMessage = "El saldo transaccional en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransDolar { get; set; }

        public bool PermiteDocGP { get; set; }

        public bool ParticipaFlujoCaja { get; set; }

        [StringLength(18)]
        public string ? CURP { get; set; }

        [StringLength(25)]
        public string ? UsuarioCreacion { get; set; }

        public DateTime ? FechaHoraCreacion { get; set; }

        [StringLength(25)]
        public string ? UsuarioUltMod { get; set; }   

        public DateTime ? FchHoraUltMod { get; set; }

        [StringLength(250)]
        public string ? EmailDocElectronicoCopia { get; set; }

        public bool DetallarKits { get; set; }

        [StringLength(20)]
        public string ? XsltPersonalizado { get; set; }

        [StringLength(20)]
        public string ? NombreAddenda { get; set; }

        [Column(TypeName = "decimal(28,12)")]
        public decimal ? GeoLatitud { get; set; }

        [Column(TypeName = "decimal(28,12)")]
        public decimal ? GeoLongitud { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica3 { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica4 { get; set; }

        [StringLength(25)]
        public string ? SubTipoDoc { get; set; }

        [StringLength(250)]
        public string ? APIRecepcionDE { get; set; }

        public bool UsaAPIRecepcion { get; set; }

        [StringLength(250)]
        public string ? UserAPIRecepcion { get; set; }

        [StringLength(250)]
        public string ? PassAPIRecepecion { get; set; }

        [StringLength(4)]
        public string ? TipoImpuesto { get; set; }

        [StringLength(2)]
        public string ? TipificacionCliente { get; set; }

        [StringLength(2)]
        public string ? AfectacionIVA { get; set; }

        public bool EsExtranjero { get; set; }

        [StringLength(4)]
        public string ? ItemHacienda { get; set; }

        [StringLength(10)]
        public string ? TipoGenerar { get; set; }

        [StringLength(10)]
        public string ? TipoPersoneria { get; set; }

        [StringLength(3)]
        public string ? UsoCFDI { get; set; }

        [StringLength(10)]
        public string ? MetodoPago { get; set; }

        public bool EsAgentePercepcion { get; set; }
    }
}
