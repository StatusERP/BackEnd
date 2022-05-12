using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CP.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("Articulos", Schema = Constants.Conjunto)]
    public class Articulo : EntityBase
    {
        [Required(ErrorMessage = "El código del artículo es requerido.")]
        [StringLength(20)]
        public string CodArticulo { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public int ? Clasificacion1Id { get; set; }
        public ClasificacionInv Clasificacion1 { get; set; }

        public int? Clasificacion2Id { get; set; }
        public ClasificacionInv Clasificacion2 { get; set; }

        public int? Clasificacion3Id { get; set; }
        public ClasificacionInv Clasificacion3 { get; set; }

        public int? Clasificacion4Id { get; set; }
        public ClasificacionInv Clasificacion4 { get; set; }

        public int? Clasificacion5Id { get; set; }
        public ClasificacionInv Clasificacion5 { get; set; }

        public int? Clasificacion6Id { get; set; }
        public ClasificacionInv Clasificacion6 { get; set; }

        [Column(TypeName = "decimal(28,8)")] 
        public decimal ?FactorConver1 { get; set; }

        [Column(TypeName = "decimal(28,8)")] 
        public decimal? FactorConver2 { get; set; }

        [Column(TypeName = "decimal(28,8)")] 
        public decimal? FactorConver3 { get; set; }

        [Column(TypeName = "decimal(28,8)")] 
        public decimal? FactorConver4 { get; set; }

        [Column(TypeName = "decimal(28,8)")] 
        public decimal? FactorConver5 { get; set; }

        [Column(TypeName = "decimal(28,8)")] 
        public decimal? FactorConver6 { get; set; }

        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(1)]
        public string Tipo { get; set; }

        public bool TiendaEnLinea { get; set; }

        public bool VentaTarjetaCredito { get; set; }

        [Required(ErrorMessage = "Debe ingresar el peso neto.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PesoNeto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el peso bruto.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PesoBruto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el volumen.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Volumen { get; set; }

        [Required(ErrorMessage = "Debe ingresar los bultos.")]
        public Int16 Bultos { get; set; }

        [Required(ErrorMessage = "Debe ingresar la categoría del artículo.")]
        [StringLength(4)]
        public int CategoriaArticuloId { get; set; }
        public CategoriaArticulo CategoriaArticulo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el impuesto.")]
        public int ImpuestoId { get; set; }
        public Impuesto Impuesto { get; set; }

        [Required(ErrorMessage = "Debe ingresar el factor de empaque.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal FactorEmpaque { get; set; }

        [Required(ErrorMessage = "Debe ingresar el factor de venta.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal FactorVenta { get; set; }

        [Required(ErrorMessage = "Debe ingresar la existencia mínima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMínima { get; set; }

        [Required(ErrorMessage = "Debe ingresar la existencia máxima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal ExistenciaMáxima { get; set; }

        [Required(ErrorMessage = "Debe ingresar el punto de reorden.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PuntoDeOrden { get; set; }

        [Required(ErrorMessage = "Costo en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoLoc { get; set; }

        [Required(ErrorMessage = "Costo en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoDol { get; set; }

        [Required(ErrorMessage = "Precio base en moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioBaseLocal { get; set; }

        [Required(ErrorMessage = "Precio base en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PrecioBaseDol { get; set; }

        [Required(ErrorMessage = "La fecha de la última salida es requerida.")]
        public DateTime UltimaSalida { get; set; }
        
        [Required(ErrorMessage = "La fecha del último movimiento es requerida.")]
        public DateTime UltimoMovimiento { get; set; }
        
        [Required(ErrorMessage = "La fecha del último ingreso es requerida.")]
        public DateTime UltimoIngreso { get; set; }
        
        [Required(ErrorMessage = "La fecha del último inventario es requerida.")]
        public DateTime UltimoInventario { get; set; }
        
        [Required(ErrorMessage = "La clase ABC es requerida.")]
        [StringLength(1)]
        public string ClaseABC { get; set; }
        
        [Required(ErrorMessage = "La frecuencia de conteo es requerida.")]
        public Int16 FrecuenciaConteo { get; set; }
        
        [StringLength(20)]
        public string ? CodigoBarrasVent { get; set; }
        
        [StringLength(20)]
        public string? CodigoBarrasInvt { get; set; }
        
        public bool? Activo { get; set; }
        
        public bool UsaLotes { get; set; }
        
        public bool ObligaCuarentena { get; set; }
        
        [Required(ErrorMessage = "Se debe ingresar el Mínimo de Vida Compra.")]
        public Int16 MinVidaCompra { get; set; }
        
        [Required(ErrorMessage = "Se debe ingresar el Mínimo de Vida Consumo.")]
        public Int16 MinVidaConsumo { get; set; }
        
        [Required(ErrorMessage = "Se debe ingresar el Mínimo de Vida Venta.")]
        public Int16 MinVidaVenta { get; set; }
        
        [Required(ErrorMessage = "Se debe ingresar la Vida Util Promedio.")]
        public Int16 VidaUtilPromedio { get; set; }
        
        [Required(ErrorMessage = "Se debe ingresar los días cuarentena.")]
        public Int16 DiasCuarentena { get; set; }
        
    
        public int? ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
        
        [StringLength(30)]
        public string? ArticuloDelProv { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar la orden mínima.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal OrdenMinima { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el plazo de reabastecimiento.")]
        public Int16 PlazoReabast { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el valor de Lote Múltiplo.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal LoteMultiplo { get; set; }
        
        public string ? Notas { get; set; }
        
        [StringLength(25)]
        public string ? UsuarioCreacion { get; set; }
        
        public DateTime ? FechaHoraCreacion { get; set; }
        
        [StringLength(25)]
        public string ?  UsuarioUltModif { get; set; }
        
        public DateTime ? FechaHoraUltModif { get; set; }
        
        public bool UsaNumerosSerie { get; set; }
        
        [StringLength((1))]
        public string ? ModalidadInvFis { get; set; }
        
        [StringLength(1)]
        public string ?  TipoCodBarraDet { get; set; }
        
        [StringLength(1)]
        public string ?  TipoCodBarraAlm { get; set; }
        
        public bool UsaReglasLocales { get; set; }
        
      
        public int UnidadAlmacenId { get; set; }
        public UnidadMedida UnidadAlmacen { get; set; }

     
        public int UnidadEmpaqueId { get; set; }
        public UnidadMedida UnidadEmpaque { get; set; }

      
        public int UnidadVentaId { get; set; }
        public UnidadMedida UnidadVenta { get; set; }
       
        public bool Perecedero { get; set; }
        
        [StringLength(35)]
        public string ? Manufacturador { get; set; }
        
        [StringLength(4)]
        public string ? CodigoRetencion { get; set; }
        
        [StringLength(4)]
        public string ? RetencionVenta { get; set; }
        
        [StringLength(4)]
        public string ? RetencionCompra { get; set; }
        
        [StringLength(4)]
        public string ? ModeloRetencion { get; set; }
        
        [StringLength(5)]
        public string ? Estilo { get; set; }
        
        [StringLength(5)]
        public string ? Talla { get; set; }
        
        [StringLength(5)]
        public string ? Color { get; set; }
        
      
        [StringLength(1)]
        public string TipoCosto { get; set; }
        
      
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoPromUltimoLoc { get; set; }
        
       
        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoPromUltimoDol { get; set; }
        
        public bool EsImpuesto { get; set; }
        
        [StringLength(2)]
        public string ?  TipoDocIVA { get; set; }
        
        public bool SugiereMin { get; set; }
        
        public bool CalculaPercep { get; set; }
        
        [Column(TypeName = "decimal(28,8)")]
        public decimal ? PorcPercep { get; set; }
        [StringLength(250)]
        public string? urlimagen { get; set; }
        //[InverseProperty("ArtEnLote")]
        //public List<Lote> LoteArticulo { get; set; }
    }
}
