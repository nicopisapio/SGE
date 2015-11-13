using GE_Business;
using GE_Entities;
using Security.BLL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Eventos
{
    public partial class FIdioma : Form
    {
        public FIdioma()
        {
            InitializeComponent();
        }

        private void FIdioma_Load(object sender, EventArgs e)
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

            CargarIdiomas();
        }

        private void CargarIdiomas()
        {
            try
            {
                List<Idioma> listaIdiomas = null;

                listaIdiomas = GestorIdioma.ObtenerInstancia().ConsultarIdiomas();

                if (listaIdiomas != null)
                {
                    this.cboIdioma.DataSource = listaIdiomas.ToArray();
                    this.cboIdioma.DisplayMember = "ID";
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaIdiomasFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Idioma idioma = (Idioma)cboIdioma.SelectedItem;
            Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;

            try
            {
                if(GestorIdioma.ObtenerInstancia().CambiarIdioma(idioma, usuario))
                {
                    if (GestorBD.ObtenerInstancia().ActualizarDVV("USUARIO"))
                    {
                        GestorIdioma.ObtenerInstancia().ModificarConfig(idioma);

                        FormHelper.ObtenerInstancia().IdiomaCambiado = true;

                        GestorLogin.ObtenerInstancia().RecargarUsuario();

                        MessageBox.Show("El idioma se ha configurado correctamente.", "Gestión de Idioma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.CambioIdiomaFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
