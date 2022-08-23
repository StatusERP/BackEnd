using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("TiposDocTributarios", Schema = Constants.Conjunto)]
    public class TipoDocTributario: EntityBase
    {
        [StringLength(25)]
        public string CodTipoDT {get; set;}

        [StringLength(25)]
        public string Descripcion { get; set;}

        [StringLength(20)]
        public string Mascara { get; set;}

    }
}
