using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("Diferido", Schema = Constants.Conjunto)]
    public class Diferido:EntityBase
    {
        [Required]
        [StringLength(55)]
        public string CodDiferido { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaIngreso { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoOriginal { get; set; }

        [Required]
        [StringLength(4)]
        public string Moneda { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Amortizado { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PendienteAmortizar { get; set; }

         public bool Estado { get; set; }

        [StringLength(10)]
        public string ? Asiento{ get; set; }

        [Required]
        [StringLength(1)]
        public decimal Modalidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ValorModalidad { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(4)]
        public string Paquete { get; set; }

        [Required]
        [StringLength(25)]
        public string TipoAsiento{ get; set; }

        [Required]
        [StringLength(25)]
        public string CtrDiferido { get; set; }

        [Required]
        [StringLength(25)]
        public string CtaDiferido { get; set; }

        [Required]
        [StringLength(25)]
        public string CtrContraAsiento{ get; set; }

        [Required]
        [StringLength(25)]
        public string CtaContraAsiento { get; set; }

        [Required]
        [StringLength(25)]
        public string CtrAmortizacion { get; set; }

        [Required]
        [StringLength(25)]
        public string CtaAmortizacion { get; set; }

        [Required]
        [StringLength(25)]
        public string CtrGastoIngreso { get; set; }

        [Required]
        [StringLength(25)]
        public string CtaGastoIngreso { get; set; }

        [Required]
        public DateTime FechaAudIng { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioAudIng { get; set; }

        [Required]
        public DateTime FechaUltMod { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioUltMod { get; set; }

        [Required]
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

        [Required]
        [StringLength(1)]
        public string Marcado { get; set; }

        [StringLength(25)]
        public string ? UsuarioMarcado { get; set; }

        [StringLength(4)]
        public string ? ConceptoME { get; set; }

        [StringLength(1)]
        public string ? DesgloseIMP { get; set; }
    }
}
