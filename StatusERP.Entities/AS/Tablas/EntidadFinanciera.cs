using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class EntidadFinanciera:EntityBase
    {
        [Required]
        [StringLength(8)]
        public string CodEntidadFinanciera { get; set; }

        [Required]
        [StringLength(20)]
        public string NIT { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string CodElectronico { get; set; }
    }
}
