using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaAutomovil
    {
        public static string Insertar(int id, string marca, string modelo, string patente, string tipo, int cantidadPuertas, int idVehiculo)
        {
            PersistenciaAutomovil datos = new PersistenciaAutomovil();
            ModeloAutomovil obj = new ModeloAutomovil(id, marca, modelo, patente, tipo, cantidadPuertas, idVehiculo);
            return datos.Insertar(obj);
        }
    }
}
