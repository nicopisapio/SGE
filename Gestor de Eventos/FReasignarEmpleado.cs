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
    public partial class FReasignarEmpleado : Form
    {

        private Reserva reserva = null;

        public FReasignarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fechaDesde = dtpFechaDesde.Value.Date;
                DateTime fechaHasta = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);
                Int64 duEmpleado = 0;

                Int64.TryParse(this.txtEmpleadoDU.Text, out duEmpleado);

                if (fechaHasta > fechaDesde)
                {

                    if (duEmpleado > 0)
                    {
                        List<Reserva> reservas = GestorReserva.ObtenerInstancia().ConsultarReservasEmpleado(duEmpleado, fechaDesde, fechaHasta);

                        if (reservas != null)
                        {
                            gridReserva.DataSource = reservas.ToArray();
                        }
                        else
                        {
                            gridReserva.DataSource = null;
                            MessageBox.Show("No se han encontrado coincidencias.", "Reasignación de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un DU válido.", "Reasignación de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La Fecha Hasta debe ser mayor que la Fecha Desde.", "Reasignación de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.ConsultaReservasFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridReserva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.gridReserva.Rows.Count > 0)
                {
                    reserva = (Reserva)this.gridReserva.CurrentRow.DataBoundItem;

                    if (reserva != null)
                    {
                        CargarDatosEmpleados(reserva);
                        BuscarEmpleadosDisponibles(reserva);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarEmpleadosDisponibles(Reserva reserva)
        {
            this.listEmpleadosDisponibles.DataSource = GestorReserva.ObtenerInstancia().ConsultarEmpleadosDisponibles(reserva);
        }

        private void CargarDatosEmpleados(Reserva reserva)
        {
            this.listEmpleadosAsignados.DataSource = reserva.Empleados.ToArray();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = (Empleado)this.listEmpleadosDisponibles.SelectedItem;

                if (empleado != null)
                {
                    Reserva res = new Reserva();
                    res.ID = reserva.ID;
                    res.Empleados.Add(empleado);

                    if (GestorReserva.ObtenerInstancia().AgregarEmpleadosReserva(res))
                    {
                        reserva.Empleados.Add(empleado);
                        CargarDatosEmpleados(reserva);
                        BuscarEmpleadosDisponibles(reserva);
                    }

                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AgregaEmpleadoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = (Empleado)this.listEmpleadosAsignados.SelectedItem;

                if (empleado != null)
                {
                    Reserva res = new Reserva();
                    res.ID = reserva.ID;
                    res.Empleados.Add(empleado);

                    if (GestorReserva.ObtenerInstancia().EliminarEmpleadosReserva(res))
                    {
                        reserva.Empleados.RemoveAll(x => x.DU == empleado.DU);
                        CargarDatosEmpleados(reserva);
                        BuscarEmpleadosDisponibles(reserva);
                    }

                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.QuitaEmpleadoFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FReasignarEmpleado_Load(object sender, EventArgs e)
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
