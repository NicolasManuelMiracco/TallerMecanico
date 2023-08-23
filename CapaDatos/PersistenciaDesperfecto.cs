using CapaModelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaPersistencia
{
    public class PersistenciaDesperfecto
    {
        public DataTable Listar(int idPresupuesto)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("listarDesperfectos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdPresupuesto", SqlDbType.Int).Value = idPresupuesto;
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

        public string Insertar(ModeloDesperfecto obj)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando;
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();                
                comando = new SqlCommand("insertarDesperfecto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdPresupuesto", SqlDbType.Int).Value = obj.IdPresupuesto;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                comando.Parameters.Add("@ManoDeObra", SqlDbType.Int).Value = obj.ManoDeObra;
                comando.Parameters.Add("@Tiempo", SqlDbType.Int).Value = obj.Tiempo;
                comando.Parameters.Add("@lastDesperfecto", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Insert Desperfecto ERROR";
                ((ModeloDesperfecto)obj).Id = Convert.ToInt32(comando.Parameters["@lastDesperfecto"].Value); //Actualizo el modeloDesperfecto con el id según el autonumérico
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