using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("MovsInventarioEnc", Schema = Constants.Conjunto)]
    public class MovInventarioEnc:EntityBase
    {

        public int? ConsecutivoId { get; set; }
        [ForeignKey(nameof(ConsecutivoId))]
        public ConsecutivoInv consecutivoInv { get; set; }

        [Required()]
        [StringLength(25)]
        public string Usuario { get; set; }

        public DateTime FechaHora { get; set; }

        [Required()]
        [StringLength(4)]
        public string ModuloOrigen { get; set; }

        [Required()]
        [StringLength(250)]
        public string Aplicacion { get; set; }

        [Required()]
        [StringLength(200)]
        public string Referencia { get; set; }

        [StringLength(10)]
        public string  ? Asiento { get; set; }

        [StringLength(25)]
        public string ? UsuarioAprob { get; set; }

        public DateTime ? FechaHoraAprob { get; set; }

        [StringLength(4)]
        public String ? PaqueteInventario { get; set; }
    }
}
