using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Request.AS
{
    public class DtoPais
    {
     //   [Required(ErrorMessage = "Debe especificarse la cantidad de decimales en costos.")]
        public string codPais { get; set; }
        
        public int Id { get; set; }

     //   [Required(ErrorMessage = "Debe especificarse la cantidad de decimales en pesos.")]
        public string nombre { get; set; }

        
    }
}
