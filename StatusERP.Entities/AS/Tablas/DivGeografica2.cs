using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("DivGeograficas2", Schema = Constants.Conjunto)]
    public class DivGeografica2:EntityBase
    {
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

        [Column("DivGeografica1")]
        public int DivGeografica1Id { get; set; }
        public DivGeografica1 DivGeografica1 { set; get; }

        [Required(ErrorMessage = "Se requiere especificar código de División Geográfica 2.")]
        [StringLength(12)]
        public string CodDivGeografica2 { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre de la División Geográfica 2.")]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
