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
    }
}
