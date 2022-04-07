using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.CP.Tablas
{
    [Table("GlobalesCP", Schema = Constants.Conjunto)]
    public class GlobalesCP:EntityBase
    {
        // AMARILLO
        [Required(ErrorMessage ="La fecha de la última purga de datos es requerida .")]
        public DateTime FechaUltComprime { get; set; }

        public bool LimpiarAplicacion { get; set; }

        public bool DetalleObligat { get; set; }

        [Required(ErrorMessage = "Se debe indicar si se pueden registrar pagos en otra moneda distinta a la del proveedor.")]
        [StringLength(1)]
        public string PagoOtraMoneda { get; set; }

        [Required(ErrorMessage = "Se debe indicar el tipo de documento a utilizar para pronto pago.")]
        [StringLength(3)]
        public string DocProntoPago { get; set; }

        [StringLength(20)]
        public string ? UltimoCh { get; set; }

        [StringLength(20)]
        public string? UltimoNC { get; set; }

        [StringLength(20)]
        public string? UltimoOC { get; set; }

        [StringLength(50)]
        public string? UltimoRet { get; set; }

        public Int16 ? VencPeriodo1 { get; set; }

        public Int16 ? VencPeriodo2 { get; set; }

        public Int16 ? VencPeriodo3 { get; set; }

        public Int16 ? VencPeriodo4 { get; set; }

        public Int16? AntPeriodo1 { get; set; }

        public Int16? AntPeriodo2 { get; set; }

        public Int16? AntPeriodo3 { get; set; }

        public Int16? AntPeriodo4 { get; set; }

        public bool UsarRubros { get; set; }

        [StringLength(15)]
        public string ? Rubro1Nombre { get; set; }

        [StringLength(15)]
        public string ? Rubro2Nombre { get; set; }

        [StringLength(4)]
        public string ?ImpuestoPorOmision { get; set; }

        public bool AsientoND { get; set; }

        public bool AsientoFac { get; set; }

        public bool AsientoInt { get; set; }

        public bool AsientoOD { get; set; }


        // VERDE

        public bool AsientoChq { get; set; }

        public bool AsientoTEF { get; set; }

        public bool AsientoLC { get; set; }

        public bool AsientoNC { get; set; }

        public bool AsientoOC { get; set; }

        [StringLength(4)]
        public string ? PaqueteCre { get; set; }

        [StringLength(4)]
        public string ? TipoAsientoCre { get; set; }

        [StringLength(4)]
        public string ? PaqueteDeb { get; set; }

        [StringLength(4)]
        public string ? TipoAsientoDeb { get; set; }

        public bool AsientosCtaPais { get; set; }

        public bool IntegracionConta { get; set; }

        [Required(ErrorMessage ="Se debe especificar la modalidad de aplicación de asientos contables.")]
        public Int16 ModAplicAsiento { get; set; }

        [StringLength(20)]
        public string ? UltimoQuedan { get; set; }

        public bool NITDuplicado { get; set; }

        public bool RefrescaAuto { get; set; }

        public bool UsarRubrosProv { get; set; }

        [StringLength(15)]
        public string ? Rubro1ProvNombre { get; set; }

        [StringLength(15)]
        public string ? Rubro2ProvNombre { get; set; }

        [StringLength(15)]
        public string ? Rubro3ProvNombre { get; set; }

        [StringLength(15)]
        public string ? Rubro4ProvNombre { get; set; }

        [StringLength(15)]
        public string ? Rubro5ProvNombre { get; set; }

        public bool CopiarNotasEnAsnt { get; set; }

        public bool AsocObligContFact { get; set; }

        public bool UsarRubrosVal { get; set; }

        [StringLength(60)]
        public string ? NomRubro1Pro { get; set; }

        // CELESTE

        [StringLength(60)]
        public string ? NomRubro2Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro3Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro4Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro5Pro { get; set; }

        public Int16 ? RubrosDiasRev { get; set; }

        public bool UsaFechaCont { get; set; }

        public Int16 ? DiasContables { get; set; }

        [StringLength(20)]
        public string ? NumLimiteRet { get; set; }

        [Required(ErrorMessage ="La fecha del último proceso de diferencial cambiario es requerida.")]
        public DateTime FechaUltDifCamb { get; set; }

        [StringLength(20)]
        public string ? UltimoFac { get; set; }

        [StringLength(20)]
        public string ? UltimoInt { get; set; }

        [StringLength(20)]
        public string ? UltimoLC { get; set; }

        [StringLength(20)]
        public string ? UltimoND { get; set; }

        [StringLength(20)]
        public string ? UltimoOD { get; set; }

        [StringLength(60)]
        public string ? NomRubro6Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro7Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro8Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro9Pro { get; set; }

        [StringLength(60)]
        public string ? NomRubro10Pro { get; set; }

        public bool AsignarMismaEntidad { get; set; }

        [StringLength(50)]
        public string ? UltimoRed { get; set; }

        [Required(ErrorMessage ="El código del asiento del interés corriente es requerido.")]
        [StringLength(1)]
        public string AsientoIntCorriente { get; set; }

        public bool AsientoDet { get; set; }

        public bool AsientoPer { get; set; }

        public bool AsientoRet { get; set; }

        public bool AsientoRed { get; set; }












    }
}
