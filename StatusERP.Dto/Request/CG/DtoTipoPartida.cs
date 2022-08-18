using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CG
{
    public class DtoTipoPartida
    {
        [Required(ErrorMessage = "El código del tipo de partida es requerido.")]
        [StringLength(4)]
        public string CodTipoPartida { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(40)]
        public string Descripcion { get; set; }


    }
}