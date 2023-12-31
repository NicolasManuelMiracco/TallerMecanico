﻿using CapaModelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaPersistencia
{
    public class PersistenciaPresupuesto {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("listarPresupuestos", conexion);
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

        public int ultimoPresupuesto()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM dbo.Presupuesto";   
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(query, conexion);                
                conexion.Open();
                int res = (int)comando.ExecuteScalar();                     
                return res;
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

        /// <summary>
        /// Se persiste el presupuesto en la BD
        /// </summary>        
        public string Insertar(ModeloPresupuesto modeloPresupuesto)
        {
            string respuesta = "";          
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarPresupuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;                
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modeloPresupuesto.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = modeloPresupuesto.Apellido;
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = modeloPresupuesto.Email;
                comando.Parameters.Add("@Total", SqlDbType.Decimal).Value = modeloPresupuesto.TotalAlConsumidor;
                comando.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = modeloPresupuesto.IdVehiculo;
                comando.Parameters.Add("@Identity", SqlDbType.Int).Direction = ParameterDirection.Output;                
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Insert Presupuesto ERROR";
                modeloPresupuesto.Id = Convert.ToInt32(comando.Parameters["@Identity"].Value); /* Se asigna al modelo el Id autonumérico retornado por el stored procedure */                
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
        /// Se actualiza el presupuesto en la BD con los datos del cliente y el monto Total
        /// </summary>        
        public string Actualizar(ModeloPresupuesto modeloPresupuesto)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("actualizarPresupuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = modeloPresupuesto.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modeloPresupuesto.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = modeloPresupuesto.Apellido;
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = modeloPresupuesto.Email;
                comando.Parameters.Add("@Total", SqlDbType.Decimal).Value = modeloPresupuesto.TotalAlConsumidor;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Update Presupuesto ERROR";                 
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

        public string eliminarPresupuestosIncompletos()
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("eliminarPresupuestosIncompletos", conexion);
                comando.CommandType = CommandType.StoredProcedure;                
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se detectan presupuestos incompletos";
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
