using AccesoBD;
using GE_DAL.Excepciones;
using GE_Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_DAL
{
    public class ReservaDAO
    {

        public List<Reserva> TraerReservas(DateTime fecha)
        {

            try
            {

                List<Reserva> listaReservas = null;
                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_por_Fecha";
                        comando.Parameters.Add(new SqlParameter("@Fecha", fecha));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaReservas = new List<Reserva>();

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                                listaReservas.Add(reserva);
                            }
                        }
                        
                    }

                }

                return listaReservas;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public List<Reserva> TraerReservas(string estado, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                List<Reserva> listaReservas = null;
                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_por_Estado_y_Fechas";
                        comando.Parameters.Add(new SqlParameter("@Estado", estado));
                        comando.Parameters.Add(new SqlParameter("@FechaDesde", fechaDesde));
                        comando.Parameters.Add(new SqlParameter("@FechaHasta", fechaHasta));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaReservas = new List<Reserva>();

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                                listaReservas.Add(reserva);
                            }
                        }

                    }

                }

                return listaReservas;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public List<Reserva> TraerReservasCliente(long duCliente, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                List<Reserva> listaReservas = null;
                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_por_Cliente_y_Fechas";
                        comando.Parameters.Add(new SqlParameter("@Cliente", duCliente));
                        comando.Parameters.Add(new SqlParameter("@FechaDesde", fechaDesde));
                        comando.Parameters.Add(new SqlParameter("@FechaHasta", fechaHasta));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaReservas = new List<Reserva>();

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                                listaReservas.Add(reserva);
                            }
                        }

                    }

                }

                return listaReservas;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public List<Reserva> TraerReservasEmpleado(long duEmpleado, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                List<Reserva> listaReservas = null;
                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_por_Empleado_y_Fechas";
                        comando.Parameters.Add(new SqlParameter("@Empleado", duEmpleado));
                        comando.Parameters.Add(new SqlParameter("@FechaDesde", fechaDesde));
                        comando.Parameters.Add(new SqlParameter("@FechaHasta", fechaHasta));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaReservas = new List<Reserva>();

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                                listaReservas.Add(reserva);
                            }
                        }

                    }

                }

                return listaReservas;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public List<Reserva> TraerReservas(string estado)
        {

            try
            {

                List<Reserva> listaReservas = null;
                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_por_Estado";
                        comando.Parameters.Add(new SqlParameter("@Estado", estado));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaReservas = new List<Reserva>();

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                                listaReservas.Add(reserva);
                            }
                        }

                    }

                }

                return listaReservas;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReservas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public List<Reserva> TraerReservasDelDia(DateTime fecha)
        {

            try
            {

                List<Reserva> listaReservas = null;
                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_del_Dia";
                        comando.Parameters.Add(new SqlParameter("@Fecha", fecha));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaReservas = new List<Reserva>();

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                                listaReservas.Add(reserva);
                            }
                        }

                    }

                }

                return listaReservas;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservasDelDia", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReservasDelDia", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReservasDelDia", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public Reserva TraerReserva(Int64 idReserva)
        {

            try
            {

                Reserva reserva = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Reserva_Pendiente_por_Id";
                        comando.Parameters.Add(new SqlParameter("@IdReserva", idReserva));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                reserva = new Reserva();

                                reserva.ID = Convert.ToInt64(dataReader["ID"]);
                                reserva.Evento = dataReader["EVENTO"] == DBNull.Value ? null : ConsultarEvento(Convert.ToInt32(dataReader["EVENTO"]));
                                reserva.Cliente = dataReader["CLIENTE"] == DBNull.Value ? null : ConsultarCliente(Convert.ToInt64(dataReader["CLIENTE"]));
                                reserva.Empleados = ConsultarEmpleados(reserva.ID);
                                reserva.Servicios = ConsultarServicios(reserva.ID);
                                reserva.Excedentes = ConsultaExcedentes(reserva.ID);
                                reserva.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                reserva.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                reserva.MontoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);
                                reserva.MontoTotal = Convert.ToDouble(dataReader["MONTO_TOTAL"]);
                                reserva.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                reserva.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);
                                reserva.CantidadBebidas = Convert.ToInt32(dataReader["CANTIDAD_BEBIDAS"]);
                                reserva.Estado = dataReader["ESTADO"].ToString();
                                reserva.Usuario = dataReader["USUARIO"].ToString();
                                reserva.FechaHora = Convert.ToDateTime(dataReader["FECHA_HORA"]);
                                reserva.DVH = dataReader["DVH"].ToString();

                            }
                        }

                    }

                }

                return reserva;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "TraerReserva", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "TraerReserva", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "TraerReserva", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public Evento ConsultarEvento(int idEvento)
        {
            try
            {

                Evento evento = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Evento";
                        comando.Parameters.Add(new SqlParameter("@IdEvento", idEvento));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                evento = new Evento();

                                evento.ID = Convert.ToInt32(dataReader["ID"]);
                                evento.Descripcion = dataReader["DESCRIPCION"].ToString();
                                evento.Precio = Convert.ToDouble(dataReader["PRECIO"]);
                                evento.PrecioBloqueExtra = Convert.ToDouble(dataReader["PRECIO_BLOQUE"]);
                                evento.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                evento.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                evento.PrecioDecenaExtra = Convert.ToDouble(dataReader["PRECIO_DECENA"]);
                                evento.Estado = Convert.ToInt16(dataReader["ESTADO"]);
                                evento.DVH = dataReader["DVH"].ToString();

                            }
                        }

                    }

                }

                return evento;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEvento", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEvento", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEvento", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Evento> ConsultarEventos()
        {
            try
            {

                List<Evento> eventos = null;
                Evento evento = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Evento_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            eventos = new List<Evento>();

                            while (dataReader.Read())
                            {
                                evento = new Evento();

                                evento.ID = Convert.ToInt32(dataReader["ID"]);
                                evento.Descripcion = dataReader["DESCRIPCION"].ToString();
                                evento.Precio = Convert.ToDouble(dataReader["PRECIO"]);
                                evento.PrecioBloqueExtra = Convert.ToDouble(dataReader["PRECIO_BLOQUE"]);
                                evento.CantidadNiños = Convert.ToInt32(dataReader["CANTIDAD_NIÑOS"]);
                                evento.CantidadAdultos = Convert.ToInt32(dataReader["CANTIDAD_ADULTOS"]);
                                evento.PrecioDecenaExtra = Convert.ToDouble(dataReader["PRECIO_DECENA"]);
                                evento.Estado = Convert.ToInt16(dataReader["ESTADO"]);
                                evento.DVH = dataReader["DVH"].ToString();

                                eventos.Add(evento);
                            }

                        }
                    }
                }

                return eventos;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEventos", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEventos", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEventos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public Cliente ConsultarCliente(Int64 duCliente)
        {
            try
            {

                Cliente cliente = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Cliente";
                        comando.Parameters.Add(new SqlParameter("@DuCliente", duCliente));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                cliente = new Cliente();

                                cliente.DU = Convert.ToInt64(dataReader["DU"]);
                                cliente.Apellido = dataReader["APELLIDO"].ToString();
                                cliente.Nombre = dataReader["NOMBRE"].ToString();
                                cliente.Telefono = dataReader["TELEFONO"].ToString();
                                cliente.Direccion = ConsultarDireccion(cliente.DU, "Cliente");
                            }
                        }

                    }

                }

                return cliente;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCliente", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCliente", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCliente", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Cliente> ConsultarClientes()
        {
            try
            {

                List<Cliente> clientes = null;
                Cliente cliente = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Cliente_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            clientes = new List<Cliente>();

                            while (dataReader.Read())
                            {
                                cliente = new Cliente();

                                cliente.DU = Convert.ToInt64(dataReader["DU"]);
                                cliente.Apellido = dataReader["APELLIDO"].ToString();
                                cliente.Nombre = dataReader["NOMBRE"].ToString();
                                cliente.Telefono = dataReader["TELEFONO"].ToString();
                                cliente.Direccion = ConsultarDireccion(cliente.DU, "Cliente");

                                clientes.Add(cliente);
                            }
                        }

                    }

                }

                return clientes;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarClientes", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarClientes", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarClientes", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Empleado> ConsultarEmpleados()
        {
            try
            {

                List<Empleado> listaEmpleados = new List<Empleado>();
                Empleado empleado = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Empleados_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                empleado = new Empleado();

                                empleado.DU = Convert.ToInt64(dataReader["DU"]);
                                empleado.Apellido = dataReader["APELLIDO"].ToString();
                                empleado.Nombre = dataReader["NOMBRE"].ToString();
                                empleado.Telefono = dataReader["TELEFONO"].ToString();
                                empleado.Cargo = ConsultarCargo(Convert.ToInt32(dataReader["CARGO"]));
                                empleado.Direccion = ConsultarDireccion(empleado.DU, "Empleado");
                                empleado.Activo = Convert.ToInt16(dataReader["ESTADO"]) == 0 ? false : true;

                                listaEmpleados.Add(empleado);
                            }
                        }

                    }

                }

                return listaEmpleados;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleados", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleados", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleados", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Empleado> ConsultarEmpleados(Int64 idReserva)
        {
            try
            {

                List<Empleado> listaEmpleados = new List<Empleado>();
                Empleado empleado = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Empleados_Asignados";
                        comando.Parameters.Add(new SqlParameter("@IdReserva", idReserva));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                empleado = new Empleado();

                                empleado.DU = Convert.ToInt64(dataReader["DU"]);
                                empleado.Apellido = dataReader["APELLIDO"].ToString();
                                empleado.Nombre = dataReader["NOMBRE"].ToString();
                                empleado.Telefono = dataReader["TELEFONO"].ToString();
                                empleado.Cargo = ConsultarCargo(Convert.ToInt32(dataReader["CARGO"]));
                                empleado.Direccion = ConsultarDireccion(empleado.DU, "Empleado");

                                listaEmpleados.Add(empleado);
                            }
                        }

                    }

                }

                return listaEmpleados;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleados", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleados", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleados", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Empleado> ConsultarEmpleadosDisponibles(DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            try
            {

                List<Empleado> listaEmpleados = new List<Empleado>();
                Empleado empleado = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Empleados_Disponibles";
                        comando.Parameters.Add(new SqlParameter("@FechaInicio", fechaHoraInicio));
                        comando.Parameters.Add(new SqlParameter("@FechaFin", fechaHoraFin));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                empleado = new Empleado();

                                empleado.DU = Convert.ToInt64(dataReader["DU"]);
                                empleado.Apellido = dataReader["APELLIDO"].ToString();
                                empleado.Nombre = dataReader["NOMBRE"].ToString();
                                empleado.Telefono = dataReader["TELEFONO"].ToString();
                                empleado.Cargo = ConsultarCargo(Convert.ToInt32(dataReader["CARGO"]));
                                empleado.Direccion = ConsultarDireccion(empleado.DU, "Empleado");

                                listaEmpleados.Add(empleado);
                            }
                        }

                    }

                }

                return listaEmpleados;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleadosDisponibles", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleadosDisponibles", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarEmpleadosDisponibles", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public Cargo ConsultarCargo(int idCargo)
        {
            try
            {

                Cargo cargo = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Cargo";
                        comando.Parameters.Add(new SqlParameter("@IdCargo", idCargo));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                cargo = new Cargo();

                                cargo.ID = Convert.ToInt32(dataReader["ID"]);
                                cargo.Descripcion = dataReader["DESCRIPCION"].ToString();
                                cargo.ValorPorHora = Convert.ToDouble(dataReader["VALOR_HORA"]);

                            }
                        }

                    }

                }

                return cargo;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCargo", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCargo", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCargo", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Cargo> ConsultarCargos()
        {
            try
            {

                List<Cargo> cargos = null;
                Cargo cargo = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Cargo_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            cargos = new List<Cargo>();

                            while (dataReader.Read())
                            {
                                cargo = new Cargo();

                                cargo.ID = Convert.ToInt32(dataReader["ID"]);
                                cargo.Descripcion = dataReader["DESCRIPCION"].ToString();
                                cargo.ValorPorHora = Convert.ToDouble(dataReader["VALOR_HORA"]);

                                cargos.Add(cargo);

                            }
                        }

                    }

                }

                return cargos;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCargos", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCargos", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarCargos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Servicio> ConsultarServicios(Int64 idReserva)
        {
            try
            {

                List<Servicio> listaServicios = new List<Servicio>();
                Servicio servicio = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Servicios";
                        comando.Parameters.Add(new SqlParameter("@IdReserva", idReserva));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                servicio = new Servicio();

                                servicio.ID = Convert.ToInt32(dataReader["ID"]);
                                servicio.Descripcion = dataReader["DESCRIPCION"].ToString();
                                servicio.Precio = Convert.ToDouble(dataReader["PRECIO"]);
                                servicio.Estado = Convert.ToInt16(dataReader["ESTADO"]);

                                listaServicios.Add(servicio);
                            }
                        }

                    }

                }

                return listaServicios;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarServicios", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarServicios", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarServicios", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Servicio> ConsultarServicios()
        {
            try
            {

                List<Servicio> listaServicios = null;
                Servicio servicio = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Servicios_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {
                            listaServicios = new List<Servicio>();

                            while (dataReader.Read())
                            {
                                servicio = new Servicio();

                                servicio.ID = Convert.ToInt32(dataReader["ID"]);
                                servicio.Descripcion = dataReader["DESCRIPCION"].ToString();
                                servicio.Precio = Convert.ToDouble(dataReader["PRECIO"]);
                                servicio.Estado = Convert.ToInt16(dataReader["ESTADO"]);

                                listaServicios.Add(servicio);
                            }
                        }

                    }

                }

                return listaServicios;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarServicios", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarServicios", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarServicios", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Excedente> ConsultaExcedentes(Int64 idReserva)
        {
            try
            {

                List<Excedente> excedentes = new List<Excedente>();
                Excedente excedente = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Excedente";
                        comando.Parameters.Add(new SqlParameter("@IdReserva", idReserva));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            excedentes = new List<Excedente>();

                            while (dataReader.Read())
                            {
                                excedente = new Excedente();

                                excedente.ID = Convert.ToInt32(dataReader["ID"]);
                                excedente.Monto = Convert.ToDouble(dataReader["MONTO"].ToString());

                                excedentes.Add(excedente);

                            }
                        }

                    }

                }

                return excedentes;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultaExcedentes", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultaExcedentes", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultaExcedentes", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public Int64 InsertarNuevaReserva(Reserva reserva)
        {
            try
            {

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Reserva";
                        comando.Parameters.Add(new SqlParameter("@DuCliente", reserva.Cliente.DU));
                        comando.Parameters.Add(new SqlParameter("@FechaHoraInicio", reserva.FechaHoraInicio));
                        comando.Parameters.Add(new SqlParameter("@FechaHoraFin", reserva.FechaHoraFin));
                        comando.Parameters.Add(new SqlParameter("@Estado", reserva.Estado));
                        comando.Parameters.Add(new SqlParameter("@Usuario", reserva.Usuario));
                        comando.Parameters.Add(new SqlParameter("@FechaHora", reserva.FechaHora));
                        comando.Parameters.Add(new SqlParameter("@DVH", reserva.DVH));

                        comando.Connection.Open();

                        reserva.ID = Convert.ToInt64(comando.ExecuteScalar());

                    }
                }

                return reserva.ID;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "InsertarNuevaReserva", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "InsertarNuevaReserva", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "InsertarNuevaReserva", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarReserva(Reserva reserva)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Reserva";
                        comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.ID));
                        if (reserva.Evento != null) { comando.Parameters.Add(new SqlParameter("@Evento", reserva.Evento.ID)); }
                        if (reserva.Cliente != null) { comando.Parameters.Add(new SqlParameter("@Cliente", reserva.Cliente.DU)); }
                        comando.Parameters.Add(new SqlParameter("@CantidadNiños", reserva.CantidadNiños));
                        comando.Parameters.Add(new SqlParameter("@CantidadAdultos", reserva.CantidadAdultos));
                        comando.Parameters.Add(new SqlParameter("@MontoPagado", reserva.MontoPagado));
                        comando.Parameters.Add(new SqlParameter("@MontoTotal", reserva.MontoTotal));
                        comando.Parameters.Add(new SqlParameter("@FechaHoraInicio", reserva.FechaHoraInicio));
                        comando.Parameters.Add(new SqlParameter("@FechaHoraFin", reserva.FechaHoraFin));
                        comando.Parameters.Add(new SqlParameter("@CantidadBebidas", reserva.CantidadBebidas));
                        comando.Parameters.Add(new SqlParameter("@Estado", reserva.Estado));
                        comando.Parameters.Add(new SqlParameter("@Usuario", reserva.Usuario));
                        comando.Parameters.Add(new SqlParameter("@FechaHora", reserva.FechaHora));
                        comando.Parameters.Add(new SqlParameter("@DVH", reserva.DVH));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                        if (reserva.Servicios != null)
                        {
                            comando.CommandText = "SPU_Reserva_Servicio";

                            foreach (Servicio ser in reserva.Servicios)
                            {
                                comando.Parameters.Clear();
                                comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.ID));
                                comando.Parameters.Add(new SqlParameter("@IdServicio", ser.ID));

                                comando.ExecuteNonQuery();
                            }
                        }

                        if (reserva.Empleados != null)
                        {
                            comando.CommandText = "SPU_Reserva_Empleado";

                            foreach (Empleado emp in reserva.Empleados)
                            {
                                comando.Parameters.Clear();
                                comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.ID));
                                comando.Parameters.Add(new SqlParameter("@IdEmpleado", emp.DU));

                                comando.ExecuteNonQuery();
                            }
                        }

                        if (reserva.Excedentes != null)
                        {
                            comando.CommandText = "SPI_Excedente";

                            foreach (Excedente exc in reserva.Excedentes)
                            {
                                if (exc.ID == 0)
                                {
                                    comando.Parameters.Clear();
                                    comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.ID));
                                    comando.Parameters.Add(new SqlParameter("@Monto", exc.Monto));

                                    comando.ExecuteNonQuery();
                                }
                            }
                        }

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
                throw new DALException("ReservaDAO", "ActualizarReserva", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ActualizarReserva", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ActualizarReserva", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool AgregarEmpleadosReserva(Reserva reserva)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Connection.Open();

                        if (reserva.Empleados != null)
                        {
                            comando.CommandText = "SPU_Reserva_Empleado";

                            foreach (Empleado emp in reserva.Empleados)
                            {
                                comando.Parameters.Clear();
                                comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.ID));
                                comando.Parameters.Add(new SqlParameter("@IdEmpleado", emp.DU));

                                filasAfectadas += comando.ExecuteNonQuery();
                            }
                        }

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
                throw new DALException("ReservaDAO", "ActualizarReserva", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ActualizarReserva", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ActualizarReserva", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarEmpleadosReserva(Reserva reserva)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Connection.Open();

                        if (reserva.Empleados != null)
                        {
                            comando.CommandText = "SPD_Reserva_Empleado";

                            foreach (Empleado emp in reserva.Empleados)
                            {
                                comando.Parameters.Clear();
                                comando.Parameters.Add(new SqlParameter("@IdReserva", reserva.ID));
                                comando.Parameters.Add(new SqlParameter("@IdEmpleado", emp.DU));

                                filasAfectadas += comando.ExecuteNonQuery();
                            }
                        }

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
                throw new DALException("ReservaDAO", "EliminarEmpleadoReserva", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "EliminarEmpleadoReserva", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "EliminarEmpleadoReserva", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<String> GenerarListaDatos(Reserva reserva)
        {
            try
            {

                List<String> datos = new List<string>();

                datos.Add(reserva.ID.ToString(CultureInfo.InvariantCulture));
                if (reserva.Evento != null) { datos.Add(reserva.Evento.ID.ToString(CultureInfo.InvariantCulture)); }
                if (reserva.Cliente != null) { datos.Add(reserva.Cliente.DU.ToString(CultureInfo.InvariantCulture)); }
                datos.Add(reserva.CantidadNiños.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.CantidadAdultos.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.MontoPagado.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.MontoTotal.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.FechaHoraInicio.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.FechaHoraFin.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.CantidadBebidas.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.Estado.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.Usuario.ToString(CultureInfo.InvariantCulture));
                datos.Add(reserva.FechaHora.ToString(CultureInfo.InvariantCulture));

                return datos;
            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "GenerarListaDatos", "AccesoBD", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "GenerarListaDatos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<String> GenerarListaDatos(Evento evento)
        {
            try
            {

                List<String> datos = new List<string>();

                datos.Add(evento.ID.ToString(CultureInfo.InvariantCulture));
                datos.Add(evento.Precio.ToString(CultureInfo.InvariantCulture));
                datos.Add(evento.PrecioBloqueExtra.ToString(CultureInfo.InvariantCulture));
                datos.Add(evento.CantidadNiños.ToString(CultureInfo.InvariantCulture));
                datos.Add(evento.CantidadAdultos.ToString(CultureInfo.InvariantCulture));
                datos.Add(evento.PrecioDecenaExtra.ToString(CultureInfo.InvariantCulture));
                datos.Add(evento.Estado.ToString(CultureInfo.InvariantCulture));

                return datos;
            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "GenerarListaDatos", "AccesoBD", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "GenerarListaDatos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<DetalleHora> ConsultarDetalleHoras(DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            try
            {

                List<DetalleHora> listaHoras = new List<DetalleHora>();
                DetalleHora detalleHora = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Detalle_Horas_Trabajadas";
                        comando.Parameters.Add(new SqlParameter("@FechaHoraInicio", fechaHoraInicio));
                        comando.Parameters.Add(new SqlParameter("@FechaHoraFin", fechaHoraFin));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                detalleHora = new DetalleHora();

                                detalleHora.Empleado = new Empleado();
                                detalleHora.Empleado.DU = Convert.ToInt64(dataReader["DU"]);
                                detalleHora.Empleado.Apellido = dataReader["APELLIDO"].ToString();
                                detalleHora.Empleado.Nombre = dataReader["NOMBRE"].ToString();
                                detalleHora.Empleado.Telefono = dataReader["TELEFONO"].ToString();
                                detalleHora.Empleado.Cargo = ConsultarCargo(Convert.ToInt32(dataReader["CARGO"]));

                                detalleHora.FechaHoraInicio = Convert.ToDateTime(dataReader["FECHA_HORA_INICIO"]);
                                detalleHora.FechaHoraFin = Convert.ToDateTime(dataReader["FECHA_HORA_FIN"]);

                                detalleHora.CalcularHorasTrabajadas();

                                listaHoras.Add(detalleHora);
                            }
                        }

                    }

                }

                return listaHoras;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarDetalleHoras", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarDetalleHoras", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarDetalleHoras", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public Int32 InsertarEvento(Evento evento)
        {
            try
            {

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Evento";
                        comando.Parameters.Add(new SqlParameter("@Descripcion", evento.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@Precio", evento.Precio));
                        comando.Parameters.Add(new SqlParameter("@PrecioBloque", evento.PrecioBloqueExtra));
                        comando.Parameters.Add(new SqlParameter("@CantidadNiños", evento.CantidadNiños));
                        comando.Parameters.Add(new SqlParameter("@CantidadAdultos", evento.CantidadAdultos));
                        comando.Parameters.Add(new SqlParameter("@PrecioDecena", evento.PrecioDecenaExtra));
                        comando.Parameters.Add(new SqlParameter("@Estado", evento.Estado));
                        comando.Parameters.Add(new SqlParameter("@DVH", evento.DVH));

                        comando.Connection.Open();

                        evento.ID = Convert.ToInt32(comando.ExecuteScalar());

                    }
                }

                return evento.ID;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "InsertarEvento", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "InsertarEvento", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "InsertarEvento", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarEvento(Evento evento)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Evento";
                        comando.Parameters.Add(new SqlParameter("@IdEvento", evento.ID));
                        comando.Parameters.Add(new SqlParameter("@Descripcion", evento.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@Precio", evento.Precio));
                        comando.Parameters.Add(new SqlParameter("@PrecioBloque", evento.PrecioBloqueExtra));
                        comando.Parameters.Add(new SqlParameter("@CantidadNiños", evento.CantidadNiños));
                        comando.Parameters.Add(new SqlParameter("@CantidadAdultos", evento.CantidadAdultos));
                        comando.Parameters.Add(new SqlParameter("@PrecioDecena", evento.PrecioDecenaExtra));
                        comando.Parameters.Add(new SqlParameter("@Estado", evento.Estado));
                        comando.Parameters.Add(new SqlParameter("@DVH", evento.DVH));

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
                throw new DALException("ReservaDAO", "ActualizarEvento", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ActualizarEvento", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ActualizarEvento", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarEvento(Evento evento)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPD_Evento";
                        comando.Parameters.Add(new SqlParameter("@IdEvento", evento.ID));

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
                throw new DALException("ReservaDAO", "EliminarEvento", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "EliminarEvento", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "EliminarEvento", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarServicio(Servicio servicio)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Servicio";
                        comando.Parameters.Add(new SqlParameter("@Descripcion", servicio.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@Precio", servicio.Precio));
                        comando.Parameters.Add(new SqlParameter("@Estado", servicio.Estado));
                        
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
                throw new DALException("ReservaDAO", "InsertarServicio", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "InsertarServicio", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "InsertarServicio", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarServicio(Servicio servicio)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Servicio";
                        comando.Parameters.Add(new SqlParameter("@IdServicio", servicio.ID));
                        comando.Parameters.Add(new SqlParameter("@Descripcion", servicio.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@Precio", servicio.Precio));
                        comando.Parameters.Add(new SqlParameter("@Estado", servicio.Estado));
                        
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
                throw new DALException("ReservaDAO", "ActualizarServicio", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ActualizarServicio", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ActualizarServicio", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarServicio(Servicio servicio)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPD_Servicio";
                        comando.Parameters.Add(new SqlParameter("@IdServicio", servicio.ID));

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
                throw new DALException("ReservaDAO", "EliminarServicio", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "EliminarServicio", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "EliminarServicio", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarCargo(Cargo cargo)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Cargo";
                        comando.Parameters.Add(new SqlParameter("@Descripcion", cargo.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@ValorHora", cargo.ValorPorHora));

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
                throw new DALException("ReservaDAO", "InsertarCargo", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "InsertarCargo", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "InsertarCargo", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarCargo(Cargo cargo)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Cargo";
                        comando.Parameters.Add(new SqlParameter("@IdCargo", cargo.ID));
                        comando.Parameters.Add(new SqlParameter("@Descripcion", cargo.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@ValorHora", cargo.ValorPorHora));

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
                throw new DALException("ReservaDAO", "ActualizarCargo", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ActualizarCargo", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ActualizarCargo", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarCargo(Cargo cargo)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPD_Cargo";
                        comando.Parameters.Add(new SqlParameter("@IdCargo", cargo.ID));

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
                throw new DALException("ReservaDAO", "EliminarCargo", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "EliminarCargo", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "EliminarCargo", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarCliente(Cliente cliente)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Cliente";
                        comando.Parameters.Add(new SqlParameter("@DU", cliente.DU));
                        comando.Parameters.Add(new SqlParameter("@Apellido", cliente.Apellido));
                        comando.Parameters.Add(new SqlParameter("@Nombre", cliente.Nombre));
                        comando.Parameters.Add(new SqlParameter("@Telefono", cliente.Telefono));

                        comando.Connection.Open();

                        filasAfectadas += comando.ExecuteNonQuery();

                        if (cliente.Direccion != null)
                        {
                            comando.CommandText = "SPI_Direccion";
                            comando.Parameters.Clear();
                            comando.Parameters.Add(new SqlParameter("@DUEmpleado", DBNull.Value));
                            comando.Parameters.Add(new SqlParameter("@DUCliente", cliente.DU));
                            comando.Parameters.Add(new SqlParameter("@Calle", cliente.Direccion.Calle));
                            comando.Parameters.Add(new SqlParameter("@Altura", cliente.Direccion.Altura));
                            comando.Parameters.Add(new SqlParameter("@Localidad", cliente.Direccion.Localidad));
                            comando.Parameters.Add(new SqlParameter("@Piso", cliente.Direccion.Piso));
                            comando.Parameters.Add(new SqlParameter("@Departamento", cliente.Direccion.Departamento));

                            comando.ExecuteNonQuery();
                        }

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
                throw new DALException("ReservaDAO", "InsertarCliente", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "InsertarCliente", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "InsertarCliente", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public Direccion ConsultarDireccion(Int64 du, string tipoPersona)
        {
            try
            {

                Direccion direccion = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Direccion_" + tipoPersona;
                        comando.Parameters.Add(new SqlParameter("@DU" + tipoPersona, du));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                direccion = new Direccion();

                                direccion.Calle = dataReader["CALLE"].ToString();
                                direccion.Altura = Convert.ToInt32(dataReader["ALTURA"]);
                                direccion.Localidad = dataReader["LOCALIDAD"].ToString();
                                direccion.Piso = Convert.ToInt32(dataReader["PISO"]);
                                direccion.Departamento = dataReader["DEPARTAMENTO"].ToString();

                            }
                        }

                    }

                }

                return direccion;

            }
            catch (AccesoBDException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarDireccion", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ConsultarDireccion", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ConsultarDireccion", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarEmpleado(Empleado empleado)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Empleado";
                        comando.Parameters.Add(new SqlParameter("@DU", empleado.DU));
                        comando.Parameters.Add(new SqlParameter("@Apellido", empleado.Apellido));
                        comando.Parameters.Add(new SqlParameter("@Nombre", empleado.Nombre));
                        comando.Parameters.Add(new SqlParameter("@Telefono", empleado.Telefono));
                        comando.Parameters.Add(new SqlParameter("@Cargo", empleado.Cargo.ID));
                        comando.Parameters.Add(new SqlParameter("@Estado", empleado.Activo));

                        comando.Connection.Open();

                        filasAfectadas += comando.ExecuteNonQuery();

                        if (empleado.Direccion != null)
                        {
                            comando.CommandText = "SPI_Direccion";
                            comando.Parameters.Clear();
                            comando.Parameters.Add(new SqlParameter("@DUEmpleado", empleado.DU));
                            comando.Parameters.Add(new SqlParameter("@DUCliente", DBNull.Value));
                            comando.Parameters.Add(new SqlParameter("@Calle", empleado.Direccion.Calle));
                            comando.Parameters.Add(new SqlParameter("@Altura", empleado.Direccion.Altura));
                            comando.Parameters.Add(new SqlParameter("@Localidad", empleado.Direccion.Localidad));
                            comando.Parameters.Add(new SqlParameter("@Piso", empleado.Direccion.Piso));
                            comando.Parameters.Add(new SqlParameter("@Departamento", empleado.Direccion.Departamento));

                            comando.ExecuteNonQuery();
                        }

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
                throw new DALException("ReservaDAO", "InsertarEmpleado", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "InsertarEmpleado", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "InsertarEmpleado", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarEmpleado(Empleado empleado)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Empleado";
                        comando.Parameters.Add(new SqlParameter("@DU", empleado.DU));
                        comando.Parameters.Add(new SqlParameter("@Apellido", empleado.Apellido));
                        comando.Parameters.Add(new SqlParameter("@Nombre", empleado.Nombre));
                        comando.Parameters.Add(new SqlParameter("@Telefono", empleado.Telefono));
                        comando.Parameters.Add(new SqlParameter("@Cargo", empleado.Cargo.ID));
                        comando.Parameters.Add(new SqlParameter("@Estado", empleado.Activo));

                        comando.Connection.Open();

                        filasAfectadas += comando.ExecuteNonQuery();

                        if (empleado.Direccion != null)
                        {
                            comando.CommandText = "SPI_Direccion";
                            comando.Parameters.Clear();
                            comando.Parameters.Add(new SqlParameter("@DUEmpleado", empleado.DU));
                            comando.Parameters.Add(new SqlParameter("@DUCliente", DBNull.Value));
                            comando.Parameters.Add(new SqlParameter("@Calle", empleado.Direccion.Calle));
                            comando.Parameters.Add(new SqlParameter("@Altura", empleado.Direccion.Altura));
                            comando.Parameters.Add(new SqlParameter("@Localidad", empleado.Direccion.Localidad));
                            comando.Parameters.Add(new SqlParameter("@Piso", empleado.Direccion.Piso));
                            comando.Parameters.Add(new SqlParameter("@Departamento", empleado.Direccion.Departamento));

                            comando.ExecuteNonQuery();
                        }

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
                throw new DALException("ReservaDAO", "ActualizarEmpleado", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "ActualizarEmpleado", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "ActualizarEmpleado", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarEmpleado(Empleado empleado)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Connection.Open();

                        if (empleado.Direccion != null)
                        {
                            comando.CommandText = "SPD_Direccion";
                            comando.Parameters.Add(new SqlParameter("@DUEmpleado", empleado.DU));
                            comando.Parameters.Add(new SqlParameter("@DUCliente", DBNull.Value));

                            comando.ExecuteNonQuery();
                        }

                        comando.CommandText = "SPD_Empleado";
                        comando.Parameters.Clear();
                        comando.Parameters.Add(new SqlParameter("@DU", empleado.DU));

                        filasAfectadas += comando.ExecuteNonQuery();

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
                throw new DALException("ReservaDAO", "EliminarEmpleado", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DALException("ReservaDAO", "EliminarEmpleado", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new DALException("ReservaDAO", "EliminarEmpleado", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

    }
}
