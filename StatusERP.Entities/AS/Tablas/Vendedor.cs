using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace StatusERP.Entities.AS.Tablas
{
    [Table("Vendedores")]
    public class  Vendedor : EntityBase
    {
        [Column("Vendedor")]
        [Required]
        [StringLength(4)]
        public string CodVendedor { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string ? Email { get; set; }

        public bool Activo { get; set; }
       
    }
}