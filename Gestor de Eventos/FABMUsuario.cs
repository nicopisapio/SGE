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
    public partial class FABMUsuario : Form
    {

        private enum Accion
        {
            Alta,
            Modificacion
        }

        private Accion Operacion;

        public FABMUsuario()
        {
            InitializeComponent();
        }

        private void FABMUsuario_Load(object sender, EventArgs e)
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

            CargarUsuarios();
            CargarPermisos();
            CargarIdiomas();

        }

        private void CargarUsuarios()
        {
            try
            {
                List<Usuario> listaUsuarios = null;

                listaUsuarios = GestorUsuario.ObtenerInstancia().ConsultarUsuarios();

                if (listaUsuarios != null)
                {
                    this.gridUsuarios.DataSource = listaUsuarios;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaUsuariosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CargarPermisos()
        {
            try
            {
                List<GrupoPermiso> listaPermisos = null;

                listaPermisos = GestorUsuario.ObtenerInstancia().ConsultarPermisos();

                if (listaPermisos != null)
                {
                    this.cboPerfil.DataSource = listaPermisos.ToArray();
                    this.cboPerfil.DisplayMember = "Descripcion";
                    this.cboPerfil.ValueMember = "Descripcion";
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaPermisosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
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
                    this.cboIdioma.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaIdiomasFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        
        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Operacion = FABMUsuario.Accion.Alta;
            HabilitarControles(true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = txtUsuario.Text;
                usuario.Clave = GestorHash.ObtenerInstancia().HashPassword(txtClave.Text);
                usuario.Idioma = (Idioma)cboIdioma.SelectedItem;
                usuario.Perfil = (PermisoBase)cboPerfil.SelectedItem;
                usuario.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(usuario);

                bool resultado = false;

                if (Operacion == Accion.Alta)
                {
                    resultado = GestorUsuario.ObtenerInstancia().CrearUsuario(usuario);
                }
                else if (Operacion == Accion.Modificacion)
                {
                    resultado = GestorUsuario.ObtenerInstancia().ActualizarUsuario(usuario);
                }
                
                if(resultado)
                {
                    if (GestorBD.ObtenerInstancia().ActualizarDVV("USUARIO"))
                    {
                        MessageBox.Show("Se ha creado/modificado el usuario correctamente");
                        HabilitarControles(false);
                        LimpiarControles();
                        CargarUsuarios();   
                    }
                }

            }
            catch (Exception ex)
            {

                string mensajeError = string.Empty;

                if (this.Operacion == Accion.Alta)
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaUsuarioFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }
                else
                {
                    mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionUsuarioFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                }
                
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarControles(bool bHabilita)
        {
            this.txtUsuario.Enabled = bHabilita;
            this.txtClave.Enabled = bHabilita;
            this.cboIdioma.Enabled = bHabilita;
            this.cboPerfil.Enabled = bHabilita;
            this.btnAceptar.Enabled = bHabilita;
            this.btnCancelar.Enabled = bHabilita;
        }

        private void LimpiarControles()
        {
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            this.cboIdioma.SelectedIndex = -1;
            this.cboPerfil.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            LimpiarControles();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridUsuarios.SelectedRows.Count != 0)
                {
                    this.Operacion = FABMUsuario.Accion.Modificacion;
                    HabilitarControles(true);
                    this.txtUsuario.Enabled = false;

                    DataGridViewRow row = this.gridUsuarios.SelectedRows[0];
                    this.txtUsuario.Text = row.Cells["Nombre"].Value.ToString();
                    this.cboIdioma.SelectedValue = row.Cells["Idioma"].Value.ToString();
                    this.cboPerfil.SelectedValue = row.Cells["Perfil"].Value.ToString();
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

                if (gridUsuarios.SelectedRows.Count != 0)
                {

                    DataGridViewRow row = this.gridUsuarios.SelectedRows[0];
                    this.cboIdioma.SelectedValue = row.Cells["Idioma"].Value.ToString();
                    this.cboPerfil.SelectedValue = row.Cells["Perfil"].Value.ToString();

                    Usuario usuario = new Usuario();
                    usuario.Nombre = row.Cells["Nombre"].Value.ToString();

                    usuario.Idioma = (Idioma)this.cboIdioma.SelectedItem;
                    usuario.Perfil = (PermisoBase)this.cboPerfil.SelectedItem;

                    DialogResult dialogo = MessageBox.Show("¿Desea eliminar definitivamente al usuario " + usuario.Nombre + "?", "Baja de Usuario", MessageBoxButtons.YesNo);

                    if (dialogo == DialogResult.Yes)
                    {
                        if (GestorUsuario.ObtenerInstancia().EliminarUsuario(usuario))
                        {

                            if (GestorBD.ObtenerInstancia().ActualizarDVV("USUARIO"))
                            {
                                MessageBox.Show("El usuario se ha eliminado correctamente", "Baja de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarUsuarios();
                            }
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BajaUsuarioFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
