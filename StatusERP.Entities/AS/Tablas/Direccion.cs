using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Direcciones", Schema = Constants.Conjunto)]
    public class Direccion : EntityBase
    {
        [StringLength(10)]
        public string CodDireccion { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(60)]
        public string? NombreCampo01 { get; set; }

        [StringLength(60)]
        public string? NombreCampo02 { get; set; }

        [StringLength(60)]
        public string? NombreCampo03 { get; set; }

        [StringLength(60)]
        public string? NombreCampo04 { get; set; }

        [StringLength(60)]
        public string? NombreCampo05 { get; set; }

        [StringLength(60)]
        public string? NombreCampo06 { get; set; }

        [StringLength(60)]
        public string? NombreCampo07 { get; set; }

        [StringLength(60)]
        public string? NombreCampo08 { get; set; }

        [StringLength(60)]
        public string? NombreCampo09 { get; set; }

        [StringLength(60)]
        public string? NombreCampo10 { get; set; }

    }
}
