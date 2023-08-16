using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class PersistenciaMoto
    {
        public string Insertar(ModeloMoto obj)
        {
            string respuesta = "";
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarMoto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = obj.IdMoto;
                comando.Parameters.Add("@Cilindrada", SqlDbType.VarChar).Value = obj.Cilindrada;
                comando.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = obj.IdVehiculo;
                comando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = obj.Marca;
                comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = obj.Modelo;
                comando.Parameters.Add("@Patente", SqlDbType.VarChar).Value = obj.Patente;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Insert Moto ERROR";
                System.Diagnostics.Debug.WriteLine("Salida: " + respuesta);
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
