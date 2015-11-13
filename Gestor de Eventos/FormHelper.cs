using Security.BLL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Eventos
{
    public class FormHelper
    {

        private static FormHelper instancia = new FormHelper();

        private FormHelper() 
        {
            IdiomaCambiado = false;
        }

        public bool IdiomaCambiado { get; set; }

        public static FormHelper ObtenerInstancia()
        {
            return instancia;
        }

        public void RecargarIdiomaFormulario(Form form)
        {

            try
            {
                Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;
                List<Componente> componentes;
                Componente componente;

                if (usuario != null)
                {
                    componentes = GestorIdioma.ObtenerInstancia().TraerLeyendas(form.Name, usuario.Idioma.ID);
                }
                else
                {
                    componentes = GestorIdioma.ObtenerInstancia().TraerLeyendas(form.Name, TraerUltimoIdioma());
                }

                componente = componentes.FirstOrDefault(c => c.Leyenda.Nombre == form.Name);

                if (componente != null)
                {
                    form.Text = componente.Traduccion;
                }

                foreach (Control control in form.Controls)
                {

                    if (control.GetType().ToString() == "System.Windows.Forms.MenuStrip")
                    {
                        MenuStrip controlMenu = (MenuStrip)control;

                        TraducirControl(controlMenu, componentes);
                    }
                    else
                    {
                        TraducirControl(control, componentes);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void TraducirControl(Control control, List<Componente> componentes)
        {

            Componente componente = componentes.FirstOrDefault(c => c.Leyenda.Nombre == control.Name);

            if (componente != null)
            {
                control.Text = componente.Traduccion;
            }

            if (control.HasChildren)
            {
                foreach (Control controlHijo in control.Controls)
                {
                    TraducirControl(controlHijo, componentes);
                }
            }
        }

        private void TraducirControl(ToolStrip menuStrip, List<Componente> componentes)
        {
            Componente componente;

            foreach (ToolStripItem menuItem in menuStrip.Items)
            {
                if (menuItem.GetType().ToString() == "System.Windows.Forms.ToolStripMenuItem")
                {

                    ToolStripDropDownItem item = (ToolStripDropDownItem)menuItem;

                    componente = componentes.FirstOrDefault(c => c.Leyenda.Nombre == item.Name);

                    if (componente != null)
                    {
                        item.Text = componente.Traduccion;
                    }

                    if (item.HasDropDownItems)
                    {
                        TraducirControl(item.DropDown, componentes);
                    }
                }
            }
        }

        public string TraerUltimoIdioma()
        {
            return ConfigurationManager.AppSettings["Idioma"].ToString();
        }

        public void MostrarFormulario(Form parent, Form hijo)
        {
            if (parent.ActiveMdiChild != null) parent.ActiveMdiChild.Close();
            hijo.MdiParent = parent;
            hijo.Show();
        }

        public void MostrarFormulario(Form parent, Form hijo, string parametro)
        {
            if (parent.ActiveMdiChild != null) parent.ActiveMdiChild.Close();
            hijo.MdiParent = parent;
            hijo.Tag = parametro;
            hijo.Show();
        }
    }
}
