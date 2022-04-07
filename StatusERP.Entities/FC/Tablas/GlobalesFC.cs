using StatusERP.Entities.ERPADMIN.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("GlobalesFC", Schema = Constants.Conjunto)]
    public class GlobalesFC:EntityBase
    {
        public bool IntegracionCC { get; set; }

        public bool IntegracionCO { get; set; }

        public bool IntegracionCP { get; set; }

        public bool IntegracionFA { get; set; }
    }
}
