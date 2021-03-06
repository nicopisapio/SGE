﻿using GE_Business;
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
    public partial class FAgregarExcedente : Form
    {

        Reserva reserva;

        public FAgregarExcedente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value.Date;
                DateTime fechaHasta = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);
                Int64 duCliente = 0;

                Int64.TryParse(this.txtClienteDU.Text, out duCliente);

                if (fechaHasta > fechaDesde)
                {

                    if (duCliente > 0)
                    {
                        List<Reserva> reservas = GestorReserva.ObtenerInstancia().ConsultarReservasCliente(duCliente, fechaDesde, fechaHasta);

                        if (reservas != null)
                        {
                            gridReserva.DataSource = reservas.ToArray();
                        }
                        else
                        {
                            gridReserva.DataSource = null;
                            LimpiarControles();
                            HabilitarControles(false);
                            MessageBox.Show("No se han encontrado coincidencias.", "Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un DU válido.", "Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La Fecha Hasta debe ser mayor que la Fecha Desde.", "Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        CargarDatos(reserva);
                        this.gbCotizacion.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManager.ObtenerInstancia().LoguearErrorBD(ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos(Reserva reserva)
        {

            this.lblMontoPagado2.Text = reserva.MontoPagado.ToString("C2");
            this.lblMontoTotalAnt2.Text = reserva.MontoTotal.ToString("C2");

            if (reserva.Estado == "R" || reserva.Estado == "P")
            {
                gbCotizacion.Enabled = true;
            }
            else
            {
                gbCotizacion.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            this.gbCotizacion.Enabled = false;
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            reserva = null;

            this.txtClienteDU.Clear();
            this.txtExcedente.Clear();

            this.lblMontoPagado2.Text = 0.ToString("C2");
            this.lblMontoTotalAnt2.Text = 0.ToString("C2");
            this.lblMontoTotalNvo2.Text = 0.ToString("C2");
        }

        private void btnRecotizar_Click(object sender, EventArgs e)
        {
            try
            {
                double precioExcedente = 0;
                if (!double.TryParse(this.txtExcedente.Text, out precioExcedente))
                {
                    MessageBox.Show("Ingrese un valor numérico.", "Gestión de Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtExcedente.Focus();
                    return;
                }

                if (precioExcedente > 0)
                {
                    Excedente excedente = new Excedente();
                    excedente.Monto = precioExcedente;
                    reserva.AgregarExcedente(excedente);
                    this.lblMontoTotalNvo2.Text = GestorReserva.ObtenerInstancia().CalcularCostoTotalReserva(reserva).ToString("C2");
                    MessageBox.Show("Se ha agregado el excedente correctamente.", "Gestión de Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControles(true);
                }
                else
                {
                    MessageBox.Show("El valor ingresado debe ser mayor a 0.", "Gestión de Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.CalcularCostoReservaFallido, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GestorReserva.ObtenerInstancia().ActualizarReserva(reserva))
                {
                    if (GestorBD.ObtenerInstancia().ActualizarDVV("RESERVA"))
                    {
                        MessageBox.Show("El excedente se ha guardado con éxito.", "Excedentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarControles(false);
                        LimpiarControles();
                        this.gbCotizacion.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                string mensajeError = ErrorManager.ObtenerInstancia().LoguearGenerarMensajeError(ex, MensajeError.AltaExcedenteFallida, FormHelper.ObtenerInstancia().TraerUltimoIdioma());
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void FAgregarExcedente_Load(object sender, EventArgs e)
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
        }

        private void HabilitarControles(bool habilita)
        {
            this.btnAceptar.Enabled = habilita;
            this.btnCancelar.Enabled = habilita;
        }
    }
}
