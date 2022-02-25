﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CG.Tablas
{
    public class CuadreAuxiliar:EntityBase
    {
        [Required]
        public int CodCuadreCG { get; set; }

        [Required]
        [StringLength(30)]
        public string TablaOrigen { get; set; }

        [StringLength(250)]
        public string ? Referencia { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(250)]
        public string Concepto { get; set; }

        [StringLength(10)]
        public string ? Asiento { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoLoc { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DebitoDol { get; set; }


        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoLoc { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal CreditoDol { get; set; }

        [Required]
        [StringLength(4)]
        public string Origen { get; set; }
    }
}