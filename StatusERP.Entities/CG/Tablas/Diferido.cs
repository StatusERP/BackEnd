using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("Diferido", Schema = Constants.Conjunto)]
    public class Diferido:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Diferido.")]
        [StringLength(55)]
        public string CodDiferido { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción.")]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es requerida.")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "El monto original es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoOriginal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar moneda.")]
        [StringLength(4)]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "El monto amortizado es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Amortizado { get; set; }

        [Required(ErrorMessage = "El monto pendiente de amortizar es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PendienteAmortizar { get; set; }

        public bool Estado { get; set; }

        [StringLength(10)]
        public string ? Asiento{ get; set; }

        [Required(ErrorMessage = "La modalidad de prorrateo es requerida.")]
        [StringLength(1)]
        public string Modalidad { get; set; }

        [Required(ErrorMessage = "El Valor que se asigna para la distribución según la modalidad es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ValorModalidad { get; set; }

        [Required(ErrorMessage = "El tipo de diferido es requerido (ingreso o gasto).")]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El código del paquete contable de la transacción es requerido.")]
        [StringLength(4)]
        public string Paquete { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un tipo de asiento.")]
        [StringLength(25)]
        public string TipoAsiento{ get; set; }

        [Required(ErrorMessage = "Se requiere especificar un centro de costo para el Diferido.")]
        [StringLength(25)]
        public string CtrDiferido { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable para el Diferido.")]

        [StringLength(25)]
        public string CtaDiferido { get; set; }
        
        [Required(ErrorMessage = "Se requiere especificar un centro de costo para el contra asiento del diferido.")]
        [StringLength(25)]
        public string CtrContraAsiento{ get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable para el contra asiento del diferido.")]
        [StringLength(25)]
        public string CtaContraAsiento { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un centro de costo para la amortización del diferido.")]
        [StringLength(25)]
        public string CtrAmortizacion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable para la amortización del diferido.")]
        [StringLength(25)]
        public string CtaAmortizacion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un centro de costo para el contra asiento de gasto/ingreso del diferido.")]
        [StringLength(25)]
        public string CtrGastoIngreso { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una cuenta contable para el contra asiento de gasto/ingreso del diferido.")]
        [StringLength(25)]
        public string CtaGastoIngreso { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es requerida.")]
        public DateTime FechaAudIng { get; set; }

        [Required(ErrorMessage = "El cógio de usuario que ingresó es requerido.")]
        [StringLength(25)]
        public string UsuarioAudIng { get; set; }

        [Required(ErrorMessage = "La fecha de última modificación es requerida.")]
        public DateTime FechaUltMod { get; set; }

        [Required(ErrorMessage = "El usuario de última modificación es requerido.")]
        [StringLength(25)]
        public string UsuarioUltMod { get; set; }

        public string ? Notas { get; set; }

        public DateTime ? FechaHoraAnulacion { get; set; }

        [StringLength(25)]
        public string ? UsuarioAnulacion { get; set; }

        [StringLength(55)]
        public string ? DiferidoOrigen { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal ? CostoLocF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? CostoDolF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? CostoLocC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? CostoDolC { get; set; }

        [StringLength(1)]
        public string ? ModalidadC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? ValorModalidadC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizacionLocF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizacionDolF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizacionLocC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizacionDolC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizadoLocF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizadoDolF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizadoLocC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? AmortizadoDolC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PendienteAmortLocF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PendienteAmortDolF { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PendienteAmortLocC { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? PendienteAmortDolC { get; set; }

        [StringLength(10)]
        public string ? AsientoCorp { get; set; }
        
        public bool Marcado { get; set; }

        [StringLength(25)]
        public string ? UsuarioMarcado { get; set; }

        [StringLength(4)]
        public string ? ConceptoME { get; set; }

        [StringLength(1)]
        public string ? DesgloseIMP { get; set; }
    }
}
