using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("CuentasBancarias", Schema = Constants.Conjunto)]
    public class CuentaBancaria:EntityBase
    {
        [Required(ErrorMessage="La cuenta de banco es requerida." )]
        [StringLength(20)]
        public string NumCuentaBancaria { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La entidad financiera es requerida.")]
        public int EntidadFinancieraId { get; set; }
        public EntidadFinanciera EntidadFinanciera { get; set; }

        [Required(ErrorMessage = "La moneda es requerida.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "La dirección es requerida.")]
        [StringLength(90)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono 1 es requerido.")]
        [StringLength(15)]
        public string Telefono1 { get; set; }

        [Required(ErrorMessage = "El teléfono 2 es requerido.")]
        [StringLength(15)]
        public string Telefono2 { get; set; }

        [Required(ErrorMessage = "El contacto es requerido.")]
        [StringLength(40)]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "El cargo del contacto es requerido.")]
        [StringLength(40)]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "El formato es requerido.")]
        [StringLength(128)]
        public string Formato { get; set; }

        [Required(ErrorMessage = "La fecha del último movimiento es requerida.")]
        public DateTime FechaUltMov { get; set; }

        [Required(ErrorMessage = "El saldo es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "El saldo según banco es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoBancos { get; set; }

        [Required(ErrorMessage = "La posición de caja es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PosicionDeCaja { get; set; }

        [Required(ErrorMessage = "El saldo anterior es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal SaldoAnterior { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en moneda local es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioLocal { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en dóalres es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioDolar { get; set; }

        public bool Activa { get; set; }

        [Required(ErrorMessage = "El último depósito es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal UltimoDeposito { get; set; }

        [Required(ErrorMessage = "La última TEF de crédito es requerida.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal UltimaTEFCR { get; set; }

        [Required(ErrorMessage = "El límite de sobregiro es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal LimiteSobregiro { get; set; }

        [StringLength(25)]
        public string ? CtrContable { get; set; }

        [StringLength(25)]
        public string ? CtaContable { get; set; }

        [StringLength(25)]
        public string ? CtrCierreDeb { get; set; }

        [StringLength(25)]
        public string ? CtaCierreDeb { get; set; }

        [StringLength(25)]
        public string ? CtrCierreCred { get; set; }

        [StringLength(25)]
        public string ? CtaCierreCred { get; set; }

        [Required(ErrorMessage = "La últma nota de crédito es requerida.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal UltimaNotaCR { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? UltimoCheque { get; set; }

        [Required(ErrorMessage = "El número del último documento de otro crédito es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal UltimoOtroCR { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? UltimaTEFDB { get; set; }

        [Required(ErrorMessage = "El número de documento de la última nota de débito es requerida.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal UltimaNotaDB { get; set; }

        [Required(ErrorMessage = "El número del último documento de otro débito es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal UltimoOtroDB { get; set; }

        public int ? UltimaConcil { get; set; }

        [Required(ErrorMessage = "Se debe indicar el modo de conciliar.")]
        [StringLength(1)]
        public string ModoConciliar { get; set; }

        [Required(ErrorMessage = "Se debe indicar el idioma para los montos en lentras.")]
        [StringLength(1)]
        public string IdiomaMonLetras { get; set; }

        [StringLength(3)]
        public string ? TipoCredAjuste { get; set; }

        public Int16 ? SubTipoCredAjust { get; set; }

        [StringLength(3)]
        public string ? TipoDebAjuste { get; set; }

        public Int16 ? SubTipoDebAjust { get; set; }

        public bool PermiteSobregiro { get; set; }

        [StringLength(25)]
        public string ? CtaAjusteCred { get; set; }

        [Required(ErrorMessage = "Se debe indicar la fecha y hora de creación.")]
        public DateTime FechaHoraCreacion { get; set; }

        [Required(ErrorMessage = "Se debe indicar el usuario creación.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        [StringLength(25)]
        public string ? CtrAjusteDeb { get; set; }

        [StringLength(25)]
        public string ? CtrGastoTransf { get; set; }

        [StringLength(25)]
        public string ? CtaAjusteDeb { get; set; }

        [StringLength(25)]
        public string ? CtaGastoTransf { get; set; }

        [StringLength(25)]
        public string ? CtrLiquidarCred { get; set; }

        [StringLength(25)]
        public string ? CtaLiquidarCred { get; set; }

        [StringLength(25)]
        public string ? CtrLiquidarDeb { get; set; }

        [StringLength(25)]
        public string ? CtaLiquidarDeb { get; set; }

        [StringLength(25)]
        public string ? CtrAjusteCred { get; set; }

        public DateTime ? FchHoraModific { get; set; }

        [StringLength(450)]
        public string ? UsuarioModific {get; set; }

        public bool PermiteTransfIC { get; set; }

        [StringLength(25)]
        public string ? CtaTransfIC { get; set; }

        [StringLength(25)]
        public string ? CtrTransfIC { get; set; }

        [StringLength(40)]
        public string ? Rubro1CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro2CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro3CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro4CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro5CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro6CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro7CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro8CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro9CtaBanco { get; set; }

        [StringLength(40)]
        public string ? Rubro10CtaBanco { get; set; }

        [StringLength(10)]
        public string? ConseCheque { get; set; }

        [StringLength(10)]
        public string? ConseTEF { get; set; }

        [StringLength(12)]
        public string? TipoCuenta { get; set; }

        [StringLength(25)]
        public string? CtrDocGP { get; set; }

        [StringLength(25)]
        public string? CtaDocGP { get; set; }

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

        [StringLength(50)]
        public string ? CtaElectronica { get; set; }
    }
}
