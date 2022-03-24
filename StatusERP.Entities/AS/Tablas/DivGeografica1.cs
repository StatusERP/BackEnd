using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("DivGeograficas1", Schema = Constants.Conjunto)]
    public class DivGeografica1:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código de País.")]
        [Column("Pais")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        [Required(ErrorMessage = "Se requiere especificar código de División Geográfica 1.")]
        [StringLength(12)]
        public string CodDivGeografica1 { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre de la División Geográfica 1.")]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
