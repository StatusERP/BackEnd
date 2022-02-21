using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    public class Localizacion:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodBodega { get; set; }

        [Required]
        [StringLength(4)]
        public string CodLocalizacion { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; } 

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Volumen { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal PesoMaximo { get; set; }


    }
}
