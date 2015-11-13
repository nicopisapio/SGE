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
    public partial class FABMEmpleado : Form
    {

        private enum Accion
        {
            Alta,
            Modificacion
        }

        private Accion Operacion;

        public FABMEmpleado()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Operacion = Accion.Alta;
            this.gbDatosEmpleado.Enabled = true;
            HabilitarControles(false);
        }

        private void FABMEmpleado_Load(object sender, EventArgs e)
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

            this.gbDatosEmpleado.Enabled = false;
            CargarEmpleados();
            CargarComboCargos();
        }

        private void CargarEmpleados()
        {
            try
            {
                List<Empleado> empleados = GestorReserva.ObtenerInstancia().ConsultarEmpleados();

                if (empleados != null)
                {
                    this.gridEmpleados.DataSource = empleados;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaEmpleadosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboCargos()
        {
            try
            {
                List<Cargo> cargos = GestorReserva.ObtenerInstancia().ConsultarCargos();

                if (cargos != null)
                {
                    this.cboCargo.DataSource = cargos.ToArray();
                    this.cboCargo.ValueMember = "Descripcion";
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

                if (this.gridEmpleados.CurrentRow != null)
                {
                    this.Operacion = Accion.Modificacion;
                    this.gbDatosEmpleado.Enabled = true;
                    this.txtDU.Enabled = false;

                    Empleado empleado = (Empleado)this.gridEmpleados.CurrentRow.DataBoundItem;

                    this.txtDU.Text = empleado.DU.ToString();
                    this.txtApellido.Text = empleado.Apellido;
                    this.txtNombre.Text = empleado.Nombre;
                    this.txtTelefono.Text = empleado.Telefono;
                    this.cboCargo.SelectedValue = empleado.Cargo.Descripcion;
                    this.chkActivo.Checked = empleado.Activo;

                    if (empleado.Direccion != null)
                    {
                        this.txtCalle.Text = empleado.Direccion.Calle;
                        this.txtAltura.Text = empleado.Direccion.Altura.ToString();
                        this.txtLocalidad.Text = empleado.Direccion.Localidad;
                        this.txtPiso.Text = empleado.Direccion.Piso == 0 ? "" : empleado.Direccion.Piso.ToString();
                        this.txtDepto.Text = empleado.Direccion.Departamento == "N/A" ? "" : empleado.Direccion.Departamento;
                    }
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
                if (this.gridEmpleados.CurrentRow != null)
                {
                    this.Operacion = Accion.Modificacion;

                    Empleado empleado = (Empleado)this.gridEmpleados.CurrentRow.DataBoundItem;

                    DialogResult dialogo = MessageBox.Show("¿Desea eliminar definitivamente al Empleado " + empleado.ToString() + "?", "Baja de Empleado", MessageBoxButtons.YesNo);

                    if (dialogo == DialogResult.Yes)
                    {
                        if (GestorReserva.ObtenerInstancia().EliminarEmpleado(empleado))
                        {
                            MessageBox.Show("El empleado se ha eliminado correctamente", "Baja de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarEmpleados();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BajaEmpleadoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCampos())
                {

                    long duCliente = 0;

                    if (Int64.TryParse(this.txtDU.Text, out duCliente))
                    {
                        if (duCliente > 0)
                        {
                            Empleado empleado = new Empleado();
                            empleado.DU = duCliente;
                            empleado.Apellido = this.txtApellido.Text.ToUpperInvariant();
                            empleado.Nombre = this.txtNombre.Text.ToUpperInvariant();
                            empleado.Telefono = this.txtTelefono.Text;
                            empleado.Cargo = (Cargo)this.cboCargo.SelectedItem;
                            empleado.Activo = this.chkActivo.Checked;

                            if (ValidarDireccion())
                            {
                                int altura = 0;
                                int piso = 0;
                                int.TryParse(this.txtPiso.Text, out piso);

                                if (Int32.TryParse(this.txtAltura.Text, out altura))
                                {
                                    if (altura > 0)
                                    {
                                        empleado.Direccion = new Direccion();
                                        empleado.Direccion.Calle = this.txtCalle.Text;
                                        empleado.Direccion.Altura = altura;
                                        empleado.Direccion.Localidad = this.txtLocalidad.Text;
                                        empleado.Direccion.Piso = piso;
                                        empleado.Direccion.Departamento = String.IsNullOrWhiteSpace(this.txtDepto.Text) ? "N/A" : this.txtDepto.Text.PadRight(5, ' ').Substring(0, 5).Trim();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La Altura debe ser distinta de 0.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        this.txtAltura.Focus();
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La Altura debe ser numérica.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.txtAltura.Focus();
                                    return;
                                }
                            }

                            bool resultado = false;
                            
                            if (Operacion == Accion.Alta)
                            {
                                resultado = GestorReserva.ObtenerInstancia().InsertarNuevoEmpleado(empleado);
                            }
                            else
                            {
                                resultado = GestorReserva.ObtenerInstancia().ActualizarEmpleado(empleado);
                            }

                            if (resultado)
                            {
                                MessageBox.Show("Se ha creado/modificado un nuevo Empleado.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HabilitarControles(true);
                                this.gbDatosEmpleado.Enabled = false;
                                this.txtDU.Enabled = true;
                                LimpiarControles();
                                CargarEmpleados();
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido dar de alta el Empleado.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El DU debe ser distinto de 0.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtDU.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El DU debe ser numérico.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtDU.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del Empleado.", "Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                string mensajeError = string.Empty;

                if (this.Operacion == Accion.Alta)
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaEmpleadoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }
                else
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionEmpleadoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }

                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDireccion()
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(this.txtCalle.Text) || string.IsNullOrWhiteSpace(this.txtAltura.Text) ||
                string.IsNullOrWhiteSpace(this.txtLocalidad.Text))
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ValidarCampos()
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(this.txtDU.Text) || string.IsNullOrWhiteSpace(this.txtApellido.Text) ||
                string.IsNullOrWhiteSpace(this.txtNombre.Text) || string.IsNullOrWhiteSpace(this.txtTelefono.Text))
            {
                resultado = false;
            }

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            this.gbDatosEmpleado.Enabled = false;
            this.txtDU.Enabled = true;
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.txtDU.Clear();
            this.txtApellido.Clear();
            this.txtNombre.Clear();
            this.txtTelefono.Clear();
            this.cboCargo.SelectedIndex = -1;
            this.chkActivo.Checked = false;

            this.txtCalle.Clear();
            this.txtAltura.Clear();
            this.txtLocalidad.Clear();
            this.txtPiso.Clear();
            this.txtDepto.Clear();
        }

        private void HabilitarControles(bool habilita)
        {
            this.btnAlta.Enabled = habilita;
            this.btnModificacion.Enabled = habilita;
            this.btnBaja.Enabled = habilita;
        }
    }
}
