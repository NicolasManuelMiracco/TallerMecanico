using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;
using CapaModelo;

namespace CapaLogica
{
    public class LogicaVehiculo
    {
        public static DataTable Listar()
        {
            PersistenciaVehiculo datos = new PersistenciaVehiculo();
            return datos.Listar();
        }

        public static DataTable Buscar(string field)
        {
            PersistenciaVehiculo datos = new PersistenciaVehiculo();
            return datos.Buscar(field);
        }

        public static string Insertar(int id, string marca, string modelo, string patente)
        {
            PersistenciaVehiculo datos = new PersistenciaVehiculo();
            ModeloVehiculo obj = new ModeloVehiculo(id, marca, modelo, patente);            
            return datos.Insertar(obj);
        }

        public static string Actualizar(int id, string marca, string modelo, string patente)
        {
            PersistenciaVehiculo datos = new PersistenciaVehiculo();
            ModeloVehiculo obj = new ModeloVehiculo(id, marca, modelo, patente);
            return datos.Actualizar(obj);
        }

        public static string Eliminar(int IdMoto, int idAutomovil)
        {
            PersistenciaVehiculo datos = new PersistenciaVehiculo();
            return datos.Eliminar(IdMoto, idAutomovil);
        }
    }
}
