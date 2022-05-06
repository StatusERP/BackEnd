using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Entities.CI.Tablas
{
    [Table("GlobalesCI", Schema = Constants.Conjunto)]
    public class GlobalesCI : EntityBase
    {
  
        public Int16 CostosDec { get; set; }

  
        public Int16 ExistenciasDec { get; set; }


        public Int16 PesosDec { get; set; }
        
  
        [StringLength(6)]
        public string UnidadPeso { get; set; }

  
        [StringLength(6)]
        public string UnidadVolumen { get; set; }
        
        public bool UsaLocalizacion { get; set; }
        
        public bool AjustarConteo { get; set; }
       
        public int MaxAuditoria { get; set; }
        
   
        public DateTime FchUltProcVcto { get; set; }
        
  
        public DateTime FchUltProcAprob { get; set; }

     
        public DateTime FechaInicioTrans { get; set; }
        
    
        [StringLength(10)]
        public string NombreClasif1 { get; set; }
        

        [StringLength(10)]
        public string NombreClasif2 { get; set; }
        

        [StringLength(10)]
        public string NombreClasif3 { get; set; }
        
        [StringLength(10)]
        public string ? NombreClasif4 { get; set; }
        
        [StringLength(10)]
        public string ? NombreClasif5 { get; set; }
        
        [StringLength(10)]
        public string ? NombreClasif6 { get; set; }
        
        public int ? TipoPartidaId { get; set; }
        public TipoPartida TipoPartida { get; set; }
        
        public int ? PaqueteContableId { get; set; }
        public PaqueteContable PaqueteContable { get; set; }
        
        public bool AsntAjuVenta { get; set; }
        
        public bool AsntAjuConsumo { get; set; }
        
        public bool AsntAjuCompra { get; set; }
        
        public bool AsntAjuProduc { get; set; }
        
        public bool AsntAjuMiscelan { get; set; }
        
        public bool AsntAjuFisico { get; set; }
        
        public bool AsntAjuVencim { get; set; }
        
        public bool AsntAjuCosto { get; set; }
        
       
        public Int16 ModAplicAsiento { get; set; }
        
        public bool IntegracionConta { get; set; }
        
        public bool CtrEnTransaccion { get; set; }
   
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
