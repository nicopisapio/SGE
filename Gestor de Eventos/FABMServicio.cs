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
    public partial class FABMServicio : Form
    {

        private Servicio servicioSeleccionado = null;

        private enum Accion
        {
            Alta,
            Modificacion
        }

        private Accion Operacion;

        public FABMServicio()
        {
            InitializeComponent();
        }

        private void FABMServicio_Load(object sender, EventArgs e)
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

            CargarServicios();
            this.gbDatosServicio.Enabled = false;
        }

        private void CargarServicios()
        {
            try
            {
                List<Servicio> servicios = GestorReserva.ObtenerInstancia().ConsultarServicios();

                if (servicios != null)
                {
                    this.gridServicios.DataSource = servicios;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaServiciosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Operacion = Accion.Alta;
            this.gbDatosServicio.Enabled = true;
            HabilitarControles(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = 0;
                Double.TryParse(this.txtPrecio.Text, out precio);

                Servicio servicio = new Servicio();
                servicio.Descripcion = txtDescripcion.Text;
                servicio.Precio = precio;
                servicio.Estado = 1;

                bool resultado = false;

                if (Operacion == Accion.Alta)
                {
                    resultado = GestorReserva.ObtenerInstancia().InsertarNuevoServicio(servicio);
                }
                else if (Operacion == Accion.Modificacion)
                {
                    servicio.ID = servicioSeleccionado.ID;
                    resultado = GestorReserva.ObtenerInstancia().ActualizarServicio(servicio);
                }

                if (resultado)
                {
                    MessageBox.Show("Se ha creado/modificado el Servicio correctamente.", "Gestión de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControles(true);
                    this.gbDatosServicio.Enabled = false;
                    LimpiarControles();
                    CargarServicios();
                }

            }
            catch (Exception ex)
            {

                string mensajeError = string.Empty;

                if (this.Operacion == Accion.Alta)
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaServicioFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }
                else
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionServicioFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            this.txtDescripcion.Clear();
            this.txtPrecio.Clear();

            servicioSeleccionado = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            this.gbDatosServicio.Enabled = false;
            LimpiarControles();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarControles(false);

                if (this.gridServicios.CurrentRow != null)
                {
                    this.Operacion = Accion.Modificacion;
                    this.gbDatosServicio.Enabled = true;

                    Servicio servicio = (Servicio)this.gridServicios.CurrentRow.DataBoundItem;

                    servicioSeleccionado = servicio;

                    this.txtDescripcion.Text = servicio.Descripcion;
                    this.txtPrecio.Text = servicio.Precio.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.gridServicios.CurrentRow != null)
                {

                    Servicio servicio = (Servicio)this.gridServicios.CurrentRow.DataBoundItem;

                    DialogResult dialogo = MessageBox.Show("¿Desea eliminar definitivamente al servicio " + servicio.Descripcion + "?", "Gestión de Servicio", MessageBoxButtons.YesNo);

                    if (dialogo == DialogResult.Yes)
                    {
                        if (GestorReserva.ObtenerInstancia().EliminarServicio(servicio))
                        {
                            MessageBox.Show("El servicio se ha eliminado correctamente", "Gestión de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarServicios();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BajaServicioFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarControles(bool habilita)
        {
            this.btnAceptar.Enabled = habilita;
            this.btnModificacion.Enabled = habilita;
            this.btnBaja.Enabled = habilita;
        }
    }
}
