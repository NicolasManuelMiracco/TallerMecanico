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
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.Insertar(nuevoPresupuesto);
        }

        public static string InsertarPresupuesto(ModeloPresupuesto nuevoPresupuesto)
        {
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.Insertar(nuevoPresupuesto);
        }




    }
}
