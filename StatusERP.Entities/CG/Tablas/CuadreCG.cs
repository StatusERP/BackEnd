using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    [Table("CuadresCG", Schema = Constants.Conjunto)]
    public class CuadreCG:EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código de Cuadre CG.")]
        public int CodCuadreCG { get; set; }

        [Required(ErrorMessage = "Se requiere descripción.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el módulo.")]
        [StringLength(4)]
        public string Modulo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha desde.")]
        public DateTime FechaDesde { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha hasta.")]
        public DateTime FechaHasta { get; set; }

        [Required(ErrorMessage = "Se requiere especificar filtros.")]
        [StringLength(250)]
        public string Filtros { get; set; }

        [Required(ErrorMessage = "Se requiere especificar cuentas.")]
        public string Cuentas { get; set; }

        [Required(ErrorMessage = "Se requiere especificar otros.")]
        [StringLength(250)]
        public string Otros { get; set; }

        [Required(ErrorMessage = "Se requiere especificar tab.")]
        public int Tab { get; set; }
    }
}
