using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("Conjuntos", Schema = "ERPADMIN")]
    public class Conjunto :EntityBase
    {
        
        [Column("Conjunto")]
        [Required(ErrorMessage = "Se requiere código para la Compañía.")]
        [StringLength(10)]
        public string Compania { get; set; }
        
        [Required(ErrorMessage = "Se requiere nombre para la Compañia.")]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se requiere dirección para la Compañia.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Se requiere teléfono para la Compañia.")]
        [StringLength(30)]
        public string Telefono { get; set; }
        
        [StringLength(250)]
        public string Logo { get; set; }
        
        public bool DobleMoneda { get; set; }

        public bool DobleContabilidad { get; set; }

        public bool UsaLotes { get; set; }

        public bool UsaCentroCosto { get; set; }

        [Required(ErrorMessage = "Dato actualizado por el Sistema.")]
        public string UsuarioUltMod { get; set; }

        [Required(ErrorMessage = "Dato actualizado por el Sistema.")]
        public DateTime FechaUltMod { get; set; }

        public string Notas { get; set; }

        [Required(ErrorMessage = "Dato actualizado por el Sistema.")]
        [StringLength(8)]
        public string VersionBD { get; set; }
               
        public string UsuarioModBd { get; set; }

        public DateTime FechaHoraModBd { get; set; }

        [Required(ErrorMessage = "Dato actualizado por el Sistema.")]
        [StringLength(8)]
        public string VersionInstalada { get; set; }

        [Required(ErrorMessage = "Se requiere el número de documento tributario de la Compañía.")]
        [StringLength(20)]
        public string DocTributario { get; set; }

        [Required(ErrorMessage = "Se requiere indicadar el país sede de la Compañía.")]
        [StringLength(20)]
        public string Pais { get; set; }

        public bool UsaSucursales { get; set; }
                
        [StringLength(10)]
        public string ? MascaraSucursal { get; set; }

        [StringLength(150)]
        public string ? DireccionWeb { get; set; }

        [StringLength(250)]
        public string ? CorreoDocElectronico { get; set; }

        [StringLength(25)]
        public string ? NumeroRegistro { get; set; }
                
        public string ? ActividadComercial { get; set; }

        public bool AgentePercepcion { get; set; }

        public bool CalPercepVentas { get; set; }

        public bool AgenteRetencion { get; set; }

        public int MembresiaId { get; set; }
        public Membresia Membresia {get; set; }

        [Required(ErrorMessage = "Se requiere fecha de vencimiento.")]
        public DateTime FechaVence { get; set; }
        
        public bool Activa { get; set; }

   
    }
}
