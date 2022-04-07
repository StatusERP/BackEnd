using System.ComponentModel.DataAnnotations;
using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CP.Tablas
{
    [Table("Proveedores", Schema = Constants.Conjunto)]
    public class Proveedor:EntityBase
    {
        [Required(ErrorMessage = "El código del proveedor es requerido.")]
        [StringLength(20)]
        public string CodProveedor { get; set; }

        public int ? DetalleDireccion { get; set; }

        [Required(ErrorMessage = "El nombre del proveedor es requerido.")]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(150)]
        public string ? Alias { get; set; }

        [Required(ErrorMessage = "El contacto es requerido.")]
        [StringLength(30)]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "El cargo del contacto es requerido.")]
        [StringLength(30)]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "La dirección es requerida.")]
        public string Direccion { get; set; }

        [StringLength(250)]
        public string ? EMail { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es requerida.")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "La fecha del último movimiento es requerida.")]
        public DateTime FechaUltMov { get; set; }

        [StringLength(50)]
        public string ? Telefono1 { get; set; }

        [StringLength(50)]
        public string ? Telefono2 { get; set; }

        [StringLength(50)]
        public string ? Fax { get; set; }

        [Required(ErrorMessage = "El monto mínimo por orden es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal OrdenMinima { get; set; }

        [Required(ErrorMessage = "El descuento asignado es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Descuento { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaInteresMora { get; set; }

        public bool Local { get; set; }

        public bool Congelado { get; set; }

        [Required(ErrorMessage = "El número de documento tributario es requerido.")]
        public int DocTributarioId { get; set; }
        public DocTributario DocTributario {get; set;}

        [Required(ErrorMessage = "La condición de pago es requerida.")]
        [StringLength(4)]
        public string CondicionPago { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El país es requerido.")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        [Required(ErrorMessage = "La categoría de proveedor es requerida.")]
        public int CategoriaProveedorId { get; set; }
        public CategoriaProveedor CategoriaProveedor { get; set; }

        public bool Multimoneda { get; set; }

        [Required(ErrorMessage = "El saldo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Saldo { get; set; }


    //  VERDE 
        [Required(ErrorMessage = "El saldo en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoLocal { get; set; }

        [Required(ErrorMessage = "El saldo en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoDolar { get; set; }

        public string ? Notas { get; set; }

        [StringLength(50)]
        public string ? Rubro1Prov { get; set; }

        [StringLength(50)]
        public string? Rubro2Prov { get; set; }

        [StringLength(50)]
        public string? Rubro3Prov { get; set; }

        [StringLength(50)]
        public string? Rubro4Prov { get; set; }

        [StringLength(50)]
        public string? Rubro5Prov { get; set; }

        [StringLength(40)]
        public string? Rubro1Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro2Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro3Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro4Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro5Proveedor { get; set; }

        [StringLength(13)]
        public string ? GLN { get; set; }

        [StringLength(250)]
        public string? Ubicacion { get; set; }

        public bool Activo { get; set; }

        [StringLength(1)]
        public string? TipoContribuyente { get; set; }

        [StringLength(40)]
        public string? Rubro6Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro7Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro8Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro9Proveedor { get; set; }

        [StringLength(40)]
        public string? Rubro10Proveedor { get; set; }

        [StringLength(4)]
        public string? ModeloRetencion { get; set; }

        [StringLength(4)]
        public string? CodigoImpuesto { get; set; }

        public int ? DivGeografica1Id { get; set; }
        public DivGeografica1 DivGeografica1 { get; set; }



        /// CELESTE

        public int ? DivGeografica2Id { get; set; }
        public DivGeografica2 DivGeografica2 { get; set; }

        public bool Autoretenedor { get; set; }

        [StringLength(12)]
        public string? RegimenTrib { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTrans { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransLocal { get; set; }

        [Required(ErrorMessage = "El saldo de la transacción en dólares es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoTransDolar { get; set; }

        public bool PermiteDocGP { get; set; }

        public bool ParticipaFlujoCaja { get; set; }

        [StringLength(18)]
        public string? CURP { get; set; }

        [StringLength(450)]
        public string? UsuarioCreacion { get; set; }

        public DateTime ? FechaHoraCreacion { get; set; }

        [StringLength(450)]
        public string? UsuarioUltMod { get; set; }

        public DateTime ? FechaHoraUltMod { get; set; }

        public bool Impuesto1Incluido { get; set; }

        [StringLength(50)]
        public string? XSLTPersonalizado { get; set; }

        public bool Internaciones { get; set; }

        [StringLength(4)]
        public string? TipoImpuesto { get; set; }

        [StringLength(2)]
        public string? TipoTarifa { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcTarifa { get; set; }

        [StringLength(2)]
        public string? TipificacionProveedor { get; set; }

        [StringLength(4)]
        public string? ItemHaciendaCompra { get; set; }

        [StringLength(3)]
        public string? TipoCF { get; set; }

        public bool UsaPlame { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? ImpCategoria { get; set; }

        [Required(ErrorMessage = "Debe indicarse el Sistema de Pensiones.")]
        [StringLength(1)]
        public string SistemaPensiones { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? ImpNacional { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? ImpPrivado { get; set; }

        public bool Domiciliado { get; set; }

        public bool Convenio { get; set; }

        [StringLength(100)]
        public string ? NumIdentNoDomic { get; set; }

        [StringLength(100)]
        public string ? NumIdentFiscBenef { get; set; }


        [StringLength(4)]
        public string ? TipoVinculacion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? TasaRetencion { get; set; }


        [StringLength(4)]
        public string ? ExoneracionOper { get; set; }

        public bool BuenContribuyente { get; set; }

        public bool AgenteRetencion { get; set;     }
    }
}
