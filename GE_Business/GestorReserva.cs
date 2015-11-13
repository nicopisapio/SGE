using GE_DAL;
using GE_Entities;
using Security.BLL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Business
{
    public class GestorReserva
    {

        private ReservaDAO reservaDAO = new ReservaDAO();

        private static GestorReserva instancia = new GestorReserva();

        private GestorReserva() { }

        public static GestorReserva ObtenerInstancia()
        {
            return instancia;
        }

        public List<Reserva> ConsultarReservasDelDia(DateTime fecha)
        {

            try
            {
                return reservaDAO.TraerReservasDelDia(fecha);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Reserva> ConsultarReservas(DateTime fecha)
        {

            try
            {
                return reservaDAO.TraerReservas(fecha);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Reserva> ConsultarReservas(string estado, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {
                return reservaDAO.TraerReservas(estado, fechaDesde, fechaHasta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Reserva> ConsultarReservasCliente(Int64 duCliente, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {
                return reservaDAO.TraerReservasCliente(duCliente, fechaDesde, fechaHasta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Reserva> ConsultarReservasEmpleado(Int64 duEmpleado, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {
                return reservaDAO.TraerReservasEmpleado(duEmpleado, fechaDesde, fechaHasta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Reserva ConsultarReserva(Int64 idReserva)
        {

            try
            {
                return reservaDAO.TraerReserva(idReserva);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ValidarHorarioReserva(DateTime fechaDesde, DateTime fechaHasta)
        {

            bool resultado = true;

            try
            {

                List<Reserva> reservas = reservaDAO.TraerReservas(fechaDesde.Date);

                if (reservas != null)
                {
                    foreach (Reserva res in reservas)
                    {

                        if (fechaHasta < res.FechaHoraInicio || fechaDesde > res.FechaHoraFin)
                        {
                            resultado = true && resultado;
                        }
                        else
                        {
                            resultado = false && resultado;
                        }

                    }
                }

                return resultado;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool ValidarHorarioReserva(Reserva reserva, DateTime fechaDesde, DateTime fechaHasta)
        {

            bool resultado = true;

            try
            {

                List<Reserva> reservas = reservaDAO.TraerReservas(fechaDesde.Date);

                reservas.RemoveAll(x => x.ID == reserva.ID);

                if (reservas != null)
                {
                    foreach (Reserva res in reservas)
                    {

                        if (fechaHasta < res.FechaHoraInicio || fechaDesde > res.FechaHoraFin)
                        {
                            resultado = true && resultado;
                        }
                        else
                        {
                            resultado = false && resultado;
                        }

                    }
                }

                return resultado;

            }
            catch (Exception)
            {
                throw;
            }

        }
        
        public Int64 NuevaReserva(DateTime fechaDesde, DateTime fechaHasta, Cliente cliente)
        {

            Reserva nuevaReserva = null;

            try
            {

                if (ValidarHorarioReserva(fechaDesde, fechaHasta))
                {

                    Reserva reserva = new Reserva();
                    reserva.Cliente = cliente;
                    reserva.FechaHoraInicio = fechaDesde;
                    reserva.FechaHoraFin = fechaHasta;
                    reserva.Estado = "I"; //Inicial
                    reserva.Usuario = GestorLogin.ObtenerInstancia().Usuario.Nombre;
                    reserva.FechaHora = DateTime.Now;
                    reserva.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(reserva));

                    Int64 idReserva = reservaDAO.InsertarNuevaReserva(reserva);

                    if (idReserva > 0)
                    {
                        nuevaReserva = reservaDAO.TraerReserva(idReserva);
                        nuevaReserva.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(nuevaReserva));

                        if (reservaDAO.ActualizarReserva(nuevaReserva))
                        {
                            return idReserva;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }

                }
                else
                {
                    return -1;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool ActualizarReserva(Reserva reserva)
        {

            try
            {

                reserva.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(reserva));

                return reservaDAO.ActualizarReserva(reserva);

            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool AgregarEmpleadosReserva(Reserva reserva)
        {

            try
            {
                return reservaDAO.AgregarEmpleadosReserva(reserva);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool EliminarEmpleadosReserva(Reserva reserva)
        {

            try
            {
                return reservaDAO.EliminarEmpleadosReserva(reserva);
            }
            catch (Exception)
            {
                throw;
            }

        }
        
        public List<Cliente> ConsultarClientes()
        {
            try
            {
                return reservaDAO.ConsultarClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Servicio> ConsultarServicios()
        {
            try
            {
                return reservaDAO.ConsultarServicios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Evento> ConsultarEventos()
        {
            try
            {
                return reservaDAO.ConsultarEventos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cargo> ConsultarCargos()
        {
            try
            {
                return reservaDAO.ConsultarCargos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Empleado> ConsultarEmpleados()
        {
            try
            {
                return reservaDAO.ConsultarEmpleados();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double CalcularCostoTiempoExtra(Reserva reserva)
        {

            double resultado = 0;
            int cantBloquesExtra = 0;

            try
            {

                TimeSpan duracion = reserva.FechaHoraFin.Subtract(reserva.FechaHoraInicio);

                if (duracion.TotalHours >= 2.5)
                {
                    cantBloquesExtra = Convert.ToInt32((duracion.TotalHours - 2.5) / 0.5);
                }

                resultado = cantBloquesExtra * reserva.Evento.PrecioBloqueExtra;

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double CalcularCostoServicios(Reserva reserva)
        {

            double resultado = 0;

            try
            {

                foreach (Servicio servicio in reserva.Servicios)
                {
                    resultado += servicio.Precio;
                }

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double CalcularCostoExcedentes(Reserva reserva)
        {

            double resultado = 0;

            try
            {
                
                foreach (Excedente excedente in reserva.Excedentes)
                {
                    resultado += excedente.Monto;
                }

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double CalcularCostoPersonasExtra(Reserva reserva)
        {

            double resultado = 0;

            try
            {

                int cantPersonasMinima = reserva.Evento.CantidadAdultos + reserva.Evento.CantidadNiños;
                int cantPersonas = reserva.CantidadAdultos + reserva.CantidadNiños;

                int decenasExtra = (cantPersonas - cantPersonasMinima) / 10;

                resultado = decenasExtra * reserva.Evento.PrecioDecenaExtra;

                return resultado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public double CalcularCostoTotalReserva(Reserva reserva)
        {

            try
            {

                reserva.MontoTotal = CalcularCostoPersonasExtra(reserva) + CalcularCostoServicios(reserva) + 
                                     CalcularCostoTiempoExtra(reserva) + reserva.Evento.Precio + CalcularCostoExcedentes(reserva);

                return reserva.MontoTotal;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public int CalcularCantidadBebidas(Reserva reserva)
        {

            int cantBebidas = 0;

            try
            {

                double litrosAdultos = reserva.CantidadAdultos * 1.5;
                double litrosNiños = reserva.CantidadNiños;

                cantBebidas = (int)Math.Ceiling((litrosAdultos + litrosNiños) / 2.25);

                reserva.CantidadBebidas = cantBebidas;

                return reserva.CantidadBebidas;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AsignarEmpleadosDisponibles(Reserva reserva)
        {

            try
            {

                double cantidadPersonas = reserva.CantidadAdultos + reserva.CantidadNiños;
                int cantCocineros = (int)Math.Ceiling(cantidadPersonas / 30);
                int cantMozos = (int)Math.Ceiling(cantidadPersonas / 15);

                List<Empleado> empleadosDisponibles = new List<Empleado>(reserva.Empleados);
                empleadosDisponibles.AddRange(reservaDAO.ConsultarEmpleadosDisponibles(reserva.FechaHoraInicio, reserva.FechaHoraFin));

                reserva.Empleados.Clear();
                reserva.Empleados.AddRange(empleadosDisponibles.Where(e => e.Cargo.ID == 1).Take(cantCocineros));
                reserva.Empleados.AddRange(empleadosDisponibles.Where(e => e.Cargo.ID == 2).Take(cantMozos));

            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Empleado> ConsultarEmpleadosDisponibles(Reserva reserva)
        {

            try
            {
                return reservaDAO.ConsultarEmpleadosDisponibles(reserva.FechaHoraInicio, reserva.FechaHoraFin);

            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<HorasSemanales> ConsultarHorasSemanalesTrabajadas(DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
        
            List<DetalleHora> horasTrabajadas = null;

            try
            {
                horasTrabajadas = reservaDAO.ConsultarDetalleHoras(fechaHoraInicio, fechaHoraFin);

                var detalle = horasTrabajadas.GroupBy(x => x.Empleado.DU)
                                             .Select(o => new
                                             {
                                                 Empleado = o.Key,
                                                 Detalle = o.ToList()
                                             })
                                             .ToList();


                List<HorasSemanales> horas = new List<HorasSemanales>();

                foreach (var item in detalle)
                {

                    HorasSemanales hora = new HorasSemanales();

                    foreach (DetalleHora detalleHora in item.Detalle)
                    {
                        hora.Empleado = detalleHora.Empleado;

                        switch (detalleHora.FechaHoraInicio.DayOfWeek)
                        {
                            case DayOfWeek.Friday:
                                hora.Viernes += detalleHora.CantidadHorasTrabajadas;
                                break;
                            case DayOfWeek.Monday:
                                hora.Lunes += detalleHora.CantidadHorasTrabajadas;
                                break;
                            case DayOfWeek.Saturday:
                                hora.Sabado += detalleHora.CantidadHorasTrabajadas;
                                break;
                            case DayOfWeek.Sunday:
                                hora.Domingo += detalleHora.CantidadHorasTrabajadas;
                                break;
                            case DayOfWeek.Thursday:
                                hora.Jueves += detalleHora.CantidadHorasTrabajadas;
                                break;
                            case DayOfWeek.Tuesday:
                                hora.Martes += detalleHora.CantidadHorasTrabajadas;
                                break;
                            case DayOfWeek.Wednesday:
                                hora.Miercoles += detalleHora.CantidadHorasTrabajadas;
                                break;
                            default:
                                break;
                        }
                    }

                    hora.CalcularTotal();

                    horas.Add(hora);
                }

                return horas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<HorasMensuales> ConsultarHorasMensualesTrabajadas(DateTime fechaInicio)
        {

            List<DetalleHora> horasTrabajadas = null;

            try
            {

                horasTrabajadas = reservaDAO.ConsultarDetalleHoras(fechaInicio, fechaInicio.AddMonths(1));

                var detalle = horasTrabajadas.GroupBy(x => x.Empleado.DU)
                                             .Select(o => new
                                             {
                                                 Empleado = o.Key,
                                                 Detalle = o.ToList()
                                             })
                                             .ToList();

                List<HorasMensuales> horasMensuales = new List<HorasMensuales>();

                foreach (var item in detalle)
                {

                    HorasMensuales hora = new HorasMensuales();

                    foreach (DetalleHora detalleHora in item.Detalle)
                    {

                        hora.Empleado = detalleHora.Empleado;

                        DateTime semana1 = new DateTime(detalleHora.FechaHoraInicio.Year, detalleHora.FechaHoraInicio.Month, 1);
                        DateTime semana2 = new DateTime(detalleHora.FechaHoraInicio.Year, detalleHora.FechaHoraInicio.Month, 1).AddDays(7);
                        DateTime semana3 = new DateTime(detalleHora.FechaHoraInicio.Year, detalleHora.FechaHoraInicio.Month, 1).AddDays(14);
                        DateTime semana4 = new DateTime(detalleHora.FechaHoraInicio.Year, detalleHora.FechaHoraInicio.Month, 1).AddDays(21);
                        DateTime semana5 = new DateTime(detalleHora.FechaHoraInicio.Year, detalleHora.FechaHoraInicio.Month, 1).AddDays(28);
                        DateTime ultimoDiaMes = new DateTime(detalleHora.FechaHoraInicio.Year, detalleHora.FechaHoraInicio.Month, 1).AddMonths(1).AddDays(-1);

                        if (detalleHora.FechaHoraInicio >= semana1 && detalleHora.FechaHoraInicio < semana2)
                        {
                            hora.Periodo1 += detalleHora.CantidadHorasTrabajadas;
                        }
                        else if (detalleHora.FechaHoraInicio >= semana2 && detalleHora.FechaHoraInicio < semana3)
                        {
                            hora.Periodo2 += detalleHora.CantidadHorasTrabajadas;
                        }
                        else if (detalleHora.FechaHoraInicio >= semana3 && detalleHora.FechaHoraInicio < semana4)
                        {
                            hora.Periodo3 += detalleHora.CantidadHorasTrabajadas;
                        }
                        else if (detalleHora.FechaHoraInicio >= semana4 && detalleHora.FechaHoraInicio < semana5)
                        {
                            hora.Periodo4 += detalleHora.CantidadHorasTrabajadas;
                        }
                        else if (detalleHora.FechaHoraInicio >= semana5 && detalleHora.FechaHoraInicio < ultimoDiaMes)
                        {
                            hora.Periodo5 += detalleHora.CantidadHorasTrabajadas;
                        }

                    }

                    hora.CalcularTotal();

                    horasMensuales.Add(hora);

                }

                return horasMensuales;

            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public bool InsertarNuevoEvento(Evento evento)
        {

            Evento nuevoEvento = null;

            try
            {

                evento.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(evento));

                int idEvento = reservaDAO.InsertarEvento(evento);

                if (idEvento > 0)
                {
                    nuevoEvento = reservaDAO.ConsultarEvento(idEvento);
                    nuevoEvento.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(nuevoEvento));

                    if (reservaDAO.ActualizarEvento(nuevoEvento))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarEvento(Evento evento)
        {
            try
            {

                evento.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(reservaDAO.GenerarListaDatos(evento));

                return reservaDAO.ActualizarEvento(evento);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarEvento(Evento evento)
        {
            try
            {
                return reservaDAO.EliminarEvento(evento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertarNuevoServicio(Servicio servicio)
        {

            try
            {
                return reservaDAO.InsertarServicio(servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarServicio(Servicio servicio)
        {
            try
            {
                return reservaDAO.ActualizarServicio(servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarServicio(Servicio servicio)
        {
            try
            {
                return reservaDAO.EliminarServicio(servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertarNuevoCargo(Cargo cargo)
        {

            try
            {
                return reservaDAO.InsertarCargo(cargo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarCargo(Cargo cargo)
        {
            try
            {
                return reservaDAO.ActualizarCargo(cargo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarCargo(Cargo cargo)
        {
            try
            {
                return reservaDAO.EliminarCargo(cargo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertarNuevoCliente(Cliente cliente)
        {
            try
            {
                return reservaDAO.InsertarCliente(cliente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertarNuevoEmpleado(Empleado empleado)
        {

            try
            {
                return reservaDAO.InsertarEmpleado(empleado);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                return reservaDAO.ActualizarEmpleado(empleado);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarEmpleado(Empleado empleado)
        {
            try
            {
                return reservaDAO.EliminarEmpleado(empleado);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
    
}
