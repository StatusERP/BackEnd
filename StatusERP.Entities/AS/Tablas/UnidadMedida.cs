using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class UnidadMedida:EntityBase
    {
        [Required]
        [StringLength(6)]
        public string CodUnidadMedida { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
