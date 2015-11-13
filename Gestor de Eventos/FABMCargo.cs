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
    public partial class FABMCargo : Form
    {

        private Cargo cargoSeleccionado = null;

        private enum Accion
        {
            Alta,
            Modificacion
        }

        private Accion Operacion;

        public FABMCargo()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Operacion = Accion.Alta;
            this.gbDatosCargo.Enabled = true;
            HabilitarControles(false);
        }

        private void FABMCargo_Load(object sender, EventArgs e)
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

            CargarCargos();
            this.gbDatosCargo.Enabled = false;
        }

        private void CargarCargos()
        {
            try
            {
                List<Cargo> cargos = GestorReserva.ObtenerInstancia().ConsultarCargos();

                if (cargos != null)
                {
                    this.gridCargos.DataSource = cargos;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaCargosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {

                HabilitarControles(false);

                if (this.gridCargos.CurrentRow != null)
                {
                    this.Operacion = Accion.Modificacion;
                    this.gbDatosCargo.Enabled = true;

                    Cargo cargo = (Cargo)this.gridCargos.CurrentRow.DataBoundItem;

                    cargoSeleccionado = cargo;

                    this.txtDescripcion.Text = cargo.Descripcion;
                    this.txtPrecio.Text = cargo.ValorPorHora.ToString("N2");
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

                if (this.gridCargos.CurrentRow != null)
                {

                    Cargo cargo = (Cargo)this.gridCargos.CurrentRow.DataBoundItem;

                    DialogResult dialogo = MessageBox.Show("¿Desea eliminar definitivamente al cargo " + cargo.Descripcion + "?", "Gestión de Cargos", MessageBoxButtons.YesNo);

                    if (dialogo == DialogResult.Yes)
                    {
                        if (GestorReserva.ObtenerInstancia().EliminarCargo(cargo))
                        {
                            MessageBox.Show("El cargo se ha eliminado correctamente", "Gestión de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCargos();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BajaCargoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = 0;
                if (!Double.TryParse(this.txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Ingrese un valor numérico.", "Gestión de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPrecio.Focus();
                }

                Cargo cargo = new Cargo();
                cargo.Descripcion = txtDescripcion.Text;
                cargo.ValorPorHora = precio;

                bool resultado = false;

                if (Operacion == Accion.Alta)
                {
                    resultado = GestorReserva.ObtenerInstancia().InsertarNuevoCargo(cargo);
                }
                else if (Operacion == Accion.Modificacion)
                {
                    cargo.ID = cargoSeleccionado.ID;
                    resultado = GestorReserva.ObtenerInstancia().ActualizarCargo(cargo);
                }

                if (resultado)
                {
                    MessageBox.Show("Se ha creado/modificado el Servicio correctamente.", "Gestión de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControles(true);
                    this.gbDatosCargo.Enabled = false;
                    LimpiarControles();
                    CargarCargos();
                }

            }
            catch (Exception ex)
            {

                string mensajeError = string.Empty;

                if (this.Operacion == Accion.Alta)
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaCargoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }
                else
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionCargoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            this.txtDescripcion.Clear();
            this.txtPrecio.Clear();
            cargoSeleccionado = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            this.gbDatosCargo.Enabled = false;
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
