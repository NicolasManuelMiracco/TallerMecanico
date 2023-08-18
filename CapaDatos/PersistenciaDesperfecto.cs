using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaPersistencia
{
    public class PersistenciaDesperfecto
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("listarDesperfectos", conexion);
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
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        public double subTotalRepuestos(int idDesperfecto)
        {
            SqlConnection conexion = new SqlConnection(); 
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("subtotalDesperfecto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                var returnParameter = cmd.Parameters.Add("@IdDesperfecto", SqlDbType.Int);               
                cmd.ExecuteNonQuery();
                var result = returnParameter.Value;
                return (double) result;                
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