using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class EntidadPresupuesto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public Double ManoDeObra { get; set; }        
        public Double Total { get; set; }
        public int IdVehiculo { get; set; }
    }
}
