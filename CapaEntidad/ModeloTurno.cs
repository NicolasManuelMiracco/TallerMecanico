using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    class ModeloTurno
    {
        DateTime Fecha { get; set; }
        ModeloPresupuesto Presupuesto { get; set; }
        
        public ModeloTurno(DateTime fecha, ModeloPresupuesto presupuesto)
        {
            Fecha = Fecha;
            Presupuesto = Presupuesto;
        }
        
    }
}
