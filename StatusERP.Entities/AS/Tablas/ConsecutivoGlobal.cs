using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.AS.Tablas
{
    public class ConsecutivoGlobal : EntityBase
    {
        [Required]
        [StringLength(10)]
        public string CodConsecutivoGlobal { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int Longitud { get; set; }

        [Required]
        [StringLength(40)]
        public string Entidad{ get; set; }

        [Required]
        [StringLength(50)]
        public string Documento { get; set; }

        [StringLength(250)]
        public string ? FormatoImpresionDetallado { get; set; }

        [StringLength(250)]
        public string ? FormatoImpresionResumido { get; set; }

        [Required]
        [StringLength(50)]
        public string Mascara { get; set; }

        [Required]
        [StringLength(50)]
        public string ValorInicial { get; set; }

        [Required]
        [StringLength(50)]
        public string ValorFinal { get; set; }

        [Required]
        [StringLength(50)]
        public string UltimoValor { get; set; }

        [Required]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required]
        public DateTime FechaHoraUlt { get; set; }  



    }
}
