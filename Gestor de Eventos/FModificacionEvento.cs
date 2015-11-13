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
    public partial class FModificacionEvento : Form
    {

        Reserva reserva;

        public FModificacionEvento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value.Date;
                DateTime fechaHasta = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);
                Int64 duCliente = 0;

                Int64.TryParse(this.txtClienteDU.Text, out duCliente);

                if (fechaHasta > fechaDesde)
                {

                    if (duCliente > 0)
                    {
                        List<Reserva> reservas = GestorReserva.ObtenerInstancia().ConsultarReservasCliente(duCliente, fechaDesde, fechaHasta);

                        if (reservas != null)
                        {
                            gridReserva.DataSource = reservas.ToArray();
                        }
                        else
                        {
                            gridReserva.DataSource = null;
                            MessageBox.Show("No se han encontrado coincidencias.", "Detalle de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un DU válido.", "Detalle de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La Fecha Hasta debe ser mayor que la Fecha Desde.", "Detalle de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaReservasFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridReserva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.gridReserva.Rows.Count > 0)
                {
                    reserva = (Reserva)this.gridReserva.CurrentRow.DataBoundItem;

                    if (reserva != null)
                    {
                        CargarDatos(reserva);
                        HabilitarControles(true);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos(Reserva reserva)
        {

            this.lblTipoEvento2.Text = reserva.Evento.Descripcion;
            this.lblAdultos2.Text = reserva.CantidadAdultos.ToString();
            this.lblNiños2.Text = reserva.CantidadNiños.ToString();
            this.listServicios.DataSource = reserva.Servicios.ToArray();
            this.lblFecha2.Text = reserva.FechaHoraInicio.ToShortDateString();
            this.lblHoraInicio2.Text = reserva.FechaHoraInicio.TimeOfDay.ToString();
            this.lblHoraFin2.Text = reserva.FechaHoraFin.TimeOfDay.ToString();
            this.lblCantidadHoras2.Text = reserva.FechaHoraFin.Subtract(reserva.FechaHoraInicio).TotalHours.ToString();
            this.lblMontoPagado2.Text = reserva.MontoPagado.ToString("C2");
            this.lblMontoTotalAnt2.Text = reserva.MontoTotal.ToString("C2");

            if (reserva.Estado == "R")
            {
                this.gbDetalleEvento.Enabled = true;
            }
            else
            {
                gbDetalleEvento.Enabled = false;
            }
        }

        private void CargaComboServicios()
        {

            this.cboServicios.DataSource = null;

            try
            {

                List<Servicio> servicios = GestorReserva.ObtenerInstancia().ConsultarServicios();

                if (servicios != null)
                {
                    this.cboServicios.DataSource = servicios;
                    this.cboServicios.DisplayMember = "Descripcion";
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaServiciosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FModificacionEvento_Load(object sender, EventArgs e)
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

            CargaComboServicios();
            HabilitarControles(false);
        }

        private void btnAgregarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoPersona = this.cboPersonas.SelectedItem != null ? this.cboPersonas.SelectedItem.ToString() : string.Empty;

                if (!string.IsNullOrWhiteSpace(tipoPersona))
                {
                    int cant = 0;

                    if (tipoPersona == "Adultos")
                    {
                        reserva.CantidadAdultos += 10;
                        cant = Convert.ToInt32(this.lblAdultos2.Text);
                        cant += 10;
                        this.lblAdultos2.Text = cant.ToString();
                    }
                    else
                    {
                        reserva.CantidadNiños += 10;
                        cant = Convert.ToInt32(this.lblNiños2.Text);
                        cant += 10;
                        this.lblNiños2.Text = cant.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoPersona = this.cboPersonas.SelectedItem != null ? this.cboPersonas.SelectedItem.ToString() : string.Empty;

                if (!string.IsNullOrWhiteSpace(tipoPersona))
                {
                    int cant = 0;
                    int cantMinima = 0;

                    if (tipoPersona == "Adultos")
                    {

                        cantMinima = reserva.Evento.CantidadAdultos;

                        if (!(cantMinima > reserva.CantidadAdultos - 10))
                        {
                            reserva.CantidadAdultos -= 10;
                            cant = Convert.ToInt32(this.lblAdultos2.Text);
                            cant -= 10;
                            this.lblAdultos2.Text = cant.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No puede quitar menos del mínimo de personas para el tipo de evento.", "Modificación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {

                        cantMinima = reserva.Evento.CantidadNiños;

                        if (!(cantMinima > reserva.CantidadNiños - 10))
                        {
                            reserva.CantidadNiños -= 10;
                            cant = Convert.ToInt32(this.lblNiños2.Text);
                            cant -= 10;
                            this.lblNiños2.Text = cant.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No puede quitar menos del mínimo de personas para el tipo de evento.", "Modificación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false);
        }

        private void LimpiarControles()
        {

            reserva = null;

            this.txtClienteDU.Clear();
            this.txtPago.Clear();

            this.listServicios.Items.Clear();

            this.gbDetalleEvento.Enabled = false;

            this.lblTipoEvento2.Text = "-";
            this.lblAdultos2.Text = "0";
            this.lblNiños2.Text = "0";
            this.listServicios.DataSource = null;
            this.lblFecha2.Text = "-";
            this.lblHoraInicio2.Text = "-";
            this.lblHoraFin2.Text = "-";
            this.lblCantidadHoras2.Text = "-";
            this.lblMontoPagado2.Text = 0.ToString("C2");
            this.lblMontoTotalAnt2.Text = 0.ToString("C2");
            this.lblMontoTotalNvo2.Text = 0.ToString("C2");
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio servicio = (Servicio)this.cboServicios.SelectedItem;

                if (servicio != null)
                {
                    reserva.AgregarServicio(servicio);
                }

                this.listServicios.DataSource = reserva.Servicios.ToArray();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio servicio = (Servicio)this.cboServicios.SelectedItem;

                if (servicio != null)
                {
                    reserva.QuitarServicio(servicio);
                }

                this.listServicios.DataSource = reserva.Servicios.ToArray();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDuracion_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime nuevaHoraFin = reserva.FechaHoraFin.AddMinutes(30);

                if (GestorReserva.ObtenerInstancia().ValidarHorarioReserva(reserva, reserva.FechaHoraInicio, nuevaHoraFin))
                {
                    reserva.FechaHoraFin = nuevaHoraFin;

                    this.lblHoraFin2.Text = reserva.FechaHoraFin.TimeOfDay.ToString();

                    this.lblCantidadHoras2.Text = reserva.FechaHoraFin.Subtract(reserva.FechaHoraInicio).TotalHours.ToString();
                }
                else
                {
                    MessageBox.Show("No puede agregar tiempo extra debido a que hay otra reserva en ese horario.", "Modificación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarDuracion_Click(object sender, EventArgs e)
        {
            try
            {
                if (reserva.FechaHoraFin.AddMinutes(-30).Subtract(reserva.FechaHoraInicio).TotalMinutes >= 150)
                {
                    reserva.FechaHoraFin = reserva.FechaHoraFin.AddMinutes(-30);

                    this.lblHoraFin2.Text = reserva.FechaHoraFin.TimeOfDay.ToString();

                    this.lblCantidadHoras2.Text = reserva.FechaHoraFin.Subtract(reserva.FechaHoraInicio).TotalHours.ToString();
                }
                else
                {
                    MessageBox.Show("La duración mínima debe ser de 2,5 horas.", "Modificación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecotizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblMontoTotalNvo2.Text = GestorReserva.ObtenerInstancia().CalcularCostoTotalReserva(reserva).ToString("C2");

                GestorReserva.ObtenerInstancia().CalcularCantidadBebidas(reserva).ToString();

                GestorReserva.ObtenerInstancia().AsignarEmpleadosDisponibles(reserva);
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.CalcularCostoReservaFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double montoPagado = 0;

                if (Double.TryParse(this.txtPago.Text, out montoPagado))
                {
                    reserva.MontoPagado = montoPagado;

                    if (reserva.MontoTotal == montoPagado)
                    {
                        reserva.Estado = "P"; //Pagado
                    }
                    else if (reserva.MontoTotal < montoPagado)
                    {
                        MessageBox.Show("Ha ingresado un monto de pago mayor al total.", "Modificación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else
                {
                    reserva.Estado = "R"; //Reservado
                }

                if (GestorReserva.ObtenerInstancia().ActualizarReserva(reserva))
                {

                    if (GestorBD.ObtenerInstancia().ActualizarDVV("RESERVA"))
                    {
                        MessageBox.Show("La cotización se ha guardado con éxito.", "Modificación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarControles(false);
                    }

                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionReservaFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarControles(bool habilita)
        {
            this.btnAceptar.Enabled = habilita;
            this.btnCancelar.Enabled = habilita;
        }
    }
}
