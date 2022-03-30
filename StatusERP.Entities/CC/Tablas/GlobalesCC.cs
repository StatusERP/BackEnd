using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CC.Tablas
{
    [Table("GlobalesCC", Schema = Constants.Conjunto)]
    public class GlobalesCC:EntityBase
    {   
        [StringLength(20)]
        public string ? UltNotaCredito { get; set; }

        [StringLength(20)]
        public string? UltNotaDebito { get; set; }

        [StringLength(20)]
        public string? UltInteresMora { get; set; }

        [StringLength(20)]
        public string? UltReciboDinero { get; set; }

        [StringLength(20)]
        public string? UltFactura { get; set; }

        [StringLength(20)]
        public string? UltOtroCredito { get; set; }

        [StringLength(20)]
        public string? UltOtroDebito { get; set; }

        [StringLength(50)]
        public string? UltRetencion { get; set; }

        [Required(ErrorMessage ="La fecha de la última compresión es obligatoria")]
        public DateTime? FechaUltComprime  { get; set; }

        public bool LimpiarAplicacion { get; set; }

        public bool IntroFacturas { get; set; }

        [StringLength(4)]
        public string ? TipoAsientoDeb { get; set; }

        [StringLength(4)]
        public string? PaqueteDeb { get; set; }

        [StringLength(4)]
        public string? TipoAsientoCre { get; set; }

        [StringLength(4)]
        public string? PaqueteCre { get; set; }

        public Int16? VencPeriodo1 { get; set; }

        public Int16? VencPeriodo2 { get; set; }

        public Int16? VencPeriodo3 { get; set; }

        public Int16? VencPeriodo4 { get; set; }

        public Int16? AntPeriodo1 { get; set; }

        public Int16? AntPeriodo2 { get; set; }

        public Int16? AntPeriodo3 { get; set; }

        public Int16? AntPeriodo4 { get; set; }

        public bool AsientoFac { get; set; }

        public bool AsientoInt { get; set; }

        public bool AsientoND { get; set; }

        public bool AsientoOD { get; set; }

        public bool AsientoLC { get; set; }

        public bool AsientoREC { get; set; }

        public bool AsientoNC { get; set; }

        public bool AsientoOC { get; set; }

        public bool AsientoDEP { get; set; }

        public bool AsientoTEF { get; set; }

        public bool AsientosCtaPais { get; set; }

        public bool IntegracionConta { get; set; }

        [Required(ErrorMessage ="Debe indicarse la modalidad de aplicación de asientos contables.")]
        public Int16 ModAplicAsiento { get; set; }

        public bool NitDuplicado { get; set; }

        public bool RefrescaAuto { get; set; }

        [Required(ErrorMessage = "Debe indicarse el tipo de documento a utilizar para pronto pago.")]
        [StringLength(3)]
        public string  DocProntoPago { get; set; }

        public bool DetalleObligat { get; set; }

        public bool UsarRubros { get; set; }

        [StringLength(15)]
        public string ? Rubro1Nombre { get; set; }

        [StringLength(15)]
        public string? Rubro2Nombre { get; set; }

        [StringLength(4)]
        public string? ImpPorOmision { get; set; }

        public bool UsarRubrosCli { get; set; }

        [StringLength(15)]
        public string? Rubro1CliNombre { get; set; }

        [StringLength(15)]
        public string? Rubro2CliNombre { get; set; }

        [StringLength(15)]
        public string? Rubro3CliNombre { get; set; }
        
        [StringLength(15)]
        public string? Rubro4CliNombre { get; set; }

        [StringLength(15)]
        public string? Rubro5CliNombre { get; set; }

        public bool CopiarNotasEnAsnt { get; set; }

        public bool AsocObligContFact { get; set; }

        public Int16? VencPeriodo5 { get; set; }

        public Int16? VencPeriodo6 { get; set; }

        public Int16? AntPeriodo5 { get; set; }

        public Int16? AntPeriodo6 { get; set; }

        public bool AsociacionDeDocs { get; set; }

        [StringLength(60)]
        public string? NomRubro1Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro2Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro3Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro4Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro5Cli { get; set; }

        public bool UsarRubrosVal { get; set; }

        public Int16? RubrosDiasRev { get; set; }

        public bool AsientoIntC { get; set; }

        [StringLength(20)]
        public string ? UltInteresCte { get; set; }

        [Required(ErrorMessage ="Se requiere indicar la fecha en que se ejecutó el último proceso de diferencial cambiario.")]
        public DateTime FechaUltDifCamb { get; set; }

        [StringLength(20)]
        public string ? UltLetraCambio { get; set; }

        [StringLength(20)]
        public string ? UltDeposito { get; set; }

        [StringLength(20)]
        public string ? UltTEF { get; set; }

        [StringLength(50)]
        public string ? UltRetDebito { get; set; }

        [StringLength(60)]
        public string? NomRubro11Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro12Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro13Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro14Cli { get; set; }

        [StringLength(60)]
        public string? NomRubro15Cli { get; set; }

        public bool ? AsientoDet { get; set; }

        public bool? AsientoPer { get; set; }

        public bool? AsientoRet { get; set; }

        public bool? AsientoRed { get; set; }

        public Int16 ? SubTipoProntoPago { get; set; }

        [StringLength(10)]
        public string? ConsecutivoGL { get; set; }

        [StringLength(10)]
        public string? ConsecutivoDE { get; set; }
    }
}
