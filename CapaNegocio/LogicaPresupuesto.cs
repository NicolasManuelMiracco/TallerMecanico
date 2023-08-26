using CapaModelo;
using CapaPersistencia;
using System.Data;

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

        public static string actualizarPresupuesto(ModeloPresupuesto nuevoPresupuesto)
        {
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.Actualizar(nuevoPresupuesto);
        }

        public static DataTable Listar()
        {
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.Listar();
        }
        /// <summary>
        /// Eliminación de presupuestos iniciados pero que han sido abortados. 
        /// Se identifican por tener: Nombre y Apellido null, Email por default y Total = 0.
        /// </summary>
        public static string eliminarPresupuestosIncompletos()
        {
            PersistenciaPresupuesto datos = new PersistenciaPresupuesto();
            return datos.eliminarPresupuestosIncompletos();
        }
    }
}
