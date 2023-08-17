using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaPresupuesto
    {
        public static int ultimoPresupuesto()
        {
            PersistenciaPresupuesto presupuesto = new PersistenciaPresupuesto();
            return presupuesto.ultimoPresupuesto();
        }

        public static string Insertar(ModeloPresupuesto modeloPresupuesto)
        {
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.Insertar(modeloPresupuesto);
        }

        
    }
}
