namespace Gestor_de_Eventos
{
    partial class FModificacionEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtClienteDU = new System.Windows.Forms.TextBox();
            this.lblDUCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.gbCotizacion = new System.Windows.Forms.GroupBox();
            this.btnRecotizar = new System.Windows.Forms.Button();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblMontoTotalNvo2 = new System.Windows.Forms.Label();
            this.lblMontoTotalNuevo1 = new System.Windows.Forms.Label();
            this.lblMontoTotalAnt2 = new System.Windows.Forms.Label();
            this.lblMontoPagado2 = new System.Windows.Forms.Label();
            this.lblMontoTotalAnterior1 = new System.Windows.Forms.Label();
            this.lblMontoPagado1 = new System.Windows.Forms.Label();
            this.gbDetalleEvento = new System.Windows.Forms.GroupBox();
            this.lblEstado2 = new System.Windows.Forms.Label();
            this.lblEstado1 = new System.Windows.Forms.Label();
            this.gbDuracion = new System.Windows.Forms.GroupBox();
            this.lblCantidadHoras2 = new System.Windows.Forms.Label();
            this.lblCantidadHoras1 = new System.Windows.Forms.Label();
            this.btnQuitarDuracion = new System.Windows.Forms.Button();
            this.btnAgregarDuracion = new System.Windows.Forms.Button();
            this.lblHoraFin2 = new System.Windows.Forms.Label();
            this.lblHoraFin1 = new System.Windows.Forms.Label();
            this.lblHoraInicio2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblHoraInicio1 = new System.Windows.Forms.Label();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.btnQuitarServicio = new System.Windows.Forms.Button();
            this.listServicios = new System.Windows.Forms.ListBox();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.gbPersonas = new System.Windows.Forms.GroupBox();
            this.btnQuitarPersonas = new System.Windows.Forms.Button();
            this.btnAgregarPersonas = new System.Windows.Forms.Button();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.lblAdultos1 = new System.Windows.Forms.Label();
            this.lblNiños2 = new System.Windows.Forms.Label();
            this.lblAdultos2 = new System.Windows.Forms.Label();
            this.lblNiños1 = new System.Windows.Forms.Label();
            this.lblTipoEvento2 = new System.Windows.Forms.Label();
            this.lblTipoEvento1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gridReserva = new System.Windows.Forms.DataGridView();
            this.chkCancelar = new System.Windows.Forms.CheckBox();
            this.gbBusqueda.SuspendLayout();
            this.gbCotizacion.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.gbDetalleEvento.SuspendLayout();
            this.gbDuracion.SuspendLayout();
            this.gbServicios.SuspendLayout();
            this.gbPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.txtClienteDU);
            this.gbBusqueda.Controls.Add(this.lblDUCliente);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.lblFechaHasta);
            this.gbBusqueda.Controls.Add(this.dtpFechaHasta);
            this.gbBusqueda.Controls.Add(this.lblFechaDesde);
            this.gbBusqueda.Controls.Add(this.dtpFechaDesde);
            this.gbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBusqueda.Size = new System.Drawing.Size(451, 124);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // txtClienteDU
            // 
            this.txtClienteDU.Location = new System.Drawing.Point(115, 33);
            this.txtClienteDU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDU.Name = "txtClienteDU";
            this.txtClienteDU.Size = new System.Drawing.Size(200, 22);
            this.txtClienteDU.TabIndex = 0;
            // 
            // lblDUCliente
            // 
            this.lblDUCliente.AutoSize = true;
            this.lblDUCliente.Location = new System.Drawing.Point(29, 36);
            this.lblDUCliente.Name = "lblDUCliente";
            this.lblDUCliente.Size = new System.Drawing.Size(79, 17);
            this.lblDUCliente.TabIndex = 5;
            this.lblDUCliente.Text = "DU Cliente:";
            this.lblDUCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Location = new System.Drawing.Point(347, 47);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 53);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(16, 94);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(92, 17);
            this.lblFechaHasta.TabIndex = 3;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            this.lblFechaHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(115, 91);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 65);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(96, 17);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Fecha Desde:";
            this.lblFechaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(115, 62);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // gbCotizacion
            // 
            this.gbCotizacion.Controls.Add(this.btnRecotizar);
            this.gbCotizacion.Controls.Add(this.gbPago);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalNvo2);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalNuevo1);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalAnt2);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado2);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalAnterior1);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado1);
            this.gbCotizacion.Location = new System.Drawing.Point(339, 214);
            this.gbCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Name = "gbCotizacion";
            this.gbCotizacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Size = new System.Drawing.Size(436, 150);
            this.gbCotizacion.TabIndex = 3;
            this.gbCotizacion.TabStop = false;
            this.gbCotizacion.Text = "Cotización";
            // 
            // btnRecotizar
            // 
            this.btnRecotizar.ForeColor = System.Drawing.Color.Black;
            this.btnRecotizar.Location = new System.Drawing.Point(311, 98);
            this.btnRecotizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecotizar.Name = "btnRecotizar";
            this.btnRecotizar.Size = new System.Drawing.Size(99, 46);
            this.btnRecotizar.TabIndex = 1;
            this.btnRecotizar.Text = "Recotizar";
            this.btnRecotizar.UseVisualStyleBackColor = true;
            this.btnRecotizar.Click += new System.EventHandler(this.btnRecotizar_Click);
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.txtPago);
            this.gbPago.Controls.Add(this.label22);
            this.gbPago.Location = new System.Drawing.Point(253, 28);
            this.gbPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPago.Name = "gbPago";
            this.gbPago.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPago.Size = new System.Drawing.Size(155, 64);
            this.gbPago.TabIndex = 0;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Ingresar Pago";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(45, 34);
            this.txtPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(101, 22);
            this.txtPago.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 17);
            this.label22.TabIndex = 0;
            this.label22.Text = "$";
            // 
            // lblMontoTotalNvo2
            // 
            this.lblMontoTotalNvo2.AutoSize = true;
            this.lblMontoTotalNvo2.Location = new System.Drawing.Point(155, 104);
            this.lblMontoTotalNvo2.Name = "lblMontoTotalNvo2";
            this.lblMontoTotalNvo2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoTotalNvo2.TabIndex = 19;
            this.lblMontoTotalNvo2.Text = "$0,00";
            this.lblMontoTotalNvo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontoTotalNuevo1
            // 
            this.lblMontoTotalNuevo1.AutoSize = true;
            this.lblMontoTotalNuevo1.Location = new System.Drawing.Point(16, 104);
            this.lblMontoTotalNuevo1.Name = "lblMontoTotalNuevo1";
            this.lblMontoTotalNuevo1.Size = new System.Drawing.Size(132, 17);
            this.lblMontoTotalNuevo1.TabIndex = 18;
            this.lblMontoTotalNuevo1.Text = "Monto Total Nuevo:";
            this.lblMontoTotalNuevo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontoTotalAnt2
            // 
            this.lblMontoTotalAnt2.AutoSize = true;
            this.lblMontoTotalAnt2.Location = new System.Drawing.Point(155, 75);
            this.lblMontoTotalAnt2.Name = "lblMontoTotalAnt2";
            this.lblMontoTotalAnt2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoTotalAnt2.TabIndex = 17;
            this.lblMontoTotalAnt2.Text = "$0,00";
            this.lblMontoTotalAnt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontoPagado2
            // 
            this.lblMontoPagado2.AutoSize = true;
            this.lblMontoPagado2.Location = new System.Drawing.Point(155, 46);
            this.lblMontoPagado2.Name = "lblMontoPagado2";
            this.lblMontoPagado2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoPagado2.TabIndex = 16;
            this.lblMontoPagado2.Text = "$0,00";
            this.lblMontoPagado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontoTotalAnterior1
            // 
            this.lblMontoTotalAnterior1.AutoSize = true;
            this.lblMontoTotalAnterior1.Location = new System.Drawing.Point(7, 75);
            this.lblMontoTotalAnterior1.Name = "lblMontoTotalAnterior1";
            this.lblMontoTotalAnterior1.Size = new System.Drawing.Size(141, 17);
            this.lblMontoTotalAnterior1.TabIndex = 1;
            this.lblMontoTotalAnterior1.Text = "Monto Total Anterior:";
            this.lblMontoTotalAnterior1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontoPagado1
            // 
            this.lblMontoPagado1.AutoSize = true;
            this.lblMontoPagado1.Location = new System.Drawing.Point(44, 46);
            this.lblMontoPagado1.Name = "lblMontoPagado1";
            this.lblMontoPagado1.Size = new System.Drawing.Size(104, 17);
            this.lblMontoPagado1.TabIndex = 0;
            this.lblMontoPagado1.Text = "Monto Pagado:";
            this.lblMontoPagado1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDetalleEvento
            // 
            this.gbDetalleEvento.Controls.Add(this.lblEstado2);
            this.gbDetalleEvento.Controls.Add(this.lblEstado1);
            this.gbDetalleEvento.Controls.Add(this.gbCotizacion);
            this.gbDetalleEvento.Controls.Add(this.gbDuracion);
            this.gbDetalleEvento.Controls.Add(this.gbServicios);
            this.gbDetalleEvento.Controls.Add(this.gbPersonas);
            this.gbDetalleEvento.Controls.Add(this.lblTipoEvento2);
            this.gbDetalleEvento.Controls.Add(this.lblTipoEvento1);
            this.gbDetalleEvento.Enabled = false;
            this.gbDetalleEvento.Location = new System.Drawing.Point(12, 313);
            this.gbDetalleEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleEvento.Name = "gbDetalleEvento";
            this.gbDetalleEvento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleEvento.Size = new System.Drawing.Size(781, 370);
            this.gbDetalleEvento.TabIndex = 2;
            this.gbDetalleEvento.TabStop = false;
            this.gbDetalleEvento.Text = "Detalle de Evento";
            // 
            // lblEstado2
            // 
            this.lblEstado2.AutoSize = true;
            this.lblEstado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado2.Location = new System.Drawing.Point(121, 28);
            this.lblEstado2.Name = "lblEstado2";
            this.lblEstado2.Size = new System.Drawing.Size(114, 20);
            this.lblEstado2.TabIndex = 19;
            this.lblEstado2.Text = "RESERVADO";
            this.lblEstado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado1
            // 
            this.lblEstado1.AutoSize = true;
            this.lblEstado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado1.Location = new System.Drawing.Point(49, 28);
            this.lblEstado1.Name = "lblEstado1";
            this.lblEstado1.Size = new System.Drawing.Size(66, 20);
            this.lblEstado1.TabIndex = 18;
            this.lblEstado1.Text = "Estado:";
            this.lblEstado1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDuracion
            // 
            this.gbDuracion.Controls.Add(this.lblCantidadHoras2);
            this.gbDuracion.Controls.Add(this.lblCantidadHoras1);
            this.gbDuracion.Controls.Add(this.btnQuitarDuracion);
            this.gbDuracion.Controls.Add(this.btnAgregarDuracion);
            this.gbDuracion.Controls.Add(this.lblHoraFin2);
            this.gbDuracion.Controls.Add(this.lblHoraFin1);
            this.gbDuracion.Controls.Add(this.lblHoraInicio2);
            this.gbDuracion.Controls.Add(this.lblFecha1);
            this.gbDuracion.Controls.Add(this.lblFecha2);
            this.gbDuracion.Controls.Add(this.lblHoraInicio1);
            this.gbDuracion.Location = new System.Drawing.Point(7, 214);
            this.gbDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDuracion.Name = "gbDuracion";
            this.gbDuracion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDuracion.Size = new System.Drawing.Size(324, 150);
            this.gbDuracion.TabIndex = 2;
            this.gbDuracion.TabStop = false;
            this.gbDuracion.Text = "Duración";
            // 
            // lblCantidadHoras2
            // 
            this.lblCantidadHoras2.AutoSize = true;
            this.lblCantidadHoras2.Location = new System.Drawing.Point(115, 119);
            this.lblCantidadHoras2.Name = "lblCantidadHoras2";
            this.lblCantidadHoras2.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadHoras2.TabIndex = 17;
            this.lblCantidadHoras2.Text = "-";
            this.lblCantidadHoras2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadHoras1
            // 
            this.lblCantidadHoras1.AutoSize = true;
            this.lblCantidadHoras1.Location = new System.Drawing.Point(20, 119);
            this.lblCantidadHoras1.Name = "lblCantidadHoras1";
            this.lblCantidadHoras1.Size = new System.Drawing.Size(89, 17);
            this.lblCantidadHoras1.TabIndex = 16;
            this.lblCantidadHoras1.Text = "Cantidad Hs:";
            this.lblCantidadHoras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuitarDuracion
            // 
            this.btnQuitarDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarDuracion.Location = new System.Drawing.Point(209, 85);
            this.btnQuitarDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarDuracion.Name = "btnQuitarDuracion";
            this.btnQuitarDuracion.Size = new System.Drawing.Size(105, 50);
            this.btnQuitarDuracion.TabIndex = 1;
            this.btnQuitarDuracion.Text = "Quitar";
            this.btnQuitarDuracion.UseVisualStyleBackColor = true;
            this.btnQuitarDuracion.Click += new System.EventHandler(this.btnQuitarDuracion_Click);
            // 
            // btnAgregarDuracion
            // 
            this.btnAgregarDuracion.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarDuracion.Location = new System.Drawing.Point(209, 28);
            this.btnAgregarDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarDuracion.Name = "btnAgregarDuracion";
            this.btnAgregarDuracion.Size = new System.Drawing.Size(105, 50);
            this.btnAgregarDuracion.TabIndex = 0;
            this.btnAgregarDuracion.Text = "Agregar";
            this.btnAgregarDuracion.UseVisualStyleBackColor = true;
            this.btnAgregarDuracion.Click += new System.EventHandler(this.btnAgregarDuracion_Click);
            // 
            // lblHoraFin2
            // 
            this.lblHoraFin2.AutoSize = true;
            this.lblHoraFin2.Location = new System.Drawing.Point(115, 92);
            this.lblHoraFin2.Name = "lblHoraFin2";
            this.lblHoraFin2.Size = new System.Drawing.Size(13, 17);
            this.lblHoraFin2.TabIndex = 15;
            this.lblHoraFin2.Text = "-";
            this.lblHoraFin2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoraFin1
            // 
            this.lblHoraFin1.AutoSize = true;
            this.lblHoraFin1.Location = new System.Drawing.Point(43, 92);
            this.lblHoraFin1.Name = "lblHoraFin1";
            this.lblHoraFin1.Size = new System.Drawing.Size(66, 17);
            this.lblHoraFin1.TabIndex = 12;
            this.lblHoraFin1.Text = "Hora Fin:";
            this.lblHoraFin1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoraInicio2
            // 
            this.lblHoraInicio2.AutoSize = true;
            this.lblHoraInicio2.Location = new System.Drawing.Point(115, 65);
            this.lblHoraInicio2.Name = "lblHoraInicio2";
            this.lblHoraInicio2.Size = new System.Drawing.Size(13, 17);
            this.lblHoraInicio2.TabIndex = 14;
            this.lblHoraInicio2.Text = "-";
            this.lblHoraInicio2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.Location = new System.Drawing.Point(59, 38);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(51, 17);
            this.lblFecha1.TabIndex = 10;
            this.lblFecha1.Text = "Fecha:";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(115, 38);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(13, 17);
            this.lblFecha2.TabIndex = 13;
            this.lblFecha2.Text = "-";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoraInicio1
            // 
            this.lblHoraInicio1.AutoSize = true;
            this.lblHoraInicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio1.Location = new System.Drawing.Point(29, 65);
            this.lblHoraInicio1.Name = "lblHoraInicio1";
            this.lblHoraInicio1.Size = new System.Drawing.Size(79, 17);
            this.lblHoraInicio1.TabIndex = 11;
            this.lblHoraInicio1.Text = "Hora Inicio:";
            this.lblHoraInicio1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.btnQuitarServicio);
            this.gbServicios.Controls.Add(this.listServicios);
            this.gbServicios.Controls.Add(this.cboServicios);
            this.gbServicios.Controls.Add(this.btnAgregarServicio);
            this.gbServicios.Location = new System.Drawing.Point(337, 66);
            this.gbServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbServicios.Size = new System.Drawing.Size(436, 142);
            this.gbServicios.TabIndex = 1;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Servicios Contratados";
            // 
            // btnQuitarServicio
            // 
            this.btnQuitarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarServicio.Location = new System.Drawing.Point(327, 81);
            this.btnQuitarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarServicio.Name = "btnQuitarServicio";
            this.btnQuitarServicio.Size = new System.Drawing.Size(105, 50);
            this.btnQuitarServicio.TabIndex = 2;
            this.btnQuitarServicio.Text = "Quitar";
            this.btnQuitarServicio.UseVisualStyleBackColor = true;
            this.btnQuitarServicio.Click += new System.EventHandler(this.btnQuitarServicio_Click);
            // 
            // listServicios
            // 
            this.listServicios.FormattingEnabled = true;
            this.listServicios.ItemHeight = 16;
            this.listServicios.Location = new System.Drawing.Point(5, 31);
            this.listServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listServicios.Name = "listServicios";
            this.listServicios.Size = new System.Drawing.Size(199, 100);
            this.listServicios.TabIndex = 3;
            // 
            // cboServicios
            // 
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(215, 31);
            this.cboServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(215, 24);
            this.cboServicios.TabIndex = 0;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarServicio.Location = new System.Drawing.Point(213, 81);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(105, 50);
            this.btnAgregarServicio.TabIndex = 1;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // gbPersonas
            // 
            this.gbPersonas.Controls.Add(this.btnQuitarPersonas);
            this.gbPersonas.Controls.Add(this.btnAgregarPersonas);
            this.gbPersonas.Controls.Add(this.cboPersonas);
            this.gbPersonas.Controls.Add(this.lblAdultos1);
            this.gbPersonas.Controls.Add(this.lblNiños2);
            this.gbPersonas.Controls.Add(this.lblAdultos2);
            this.gbPersonas.Controls.Add(this.lblNiños1);
            this.gbPersonas.Location = new System.Drawing.Point(7, 64);
            this.gbPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPersonas.Name = "gbPersonas";
            this.gbPersonas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPersonas.Size = new System.Drawing.Size(324, 144);
            this.gbPersonas.TabIndex = 0;
            this.gbPersonas.TabStop = false;
            this.gbPersonas.Text = "Personas";
            // 
            // btnQuitarPersonas
            // 
            this.btnQuitarPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarPersonas.Location = new System.Drawing.Point(209, 78);
            this.btnQuitarPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarPersonas.Name = "btnQuitarPersonas";
            this.btnQuitarPersonas.Size = new System.Drawing.Size(105, 50);
            this.btnQuitarPersonas.TabIndex = 2;
            this.btnQuitarPersonas.Text = "Quitar";
            this.btnQuitarPersonas.UseVisualStyleBackColor = true;
            this.btnQuitarPersonas.Click += new System.EventHandler(this.btnQuitarPersonas_Click);
            // 
            // btnAgregarPersonas
            // 
            this.btnAgregarPersonas.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarPersonas.Location = new System.Drawing.Point(209, 21);
            this.btnAgregarPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPersonas.Name = "btnAgregarPersonas";
            this.btnAgregarPersonas.Size = new System.Drawing.Size(105, 50);
            this.btnAgregarPersonas.TabIndex = 1;
            this.btnAgregarPersonas.Text = "Agregar";
            this.btnAgregarPersonas.UseVisualStyleBackColor = true;
            this.btnAgregarPersonas.Click += new System.EventHandler(this.btnAgregarPersonas_Click);
            // 
            // cboPersonas
            // 
            this.cboPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Items.AddRange(new object[] {
            "Adultos",
            "Niños"});
            this.cboPersonas.Location = new System.Drawing.Point(20, 96);
            this.cboPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(159, 24);
            this.cboPersonas.TabIndex = 0;
            // 
            // lblAdultos1
            // 
            this.lblAdultos1.AutoSize = true;
            this.lblAdultos1.Location = new System.Drawing.Point(29, 36);
            this.lblAdultos1.Name = "lblAdultos1";
            this.lblAdultos1.Size = new System.Drawing.Size(119, 17);
            this.lblAdultos1.TabIndex = 1;
            this.lblAdultos1.Text = "Cantidad Adultos:";
            this.lblAdultos1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNiños2
            // 
            this.lblNiños2.AutoSize = true;
            this.lblNiños2.Location = new System.Drawing.Point(155, 66);
            this.lblNiños2.Name = "lblNiños2";
            this.lblNiños2.Size = new System.Drawing.Size(16, 17);
            this.lblNiños2.TabIndex = 8;
            this.lblNiños2.Text = "0";
            this.lblNiños2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdultos2
            // 
            this.lblAdultos2.AutoSize = true;
            this.lblAdultos2.Location = new System.Drawing.Point(155, 36);
            this.lblAdultos2.Name = "lblAdultos2";
            this.lblAdultos2.Size = new System.Drawing.Size(16, 17);
            this.lblAdultos2.TabIndex = 7;
            this.lblAdultos2.Text = "0";
            this.lblAdultos2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNiños1
            // 
            this.lblNiños1.AutoSize = true;
            this.lblNiños1.Location = new System.Drawing.Point(20, 66);
            this.lblNiños1.Name = "lblNiños1";
            this.lblNiños1.Size = new System.Drawing.Size(128, 17);
            this.lblNiños1.TabIndex = 2;
            this.lblNiños1.Text = "Cantidad de Niños:";
            this.lblNiños1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoEvento2
            // 
            this.lblTipoEvento2.AutoSize = true;
            this.lblTipoEvento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento2.Location = new System.Drawing.Point(476, 28);
            this.lblTipoEvento2.Name = "lblTipoEvento2";
            this.lblTipoEvento2.Size = new System.Drawing.Size(156, 20);
            this.lblTipoEvento2.TabIndex = 6;
            this.lblTipoEvento2.Text = "Cumpleaños Infantil";
            this.lblTipoEvento2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoEvento1
            // 
            this.lblTipoEvento1.AutoSize = true;
            this.lblTipoEvento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento1.Location = new System.Drawing.Point(345, 28);
            this.lblTipoEvento1.Name = "lblTipoEvento1";
            this.lblTipoEvento1.Size = new System.Drawing.Size(125, 20);
            this.lblTipoEvento1.TabIndex = 0;
            this.lblTipoEvento1.Text = "Tipo de Evento:";
            this.lblTipoEvento1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(687, 692);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(576, 692);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 50);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gridReserva
            // 
            this.gridReserva.AllowUserToAddRows = false;
            this.gridReserva.AllowUserToDeleteRows = false;
            this.gridReserva.AllowUserToResizeRows = false;
            this.gridReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReserva.Location = new System.Drawing.Point(13, 142);
            this.gridReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridReserva.Name = "gridReserva";
            this.gridReserva.ReadOnly = true;
            this.gridReserva.RowHeadersVisible = false;
            this.gridReserva.RowTemplate.Height = 24;
            this.gridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReserva.Size = new System.Drawing.Size(780, 165);
            this.gridReserva.TabIndex = 1;
            this.gridReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellDoubleClick);
            // 
            // chkCancelar
            // 
            this.chkCancelar.AutoSize = true;
            this.chkCancelar.Location = new System.Drawing.Point(19, 692);
            this.chkCancelar.Name = "chkCancelar";
            this.chkCancelar.Size = new System.Drawing.Size(86, 21);
            this.chkCancelar.TabIndex = 5;
            this.chkCancelar.Text = "Cancelar";
            this.chkCancelar.UseVisualStyleBackColor = true;
            this.chkCancelar.CheckedChanged += new System.EventHandler(this.chkCancelar_CheckedChanged);
            // 
            // FModificacionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 754);
            this.Controls.Add(this.chkCancelar);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDetalleEvento);
            this.Controls.Add(this.gbBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(821, 801);
            this.Name = "FModificacionEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificación de Eventos";
            this.Load += new System.EventHandler(this.FModificacionEvento_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbCotizacion.ResumeLayout(false);
            this.gbCotizacion.PerformLayout();
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbDetalleEvento.ResumeLayout(false);
            this.gbDetalleEvento.PerformLayout();
            this.gbDuracion.ResumeLayout(false);
            this.gbDuracion.PerformLayout();
            this.gbServicios.ResumeLayout(false);
            this.gbPersonas.ResumeLayout(false);
            this.gbPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.TextBox txtClienteDU;
        private System.Windows.Forms.Label lblDUCliente;
        private System.Windows.Forms.GroupBox gbCotizacion;
        private System.Windows.Forms.Label lblMontoTotalAnt2;
        private System.Windows.Forms.Label lblMontoPagado2;
        private System.Windows.Forms.Label lblMontoTotalAnterior1;
        private System.Windows.Forms.Label lblMontoPagado1;
        private System.Windows.Forms.GroupBox gbDetalleEvento;
        private System.Windows.Forms.Label lblNiños2;
        private System.Windows.Forms.Label lblAdultos2;
        private System.Windows.Forms.Label lblTipoEvento2;
        private System.Windows.Forms.ListBox listServicios;
        private System.Windows.Forms.Label lblNiños1;
        private System.Windows.Forms.Label lblAdultos1;
        private System.Windows.Forms.Label lblTipoEvento1;
        private System.Windows.Forms.GroupBox gbPersonas;
        private System.Windows.Forms.Button btnQuitarPersonas;
        private System.Windows.Forms.Button btnAgregarPersonas;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.Label lblHoraFin2;
        private System.Windows.Forms.Label lblHoraInicio2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblHoraFin1;
        private System.Windows.Forms.Label lblHoraInicio1;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.Button btnQuitarServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.GroupBox gbDuracion;
        private System.Windows.Forms.Button btnQuitarDuracion;
        private System.Windows.Forms.Button btnAgregarDuracion;
        private System.Windows.Forms.Label lblMontoTotalNvo2;
        private System.Windows.Forms.Label lblMontoTotalNuevo1;
        private System.Windows.Forms.Label lblEstado2;
        private System.Windows.Forms.Label lblEstado1;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCantidadHoras2;
        private System.Windows.Forms.Label lblCantidadHoras1;
        private System.Windows.Forms.Button btnRecotizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.CheckBox chkCancelar;
    }
}