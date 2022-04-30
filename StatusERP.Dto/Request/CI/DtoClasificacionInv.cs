using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CI
{
    public class DtoClasificacionInv
    {
        [Required(ErrorMessage = "Se requiere especificar un código de Clasificación.")]
        [StringLength(12)]
        public string CodClasificacion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una descripción.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar una agrupacion.")]
        public Int16 Agrupacion { get; set; }

        public bool UsaNumerosSerie { get; set; }

        [StringLength(4)]
        public string ? PlantillaSerie { get; set; }

        [StringLength(5)]
        public string ? AporteCodigo { get; set; }

        [StringLength(1)]
        public string ? TipoCodigoBarras { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la unidad de medida.")]
        [StringLength(6)]
        public string UnidadMedida { get; set; }
    }
}

