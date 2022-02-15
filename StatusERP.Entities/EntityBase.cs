using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities
{
    public class EntityBase
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Createby { get; set; }
        public DateTime CreateDate { get; set; }
        public string Updateby { get; set; }

        public DateTime UpdateDate { get; set; }
        
        public string Conjunto { get; set; }

    }
}