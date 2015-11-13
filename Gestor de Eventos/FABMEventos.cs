using GE_Business;
using GE_Entities;
using Security.BLL;
using Security.Entities;
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
    public partial class FABMEventos : Form
    {

        private Evento eventoSeleccionado = null;

        private enum Accion
        {
            Alta,
            Modificacion
        }

        private Accion Operacion;

        public FABMEventos()
        {
            InitializeComponent();
        }

        private void FABMEventos_Load(object sender, EventArgs e)
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

            CargarEventos();
            this.gbDatosEvento.Enabled = false;
        }

        private void CargarEventos()
        {
            try
            {
                List<Evento> eventos = GestorReserva.ObtenerInstancia().ConsultarEventos();

                if (eventos != null)
                {
                    this.gridEventos.DataSource = eventos;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaEventosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Operacion = Accion.Alta;
            this.gbDatosEvento.Enabled = true;
            HabilitarControles(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = 0;
                if (!Double.TryParse(this.txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Ingrese un valor numérico.", "Alta de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPrecio.Focus();
                }

                double precioBloque = 0;
                if (!Double.TryParse(this.txtPrecioBloque.Text, out precioBloque))
                {
                    MessageBox.Show("Ingrese un valor numérico.", "Alta de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPrecioBloque.Focus();
                }

                double precioDecena = 0;
                if (!Double.TryParse(this.txtPrecioDecena.Text, out precioDecena))
                {
                    MessageBox.Show("Ingrese un valor numérico.", "Alta de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPrecioDecena.Focus();
                }
                
                Evento evento = new Evento();
                evento.Descripcion = txtDescripcion.Text;
                evento.Precio = precio;
                evento.PrecioBloqueExtra = precioBloque;
                evento.CantidadNiños = Convert.ToInt32(numCantidadNiños.Value);
                evento.CantidadAdultos = Convert.ToInt32(numCantidadAdultos.Value);
                evento.PrecioDecenaExtra = precioDecena;
                evento.Estado = 1;

                bool resultado = false;

                if (Operacion == Accion.Alta)
                {
                    resultado = GestorReserva.ObtenerInstancia().InsertarNuevoEvento(evento);
                }
                else if (Operacion == Accion.Modificacion)
                {
                    evento.ID = eventoSeleccionado.ID;
                    resultado = GestorReserva.ObtenerInstancia().ActualizarEvento(evento);
                }

                if (resultado)
                {
                    if (GestorBD.ObtenerInstancia().ActualizarDVV("EVENTO"))
                    {
                        MessageBox.Show("Se ha creado/modificado el Evento correctamente.", "Alta de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarControles(true);
                        this.gbDatosEvento.Enabled = false;
                        LimpiarControles();
                        CargarEventos();
                    }
                }

            }
            catch (Exception ex)
            {

                string mensajeError = string.Empty;

                if (this.Operacion == Accion.Alta)
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaEventoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }
                else
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionEventoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            this.txtDescripcion.Clear();
            this.txtPrecio.Clear();
            this.txtPrecioBloque.Clear();
            this.txtPrecioDecena.Clear();
            this.numCantidadAdultos.Value = 0;
            this.numCantidadNiños.Value = 0;

            eventoSeleccionado = null;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {

                HabilitarControles(false);

                if (this.gridEventos.CurrentRow != null)
                {
                    this.Operacion = Accion.Modificacion;
                    this.gbDatosEvento.Enabled = true;

                    Evento evento = (Evento)this.gridEventos.CurrentRow.DataBoundItem;

                    eventoSeleccionado = evento;

                    this.txtDescripcion.Text = evento.Descripcion;
                    this.txtPrecio.Text = evento.Precio.ToString("N2");
                    this.txtPrecioBloque.Text = evento.PrecioBloqueExtra.ToString("N2");
                    this.txtPrecioDecena.Text = evento.PrecioDecenaExtra.ToString("N2");
                    this.numCantidadAdultos.Value = evento.CantidadAdultos;
                    this.numCantidadNiños.Value = evento.CantidadNiños;
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

                if (this.gridEventos.CurrentRow != null)
                {
                    this.Operacion = Accion.Modificacion;

                    Evento evento = (Evento)this.gridEventos.CurrentRow.DataBoundItem;

                    DialogResult dialogo = MessageBox.Show("¿Desea eliminar definitivamente al evento " + evento.Descripcion + "?", "Baja de Evento", MessageBoxButtons.YesNo);

                    if (dialogo == DialogResult.Yes)
                    {
                        if (GestorReserva.ObtenerInstancia().EliminarEvento(evento))
                        {
                            if (GestorBD.ObtenerInstancia().ActualizarDVV("EVENTO"))
                            {
                                MessageBox.Show("El evento se ha eliminado correctamente.", "Baja de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarEventos();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BajaEventoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            this.gbDatosEvento.Enabled = false;
            LimpiarControles();
        }

        private void HabilitarControles(bool habilita)
        {
            this.btnAlta.Enabled = habilita;
            this.btnModificacion.Enabled = habilita;
            this.btnBaja.Enabled = habilita;
        }
    }
}
