using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("PaquetesContables", Schema = Constants.Conjunto)]
    public class PaqueteContable:EntityBase
    {
        [StringLength(4)]
        public string CodPaquete { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(250)]
        public string UsuarioCreador { get; set; }

        [StringLength(250)] 
        public string UltimoUsuario { get; set; }

        public DateTime FechaUltAcceso { get; set; }

        [StringLength(10)]
        public string UltimoAsiento { get; set; }

        public bool Marcado { get; set; }
    }
}
