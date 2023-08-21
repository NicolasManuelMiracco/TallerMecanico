using CapaModelo;
using CapaPersistencia;

namespace CapaLogica
{
    public class LogicaPresupuesto
    {
        public static int ultimoPresupuesto()
        {
            PersistenciaPresupuesto presupuesto = new PersistenciaPresupuesto();
            return presupuesto.ultimoPresupuesto();
        }

        public static string IniciarPresupuesto(ModeloPresupuesto nuevoPresupuesto)
        {
            //ModeloPresupuesto nuevoPresupuesto = new ModeloPresupuesto(idVehiculo);
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.Insertar(nuevoPresupuesto);
        }

        
    }
}
