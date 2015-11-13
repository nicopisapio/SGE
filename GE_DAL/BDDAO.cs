using AccesoBD;
using GE_DAL.Excepciones;
using GE_Entities;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Security.BLL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_DAL
{
    public class BDDAO
    {

        public bool RealizarBackupBD()
        {

            bool resultado = false;

            try
            {
                string carpetaBackup = ConfigurationManager.AppSettings["CarpetaBackup"].ToString();
                string baseDeDatos = ConfigurationManager.AppSettings["BaseDeDatos"].ToString();

                if (!Directory.Exists(carpetaBackup))
                {
                    Directory.CreateDirectory(carpetaBackup);
                }

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    //string file = String.Format("{0}{1}-{2}.bak", carpetaBackup, baseDeDatos, DateTime.Now.ToString("yyyy-MM-dd"));

                    //string query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'", baseDeDatos, file);

                    //using (SqlCommand comando = conexion.CreateCommand())
                    //{
                    //    comando.CommandText = query;
                    //    conexion.Open();
                    //    comando.ExecuteNonQuery();
                    //}

                    ServerConnection conexionServer = new ServerConnection(conexion);
                    Server servidor = new Server(conexionServer);

                    Backup backupBD = new Backup();
                    backupBD.Action = BackupActionType.Database;
                    backupBD.Database = baseDeDatos;

                    string archivoBackup = String.Format("{0}{1}-{2}.bak", carpetaBackup, baseDeDatos, DateTime.Now.ToString("yyyy-MM-dd"));

                    BackupDeviceItem deviceItem = new BackupDeviceItem(archivoBackup, DeviceType.File);
                    backupBD.Devices.Add(deviceItem);
                    
                    backupBD.SqlBackup(servidor);
                    
                    conexionServer.Disconnect();

                    resultado = true;
                }

                return resultado;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "RealizarBackupBD", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "RealizarBackupBD", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "RealizarBackupBD", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool RealizarRestoreBD(string rutaArchivo)
        {

            bool resultado = false;

            try
            {

                string baseDeDatos = ConfigurationManager.AppSettings["BaseDeDatos"].ToString();

                if (File.Exists(rutaArchivo))
                {

                    using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQLMaster())
                    {
                        ServerConnection conexionServer = new ServerConnection(conexion);
                        Server servidor = new Server(conexionServer);
                        
                        Restore restoreBD = new Restore();
                        restoreBD.Action = RestoreActionType.Database;
                        restoreBD.Database = baseDeDatos;

                        String query = "ALTER DATABASE " + baseDeDatos + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        using(SqlCommand comando = new SqlCommand(query, conexion))
                        { 
                            comando.Connection.Open();
                            comando.ExecuteNonQuery();
                        }

                        BackupDeviceItem deviceItem = new BackupDeviceItem(rutaArchivo, DeviceType.File);
                        restoreBD.Devices.Add(deviceItem);
                        restoreBD.ReplaceDatabase = true;
                        
                        restoreBD.SqlRestore(servidor);

                        conexionServer.Disconnect();
                    }

                    resultado = true;
                }

                return resultado;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "RealizarRestoreBD", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "RealizarRestoreBD", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "RealizarRestoreBD", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        private List<string> ConsultarDVH(string nombreTabla)
        {

            try
            {
                List<string> registros = new List<string>();

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_DVH_" + nombreTabla;

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            registros.Add(dataReader["DVH"].ToString());
                        }
                    }
                }

                return registros;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "ConsultarDVH", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "ConsultarDVH", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "ConsultarDVH", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarDVVBD(string nombreTabla)
        {

            try
            {

                int filasAfectadas = 0;

                List<string> registros = ConsultarDVH(nombreTabla);

                string valorDVV = GestorHash.ObtenerInstancia().GenerarHashDatos(registros);

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_DVV";
                        comando.Parameters.Add(new SqlParameter("@Tabla", nombreTabla));
                        comando.Parameters.Add(new SqlParameter("@DVV", valorDVV));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "ActualizarDVVBD", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "ActualizarDVVBD", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "ActualizarDVVBD", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public bool VerificarIntegridadBD(string nombreTabla)
        {

            bool resultado = false;

            try
            {
                List<string> registrosHasheados = new List<string>();
                string DVVGenerado; 
                string DVVAlmacenado = String.Empty;

                if (nombreTabla.Equals("USUARIO"))
                {
                    List<Usuario> usuarios = new List<Usuario>();

                    usuarios = GestorUsuario.ObtenerInstancia().ConsultarUsuarios();

                    foreach (Usuario usuario in usuarios)
                    {
                        string hash = GestorHash.ObtenerInstancia().GenerarHashDatos(usuario);

                        if (!hash.Equals(usuario.DVH, StringComparison.Ordinal))
                        {
                            return false;
                        }

                        registrosHasheados.Add(hash);
                    }
                }
                else if (nombreTabla.Equals("RESERVA"))
                {
                    ReservaDAO reservaDAO = new ReservaDAO();

                    List<Reserva> reservas = new List<Reserva>();

                    reservas = reservaDAO.TraerReservas("R");

                    foreach (Reserva reserva in reservas)
                    {
                        string hash = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(reserva));

                        if (!hash.Equals(reserva.DVH, StringComparison.Ordinal))
                        {
                            return false;
                        }

                        registrosHasheados.Add(hash);
                    }
                }
                else if (nombreTabla.Equals("EVENTO"))
                {
                    ReservaDAO reservaDAO = new ReservaDAO();

                    List<Evento> eventos = new List<Evento>();

                    eventos = reservaDAO.ConsultarEventos();

                    foreach (Evento evento in eventos)
                    {
                        string hash = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(evento));

                        if (!hash.Equals(evento.DVH, StringComparison.Ordinal))
                        {
                            return false;
                        }

                        registrosHasheados.Add(hash);
                    }
                }

                DVVGenerado = GestorHash.ObtenerInstancia().GenerarHashDatos(registrosHasheados);

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_DVV";
                        comando.Parameters.Add(new SqlParameter("@Tabla", nombreTabla));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            DVVAlmacenado = dataReader["VALOR"].ToString();
                        }
                    }
                }

                if (string.IsNullOrEmpty(DVVAlmacenado))
                {
                    //resultado = false;
                    throw new DALException("BDDAO", "VerificarIntegridadBD", "Datos", "El DVV obtenido es vacío o incorrecto.", null);
                }

                if (string.IsNullOrEmpty(DVVGenerado))
                {
                    //resultado = false;
                    throw new DALException("BDDAO", "VerificarIntegridadBD", "Datos", "El DVV generado es vacío o incorrecto.", null);
                }

                if (DVVGenerado.Equals(DVVAlmacenado, StringComparison.Ordinal))
                {
                    resultado = true;
                }

                return resultado;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "VerificarIntegridadBD", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "VerificarIntegridadBD", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "VerificarIntegridadBD", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarParametro(string parametro, string valor)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Parametro";
                        comando.Parameters.Add(new SqlParameter("@Nombre", parametro));
                        comando.Parameters.Add(new SqlParameter("@Valor", valor));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "ActualizarParametro", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "ActualizarParametro", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "ActualizarParametro", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public string ConsultarParametro(string parametro)
        {

            try
            {

                string valor = string.Empty;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Parametro";
                        comando.Parameters.Add(new SqlParameter("@Nombre", parametro));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            valor = dataReader["VALOR"].ToString();
                        }
                    }

                }

                return valor;
            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BDDAO", "ConsultarParametro", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BDDAO", "ConsultarParametro", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BDDAO", "ConsultarParametro", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }
    }
}
