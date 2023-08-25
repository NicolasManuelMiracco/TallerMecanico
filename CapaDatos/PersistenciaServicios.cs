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

        public DataTable RepuestoMasUtilizado(String marcaModelo)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("repuestoMasUtilizado", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@MarcaModelo", SqlDbType.VarChar).Value = marcaModelo;
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

        public DataTable PromedioMontoTotal(String marcaModelo)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("promedioMontoTotal", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@MarcaModelo", SqlDbType.VarChar).Value = marcaModelo;                
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

        public DataTable MassiveCharge()
        {
            DataTable tabla = new DataTable();
            SqlDataReader resultado;            
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("MassiveCharge", conexion);
                comando.CommandType = CommandType.StoredProcedure;                
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

        public DataTable CargaAll()
        {
            DataTable tabla = new DataTable();
            SqlDataReader resultado;
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("cargaAll", conexion);
                comando.CommandType = CommandType.StoredProcedure;
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


    }
}
