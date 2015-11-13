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
    public partial class FDetalleHorasMensuales : Form
    {
        public FDetalleHorasMensuales()
        {
            InitializeComponent();
        }

        private void CargarComboAño()
        {
            try
            {
                int añoActual = DateTime.Now.Year;
                this.cboAño.DataSource = Enumerable.Range(añoActual - 2, 5).ToList();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboMes()
        {
            try
            {
                this.cboMes.DataSource = Enumerable.Range(1, 12).ToList();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            List<HorasMensuales> horasTrabajadas = null;

            try
            {
                DateTime fechaHoraInicio = new DateTime((int)this.cboAño.SelectedItem, (int)this.cboMes.SelectedItem, 1);

                horasTrabajadas = GestorReserva.ObtenerInstancia().ConsultarHorasMensualesTrabajadas(fechaHoraInicio);

                if (horasTrabajadas.Count > 0)
                {
                    this.gridDetalleHoras.DataSource = horasTrabajadas;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaHorasMensualesFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FDetalleHorasMensuales_Load(object sender, EventArgs e)
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

            CargarComboAño();
            CargarComboMes();
        }
    }
}
