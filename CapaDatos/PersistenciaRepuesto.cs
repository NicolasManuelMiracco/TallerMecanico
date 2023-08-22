using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class PersistenciaRepuesto
    {
        
        /// <summary>
        ///  Persistencia en BD tabla Repuesto. El Stored procedure retorna el Id autonumérico generado.
        /// </summary>
        
        public int Insertar(String nombre, Decimal precio)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarRepuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                comando.Parameters.Add("@IdRepuesto", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Insert Desperfecto ERROR";
                if (respuesta == "OK") return Convert.ToInt32(comando.Parameters["@IdRepuesto"].Value);
                else return -1; // Indica error en la salida
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                throw ex;
            }
            finally {   if (conexion.State == ConnectionState.Open) conexion.Close();   }           
        }

        /// <summary>
        ///  Se obtiene el modelo Repuesto existente a partir de su Id
        /// </summary>
        public ModeloRepuesto buscarRepuesto(int idRepuestoExistente)
        {
            string respuesta;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("buscarRepuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = idRepuestoExistente;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == -1 ? "OK" : "Select Repuesto ERROR"; // -1 es la salida para un select
                if (respuesta == "OK") return new ModeloRepuesto(idRepuestoExistente, Convert.ToString(comando.Parameters["@Nombre"].Value), Convert.ToDecimal(comando.Parameters["@Precio"].Value));
                else return null;
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                throw ex;
            }
            finally { if (conexion.State == ConnectionState.Open) conexion.Close(); }            
        }

    }
}
