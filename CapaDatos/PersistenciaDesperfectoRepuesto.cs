using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class PersistenciaDesperfectoRepuesto
    {
        /// <summary>
        ///  Persistencia en BD tabla DesperfectoRepuesto.
        /// </summary>

        public string Insertar(int idRepuesto, int idDesperfecto)
        {
            System.Diagnostics.Debug.WriteLine("Salida ID: " + idDesperfecto + " IR: " + idRepuesto);
            string respuesta = "";            
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarDesperfectoRepuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idDesperfecto", SqlDbType.Int).Value = idDesperfecto;
                comando.Parameters.Add("@IdRepuesto", SqlDbType.Int).Value = idRepuesto;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Insert DesperfectoRepuesto ERROR";
                System.Diagnostics.Debug.WriteLine("Salida ID: " + idDesperfecto + " IR: " + idRepuesto);
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                throw ex;
            }
            finally { if (conexion.State == ConnectionState.Open) conexion.Close(); }
            return respuesta;
        }
    }
}
