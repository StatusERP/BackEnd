using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class CentroCosto:EntityBase
    {
        [Required]
        [StringLength(25)]
        public string CodCentroCosto { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public bool AceptaDatos { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }    
    }
}
