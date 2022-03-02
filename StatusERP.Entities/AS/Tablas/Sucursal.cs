using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Sucursales", Schema = Constants.Conjunto)]
    public class Sucursal:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Sucursal.")]
        [StringLength(4)]
        public string CodSucursal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción de la Sucursal.")]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }

    }
}
