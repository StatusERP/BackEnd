using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("GlobalesCG", Schema = Constants.Conjunto)]
    public class GlobalesCG : EntityBase
    {
        [StringLength(25)]
        public string? CtaPerdDifCamDol { get; set; }

        [StringLength(25)]
        public string? CtaPerdDifCamLoc { get; set; }

        [StringLength(4)]
        public string? TipAsntCierreAn { get; set; }

        [Required(ErrorMessage = "Se requiere el patrón para los códigos de las cuentas contables.")]
        [StringLength(25)]
        public string Patron { get; set; }

        [StringLength(25)]
        public string ? CtrDifCambioLocal { get; set; }

        [StringLength(25)]
        public string ? CtaDifCambioLocal { get; set; }

        [StringLength(25)]
        public string ? CtrDifCambioDolar{ get; set; }

        [StringLength(25)]
        public string ? CtaDifCambioDolar { get; set; }

        [Required(ErrorMessage = "Fecha de última actualización del diferencial cambiario fiscal no puede ser nula.")]
        public DateTime FechaDifCamFiscal { get; set; }

        [Required(ErrorMessage = "Fecha de última actualización del diferencial cambiario corporativo no puede ser nula.")]
        public DateTime FechaDifCamCorp { get; set; }

        [Required(ErrorMessage = "Fecha de último cierre fiscal no puede ser nula.")]
        public DateTime FechaCierreFiscal { get; set; }

        [Required(ErrorMessage = "Fecha de último cierre corporativo no puede ser nula.")]
        public DateTime FechaCierreCorp { get; set; }

        [Required(ErrorMessage = "Mes de cierre fiscal no puede ser nulo.")]
        public Int16 MesCierreFiscal { get; set; }

        [Required(ErrorMessage = "Mes de cierre corporativo no puede ser nulo.")]
        public Int16 MesCierreCorp { get; set; }

        [Required(ErrorMessage = "No. de último asiento no puede ser nulo.")]
        [StringLength(10)]
        public string  UltimoAsiento { get; set; }

        [Required]
        public bool NumAsientoGlobal { get; set; }

        [Required(ErrorMessage = "Se debe indicar un nombre para el asiento contable.")]
        [StringLength(10)]
        public string NombreAsiento { get; set; }

        [Required(ErrorMessage = "Cantidad de decimales a utilizar no puede ser nula.")]
        public Int16 CantDecimales { get; set; }

        public bool TruncarConversion { get; set; }

        [StringLength(25)]
        public string ? CtrCierre { get; set; }

        [StringLength(25)]
        public string? CtaCierre { get; set; }

        public bool AjusAnFiscPend { get; set; }

        public bool AjusAnCorpPend { get; set; }


        public bool PermiteMovRojo { get; set; }

        public bool AuxReverMovRojo { get; set; }

        [StringLength(25)]
        public string ? CtrPerdDifCamLoc { get; set; }

        [StringLength(25)]
        public string ? CtrPerdDifCamDol { get; set; }

        [StringLength(15)]
        public string ? NombreContaFiscal { get; set; }

        [StringLength(15)]
        public string ? NombreContaCorp { get; set; }

        [StringLength(25)]
        public string? CtrDifCamLocUtiReali { get; set; }

        [StringLength(25)]
        public string? CtaDifCamLocUtiReali { get; set; }

        [StringLength(25)]
        public string? CtrDifCamDolUtiReali { get; set; }

        [StringLength(25)]
        public string? CtaDifCamDolUtiReali { get; set; }

        [StringLength(25)]
        public string? CtrDifCamLocPerReali { get; set; }

        [StringLength(25)]
        public string? CtaDifCamLocPerReali { get; set; }

        [StringLength(25)]
        public string? CtrDifCamDolPerReali { get; set; }

        [StringLength(25)]
        public string? CtaDifCamDolPerReali { get; set; }

        public bool DobleControl { get; set; }

        [StringLength(70)]
        public string? NombreContador { get; set; }

        [StringLength(70)]
        public string? NombreRevisor { get; set; }

        [StringLength(70)]
        public string? NombreRepresentante { get; set; }

        public Byte? FirmaContador { get; set; }

        public Byte? FirmaRevisor { get; set; }

        public Byte? FirmaRepresentante { get; set; }
    }
}
