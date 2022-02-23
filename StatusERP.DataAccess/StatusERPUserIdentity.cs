using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace StatusERP.DataAccess
{
    public class StatusERPUserIdentity : IdentityUser
    {
        [StringLength(100)]
        public string Firstname { get; set; }
        [StringLength(100)]
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int TypeDocument{ get; set; }
        [StringLength(20)]
        public string DocumentNumber { get; set; }
    }
}
