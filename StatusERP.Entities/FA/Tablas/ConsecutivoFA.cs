using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("ConsecutivosFA", Schema = Constants.Conjunto)]
    public class ConsecutivoFA:EntityBase
    {
        [Required(ErrorMessage = "El código del consecutivo es obligatorio.")]
        [StringLength(10)]
        public string CodigoConsecutivo { get; set; }
        
        [Required(ErrorMessage = "El último usuario es obligatorio.")]
        [StringLength(25)]
        public string UsuarioUlt { get; set; }
        
        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "El tipo es obligatorio.")]
        [StringLength(1)]
        public string Tipo { get; set; }
        
        [Required(ErrorMessage = "La longitud es obligatoria.")]
        public Int16 Longitud { get; set; }
        
        [Required(ErrorMessage = "El valor del consecutivo es obligatorio.")]
        [StringLength(50)]
        public string ValorConsecutivo { get; set; }
        
        [StringLength(50)]
        public string ? Mascara { get; set; }
        
        [Required(ErrorMessage = "Fecha y hora de último acceso son obligatorias.")]
        public DateTime FechaHoraUlt { get; set; }
        
        [Required(ErrorMessage = "El formato es obligatorio.")]
        [StringLength(250)]
        public string Formato { get; set; }
        
        public bool UsaEsquemaCajas { get; set; }
        
        [Required(ErrorMessage = "El valor máximo es obligatorio.")]
        [StringLength(50)]
        public string ValorMaximo { get; set; }
        
        [Required(ErrorMessage = "El número de copias es obligatorio.")]
        public int NumeroCopias { get; set; }
        
        [StringLength(30)]
        public string? Original { get; set; }
        
        [StringLength(30)]
        public string? Copia1 { get; set; }
        
        [StringLength(30)]
        public string? Copia2 { get; set; }
        
        [StringLength(30)]
        public string? Copia3 { get; set; }
        
        [StringLength(30)]
        public string? Copia4 { get; set; }
        
        [StringLength(30)]
        public string? Copia5 { get; set; }
        
        [StringLength(30)]
        public string? Reimpresion { get; set; }
        
        [StringLength(20)]
        public string? Resolucion { get; set; }
        
        [StringLength(25)]
        public string? Serie { get; set; }
        
        [StringLength(250)]
        public string? DeConsRPT { get; set; }
        
        [StringLength(50)]
        public string? ValorInicial { get; set; }
        
        [StringLength(250)]
        public string? DeCCRPT { get; set; }
        
        public int ? MatriculaMercantil { get; set; }
    }
}
