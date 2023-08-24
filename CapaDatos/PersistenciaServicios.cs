using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class PersistenciaServicios
    {
        
        public DataTable SumatoriaMontoTotal(String tipoVehiculo)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("sumatoriaMontoTotal", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@TipoVehiculo", SqlDbType.VarChar).Value = tipoVehiculo;
                //comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                //comando.Parameters.Add("@Precio", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                conexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (conexion.State == ConnectionState.Open) conexion.Close(); }
        }

        public DataTable RepuestoMasUtilizado()
        {
            DataTable tabla = new DataTable();
            return tabla;
        }

        public DataTable PromedioMontoTotal()
        {
            DataTable tabla = new DataTable();
            return tabla;
        }

        public DataTable MassiveCharge()
        {
            DataTable tabla = new DataTable();
            return tabla;
        }

        public DataTable CargaAll()
        {
            DataTable tabla = new DataTable();
            return tabla;
        }


    }
}
