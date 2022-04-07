using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("ConciliacionesBancarias", Schema = Constants.Conjunto)]
    public class ConciliacionBancaria:EntityBase
    {
        [Required(ErrorMessage ="La cuenta bancaria es requerida.")]
        public int CuentaBancariaId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El número de conciliación es requerido.")]
        public int Conciliacion { get; set; }

        [Required(ErrorMessage = "La fecha inicial es requerida.")]
        public DateTime FechaInicial { get; set; }

        [Required(ErrorMessage = "La fecha final es requerida.")]
        public DateTime FechaFinal { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SaldoLibros { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? SaldoBancos { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosTransito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosTransito { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosConcil { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosConcil { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosSinDinf { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosSinDif { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosConAjust { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosConAjust { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosAjustes { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosAjustes { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosLiquidar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosLiquidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosAclarar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosAclarar { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosAclaraEF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosAclaraEF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CreditosAclaraCB{ get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? DebitosAclaraCB { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public string ? Notas { get; set; }

        [Required(ErrorMessage = "La fecha y hora de creación son requeridas.")]
        public DateTime FechaHoraCreacion { get; set; }

        [Required(ErrorMessage = "El usuario de creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        public DateTime ? FechaHoraModific { get; set; }

        [StringLength(450)]
        public string ? UsuarioModific { get; set; }

        public DateTime ? FechaHoraAprobacion { get; set; }

        [StringLength(450)]
        public string ? UsuarioAprobacion { get; set; }
    }
}
