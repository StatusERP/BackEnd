﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoLote
    {
        [Required(ErrorMessage = "Se requiere especificar un código de lote.")]
        [StringLength(15)]
        public string CodLote { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un código de articulo.")]
        public int ArticuloId { get; set; }

        public int? ProveedorId { get; set; }

        [StringLength(15)]
        public string LoteProveedor { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la fecha de entrada del lote.")]
        public DateTime FechaEntrada { get; set; }

        [Required(ErrorMessage = "Se requiere especificar fecha de vencimiento.")]
        public DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "Se requiere especificar fecha de cuarentena.")]
        public DateTime FechaCuarentena { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la cantidad ingresada.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CantidadIngresada { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el estado del lote.")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el tipo de ingreso.")]
        [StringLength(1)]
        public string TipoIngreso { get; set; }

        public string Notas { get; set; }

        [Required(ErrorMessage = "Se requiere indicar el último ingreso.")]
        public int UltimoIngreso { get; set; }

        public DateTime FechaFabricacion { get; set; }
    }
}
