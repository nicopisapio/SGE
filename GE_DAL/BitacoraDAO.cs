using AccesoBD;
using GE_DAL.Excepciones;
using GE_Entities;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_DAL
{
    public class BitacoraDAO
    {

        public bool InsertarBitacoraBD(Bitacora bitacora)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Bitacora";
                        comando.Parameters.Add(new SqlParameter("@IdUsuario", bitacora.IDUsuario));
                        comando.Parameters.Add(new SqlParameter("@Tipo", bitacora.Tipo));
                        comando.Parameters.Add(new SqlParameter("@Mensaje", bitacora.Mensaje));
                        comando.Parameters.Add(new SqlParameter("@FechaHora", bitacora.FechaHora));

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
                throw new DALException("BitacoraDAO", "InsertarBitacoraBD", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BitacoraDAO", "InsertarBitacoraBD", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BitacoraDAO", "InsertarBitacoraBD", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Bitacora> ConsultarBitacora(string tipo)
        {

            try
            {

                List<Bitacora> resultadoBitacora = null;
                Bitacora bitacora = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Bitacora_por_Tipo";
                        comando.Parameters.Add(new SqlParameter("@Tipo", tipo));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            resultadoBitacora = new List<Bitacora>();

                            while (dataReader.Read())
                            {
                                bitacora = new Bitacora();

                                bitacora.ID = Convert.ToInt64(dataReader["ID"]);
                                bitacora.IDUsuario = dataReader["ID_USUARIO"].ToString();
                                bitacora.Tipo = dataReader["TIPO"].ToString();
                                bitacora.Mensaje = dataReader["MENSAJE"].ToString();
                                bitacora.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);

                                resultadoBitacora.Add(bitacora);
                            }
                        }

                    }

                }

                return resultadoBitacora;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
            
        }

        public List<Bitacora> ConsultarBitacora(DateTime fecha)
        {

            try
            {

                List<Bitacora> resultadoBitacora = null;
                Bitacora bitacora = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Bitacora_por_Fecha";
                        comando.Parameters.Add(new SqlParameter("@Fecha", fecha));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            resultadoBitacora = new List<Bitacora>();

                            while (dataReader.Read())
                            {
                                bitacora = new Bitacora();

                                bitacora.ID = Convert.ToInt64(dataReader["ID"]);
                                bitacora.IDUsuario = dataReader["ID_USUARIO"].ToString();
                                bitacora.Tipo = dataReader["TIPO"].ToString();
                                bitacora.Mensaje = dataReader["MENSAJE"].ToString();
                                bitacora.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);

                                resultadoBitacora.Add(bitacora);
                            }
                        }

                    }

                }

                return resultadoBitacora;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Bitacora> ConsultarBitacora(string tipo, DateTime fecha)
        {

            try
            {

                List<Bitacora> resultadoBitacora = null;
                Bitacora bitacora = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Bitacora_por_Tipo_y_Fecha";
                        comando.Parameters.Add(new SqlParameter("@Tipo", tipo));
                        comando.Parameters.Add(new SqlParameter("@Fecha", fecha));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            resultadoBitacora = new List<Bitacora>();

                            while (dataReader.Read())
                            {
                                bitacora = new Bitacora();

                                bitacora.ID = Convert.ToInt64(dataReader["ID"]);
                                bitacora.IDUsuario = dataReader["ID_USUARIO"].ToString();
                                bitacora.Tipo = dataReader["TIPO"].ToString();
                                bitacora.Mensaje = dataReader["MENSAJE"].ToString();
                                bitacora.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);

                                resultadoBitacora.Add(bitacora);
                            }
                        }
                    }

                }

                return resultadoBitacora;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Bitacora> ConsultarBitacora(string tipo, DateTime fecha, Usuario usuario)
        {

            try
            {

                List<Bitacora> resultadoBitacora = null;
                Bitacora bitacora = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Bitacora_por_Tipo_Fecha_y_Usuario";
                        comando.Parameters.Add(new SqlParameter("@Tipo", tipo));
                        comando.Parameters.Add(new SqlParameter("@Fecha", fecha));
                        comando.Parameters.Add(new SqlParameter("@IdUsuario", usuario.Nombre));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            resultadoBitacora = new List<Bitacora>();

                            while (dataReader.Read())
                            {
                                bitacora = new Bitacora();

                                bitacora.ID = Convert.ToInt64(dataReader["ID"]);
                                bitacora.IDUsuario = dataReader["ID_USUARIO"].ToString();
                                bitacora.Tipo = dataReader["TIPO"].ToString();
                                bitacora.Mensaje = dataReader["MENSAJE"].ToString();
                                bitacora.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);

                                resultadoBitacora.Add(bitacora);
                            }
                        }
                    }

                }

                return resultadoBitacora;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Bitacora> ConsultarBitacora(DateTime fecha, Usuario usuario)
        {

            try
            {

                List<Bitacora> resultadoBitacora = null;
                Bitacora bitacora = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Bitacora_por_Fecha_y_Usuario";
                        comando.Parameters.Add(new SqlParameter("@Fecha", fecha));
                        comando.Parameters.Add(new SqlParameter("@IdUsuario", usuario.Nombre));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            resultadoBitacora = new List<Bitacora>();

                            while (dataReader.Read())
                            {
                                bitacora = new Bitacora();

                                bitacora.ID = Convert.ToInt64(dataReader["ID"]);
                                bitacora.IDUsuario = dataReader["ID_USUARIO"].ToString();
                                bitacora.Tipo = dataReader["TIPO"].ToString();
                                bitacora.Mensaje = dataReader["MENSAJE"].ToString();
                                bitacora.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);

                                resultadoBitacora.Add(bitacora);
                            }
                        }
                    }

                }

                return resultadoBitacora;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("BitacoraDAO", "ConsultarBitacora", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }
        
    }
}
