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
    public partial class FAltaCliente : Form
    {
        public FAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidarCampos())
                {

                    long duCliente = 0;
                    
                    if(Int64.TryParse(this.txtDU.Text, out duCliente))
                    {
                        if (duCliente > 0)
                        {
                            Cliente cliente = new Cliente();
                            cliente.DU = duCliente;
                            cliente.Apellido = this.txtApellido.Text.ToUpperInvariant();
                            cliente.Nombre = this.txtNombre.Text.ToUpperInvariant();
                            cliente.Telefono = this.txtTelefono.Text;

                            if (ValidarDireccion())
                            {
                                int altura = 0;
                                int piso = 0;
                                int.TryParse(this.txtPiso.Text, out piso);

                                if (Int32.TryParse(this.txtAltura.Text, out altura))
                                {
                                    if (altura > 0)
                                    {
                                        cliente.Direccion = new Direccion();
                                        cliente.Direccion.Calle = this.txtCalle.Text;
                                        cliente.Direccion.Altura = altura;
                                        cliente.Direccion.Localidad = this.txtLocalidad.Text;
                                        cliente.Direccion.Piso =  piso;
                                        cliente.Direccion.Departamento = String.IsNullOrWhiteSpace(this.txtDepto.Text) ? "N/A" : this.txtDepto.Text.PadRight(5, ' ').Substring(0, 5).Trim();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La Altura debe ser distinta de 0.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        this.txtAltura.Focus();
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La Altura debe ser numérica.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.txtAltura.Focus();
                                    return;
                                }
                            }

                            if (GestorReserva.ObtenerInstancia().InsertarNuevoCliente(cliente))
                            {
                                MessageBox.Show("Se ha creado un nuevo Cliente.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido dar de alta el Cliente.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El DU debe ser distinto de 0.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtDU.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El DU debe ser numérico.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtDU.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del Cliente", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaClienteFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
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
            this.DialogResult = DialogResult.Cancel;
        }

        private void FAltaCliente_Load(object sender, EventArgs e)
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
    }
}
