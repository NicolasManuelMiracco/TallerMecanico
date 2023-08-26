using CapaPersistencia;
using System;
using System.Data;

namespace CapaLogica
{
    public class LogicaServicios
    {
        public static DataTable SumatoriaMontoTotal(String tipoVehiculo)
        {
            PersistenciaServicios datos = new PersistenciaServicios();
            return datos.SumatoriaMontoTotal(tipoVehiculo);
        }

        public static DataTable RepuestoMasUtilizado(String marcaModelo)
        {
            PersistenciaServicios datos = new PersistenciaServicios();
            return datos.RepuestoMasUtilizado(marcaModelo);
        }

        public static DataTable PromedioMontoTotal(String marcaModelo)
        {
            PersistenciaServicios datos = new PersistenciaServicios();
            return datos.PromedioMontoTotal(marcaModelo);
        }

        public static DataTable MassiveCharge()
        {
            PersistenciaServicios datos = new PersistenciaServicios();
            return datos.MassiveCharge();
        }

        public static DataTable CargaAll()
        {
            PersistenciaServicios datos = new PersistenciaServicios();
            return datos.CargaAll();
        }
    }
}
