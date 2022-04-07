using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("GlobalesCB", Schema = Constants.Conjunto)]
    public class GlobalesCB:EntityBase
    {
        public bool PausarEnCheques { get; set; }

        public bool FecAsientoCheq { get; set; }

        public bool ImpCheqPantalla { get; set; }

        [StringLength(4)]
        public string ? TipoAsiento { get; set; }

        [StringLength(4)]
        public string ? Paquete { get; set; }

        public bool AsientoDep {get; set; }

        public bool AsientoNCR { get; set; }

        public bool AsientoOCR { get; set; }

        public bool AsientoCHQ { get; set; }

        public bool AsientoNDB { get; set; }

        public bool AsientoODB { get; set; }

        public bool AsientoTEFDB { get; set; }

        public bool AsientoTEFCR { get; set; }

        [Required(ErrorMessage = "La fecha del último proceso de diferencial cambiario es requerida.")]
        public DateTime FechaUltDifCamb { get; set; }

        [Required(ErrorMessage = "Debe indicarse el manejo que se dará a los documentos pendientes en las conciliaciones.")]
        [StringLength(1)]
        public string ConcilNoEntregado { get; set; }

        public bool DefDocEntregado { get; set; }

        public bool IntegracionConta { get; set; }

        [Required(ErrorMessage = "Debe indicarse la modalidad de aplicación de los asientos contables.")]
        public Int16 ModAplicAsiento { get; set; }

        public bool CopiarNotasEnAsnt { get; set; }

        public bool MostrarChqSug { get; set; }

        public bool ImprimirMontoMon { get; set; }

        [Required(ErrorMessage = "Debe indicarse la cantidad de líneas por asiento a la hora de imprimir.")]
        public int CantLineasAsnt { get; set; }

        public bool ValidarDocAsnt { get; set; }

        public bool VerCtasInactivas { get; set; }

        public bool UsaRubrosCtaBanco { get; set; }

        [StringLength(60)]
        public string ?Rubro1CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro2CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro3CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro4CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro5CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro6CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro7CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro8CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro9CtaBanco { get; set; }

        [StringLength(60)]
        public string? Rubro10CtaBanco { get; set; }

        [StringLength(50)]
        public string? ConseLote { get; set; }
    }
}
