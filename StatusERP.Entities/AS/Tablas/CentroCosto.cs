using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("CentrosCosto", Schema = Constants.Conjunto)]
    public class CentroCosto:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar Código para el Centro de Costos")]
        [StringLength(25)]
        public string CodCentroCosto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Descripción para el Centro de Costos")]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public bool AceptaDatos { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Tipo para el Centro de Costos")]
        [StringLength(1)]
        public string Tipo { get; set; }    
    }
}
