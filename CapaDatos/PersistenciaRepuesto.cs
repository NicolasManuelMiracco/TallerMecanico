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
        ///  Se agregan los repuestos en el desperfecto vigente (under construction) para el presupuesto activo.
        /// </summary>
        //seguir aca
        public string Insertar(ModeloDesperfecto obj)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                //System.Diagnostics.Debug.WriteLine("Salida: " + (string)obj.Marca);
                SqlCommand comando = new SqlCommand("insertarDesperfecto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdPresupuesto", SqlDbType.Int).Value = obj.IdPresupuesto;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                comando.Parameters.Add("@ManoDeObra", SqlDbType.Int).Value = obj.ManoDeObra;
                comando.Parameters.Add("@Tiempo", SqlDbType.Int).Value = obj.Tiempo;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Insert Desperfecto ERROR";
                //System.Diagnostics.Debug.WriteLine("Salida: " + respuesta);
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

        /// <summary>
        ///  Se obtiene el modelo Repuesto existente a partir de su Id
        /// </summary>
        public ModeloRepuesto buscarRepuesto(int IdRepuestoExistente)
        {
            string respuesta;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                //System.Diagnostics.Debug.WriteLine("Salida: " + (string)obj.Marca);
                SqlCommand comando = new SqlCommand("buscarRepuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = IdRepuestoExistente;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Select Repuesto ERROR";
                if (respuesta == "OK")
                {
                    return new ModeloRepuesto(IdRepuestoExistente, Convert.ToString(comando.Parameters["@Nombre"].Value), Convert.ToDecimal(comando.Parameters["@Precio"].Value));
                }
                else return null;
                //System.Diagnostics.Debug.WriteLine("Salida: " + respuesta);
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
        }

    }
}
