using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CP.Tablas
{
    [Table("HistoricoDifCambiarioCP", Schema = Constants.Conjunto)]
    public class HistoricoDifCambiarioCP:EntityBase
    {
        [Required(ErrorMessage = "El usuario auditoría es requerido.")]
        [StringLength(450)]
        public string UsuarioAuditoria { get; set; }

        [Required(ErrorMessage = "La fecha de auditoría es requerida.")]
        public DateTime FechaAuditoria { get; set; }

        [Required(ErrorMessage = "La fecha en que se realiza el proceso es requerida.")]
        public DateTime FechaProc { get; set; }

        [Required(ErrorMessage = "El documento es requerido.")]
        [StringLength(50)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El proveedor es requerido.")]
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required(ErrorMessage = "El tipo de cambio del proceso es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TipoCambioProc { get; set; }

        [StringLength(10)]
        public string ? AsientoProc { get; set; }

        [Required(ErrorMessage = "La diferencia cambiaria en moneda local es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DifCamLocal { get; set; }

        [Required(ErrorMessage = "La diferencia cambiaria en dólares es requerida.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DifCamDolar { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en moneda local con que se ejecutó el proceso anterior es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TCambLocDocAnt { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en dólares con que se ejecutó el proceso anterior es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TCambDolDocAnt { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en moneda local con que se ejecutó el proceso actual es requerido")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TCambLocDocAct { get; set; }

        [Required(ErrorMessage = "El tipo de cambio en dólares con que se ejecutó el proceso actual es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal TCambDolDocAct { get; set; }

        [StringLength(25)]
        public string ? CuentaContable { get; set; }

        [StringLength(25)]
        public string ? CentroCosto { get; set; }

        [Required(ErrorMessage = "El estado del proceso es requerido.")]
        [StringLength(1)]
        public string Estado { get; set; }

        public string ? NotasRev { get; set; }
    }
}
