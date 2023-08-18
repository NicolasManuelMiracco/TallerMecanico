using System;
using System.Data;
using System.Data.SqlClient;
using CapaModelo;

namespace CapaPersistencia
{
    public class PersistenciaVehiculo
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("listarVehiculos", conexion);
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
        public string Insertar (ModeloVehiculo obj) 
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarVehiculo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                comando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = obj.Marca;
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = obj.Modelo;
                comando.Parameters.Add("@Patente", SqlDbType.VarChar).Value = obj.Patente;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Insert Vehículo ERROR";
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

        public DataTable Buscar(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("buscarVehiculos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public string Actualizar(ModeloVehiculo obj)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("actualizarVehiculo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                comando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = obj.Marca;
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = obj.Modelo;
                comando.Parameters.Add("@Patente", SqlDbType.VarChar).Value = obj.Patente;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Update Vehículo ERROR";
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

        public string Eliminar(int IdMoto, int idAutomovil)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("eliminarVehiculo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdMoto", SqlDbType.Int).Value = IdMoto;
                comando.Parameters.Add("@IdAutomovil", SqlDbType.Int).Value = idAutomovil;                
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Delete Vehículo ERROR";
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
