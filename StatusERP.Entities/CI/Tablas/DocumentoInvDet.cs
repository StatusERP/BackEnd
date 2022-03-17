using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("DocumentosInvDet", Schema = Constants.Conjunto)]
    public class DocumentoInvDet:EntityBase
    {
        public string PaqueteInventario { get; set; }

        public string DocumentoInv { get; set; }

        public int LineaDocInv { get; set; }

        public string DocTributario { get; set; }

        public string Articulo { get; set; }    

        public string Bodega { get; set; }  

        public string Localización { get; set; }

        public string Lote { get; set; }

        public string Tipo { get; set; }    

        public string Subtipo { get; set; } 

        public string Subsubtipo { get; set;}


    }
}
