using System;
using System.Windows.Forms;
using Security.BLL;
using Security.Entities;
using System.Collections.Generic;
using GE_Business;
using System.Configuration;
using GE_Entities;

namespace Gestor_de_Eventos
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void menuBusquedaYReservaDeFechas_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FReserva());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuCotizacionDeEventos_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FCotizacionEvento());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuDetalleDeEventosReservados_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FDetalleEvento());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuModificacionDeEventosReservados_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FModificacionEvento());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuCerrarSesion_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            menuIniciarSesion.Enabled = true;
            menuCerrarSesion.Enabled = false;

            menuVenta.Enabled = false;
            menuEventos.Enabled = false;
            menuAdministracion.Enabled = false;
            menuHerramientas.Enabled = false;
            menuOpciones.Enabled = false;

            GestorLogin.ObtenerInstancia().CerrarSesion();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
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

            menuIniciarSesion.Enabled = true;
            menuCerrarSesion.Enabled = false;

            menuVenta.Enabled = false;
            menuEventos.Enabled = false;
            menuAdministracion.Enabled = false;
            menuHerramientas.Enabled = false;
            menuOpciones.Enabled = false;
        }

        private void menuIniciarSesion_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            Login fl = new Login();

            DialogResult result = fl.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {

                menuVenta.Enabled = GestorLogin.ObtenerInstancia().VerificarPermiso("VENDEDOR");
                menuEventos.Enabled = GestorLogin.ObtenerInstancia().VerificarPermiso("ADM_EVENTOS");
                menuAdministracion.Enabled = GestorLogin.ObtenerInstancia().VerificarPermiso("ADM_GENERAL");
                menuBD.Enabled = GestorLogin.ObtenerInstancia().VerificarPermiso("BASE_DATOS");

                menuBitacora.Enabled = true;
                menuHerramientas.Enabled = true;
                menuOpciones.Enabled = true;
                menuIniciarSesion.Enabled = false;
                menuCerrarSesion.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("La aplicación se encuentra bloqueda. Por favor contacte a un administrador y realice un Restore", "Aplicación Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (result == DialogResult.Yes)
            {
                menuHerramientas.Enabled = true;
                menuBD.Enabled = true;
                menuRealizarRestore.Enabled = true;
                menuBitacora.Enabled = false;
                menuRealizarBackup.Enabled = false;
                menuIniciarSesion.Enabled = false;
                menuCerrarSesion.Enabled = true;
                menuOpciones.Enabled = false;
            }
            
        }

        private void menuGestionDeUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FABMUsuario());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuCambiarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FIdioma());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FPrincipal_Activated(object sender, EventArgs e)
        {

            try
            {
                if (FormHelper.ObtenerInstancia().IdiomaCambiado)
                {
                    FormHelper.ObtenerInstancia().RecargarIdiomaFormulario(this);
                    FormHelper.ObtenerInstancia().IdiomaCambiado = false;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.TraduccionFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void menuRealizarBackup_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogo = MessageBox.Show("¿Desea realizar un backup de la Base de Datos?", "Backup", MessageBoxButtons.YesNo);

                if (dialogo == DialogResult.Yes)
                {
                    if (GestorBD.ObtenerInstancia().RealizarBackup())
                    {
                        MessageBox.Show("El backup se ha realizado correctamente", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BackupFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void menuRealizarRestore_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Seleccione el archivo para realizar el restore de la Base de Datos:";
                theDialog.Filter = "BAK Files|*.bak";
                theDialog.InitialDirectory = ConfigurationManager.AppSettings["CarpetaBackup"].ToString();

                if (theDialog.ShowDialog() == DialogResult.OK)
                {

                    if (GestorBD.ObtenerInstancia().RealizarRestore(theDialog.FileName))
                    {
                        MessageBox.Show("El Restore se ha realizado correctamente", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.RestoreFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FBitacora());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuAgregarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FABMIdioma());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuGestionDePermisos_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FPermiso());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void semanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FDetalleHorasSemanales());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FDetalleHorasMensuales());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuGestionDeTipoDeEventos_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FABMEventos());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuGestionDeServicios_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FABMServicio());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuAgregarExcedentes_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FAgregarExcedente());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuReasignacionDeEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FReasignarEmpleado());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuGestionDeEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FABMEmpleado());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuGestionDeCargos_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.ObtenerInstancia().MostrarFormulario(this, new FABMCargo());
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

    }
}
