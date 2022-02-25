using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
    public class CuadreCG:EntityBase
    {
        [Required]
        public int CodCuadreCG { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(4)]
        public string Modulo { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public DateTime FechaDesde { get; set; }

        [Required]
        public DateTime FechaHasta { get; set; }

        [Required]
        [StringLength(250)]
        public string Filtros { get; set; }

        [Required]
        public string Cuentas { get; set; }

        [Required]
        [StringLength(250)]
        public string Otros { get; set; }

        [Required]
        public int Tab { get; set; }
    }
}
