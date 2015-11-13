using GE_Business;
using GE_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Eventos
{
    public partial class FReserva : Form
    {

        private DateTime fechaSeleccionada;

        public FReserva()
        {
            InitializeComponent();

        }

        private void calFecha_DateChanged(object sender, DateRangeEventArgs e)
        {

            try
            {

                fechaSeleccionada = calFecha.SelectionRange.Start;
                CargarGrilla(fechaSeleccionada);
                
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla(DateTime fecha)
        {
            try
            {
                List<Booking> horarios = new List<Booking>();

                List<Reserva> reservas = GestorReserva.ObtenerInstancia().ConsultarReservasDelDia(fecha);

                if (reservas != null)
                {
                    foreach (Reserva reserva in reservas)
                    {
                        Booking booking = new Booking(reserva.ID, reserva.Cliente.ToString(), reserva.FechaHoraInicio, reserva.FechaHoraFin);
                        horarios.Add(booking);
                    }
                }

                this.gridHorarios.DataSource = horarios;
                this.gridHorarios.Refresh();
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaReservasFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FReserva_Load(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().RecargarIdiomaFormulario(this);
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.TraduccionFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.calFecha.MinDate = DateTime.Now.AddDays(1);
            CargarGrilla(DateTime.Now.AddDays(1).Date);
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            this.grCalendario.Enabled = false;
            this.grNuevaReserva.Enabled = true;
            this.dtpHoraInicio.MinDate = this.calFecha.SelectionRange.Start.AddHours(10);
            this.dtpHoraInicio.MaxDate = this.calFecha.SelectionRange.Start.AddHours(21);
            this.dtpHoraFin.MinDate = this.calFecha.SelectionRange.Start.AddHours(12.5);

            CargarComboClientes();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fechaDesde = this.dtpHoraInicio.Value;
                DateTime fechaHasta = this.dtpHoraFin.Value;

                TimeSpan duracion = fechaHasta.Subtract(fechaDesde);

                if (duracion.TotalHours < 6)
                {
                    if (duracion.TotalMinutes >= 150)
                    {

                        Cliente cliente = (Cliente)this.cboCliente.SelectedItem;

                        if (cliente != null)
                        {
                            Int64 idReservaNueva = GestorReserva.ObtenerInstancia().NuevaReserva(fechaDesde, fechaHasta, cliente);

                            if (idReservaNueva > 0)
                            {
                                if (GestorBD.ObtenerInstancia().ActualizarDVV("RESERVA"))
                                {
                                    MessageBox.Show("Se ha generado la reserva número " + idReservaNueva + " correctamente.", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.grNuevaReserva.Enabled = false;
                                    this.grCalendario.Enabled = true;
                                    fechaSeleccionada = calFecha.SelectionRange.Start;
                                    CargarGrilla(fechaSeleccionada);
                                }
                            }
                            else if (idReservaNueva < 0)
                            {
                                MessageBox.Show("Ya existe otra reserva en ese horario.", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido dar de alta la reserva.", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione al cliente correspondiente.", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("La duración mínima debe ser de 2,5 horas.", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La duración máxima puede ser hasta 6 horas.", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaReservaFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.grNuevaReserva.Enabled = false;
            this.grCalendario.Enabled = true;
        }

        private void CargarComboClientes()
        {
            try
            {
                this.cboCliente.DataSource = null;

                List<Cliente> clientes = GestorReserva.ObtenerInstancia().ConsultarClientes();

                if (clientes != null)
                {
                    this.cboCliente.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaClientesFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FAltaCliente fAltaCliente = new FAltaCliente();

            if (fAltaCliente.ShowDialog() == DialogResult.OK)
            {
                CargarComboClientes();
            }
        }

    }
}
