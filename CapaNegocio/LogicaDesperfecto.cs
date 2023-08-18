using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaDesperfecto
    {
        public static DataTable Listar()
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            return datos.Listar();
        }

        /// <summary>
        /// Definición lógica para recuperar el costo de repuestos por desperfecto
        /// </summary>
        
        public static Double obtenerSubtotalRepuestos(int idDesperfecto)
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            System.Diagnostics.Debug.WriteLine("Salida: " + datos.subTotalRepuestos(idDesperfecto));
            return datos.subTotalRepuestos(idDesperfecto);
        }
    }
}
