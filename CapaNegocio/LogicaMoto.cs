using CapaModelo;
using CapaPersistencia;

namespace CapaLogica
{
    public class LogicaMoto
    {
        public static string Insertar(int id, string marca, string modelo, string patente, int idVehiculo, string cilindrada)
        {
            PersistenciaMoto datos = new PersistenciaMoto();
            ModeloMoto obj = new ModeloMoto(id, marca, modelo, patente, idVehiculo, cilindrada);
            return datos.Insertar(obj);
        }
    }
}
