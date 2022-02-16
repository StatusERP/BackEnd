﻿using StatusERP.Entities.ERPADMIN.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("Vendedores")]
    public class Vendedor:EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Vendedor")]
        [Required]  
       [StringLength(4)]
        public string CodVendedor { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Email { get; set; }
        public bool Activo { get; set; }
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }  
    }
}
