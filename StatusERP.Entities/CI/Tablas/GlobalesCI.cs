using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.CG.Tablas;


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

        [Required(ErrorMessage = "Debe especificarse la unidad de volumen.")]
        [StringLength(6)]
        public string UnidadVolumen { get; set; }
        
        public bool UsaLocalizacion { get; set; }
        
        public bool AjustarConteo { get; set; }
        
        [Required(ErrorMessage = "Maximo número de auditoría agregado en las transacciones de inventario.")]
        public int MaxAuditoria { get; set; }
        
        [Required(ErrorMessage = "Fecha en que se ejecutó por última vez el proceso de vencimiento.")]
        public DateTime FchUltProcVcto { get; set; }
        
        [Required(ErrorMessage = "Fecha en que se ejecutó por última vez el proceso de aprobación.")]
        public DateTime FchUltProcAprob { get; set; }

        [Required(ErrorMessage = "Fecha de inicio de las transacciones de CI.")]
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
        
        public int ? TipoPartidaId { get; set; }
        public TipoPartida tipoPartida { get; set; }
        
        public int ? PaqueteContableId { get; set; }
        public PaqueteContable paqueteContable { get; set; }
        
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
        
        [Required(ErrorMessage = "Debe indicarse lOS totales en las consultas de existencias." )]
        [StringLength(10)]
        public string ExistEnTotales { get; set; }
        
        public bool TransacXUsuario { get; set; }
        
        public bool UsaConsecutivos { get; set; }
        
        [StringLength(1)]
        public string ? ModalidadUso { get; set; }
        
        public bool UsarNumerosSerie { get; set; }
        
        public bool CntrlSeriesEntr { get; set; }
        
        public bool UsaCodigoBarras { get; set; }
        
        public bool UsaUnidadesDist { get; set; }
        
        public bool AsistenciaAutomat { get; set; }
        
        public bool UsaCodigoEAN13 { get; set; }
        
        public bool UsaCodigoEAN8 { get; set; }

        public bool UsaCodigoUCC12 { get; set; }

        public bool UsaCodigoUCC8 { get; set; }

        [StringLength(18)]
        public string ? EAN13ReglaLocal { get; set; }

        [StringLength(3)]
        public string ? EAN8ReglaLocal { get; set; }

        [StringLength(6)]
        public string ? UCC12ReglaLocal { get; set; }

        [StringLength(1)]
        public string ? PrioridadBusqueda { get; set; }

        public bool UsaCodigoGeneric { get; set; }

        public int ? LineasMaxTrans { get; set; }

        public bool UsarAprobacion { get; set; }
     }
}
