using GE_Business;
using GE_Entities;
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
    public partial class FDetalleHorasSemanales : Form
    {
        public FDetalleHorasSemanales()
        {
            InitializeComponent();
        }

        private void FDetalleHorasSemanales_Load(object sender, EventArgs e)
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
            CargarComboSemana();
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

        private void CargarComboSemana()
        {
            try
            {
                this.cboSemana.DataSource = null;

                int año = (int)this.cboAño.SelectedItem;

                int mes = 1;

                if (this.cboMes.Items.Count > 0)
                {
                    mes = (int)this.cboMes.SelectedItem;
                }

                var fechas = Enumerable.Range(1, DateTime.DaysInMonth(año, mes)).Select(n => new DateTime(año, mes, n));

                var semanas = from d in fechas
                              where d.DayOfWeek == DayOfWeek.Monday
                              select d;

                this.cboSemana.DataSource = semanas.ToList();
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboSemana();
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboSemana();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            List<HorasSemanales> horasTrabajadas = null;

            try
            {

                DateTime fechaHoraInicio = (DateTime)this.cboSemana.SelectedItem;
                DateTime fechaHoraFin = fechaHoraInicio.AddDays(7);

                horasTrabajadas = GestorReserva.ObtenerInstancia().ConsultarHorasSemanalesTrabajadas(fechaHoraInicio, fechaHoraFin);

                if (horasTrabajadas.Count > 0)
                {
                    this.gridDetalleHoras.DataSource = horasTrabajadas;
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaHorasSemanalesFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
