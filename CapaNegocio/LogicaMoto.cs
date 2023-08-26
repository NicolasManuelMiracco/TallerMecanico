using CapaModelo;
using CapaPersistencia;

namespace CapaLogica
{
    public class LogicaMoto
    {
        /// <summary>
        ///  Gestión lógica para la inserción de Moto
        /// </summary>     
        public static string Insertar(int id, string marca, string modelo, string patente, int idVehiculo, string cilindrada)
        {
            PersistenciaMoto datos = new PersistenciaMoto();
            ModeloMoto obj = new ModeloMoto(id, marca, modelo, patente, idVehiculo, cilindrada);
            return datos.Insertar(obj);
        }
        /// <summary>
        ///  Gestión lógica para la inserción de Moto
        /// </summary>     
        public static string Actualizar(int id, string marca, string modelo, string patente, int idVehiculo, string cilindrada)
        {
            PersistenciaMoto datos = new PersistenciaMoto();
            ModeloMoto obj = new ModeloMoto(id, marca, modelo, patente, idVehiculo, cilindrada);
            return datos.Actualizar(obj);
        }
    }
}
