using GE_Business;
using GE_Entities;
using Security.BLL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Eventos
{
    public partial class FABMIdioma : Form
    {
        public FABMIdioma()
        {
            InitializeComponent();
        }

        private void FABMIdioma_Load(object sender, EventArgs e)
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

            CargarComboCultura();
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            List<Componente> componentes = GestorIdioma.ObtenerInstancia().TraerLeyendasTodas(GestorLogin.ObtenerInstancia().Usuario.Idioma.ID);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id Leyenda");
            tabla.Columns.Add("Texto");
            tabla.Columns.Add("Traduccion");

            foreach (Componente componente in componentes)
            {
                DataRow row = tabla.NewRow();
                row[0] = componente.Leyenda.ID;
                row[1] = componente.Traduccion;

                tabla.Rows.Add(row);
            }

            gridTraduccion.DataSource = tabla;
            gridTraduccion.Columns[0].ReadOnly = true;
            gridTraduccion.Columns[1].ReadOnly = true;
        }

        private void CargarComboCultura()
        {

            try
            {
                List<Idioma> idiomas = GestorIdioma.ObtenerInstancia().ConsultarIdiomas();
                List<CultureInfo> culturas = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures).ToList();

                foreach (Idioma idioma in idiomas)
                {
                    culturas.RemoveAll(x => x.Name == idioma.ID);
                }

                this.cboCulturas.DataSource = culturas;
                this.cboCulturas.DisplayMember = "DisplayName";
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaCulturasFallidas, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txtNombreIdioma.Text))
                {
                    List<Componente> componentes = new List<Componente>();
                    Componente componente;

                    CultureInfo culturaElegida = (CultureInfo)cboCulturas.SelectedItem;

                    DataTable tabla = (DataTable)this.gridTraduccion.DataSource;

                    foreach (DataRow row in tabla.Rows)
                    {
                        componente = new Componente();
                        componente.Idioma = new Idioma();
                        componente.Idioma.ID = culturaElegida.Name;
                        componente.Idioma.Nombre = txtNombreIdioma.Text.Trim();
                        componente.Leyenda = new Leyenda();
                        componente.Leyenda.ID = Convert.ToInt32(row[0]);
                        componente.Traduccion = string.IsNullOrWhiteSpace(Convert.ToString(row[2])) ? Convert.ToString(row[1]) : Convert.ToString(row[2]);

                        componentes.Add(componente);
                    }

                    if (GestorIdioma.ObtenerInstancia().InsertarNuevoIdioma(componentes))
                    {
                        MessageBox.Show("El idioma se ha creado correctamente", "Gestor de Idioma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarComponentes();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre de Idioma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.NuevoIdiomaFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void LimpiarComponentes()
        {
            cboCulturas.SelectedIndex = 0;
            txtNombreIdioma.Clear();

            foreach (DataGridViewRow row in gridTraduccion.Rows)
            {
                row.Cells[2].Value = null;
            }
            //gridTraduccion.Rows[2].Cells.Clear();
            //CargarGrilla();
        }
    }
}
