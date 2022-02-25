using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
    public class GlobalesCG : EntityBase
    {
        [StringLength(25)]
        public string? CtaPerdDifCamDol { get; set; }

        [StringLength(25)]
        public string? CtaPerdDifCamLoc { get; set; }

        [StringLength(4)]
        public string? TipAsntCierreAn { get; set; }

        [Required]
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

        [Required]
        public DateTime FechaDifCamFiscal { get; set; }

        [Required]
        public DateTime FechaDifCamCorp { get; set; }

        [Required]
        public DateTime FechaCierreFiscal { get; set; }

        [Required]
        public DateTime FechaCierreCorp { get; set; }

        [Required]
        public Int16 MesCierreFiscal { get; set; }

        [Required]
        public Int16 MesCierreCorp { get; set; }

        [Required]
        [StringLength(10)]
        public string  UltimoAsiento { get; set; }

        [Required]
        public bool NumAsientoGlobal { get; set; }

        [Required]
        [StringLength(10)]
        public string NombreAsiento { get; set; }

        [Required]
        public Int16 CantDecimales { get; set; }

        [Required]
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
