using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("EntidadesFinancieras", Schema = Constants.Conjunto)]
    public class EntidadFinanciera:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código de la Entidad Financiera.")]
        [StringLength(8)]
        public string CodEntidadFinanciera { get; set; }

        [Required(ErrorMessage = "Se requiere especificar No. de Documento Tributario de la Entidad Financiera.")]
        [StringLength(20)]
        public string NIT { get; set; }

        [Required(ErrorMessage = "Se requiere especificar descripción de la Entidad Financiera.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string ? CodElectronico { get; set; }
    }
}
