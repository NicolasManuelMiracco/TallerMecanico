using CapaModelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaPersistencia
{
    public class PersistenciaAutomovil
    {
        public string Insertar(ModeloAutomovil obj)
        {
            string respuesta = "";           
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();            
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarAutomovil", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = obj.IdAutomovil;
                comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                comando.Parameters.Add("@CantidadPuertas", SqlDbType.Int).Value = obj.CantidadPuertas;
                comando.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = obj.IdVehiculo;                
                comando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = obj.Marca;
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = obj.Modelo;
                comando.Parameters.Add("@Patente", SqlDbType.VarChar).Value = obj.Patente;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Insert Automóvil ERROR";                
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }

        public string Actualizar(ModeloAutomovil obj)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("actualizarAutomovil", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = obj.IdAutomovil;
                comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                comando.Parameters.Add("@CantidadPuertas", SqlDbType.VarChar).Value = obj.CantidadPuertas;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Update Automóvil ERROR";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }

    }
}
