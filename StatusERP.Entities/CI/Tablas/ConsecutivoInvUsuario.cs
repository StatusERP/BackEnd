using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ConsecutivosInvUsuarios", Schema = Constants.Conjunto)]
    public class ConsecutivoInvUsuario:EntityBase
    {
        public int Consecutivo { get; set; }
        
        public int Usuario { get; set; }
    }
}
