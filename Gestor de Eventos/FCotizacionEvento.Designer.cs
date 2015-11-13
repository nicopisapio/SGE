namespace Gestor_de_Eventos
{
    partial class FCotizacionEvento
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
            this.gpEvento = new System.Windows.Forms.GroupBox();
            this.lblCantidadNiños2 = new System.Windows.Forms.Label();
            this.lblCantidadAdultos2 = new System.Windows.Forms.Label();
            this.lblCantidadNiños = new System.Windows.Forms.Label();
            this.lblCantidadAdultos1 = new System.Windows.Forms.Label();
            this.cboTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.gpDatosReserva = new System.Windows.Forms.GroupBox();
            this.lblDuracion2 = new System.Windows.Forms.Label();
            this.lblDuracion1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHoraFin2 = new System.Windows.Forms.Label();
            this.lblHoraInicio2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblHoraFin1 = new System.Windows.Forms.Label();
            this.lblHoraInicio1 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.gpPersonas = new System.Windows.Forms.GroupBox();
            this.lblNiñosExtra2 = new System.Windows.Forms.Label();
            this.lblAdultosExtra2 = new System.Windows.Forms.Label();
            this.lblNiñosExtra1 = new System.Windows.Forms.Label();
            this.lblAdultosExtra1 = new System.Windows.Forms.Label();
            this.btnAgregarPersonas = new System.Windows.Forms.Button();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.gpServicios = new System.Windows.Forms.GroupBox();
            this.listServiciosAgregados = new System.Windows.Forms.ListBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.gpCotizacion = new System.Windows.Forms.GroupBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPagoAdelantado = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblPrecioTiempoExtra2 = new System.Windows.Forms.Label();
            this.lblPrecioTiempoExtra1 = new System.Windows.Forms.Label();
            this.lblPrecioServiciosExtra2 = new System.Windows.Forms.Label();
            this.lblPrecioPersonasExtra2 = new System.Windows.Forms.Label();
            this.lblPrecioEvento2 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblPrecioServiciosExtra1 = new System.Windows.Forms.Label();
            this.lblPrecioPersonasExtra1 = new System.Windows.Forms.Label();
            this.lblPrecioEvento1 = new System.Windows.Forms.Label();
            this.btnCancelarCotizacion = new System.Windows.Forms.Button();
            this.btnAceptarCotizacion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.gpEmpleados = new System.Windows.Forms.GroupBox();
            this.listEmpleadosAsignados = new System.Windows.Forms.ListBox();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.lblBebidas2 = new System.Windows.Forms.Label();
            this.lblBebidas1 = new System.Windows.Forms.Label();
            this.gpEvento.SuspendLayout();
            this.gpDatosReserva.SuspendLayout();
            this.gpPersonas.SuspendLayout();
            this.gpServicios.SuspendLayout();
            this.gpCotizacion.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpEmpleados.SuspendLayout();
            this.gpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEvento
            // 
            this.gpEvento.Controls.Add(this.lblCantidadNiños2);
            this.gpEvento.Controls.Add(this.lblCantidadAdultos2);
            this.gpEvento.Controls.Add(this.lblCantidadNiños);
            this.gpEvento.Controls.Add(this.lblCantidadAdultos1);
            this.gpEvento.Controls.Add(this.cboTipoEvento);
            this.gpEvento.Controls.Add(this.lblTipoEvento);
            this.gpEvento.Enabled = false;
            this.gpEvento.Location = new System.Drawing.Point(15, 165);
            this.gpEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpEvento.Name = "gpEvento";
            this.gpEvento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpEvento.Size = new System.Drawing.Size(483, 101);
            this.gpEvento.TabIndex = 0;
            this.gpEvento.TabStop = false;
            this.gpEvento.Text = "Evento";
            // 
            // lblCantidadNiños2
            // 
            this.lblCantidadNiños2.AutoSize = true;
            this.lblCantidadNiños2.Location = new System.Drawing.Point(340, 68);
            this.lblCantidadNiños2.Name = "lblCantidadNiños2";
            this.lblCantidadNiños2.Size = new System.Drawing.Size(16, 17);
            this.lblCantidadNiños2.TabIndex = 5;
            this.lblCantidadNiños2.Text = "0";
            // 
            // lblCantidadAdultos2
            // 
            this.lblCantidadAdultos2.AutoSize = true;
            this.lblCantidadAdultos2.Location = new System.Drawing.Point(156, 68);
            this.lblCantidadAdultos2.Name = "lblCantidadAdultos2";
            this.lblCantidadAdultos2.Size = new System.Drawing.Size(16, 17);
            this.lblCantidadAdultos2.TabIndex = 4;
            this.lblCantidadAdultos2.Text = "0";
            // 
            // lblCantidadNiños
            // 
            this.lblCantidadNiños.AutoSize = true;
            this.lblCantidadNiños.Location = new System.Drawing.Point(205, 68);
            this.lblCantidadNiños.Name = "lblCantidadNiños";
            this.lblCantidadNiños.Size = new System.Drawing.Size(128, 17);
            this.lblCantidadNiños.TabIndex = 3;
            this.lblCantidadNiños.Text = "Cantidad de Niños:";
            // 
            // lblCantidadAdultos1
            // 
            this.lblCantidadAdultos1.AutoSize = true;
            this.lblCantidadAdultos1.Location = new System.Drawing.Point(5, 68);
            this.lblCantidadAdultos1.Name = "lblCantidadAdultos1";
            this.lblCantidadAdultos1.Size = new System.Drawing.Size(139, 17);
            this.lblCantidadAdultos1.TabIndex = 2;
            this.lblCantidadAdultos1.Text = "Cantidad de Adultos:";
            // 
            // cboTipoEvento
            // 
            this.cboTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEvento.FormattingEnabled = true;
            this.cboTipoEvento.Location = new System.Drawing.Point(121, 28);
            this.cboTipoEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoEvento.Name = "cboTipoEvento";
            this.cboTipoEvento.Size = new System.Drawing.Size(349, 24);
            this.cboTipoEvento.TabIndex = 1;
            this.cboTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cboTipoEvento_SelectedIndexChanged);
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(5, 34);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(108, 17);
            this.lblTipoEvento.TabIndex = 0;
            this.lblTipoEvento.Text = "Tipo de Evento:";
            // 
            // gpDatosReserva
            // 
            this.gpDatosReserva.Controls.Add(this.lblDuracion2);
            this.gpDatosReserva.Controls.Add(this.lblDuracion1);
            this.gpDatosReserva.Controls.Add(this.lblNombre);
            this.gpDatosReserva.Controls.Add(this.lblCliente);
            this.gpDatosReserva.Controls.Add(this.lblHoraFin2);
            this.gpDatosReserva.Controls.Add(this.lblHoraInicio2);
            this.gpDatosReserva.Controls.Add(this.lblFecha2);
            this.gpDatosReserva.Controls.Add(this.lblHoraFin1);
            this.gpDatosReserva.Controls.Add(this.lblHoraInicio1);
            this.gpDatosReserva.Controls.Add(this.lblFecha1);
            this.gpDatosReserva.Location = new System.Drawing.Point(503, 14);
            this.gpDatosReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatosReserva.Name = "gpDatosReserva";
            this.gpDatosReserva.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatosReserva.Size = new System.Drawing.Size(484, 146);
            this.gpDatosReserva.TabIndex = 1;
            this.gpDatosReserva.TabStop = false;
            this.gpDatosReserva.Text = "Datos de Reserva";
            // 
            // lblDuracion2
            // 
            this.lblDuracion2.AutoSize = true;
            this.lblDuracion2.Location = new System.Drawing.Point(336, 73);
            this.lblDuracion2.Name = "lblDuracion2";
            this.lblDuracion2.Size = new System.Drawing.Size(13, 17);
            this.lblDuracion2.TabIndex = 9;
            this.lblDuracion2.Text = "-";
            // 
            // lblDuracion1
            // 
            this.lblDuracion1.AutoSize = true;
            this.lblDuracion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDuracion1.Location = new System.Drawing.Point(256, 73);
            this.lblDuracion1.Name = "lblDuracion1";
            this.lblDuracion1.Size = new System.Drawing.Size(69, 17);
            this.lblDuracion1.TabIndex = 8;
            this.lblDuracion1.Text = "Duración:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(336, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(13, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "-";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCliente.Location = new System.Drawing.Point(271, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblHoraFin2
            // 
            this.lblHoraFin2.AutoSize = true;
            this.lblHoraFin2.Location = new System.Drawing.Point(115, 108);
            this.lblHoraFin2.Name = "lblHoraFin2";
            this.lblHoraFin2.Size = new System.Drawing.Size(13, 17);
            this.lblHoraFin2.TabIndex = 5;
            this.lblHoraFin2.Text = "-";
            // 
            // lblHoraInicio2
            // 
            this.lblHoraInicio2.AutoSize = true;
            this.lblHoraInicio2.Location = new System.Drawing.Point(115, 73);
            this.lblHoraInicio2.Name = "lblHoraInicio2";
            this.lblHoraInicio2.Size = new System.Drawing.Size(13, 17);
            this.lblHoraInicio2.TabIndex = 4;
            this.lblHoraInicio2.Text = "-";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(115, 39);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(13, 17);
            this.lblFecha2.TabIndex = 3;
            this.lblFecha2.Text = "-";
            // 
            // lblHoraFin1
            // 
            this.lblHoraFin1.AutoSize = true;
            this.lblHoraFin1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHoraFin1.Location = new System.Drawing.Point(37, 108);
            this.lblHoraFin1.Name = "lblHoraFin1";
            this.lblHoraFin1.Size = new System.Drawing.Size(66, 17);
            this.lblHoraFin1.TabIndex = 2;
            this.lblHoraFin1.Text = "Hora Fin:";
            // 
            // lblHoraInicio1
            // 
            this.lblHoraInicio1.AutoSize = true;
            this.lblHoraInicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHoraInicio1.Location = new System.Drawing.Point(23, 73);
            this.lblHoraInicio1.Name = "lblHoraInicio1";
            this.lblHoraInicio1.Size = new System.Drawing.Size(79, 17);
            this.lblHoraInicio1.TabIndex = 1;
            this.lblHoraInicio1.Text = "Hora Inicio:";
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha1.Location = new System.Drawing.Point(51, 39);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(51, 17);
            this.lblFecha1.TabIndex = 0;
            this.lblFecha1.Text = "Fecha:";
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarReserva.Location = new System.Drawing.Point(355, 38);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(99, 78);
            this.btnBuscarReserva.TabIndex = 8;
            this.btnBuscarReserva.Text = "Buscar Reserva";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // gpPersonas
            // 
            this.gpPersonas.Controls.Add(this.lblNiñosExtra2);
            this.gpPersonas.Controls.Add(this.lblAdultosExtra2);
            this.gpPersonas.Controls.Add(this.lblNiñosExtra1);
            this.gpPersonas.Controls.Add(this.lblAdultosExtra1);
            this.gpPersonas.Controls.Add(this.btnAgregarPersonas);
            this.gpPersonas.Controls.Add(this.cboPersonas);
            this.gpPersonas.Enabled = false;
            this.gpPersonas.Location = new System.Drawing.Point(503, 165);
            this.gpPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpPersonas.Name = "gpPersonas";
            this.gpPersonas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpPersonas.Size = new System.Drawing.Size(484, 101);
            this.gpPersonas.TabIndex = 2;
            this.gpPersonas.TabStop = false;
            this.gpPersonas.Text = "Agregar Personas";
            // 
            // lblNiñosExtra2
            // 
            this.lblNiñosExtra2.AutoSize = true;
            this.lblNiñosExtra2.Location = new System.Drawing.Point(437, 55);
            this.lblNiñosExtra2.Name = "lblNiñosExtra2";
            this.lblNiñosExtra2.Size = new System.Drawing.Size(16, 17);
            this.lblNiñosExtra2.TabIndex = 5;
            this.lblNiñosExtra2.Text = "0";
            // 
            // lblAdultosExtra2
            // 
            this.lblAdultosExtra2.AutoSize = true;
            this.lblAdultosExtra2.Location = new System.Drawing.Point(437, 22);
            this.lblAdultosExtra2.Name = "lblAdultosExtra2";
            this.lblAdultosExtra2.Size = new System.Drawing.Size(16, 17);
            this.lblAdultosExtra2.TabIndex = 4;
            this.lblAdultosExtra2.Text = "0";
            // 
            // lblNiñosExtra1
            // 
            this.lblNiñosExtra1.AutoSize = true;
            this.lblNiñosExtra1.Location = new System.Drawing.Point(347, 55);
            this.lblNiñosExtra1.Name = "lblNiñosExtra1";
            this.lblNiñosExtra1.Size = new System.Drawing.Size(84, 17);
            this.lblNiñosExtra1.TabIndex = 3;
            this.lblNiñosExtra1.Text = "Niños Extra:";
            this.lblNiñosExtra1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdultosExtra1
            // 
            this.lblAdultosExtra1.AutoSize = true;
            this.lblAdultosExtra1.Location = new System.Drawing.Point(336, 21);
            this.lblAdultosExtra1.Name = "lblAdultosExtra1";
            this.lblAdultosExtra1.Size = new System.Drawing.Size(95, 17);
            this.lblAdultosExtra1.TabIndex = 2;
            this.lblAdultosExtra1.Text = "Adultos Extra:";
            this.lblAdultosExtra1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregarPersonas
            // 
            this.btnAgregarPersonas.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarPersonas.Location = new System.Drawing.Point(208, 21);
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
            "Niños",
            "Adultos"});
            this.cboPersonas.Location = new System.Drawing.Point(11, 30);
            this.cboPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(183, 24);
            this.cboPersonas.TabIndex = 0;
            // 
            // gpServicios
            // 
            this.gpServicios.Controls.Add(this.listServiciosAgregados);
            this.gpServicios.Controls.Add(this.btnAgregarServicio);
            this.gpServicios.Controls.Add(this.cboServicios);
            this.gpServicios.Enabled = false;
            this.gpServicios.Location = new System.Drawing.Point(13, 273);
            this.gpServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpServicios.Name = "gpServicios";
            this.gpServicios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpServicios.Size = new System.Drawing.Size(484, 185);
            this.gpServicios.TabIndex = 3;
            this.gpServicios.TabStop = false;
            this.gpServicios.Text = "Servicios Extra";
            // 
            // listServiciosAgregados
            // 
            this.listServiciosAgregados.FormattingEnabled = true;
            this.listServiciosAgregados.ItemHeight = 16;
            this.listServiciosAgregados.Location = new System.Drawing.Point(211, 33);
            this.listServiciosAgregados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listServiciosAgregados.Name = "listServiciosAgregados";
            this.listServiciosAgregados.Size = new System.Drawing.Size(261, 132);
            this.listServiciosAgregados.TabIndex = 3;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarServicio.Location = new System.Drawing.Point(41, 94);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(105, 50);
            this.btnAgregarServicio.TabIndex = 2;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // cboServicios
            // 
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(11, 50);
            this.cboServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(183, 24);
            this.cboServicios.TabIndex = 1;
            // 
            // gpCotizacion
            // 
            this.gpCotizacion.Controls.Add(this.btnCotizar);
            this.gpCotizacion.Controls.Add(this.groupBox6);
            this.gpCotizacion.Controls.Add(this.lblTotal2);
            this.gpCotizacion.Controls.Add(this.lblPrecioTiempoExtra2);
            this.gpCotizacion.Controls.Add(this.lblPrecioTiempoExtra1);
            this.gpCotizacion.Controls.Add(this.lblPrecioServiciosExtra2);
            this.gpCotizacion.Controls.Add(this.lblPrecioPersonasExtra2);
            this.gpCotizacion.Controls.Add(this.lblPrecioEvento2);
            this.gpCotizacion.Controls.Add(this.lblTotal1);
            this.gpCotizacion.Controls.Add(this.lblPrecioServiciosExtra1);
            this.gpCotizacion.Controls.Add(this.lblPrecioPersonasExtra1);
            this.gpCotizacion.Controls.Add(this.lblPrecioEvento1);
            this.gpCotizacion.Enabled = false;
            this.gpCotizacion.Location = new System.Drawing.Point(503, 273);
            this.gpCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCotizacion.Name = "gpCotizacion";
            this.gpCotizacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpCotizacion.Size = new System.Drawing.Size(484, 185);
            this.gpCotizacion.TabIndex = 4;
            this.gpCotizacion.TabStop = false;
            this.gpCotizacion.Text = "Cotización";
            // 
            // btnCotizar
            // 
            this.btnCotizar.ForeColor = System.Drawing.Color.Black;
            this.btnCotizar.Location = new System.Drawing.Point(368, 124);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(105, 50);
            this.btnCotizar.TabIndex = 11;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPagoAdelantado);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Location = new System.Drawing.Point(261, 22);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(217, 78);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pago por adelantado";
            // 
            // txtPagoAdelantado
            // 
            this.txtPagoAdelantado.Location = new System.Drawing.Point(29, 34);
            this.txtPagoAdelantado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPagoAdelantado.Name = "txtPagoAdelantado";
            this.txtPagoAdelantado.Size = new System.Drawing.Size(181, 22);
            this.txtPagoAdelantado.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "$";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.Location = new System.Drawing.Point(97, 144);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(61, 25);
            this.lblTotal2.TabIndex = 9;
            this.lblTotal2.Text = "$0.00";
            // 
            // lblPrecioTiempoExtra2
            // 
            this.lblPrecioTiempoExtra2.AutoSize = true;
            this.lblPrecioTiempoExtra2.Location = new System.Drawing.Point(172, 57);
            this.lblPrecioTiempoExtra2.Name = "lblPrecioTiempoExtra2";
            this.lblPrecioTiempoExtra2.Size = new System.Drawing.Size(44, 17);
            this.lblPrecioTiempoExtra2.TabIndex = 8;
            this.lblPrecioTiempoExtra2.Text = "$0.00";
            // 
            // lblPrecioTiempoExtra1
            // 
            this.lblPrecioTiempoExtra1.AutoSize = true;
            this.lblPrecioTiempoExtra1.Location = new System.Drawing.Point(7, 57);
            this.lblPrecioTiempoExtra1.Name = "lblPrecioTiempoExtra1";
            this.lblPrecioTiempoExtra1.Size = new System.Drawing.Size(159, 17);
            this.lblPrecioTiempoExtra1.TabIndex = 7;
            this.lblPrecioTiempoExtra1.Text = "Precio de Tiempo Extra:";
            // 
            // lblPrecioServiciosExtra2
            // 
            this.lblPrecioServiciosExtra2.AutoSize = true;
            this.lblPrecioServiciosExtra2.Location = new System.Drawing.Point(181, 110);
            this.lblPrecioServiciosExtra2.Name = "lblPrecioServiciosExtra2";
            this.lblPrecioServiciosExtra2.Size = new System.Drawing.Size(44, 17);
            this.lblPrecioServiciosExtra2.TabIndex = 6;
            this.lblPrecioServiciosExtra2.Text = "$0.00";
            // 
            // lblPrecioPersonasExtra2
            // 
            this.lblPrecioPersonasExtra2.AutoSize = true;
            this.lblPrecioPersonasExtra2.Location = new System.Drawing.Point(185, 82);
            this.lblPrecioPersonasExtra2.Name = "lblPrecioPersonasExtra2";
            this.lblPrecioPersonasExtra2.Size = new System.Drawing.Size(44, 17);
            this.lblPrecioPersonasExtra2.TabIndex = 5;
            this.lblPrecioPersonasExtra2.Text = "$0.00";
            // 
            // lblPrecioEvento2
            // 
            this.lblPrecioEvento2.AutoSize = true;
            this.lblPrecioEvento2.Location = new System.Drawing.Point(133, 31);
            this.lblPrecioEvento2.Name = "lblPrecioEvento2";
            this.lblPrecioEvento2.Size = new System.Drawing.Size(44, 17);
            this.lblPrecioEvento2.TabIndex = 4;
            this.lblPrecioEvento2.Text = "$0.00";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(5, 144);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(85, 25);
            this.lblTotal1.TabIndex = 3;
            this.lblTotal1.Text = "TOTAL:";
            // 
            // lblPrecioServiciosExtra1
            // 
            this.lblPrecioServiciosExtra1.AutoSize = true;
            this.lblPrecioServiciosExtra1.Location = new System.Drawing.Point(7, 110);
            this.lblPrecioServiciosExtra1.Name = "lblPrecioServiciosExtra1";
            this.lblPrecioServiciosExtra1.Size = new System.Drawing.Size(169, 17);
            this.lblPrecioServiciosExtra1.TabIndex = 2;
            this.lblPrecioServiciosExtra1.Text = "Precio de Servicios Extra:";
            // 
            // lblPrecioPersonasExtra1
            // 
            this.lblPrecioPersonasExtra1.AutoSize = true;
            this.lblPrecioPersonasExtra1.Location = new System.Drawing.Point(7, 82);
            this.lblPrecioPersonasExtra1.Name = "lblPrecioPersonasExtra1";
            this.lblPrecioPersonasExtra1.Size = new System.Drawing.Size(172, 17);
            this.lblPrecioPersonasExtra1.TabIndex = 1;
            this.lblPrecioPersonasExtra1.Text = "Precio de Personas Extra:";
            // 
            // lblPrecioEvento1
            // 
            this.lblPrecioEvento1.AutoSize = true;
            this.lblPrecioEvento1.Location = new System.Drawing.Point(7, 31);
            this.lblPrecioEvento1.Name = "lblPrecioEvento1";
            this.lblPrecioEvento1.Size = new System.Drawing.Size(120, 17);
            this.lblPrecioEvento1.TabIndex = 0;
            this.lblPrecioEvento1.Text = "Precio de Evento:";
            // 
            // btnCancelarCotizacion
            // 
            this.btnCancelarCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCotizacion.Location = new System.Drawing.Point(881, 601);
            this.btnCancelarCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCotizacion.Name = "btnCancelarCotizacion";
            this.btnCancelarCotizacion.Size = new System.Drawing.Size(105, 50);
            this.btnCancelarCotizacion.TabIndex = 12;
            this.btnCancelarCotizacion.Text = "Cancelar";
            this.btnCancelarCotizacion.UseVisualStyleBackColor = true;
            this.btnCancelarCotizacion.Click += new System.EventHandler(this.btnCancelarCotizacion_Click);
            // 
            // btnAceptarCotizacion
            // 
            this.btnAceptarCotizacion.ForeColor = System.Drawing.Color.Green;
            this.btnAceptarCotizacion.Location = new System.Drawing.Point(761, 601);
            this.btnAceptarCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptarCotizacion.Name = "btnAceptarCotizacion";
            this.btnAceptarCotizacion.Size = new System.Drawing.Size(105, 50);
            this.btnAceptarCotizacion.TabIndex = 11;
            this.btnAceptarCotizacion.Text = "Aceptar";
            this.btnAceptarCotizacion.UseVisualStyleBackColor = true;
            this.btnAceptarCotizacion.Click += new System.EventHandler(this.btnAceptarCotizacion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIdReserva);
            this.groupBox2.Controls.Add(this.txtIdReserva);
            this.groupBox2.Controls.Add(this.btnBuscarReserva);
            this.groupBox2.Location = new System.Drawing.Point(13, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda de Reserva";
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdReserva.Location = new System.Drawing.Point(33, 71);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(80, 17);
            this.lblIdReserva.TabIndex = 10;
            this.lblIdReserva.Text = "Id Reserva:";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(123, 68);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(191, 22);
            this.txtIdReserva.TabIndex = 9;
            // 
            // gpEmpleados
            // 
            this.gpEmpleados.Controls.Add(this.listEmpleadosAsignados);
            this.gpEmpleados.Location = new System.Drawing.Point(13, 464);
            this.gpEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.gpEmpleados.Name = "gpEmpleados";
            this.gpEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.gpEmpleados.Size = new System.Drawing.Size(484, 187);
            this.gpEmpleados.TabIndex = 13;
            this.gpEmpleados.TabStop = false;
            this.gpEmpleados.Text = "Empleados";
            // 
            // listEmpleadosAsignados
            // 
            this.listEmpleadosAsignados.FormattingEnabled = true;
            this.listEmpleadosAsignados.ItemHeight = 16;
            this.listEmpleadosAsignados.Location = new System.Drawing.Point(11, 32);
            this.listEmpleadosAsignados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listEmpleadosAsignados.Name = "listEmpleadosAsignados";
            this.listEmpleadosAsignados.Size = new System.Drawing.Size(461, 148);
            this.listEmpleadosAsignados.TabIndex = 4;
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.lblBebidas2);
            this.gpInfo.Controls.Add(this.lblBebidas1);
            this.gpInfo.Location = new System.Drawing.Point(505, 464);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gpInfo.Size = new System.Drawing.Size(481, 130);
            this.gpInfo.TabIndex = 14;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Información Adicional";
            // 
            // lblBebidas2
            // 
            this.lblBebidas2.AutoSize = true;
            this.lblBebidas2.Location = new System.Drawing.Point(169, 43);
            this.lblBebidas2.Name = "lblBebidas2";
            this.lblBebidas2.Size = new System.Drawing.Size(16, 17);
            this.lblBebidas2.TabIndex = 7;
            this.lblBebidas2.Text = "0";
            // 
            // lblBebidas1
            // 
            this.lblBebidas1.AutoSize = true;
            this.lblBebidas1.Location = new System.Drawing.Point(35, 43);
            this.lblBebidas1.Name = "lblBebidas1";
            this.lblBebidas1.Size = new System.Drawing.Size(122, 17);
            this.lblBebidas1.TabIndex = 3;
            this.lblBebidas1.Text = "Bebidas incluídas:";
            // 
            // FCotizacionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 666);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.gpEmpleados);
            this.Controls.Add(this.btnCancelarCotizacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAceptarCotizacion);
            this.Controls.Add(this.gpCotizacion);
            this.Controls.Add(this.gpServicios);
            this.Controls.Add(this.gpPersonas);
            this.Controls.Add(this.gpDatosReserva);
            this.Controls.Add(this.gpEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FCotizacionEvento";
            this.Text = "Cotización de Eventos";
            this.Load += new System.EventHandler(this.FCotizacionEvento_Load);
            this.gpEvento.ResumeLayout(false);
            this.gpEvento.PerformLayout();
            this.gpDatosReserva.ResumeLayout(false);
            this.gpDatosReserva.PerformLayout();
            this.gpPersonas.ResumeLayout(false);
            this.gpPersonas.PerformLayout();
            this.gpServicios.ResumeLayout(false);
            this.gpCotizacion.ResumeLayout(false);
            this.gpCotizacion.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpEmpleados.ResumeLayout(false);
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEvento;
        private System.Windows.Forms.ComboBox cboTipoEvento;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.GroupBox gpDatosReserva;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblHoraFin2;
        private System.Windows.Forms.Label lblHoraInicio2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblHoraFin1;
        private System.Windows.Forms.Label lblHoraInicio1;
        private System.Windows.Forms.Label lblCantidadNiños2;
        private System.Windows.Forms.Label lblCantidadAdultos2;
        private System.Windows.Forms.Label lblCantidadNiños;
        private System.Windows.Forms.Label lblCantidadAdultos1;
        private System.Windows.Forms.GroupBox gpPersonas;
        private System.Windows.Forms.Button btnAgregarPersonas;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.Label lblNiñosExtra2;
        private System.Windows.Forms.Label lblAdultosExtra2;
        private System.Windows.Forms.Label lblNiñosExtra1;
        private System.Windows.Forms.Label lblAdultosExtra1;
        private System.Windows.Forms.GroupBox gpServicios;
        private System.Windows.Forms.ListBox listServiciosAgregados;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.GroupBox gpCotizacion;
        private System.Windows.Forms.Label lblPrecioServiciosExtra1;
        private System.Windows.Forms.Label lblPrecioPersonasExtra1;
        private System.Windows.Forms.Label lblPrecioEvento1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPagoAdelantado;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblPrecioTiempoExtra2;
        private System.Windows.Forms.Label lblPrecioTiempoExtra1;
        private System.Windows.Forms.Label lblPrecioServiciosExtra2;
        private System.Windows.Forms.Label lblPrecioPersonasExtra2;
        private System.Windows.Forms.Label lblPrecioEvento2;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Button btnCancelarCotizacion;
        private System.Windows.Forms.Button btnAceptarCotizacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.GroupBox gpEmpleados;
        private System.Windows.Forms.ListBox listEmpleadosAsignados;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.Label lblDuracion2;
        private System.Windows.Forms.Label lblDuracion1;
        private System.Windows.Forms.Label lblBebidas2;
        private System.Windows.Forms.Label lblBebidas1;
    }
}