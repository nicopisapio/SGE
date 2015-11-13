using System;
using System.Windows.Forms;
using Security.BLL;
using System.Configuration;
using GE_Business;
using GE_Business.Excepciones;
using GE_Entities;
using Security.Excepciones;

namespace Gestor_de_Eventos
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                FormHelper.ObtenerInstancia().RecargarIdiomaFormulario(this);

                if (GestorBD.ObtenerInstancia().AplicacionBloqueada())
                {
                    if (GestorLogin.ObtenerInstancia().IniciarSesion(txtUser.Text, txtPassword.Text, true))
                    {
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                    }

                }
                else
                {
                    if (GestorBD.ObtenerInstancia().HayQueVerificarIntegridad())
                    {
                        this.lblMensaje.Visible = true;

                        GestorBD.ObtenerInstancia().VerificarIntegridadBD();
                    }

                    if (GestorLogin.ObtenerInstancia().IniciarSesion(txtUser.Text, txtPassword.Text))
                    {

                        if (!GestorLogin.ObtenerInstancia().Usuario.Idioma.ID.Equals(ConfigurationManager.AppSettings["Idioma"].ToString()))
                        {
                            GestorIdioma.ObtenerInstancia().ModificarConfig(GestorLogin.ObtenerInstancia().Usuario.Idioma);
                            FormHelper.ObtenerInstancia().IdiomaCambiado = true;
                        }

                        this.DialogResult = DialogResult.OK;

                    }
                }

            }
            catch (LoginFallidoException ex)
            {
                this.txtPassword.Clear();
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.LoginFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (AplicacionBloqueadaException ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AplicacionBloqueada, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (IntegridadCorruptaException ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.IntegridadCorrupta, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
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
