using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("ConsecutivosGlobales", Schema = Constants.Conjunto)]
    public class ConsecutivoGlobal : EntityBase
    {
        [Required(ErrorMessage = "Se requiere especificar código para el Consecutivo Global.")]
        [StringLength(10)]
        public string CodConsecutivoGlobal { get; set; }

        [Required(ErrorMessage = "Se requiere especificar descripción para el Consecutivo Global.")]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        [Required(ErrorMessage = "Se requiere especificar longitud para el Consecutivo Global.")]
        public int Longitud { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar una Entidad.")]
        [StringLength(40)]
        public string Entidad{ get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar un Documento.")]
        [StringLength(50)]
        public string Documento { get; set; }

        [StringLength(250)]
        public string ? FormatoImpresionDetallado { get; set; }

        [StringLength(250)]
        public string ? FormatoImpresionResumido { get; set; }

        [Required(ErrorMessage = "Se requiere definir una máscara para el Consecutivo Global.")]
        [StringLength(50)]
        public string Mascara { get; set; }

        [Required(ErrorMessage = "Se requiere el valor inicial del Consecutivo.")]
        [StringLength(50)]
        public string ValorInicial { get; set; }

        [Required(ErrorMessage = "Se requiere el valor final del consecutivo.")]
        [StringLength(50)]
        public string ValorFinal { get; set; }

        [Required(ErrorMessage = "Valor no editable.  El Sistema lo actualiza automáticamente.")]
        [StringLength(50)]
        public string UltimoValor { get; set; }

        [Required(ErrorMessage = "El última usuario que modificó el Consecutivo debe ser actualizado por el Sistema.")]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required(ErrorMessage = "La última vez que se modificó el Consecutivo debe ser actualizada por el Sistema.")]
        public DateTime FechaHoraUlt { get; set; } 
    }
}
