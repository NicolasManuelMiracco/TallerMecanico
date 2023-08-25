using CapaModelo;
using CapaPersistencia;

namespace CapaLogica
{
    public class LogicaAutomovil
    {
        /// <summary>
        ///  Gestión lógica para la inserción de Automóvil
        /// </summary>        
        public static string Insertar(int id, string marca, string modelo, string patente, string tipo, int cantidadPuertas, int idVehiculo)
        {
            PersistenciaAutomovil datos = new PersistenciaAutomovil();
            ModeloAutomovil obj = new ModeloAutomovil(id, marca, modelo, patente, tipo, cantidadPuertas, idVehiculo);
            return datos.Actualizar(obj);
        }

        public static string Actualizar(int id, string marca, string modelo, string patente, string tipo, int cantidadPuertas, int idVehiculo)
        {
            PersistenciaAutomovil datos = new PersistenciaAutomovil();
            ModeloAutomovil obj = new ModeloAutomovil(id, marca, modelo, patente, tipo, cantidadPuertas, idVehiculo);
            return datos.Actualizar(obj);            
        }
    }
}
