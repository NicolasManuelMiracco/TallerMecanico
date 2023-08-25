using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloTallerMecanico
    {
        List<ModeloPresupuesto> presupuestos;
        List<ModeloTurno> turnos;
        DateTime UltimoTurno { get; set; }

        public void setUltimoTurno(DateTime ultimoTurno)
        {
            UltimoTurno = ultimoTurno;
        }

        public ModeloTallerMecanico()
        {
            presupuestos = new List<ModeloPresupuesto>();
            turnos = new List<ModeloTurno>();
            UltimoTurno = DateTime.Today;
        }
    }
}
