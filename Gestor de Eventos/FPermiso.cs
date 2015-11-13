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
    public partial class FPermiso : Form
    {
        public FPermiso()
        {
            InitializeComponent();
        }

        private void FPermiso_Load(object sender, EventArgs e)
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

            CargarPermisos();
            CargarGrupoPermisos();
        }

        private void CargarPermisos()
        {
            try
            {
                treePermisosPadre.Nodes.Clear();

                List<PermisoBase> listaPermisos = null;

                listaPermisos = GestorUsuario.ObtenerInstancia().ConsultarTodosPermisos();

                if (listaPermisos != null)
                {

                    TreeNode nodo;

                    foreach (PermisoBase per in listaPermisos)
                    {
                        if (per.TieneHijos())
                        {
                            GrupoPermiso padre = (GrupoPermiso)per;
                            nodo = new TreeNode(padre.Descripcion);
                            nodo.Tag = padre;

                            nodo.Nodes.AddRange(GenerarArbol(padre.Permisos).ToArray());

                        }
                        else
                        {
                            Permiso permiso = (Permiso)per;
                            nodo = new TreeNode(permiso.Descripcion);
                            nodo.Tag = permiso;
                        }

                        treePermisosPadre.Nodes.Add(nodo);
                    }

                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaPermisosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private List<TreeNode> GenerarArbol(List<PermisoBase> permisos)
        {

            List<TreeNode> arbol = new List<TreeNode>();
            TreeNode nodo;

            foreach (PermisoBase per in permisos)
            {

                if (per.TieneHijos())
                {
                    GrupoPermiso padre = (GrupoPermiso)per;
                    nodo = new TreeNode(padre.Descripcion);
                    nodo.Tag = padre;

                    nodo.Nodes.AddRange(GenerarArbol(padre.Permisos).ToArray());

                }
                else
                {
                    Permiso permiso = (Permiso)per;
                    nodo = new TreeNode(permiso.Descripcion);
                    nodo.Tag = permiso;
                }

                arbol.Add(nodo);
            }

            return arbol;

        }

        private void CargarGrupoPermisos()
        {
            try
            {
                List<GrupoPermiso> listaPermisos = null;

                listaPermisos = GestorUsuario.ObtenerInstancia().ConsultarPermisos();

                if (listaPermisos != null)
                {
                    this.listPermisosPadre.DataSource = listaPermisos.ToArray();
                    this.listPermisosPadre.DisplayMember = "Descripcion";
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaPermisosFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listPermisosPadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GrupoPermiso permiso = (GrupoPermiso)this.listPermisosPadre.SelectedItem;

                this.listPermisosHijo.DataSource = permiso.Permisos.ToArray();
                this.listPermisosHijo.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoPermiso permiso = (GrupoPermiso)this.listPermisosPadre.SelectedItem;

                if (this.treePermisosPadre.SelectedNode != null)
                {
                    PermisoBase permisoAAgregar = (PermisoBase)this.treePermisosPadre.SelectedNode.Tag;

                    if (permisoAAgregar != null)
                    {

                        if (permiso.AgregarHijo(permisoAAgregar))
                        {
                            if (GestorPermiso.ObtenerInstancia().ActualizarPermiso(permiso))
                            {
                                this.listPermisosHijo.DataSource = permiso.Permisos.ToArray();
                                this.listPermisosHijo.DisplayMember = "Descripcion";
                                CargarPermisos();
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionPermisoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {

                PermisoBase nuevoPermiso = new GrupoPermiso();
                nuevoPermiso.Accion = 0;

                nuevoPermiso.Descripcion = txtDescripcion.Text.Trim();

                if (GestorPermiso.ObtenerInstancia().CrearPermiso(nuevoPermiso))
                {
                    MessageBox.Show("El nuevo permiso se ha creado correctamente", "Gestión de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txtDescripcion.Clear();
                    CargarPermisos();
                    CargarGrupoPermisos();

                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaPermisoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoPermiso permiso = (GrupoPermiso)this.listPermisosPadre.SelectedItem;
                PermisoBase permisoAQuitar = (PermisoBase)this.listPermisosHijo.SelectedItem;

                if (permisoAQuitar != null)
                {

                    if (permiso.RemoverHijo(permisoAQuitar))
                    {
                        if (GestorPermiso.ObtenerInstancia().ActualizarPermiso(permiso))
                        {
                            this.listPermisosHijo.DataSource = permiso.Permisos.ToArray();
                            this.listPermisosHijo.DisplayMember = "Descripcion";
                            CargarPermisos();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ModificacionPermisoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.treePermisosPadre.SelectedNode != null)
                {
                    PermisoBase permiso = (PermisoBase)this.treePermisosPadre.SelectedNode.Tag;

                    if (permiso != null && permiso.Accion == 0)
                    {
                        GrupoPermiso grupoPermiso = (GrupoPermiso)permiso;

                        if (GestorPermiso.ObtenerInstancia().EliminarPermiso(grupoPermiso))
                        {
                            MessageBox.Show("El grupo se ha eliminado correctamente.", "Gestión de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.txtDescripcion.Clear();
                            CargarPermisos();
                            CargarGrupoPermisos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.BajaPermisoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
