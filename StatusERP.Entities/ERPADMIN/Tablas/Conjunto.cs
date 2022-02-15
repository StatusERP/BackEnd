using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    public class Conjunto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Conjunto")]
        [Required]
        [StringLength(10)]
        public string Compania { get; set; }
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        [StringLength(30)]
        public string Telefono { get; set; }
        
        [StringLength(250)]
        public string Logo { get; set; }
        
        public bool DobleMoneda { get; set; }
        public bool DobleContabilidad { get; set; }

        public bool UsaLotes { get; set; }

        public bool UsaCentroCosto { get; set; }

        [Required]
        public string UsuarioUltMod { get; set; }
        [Required]
        public DateTime FechaUltMod { get; set; }

        public string Notas { get; set; }

        [Required]
        [StringLength(8)]
        public string VersionBD { get; set; }

       
        public string UsuarioModBd { get; set; }
        public DateTime FechaHoraModBd { get; set; }

        [Required]
        [StringLength(8)]
        public string VersionInstalad { get; set; }
        [Required]
        [StringLength(20)]
        public string NIT { get; set; }

        [Required]
        [StringLength(20)]
        public string PAIS { get; set; }

        public bool UsaSucursales { get; set; }

        
        [StringLength(10)]
        public string MascaraSucursal { get; set; }

        [StringLength(150)]
        public string DireccionWeb { get; set; }

        [StringLength(250)]
        public string CorreoDocEletronico { get; set; }

        [StringLength(25)]
        public string NumeroRegistro { get; set; }
                
        public string ActividadComercial { get; set; }

        public bool AgentePerseccion { get; set; }
        public bool CalPerscVentas { get; set; }

        public bool AgenteRetencionn { get; set; }


        public bool IsDeleted { get; set; }
        [StringLength(250)]
        [Required]
        public string Createby { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [StringLength(250)]
        [Required]
        public string Updateby { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }

    }
}
