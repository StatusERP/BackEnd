using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("GlobalesCI", Schema = Constants.Conjunto)]
    public class GlobalesCI : EntityBase
    {
        [Required(ErrorMessage = "Debe especificarse la cantidad de decimales en costos.")]
        public Int16 CostosDec { get; set; }

        [Required(ErrorMessage = "Debe especificarse la cantidad de decimales en existencias.")]
        public Int16 ExistenciasDec { get; set; }

        [Required(ErrorMessage = "Debe especificarse la cantidad de decimales en pesos.")]
        public Int16 PesosDec { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse la unidad de peso.")]
        [StringLength(6)]
        public string UnidadPeso { get; set; }

        [Required(ErrorMessage = "Debe especificarse la cantidad de volumen.")]
        [StringLength(6)]
        public string UnidadVolumen { get; set; }
        
        public bool UsaLocalizacion { get; set; }
        
        public bool AjustarConteo { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse el valor de MaxAuditoria.")]
        public int MaxAuditoria { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse la fecha del último proceso de vencimiento.")]
        public DateTime FchUltProcVcto { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse la fecha del último proceso de aprobación.")]
        public DateTime FchUltProcAprob { get; set; }

        [Required(ErrorMessage = "Debe especificarse la fecha de inicio de transacciones.")]
        public DateTime FechaInicioTrans { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse un nombre para la clasificación 1.")]
        [StringLength(10)]
        public string NombreClasif1 { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse un nombre para la clasificación 2.")]
        [StringLength(10)]
        public string NombreClasif2 { get; set; }
        
        [Required(ErrorMessage = "Debe especificarse un nombre para la clasificación 3.")]
        [StringLength(10)]
        public string NombreClasif3 { get; set; }
        
        [StringLength(10)]
        public string ? NombreClasif4 { get; set; }
        
        [StringLength(10)]
        public string ? NombreClasif5 { get; set; }
        
        [StringLength(10)]
        public string ? NombreClasif6 { get; set; }
        
        [StringLength(4)]
        public string ? TipoAsiento { get; set; }
        
        [StringLength(4)]
        public string ? Paquete { get; set; }
        
        public bool AsntAjuVenta { get; set; }
        
        public bool AsntAjuConsumo { get; set; }
        
        public bool AsntAjuCompra { get; set; }
        
        public bool AsntAjuProduc { get; set; }
        
        public bool AsntAjuMiscelan { get; set; }
        
        public bool AsntAjuFisico { get; set; }
        
        public bool AsntAjuVencim { get; set; }
        
        public bool AsntAjuCosto { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el modo de generación para los asientos contables" )]
        public Int16 ModAplicAsiento { get; set; }
        
        public bool IntegracionConta { get; set; }
        
        public bool CtrEnTransaccion { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse las existencias en Totales." )]
        [StringLength(10)]
        public string ExistEnTotales { get; set; }
        
        
        
        
        

        

    }
}
