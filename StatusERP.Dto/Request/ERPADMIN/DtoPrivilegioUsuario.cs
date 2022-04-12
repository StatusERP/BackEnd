using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Request.ERPADMIN
{
    public class DtoPrivilegioUsuario
    {
        [Required(ErrorMessage = "Codigo de Usuario es requerido.")]
        [StringLength(36)]
        public string UsuarioId { get; set; }

        [Required(ErrorMessage = "Conjunto es requerido.")]
        public int ConjuntoId { get; set; }
        

        [Required(ErrorMessage = "Codigo de Acción es requerido.")]
        public int AccionId { get; set; }
        

        public bool Activo { get; set; }
    }
}
