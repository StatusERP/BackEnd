using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("DireccEmbarques", Schema = Constants.Conjunto)]
    public class DireccEmbarque : EntityBase
    {
        public int ClienteId { get; set; }
        [ForeignKey(nameof(ClienteId))]
        public Cliente Cliente{ get; set; }

        [StringLength(8)]
        public string Direccion { get; set; }

        public int? DetalleDireccionId { get; set; }
        [ForeignKey(nameof(DetalleDireccionId))]
        public DetalleDireccion detalleDireccion { get; set; }

        public string? Descripcion { get; set; }

        [StringLength(30)]
        public string? Contacto { get; set; }

        [StringLength(30)]
        public string? Cargo { get; set; }

        [StringLength(50)]
        public string? Telefono1 { get; set; }

        [StringLength(50)]
        public string? Telefono2 { get; set; }

        [StringLength(50)]
        public string? Fax { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }
    }
}
