using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AccesoBD
{
    public class Conexion
    {

        private static Conexion instancia = new Conexion();
        private string nombreConexion = ConfigurationManager.AppSettings["NombreConexion"].ToString();
        private string masterConexion = ConfigurationManager.AppSettings["MasterConexion"].ToString();

        private Conexion() { }

        public static Conexion ObtenerInstancia()
        {
            return instancia;
        }

        public SqlConnection CrearConexionSQL()
        {

            string connectionString = string.Empty;

            try
            {
                connectionString = ConfigurationManager.ConnectionStrings[nombreConexion].ConnectionString;

                SqlConnection conexion = new SqlConnection(connectionString);

                return conexion;
            }
            catch (Exception ex)
            {
                throw new AccesoBDException(connectionString, ex.Message, ex);
            }
        }

        public SqlConnection CrearConexionSQLMaster()
        {

            string connectionString = string.Empty;

            try
            {
                connectionString = ConfigurationManager.ConnectionStrings[masterConexion].ConnectionString;

                SqlConnection conexion = new SqlConnection(connectionString);

                return conexion;
            }
            catch (Exception ex)
            {
                throw new AccesoBDException(connectionString, ex.Message, ex);
            }

        }
    }
}
