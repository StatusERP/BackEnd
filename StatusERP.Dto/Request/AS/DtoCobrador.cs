﻿using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoCobrador
    {
        [Required(ErrorMessage = "Se requiere especificar un código de Cobrador")]
        [StringLength(4)]
        public string CodCobrador { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el nombre del Cobrador")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string? Email { get; set; }

        public bool Activo { get; set; }
    }
}