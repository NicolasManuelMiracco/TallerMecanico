using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
