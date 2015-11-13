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
    public partial class FDetalleEvento : Form
    {
        public FDetalleEvento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fechaDesde = dtpFechaDesde.Value.Date;
                DateTime fechaHasta = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);

                if (fechaHasta > fechaDesde)
                {
                    List<Reserva> reservas = GestorReserva.ObtenerInstancia().ConsultarReservas("R", fechaDesde, fechaHasta);

                    if (reservas != null)
                    {
                        gridReserva.DataSource = reservas.ToArray();
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

        private void CargarDatos(Reserva reserva)
        {

            this.lblTipoEvento2.Text = reserva.Evento.Descripcion;
            this.lblCantidadAdultos2.Text = reserva.CantidadAdultos.ToString();
            this.lblCantidadNiños2.Text = reserva.CantidadNiños.ToString();
            this.lblEmpleadosNecesarios2.Text = reserva.Empleados.Count().ToString();
            this.lblExcedente2.Text = reserva.Excedentes == null ? "-" : GestorReserva.ObtenerInstancia().CalcularCostoExcedentes(reserva).ToString("C2");
            this.listServicios.DataSource = reserva.Servicios.ToArray();
            this.lblDUCliente2.Text = reserva.Cliente.DU.ToString();
            this.lblApellido2.Text = reserva.Cliente.Apellido;
            this.lblNombre2.Text = reserva.Cliente.Nombre;
            this.lblTel2.Text = reserva.Cliente.Telefono;
            this.lblDireccion2.Text = reserva.Cliente.Direccion == null ? " - " : reserva.Cliente.Direccion.ToString();
            this.lblMontoPagado2.Text = reserva.MontoPagado.ToString("C2");
            this.lblMontoTotal2.Text = reserva.MontoTotal.ToString("C2");

            switch (reserva.Estado)
            {
                case "R":
                    this.lblEstado.Text = "RESERVADO";
                    break;
                case "P":
                    this.lblEstado.Text = "PAGADO";
                    break;
                case "T":
                    this.lblEstado.Text = "TERMINADO";
                    break;
                default:
                    break;
            }
        }

        private void FDetalleEvento_Load(object sender, EventArgs e)
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
        }

        private void gridReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Reserva reserva = (Reserva)this.gridReserva.CurrentRow.DataBoundItem;

                if (reserva != null)
                {
                    CargarDatos(reserva);
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
