﻿using CapaModelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaPersistencia
{
    public class PersistenciaPresupuesto { 
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
                //System.Diagnostics.Debug.WriteLine("Salida: " + res);                
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

        public string Insertar(ModeloPresupuesto modeloPresupuesto)
        {
            string respuesta = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("insertarPresupuesto", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = modeloPresupuesto.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modeloPresupuesto.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = modeloPresupuesto.Apellido;
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = modeloPresupuesto.Email;
                comando.Parameters.Add("@Total", SqlDbType.Decimal).Value = modeloPresupuesto.Total;
                comando.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = modeloPresupuesto.IdVehiculo;
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