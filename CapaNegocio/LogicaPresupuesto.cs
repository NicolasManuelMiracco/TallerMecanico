using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaPresupuesto
    {
                
        public Double descuento { get; set; }
        public Double recargo { get; set; }
        public int DiasReparacion { get; set; }
        public Double ManoDeObra { get; set; }
        public Double calcularTotal() {
            return 0;
        }
    }
}
