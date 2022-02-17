using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class Sucursal:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodSucursal { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }

    }
}
