using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("ConsecutivosFA", Schema = Constants.Conjunto)]
    public class ConsecutivoFA:EntityBase
    {
        [StringLength(10)]
        public string CodConsecutivo { get; set; }
        
        [StringLength(250)]
        public string UsuarioUlt { get; set; }
        
        [StringLength(40)]
        public string Descripcion { get; set; }
        
        [StringLength(1)]
        public string Tipo { get; set; }
        
        public Int16 Longitud { get; set; }
        
        [StringLength(50)]
        public string ValorConsecutivo { get; set; }
        
        [StringLength(50)]
        public string ? Mascara { get; set; }
        
        public DateTime FechaHoraUlt { get; set; }
        
        [StringLength(250)]
        public string Formato { get; set; }
        
        [StringLength(50)]
        public string ValorMaximo { get; set; }
        
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
        
        [StringLength(254)]
        public string? DeConsRPT { get; set; }
        
        [StringLength(50)]
        public string? ValorInicial { get; set; }
        
        [StringLength(254)]
        public string? DeCCRPT { get; set; }
        
        public int ? MatriculaMercantil { get; set; }
    }
}
