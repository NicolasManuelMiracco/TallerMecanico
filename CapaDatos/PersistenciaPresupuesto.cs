using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class PersistenciaPresupuesto { 
        public int ultimoPresupuesto()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM dbo.Presupuesto";   
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(query, conexion);
                //comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                int res = (int)comando.ExecuteScalar();
                //System.Diagnostics.Debug.WriteLine("Salida: " + res);                
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }
    }
}
