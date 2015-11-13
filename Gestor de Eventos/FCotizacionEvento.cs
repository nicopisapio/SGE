using GE_Business;
using GE_Entities;
using Security.BLL;
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
    public partial class FCotizacionEvento : Form
    {

        private Reserva reserva;

        public FCotizacionEvento()
        {
            InitializeComponent();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtIdReserva.Text))
                {
                    MessageBox.Show("Debe ingresar un ID de reserva.", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIdReserva.Focus();
                    return;
                }

                long idReserva = 0;

                if (Int64.TryParse(this.txtIdReserva.Text, out idReserva))
                {
                    reserva = GestorReserva.ObtenerInstancia().ConsultarReserva(idReserva);

                    if (reserva != null)
                    {
                        CargarDatosReserva(reserva);
                        CargarControles();
                    }
                    else
                    {

                        DialogResult dialogo = MessageBox.Show("Reserva inexistente. ¿Desea generar una nueva reserva?", "Cotización", MessageBoxButtons.YesNo);

                        if (dialogo == System.Windows.Forms.DialogResult.Yes)
                        {
                            FormHelper.ObtenerInstancia().MostrarFormulario(this.MdiParent, new FReserva());
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor númerico.", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIdReserva.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaReservasFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarControles()
        {
            HabilitarControles(true);
            CargaComboServicios();
            CargarComboEventos();
        }

        private void HabilitarControles(bool habilitado)
        {
            this.gbEvento.Enabled = habilitado;
            this.gpPersonas.Enabled = habilitado;
            this.gpServicios.Enabled = habilitado;
            this.gbCotizacion.Enabled = habilitado;
            this.gbEmpleados.Enabled = habilitado;
            this.gbInfo.Enabled = habilitado;
            this.btnAceptar.Enabled = habilitado;
            this.btnCancelar.Enabled = habilitado;
        }

        private void CargarDatosReserva(Reserva res)
        {
            this.lblFecha2.Text = res.FechaHoraInicio.ToShortDateString();
            this.lblHoraInicio2.Text = res.FechaHoraInicio.TimeOfDay.ToString();
            this.lblHoraFin2.Text = res.FechaHoraFin.TimeOfDay.ToString();
            this.lblNombre.Text = res.Cliente.ToString();
            this.lblDuracion2.Text = res.FechaHoraFin.Subtract(res.FechaHoraInicio).TotalHours.ToString("N1") + " Hs.";
            this.listServiciosAgregados.DataSource = res.Servicios.ToArray();
            this.listEmpleadosAsignados.DataSource = res.Empleados.ToArray();
        }

        private void CargarComboEventos()
        {

            this.cboTipoEvento.DataSource = null;

            try
            {

                List<Evento> eventos = GestorReserva.ObtenerInstancia().ConsultarEventos();

                if (eventos != null)
                {
                    this.cboTipoEvento.DataSource = eventos;
                    this.cboTipoEvento.DisplayMember = "Descripcion";
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaEventosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cboTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Evento evento = (Evento)this.cboTipoEvento.SelectedItem;

                if (evento != null)
                {
                    reserva.Evento = evento;

                    reserva.CantidadAdultos = evento.CantidadAdultos;
                    reserva.CantidadNiños = evento.CantidadNiños;

                    this.lblCantidadAdultos2.Text = evento.CantidadAdultos.ToString();
                    this.lblCantidadNiños2.Text = evento.CantidadNiños.ToString();
                    this.lblPrecioEvento2.Text = evento.Precio.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                this.listServiciosAgregados.DataSource = reserva.Servicios.ToArray();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoPersona = this.cboPersonas.SelectedItem != null ? this.cboPersonas.SelectedItem.ToString() : string.Empty;

                if (string.IsNullOrWhiteSpace(tipoPersona))
                {
                    int cant = 0;

                    if (tipoPersona == "Adultos")
                    {
                        reserva.CantidadAdultos += 10;
                        cant = Convert.ToInt32(this.lblAdultosExtra2.Text);
                        cant += 10;
                        this.lblAdultosExtra2.Text = cant.ToString();
                    }
                    else
                    {
                        reserva.CantidadNiños += 10;
                        cant = Convert.ToInt32(this.lblNiñosExtra2.Text);
                        cant += 10;
                        this.lblNiñosExtra2.Text = cant.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblPrecioTiempoExtra2.Text = GestorReserva.ObtenerInstancia().CalcularCostoTiempoExtra(reserva).ToString("C2");
                this.lblPrecioServiciosExtra2.Text = GestorReserva.ObtenerInstancia().CalcularCostoServicios(reserva).ToString("C2");
                this.lblPrecioPersonasExtra2.Text = GestorReserva.ObtenerInstancia().CalcularCostoPersonasExtra(reserva).ToString("C2");

                this.lblTotal2.Text = GestorReserva.ObtenerInstancia().CalcularCostoTotalReserva(reserva).ToString("C2");

                this.lblBebidas2.Text = GestorReserva.ObtenerInstancia().CalcularCantidadBebidas(reserva).ToString();

                GestorReserva.ObtenerInstancia().AsignarEmpleadosDisponibles(reserva);

                CargarListaEmpleados();
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.CalcularCostoReservaFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarCotizacion_Click(object sender, EventArgs e)
        {

            try
            {
                double montoPagado = 0;

                if (Double.TryParse(this.txtPagoAdelantado.Text, out montoPagado))
                {
                    reserva.MontoPagado = montoPagado;

                    if (reserva.MontoTotal == montoPagado)
                    {
                        reserva.Estado = "P"; //Pagado
                    }
                    else if (reserva.MontoTotal < montoPagado)
                    {
                        MessageBox.Show("Ha ingresado un monto de pago mayor al total.", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("La cotización se ha guardado con éxito.", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionReservaFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaEmpleados()
        {
            this.listEmpleadosAsignados.DataSource = null;
            this.listEmpleadosAsignados.DataSource = reserva.Empleados.ToArray();
        }

        private void LimpiarControles()
        {

            reserva = null;

            this.txtIdReserva.Clear();
            
            HabilitarControles(false);

            this.lblFecha2.Text = "-";
            this.lblHoraInicio2.Text = "-";
            this.lblHoraFin2.Text = "-";
            this.lblNombre.Text = "-";
            this.lblDuracion2.Text = "-";

            this.lblAdultosExtra2.Text = "0";
            this.lblNiñosExtra2.Text = "0";

            this.lblCantidadAdultos2.Text = "0";
            this.lblCantidadNiños2.Text = "0";

            this.listServiciosAgregados.DataSource = null;
            this.listEmpleadosAsignados.DataSource = null;

            this.txtPagoAdelantado.Clear();

            this.lblPrecioEvento2.Text = 0.ToString("C2");
            this.lblPrecioPersonasExtra2.Text = 0.ToString("C2");
            this.lblPrecioServiciosExtra2.Text = 0.ToString("C2");
            this.lblPrecioTiempoExtra2.Text = 0.ToString("C2");
            this.lblTotal2.Text = 0.ToString("C2");

            this.lblBebidas2.Text = "0";
        }

        private void btnCancelarCotizacion_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false);
        }

        private void FCotizacionEvento_Load(object sender, EventArgs e)
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

            HabilitarControles(false);
        }

    }
}
