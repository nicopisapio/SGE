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
    public partial class FBitacora : Form
    {
        public FBitacora()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {

                List<Bitacora> datos;

                if (cboUsuario.Visible)
                {

                    Usuario usuario = (Usuario)cboUsuario.SelectedItem;

                    if (string.IsNullOrEmpty((string)this.cboTipo.SelectedItem) && !chkUsuario.Checked)
                    {
                        datos = GestorBitacora.ObtenerInstancia().ConsultarBitacora(dtpFechaDesde.Value);
                    }
                    else if (!chkUsuario.Checked)
                    {
                        datos = GestorBitacora.ObtenerInstancia().ConsultarBitacora((string)cboTipo.SelectedItem, dtpFechaDesde.Value);
                    }
                    else if (string.IsNullOrEmpty((string)this.cboTipo.SelectedItem) && chkUsuario.Checked)
                    {
                        datos = GestorBitacora.ObtenerInstancia().ConsultarBitacora(dtpFechaDesde.Value, usuario);
                    }
                    else
                    {
                        datos = GestorBitacora.ObtenerInstancia().ConsultarBitacora((string)cboTipo.SelectedItem, dtpFechaDesde.Value, usuario);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty((string)cboTipo.SelectedItem))
                    {
                        datos = GestorBitacora.ObtenerInstancia().ConsultarBitacora(dtpFechaDesde.Value);
                    }
                    else
                    {
                        datos = GestorBitacora.ObtenerInstancia().ConsultarBitacora((string)cboTipo.SelectedItem, dtpFechaDesde.Value);
                    }
                }

                if (datos != null)       
                {
                    gridBitacora.DataSource = datos;
                }
                else
                {
                    MessageBox.Show("No se han encontrado datos", "Consulta Bitácora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaBitacoraFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FBitacora_Load(object sender, EventArgs e)
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

            CargarComboTipo();
            dtpFechaDesde.Value = DateTime.Now;
            MostrarFiltroUsuario(GestorLogin.ObtenerInstancia().Usuario.Perfil.VerificarPermiso("SUPERADMIN"));
        }

        private void CargarComboTipo()
        {

            List<string> tiposLog = new List<string>();

            tiposLog.Add("");
            tiposLog.Add("ERROR");
            tiposLog.Add("INFO");

            this.cboTipo.DataSource = tiposLog;
        }

        private void MostrarFiltroUsuario(bool visible)
        {

            cboUsuario.Visible = visible;
            lblUsuario.Visible = visible;
            chkUsuario.Visible = visible;

            CargarComboUsuario();
            cboUsuario.Enabled = false;

            //if (visible)
            //{
            //    //gpFiltro.Size = new Size(627, 115);
            //    //btnBuscar.Location = new Point(645, 50);
            //}
            //else
            //{
            //    //gpFiltro.Size = new Size(336, 115);
            //    //gpFiltro.Location = new Point(12, 12);
            //    //btnBuscar.Location = new Point(372, 50);
            //}
        }

        private void CargarComboUsuario()
        {
            try
            {
                List<Usuario> usuarios = GestorUsuario.ObtenerInstancia().ConsultarUsuarios();

                if (usuarios != null)
                {
                    cboUsuario.DataSource = usuarios;
                    cboUsuario.DisplayMember = "Nombre";
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaUsuariosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkUsuario.Checked)
            {
                cboUsuario.Enabled = true;
            }
            else
            {
                cboUsuario.Enabled = false;
            }
        }
    }
}
