using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class Bodega:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodBodega { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public bool Activa { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(250)]
        public string ? Direccion { get; set; }

        public int ? SucursalId  { get; set; }

        public virtual Sucursal Sucursal { get; set; }

    }
}
 