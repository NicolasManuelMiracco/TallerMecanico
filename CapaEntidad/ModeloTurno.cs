using System;

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
