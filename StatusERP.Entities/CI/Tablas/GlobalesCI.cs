using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("GlobalesCI", Schema = Constants.Conjunto)]
    public class GlobalesCI : EntityBase
    {
        public Int16 CostosDec { get; set; }

        public Int16 ExistenciasDec { get; set; }

        public Int16 PesosDec { get; set; }

        public string Costo { get; set; }

        public string CostoIngrDefault { get; set; }

        public string UnidadPeso { get; set; }

        public string UnidadVolumen { get; set; }
        
        public bool UsaLocalizacion { get; set; }
        
        public bool AjustarConteo { get; set; }

        public int MaxAuditoria { get; set; }
    

}
}
