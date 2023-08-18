using System;
using System.Data.SqlClient;

namespace CapaPersistencia
{ 
    class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion con;
        public Conexion()
        {
            this.Base = "master";
            this.Servidor = "BDT-NTB-NMIRACC";
            this.Usuario = "nmiracco";
            this.Clave = "nmiracco";
            this.Seguridad = true;
            con = null;

        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server = " + this.Servidor + "; Database = " + this.Base + ";";
                if (this.Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Trusted_Connection = True;";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id = " + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion crearInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
