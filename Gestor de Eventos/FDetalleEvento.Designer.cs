namespace Gestor_de_Eventos
{
    partial class FDetalleEvento
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.gbCotizacion = new System.Windows.Forms.GroupBox();
            this.lblMontoTotal2 = new System.Windows.Forms.Label();
            this.lblMontoPagado2 = new System.Windows.Forms.Label();
            this.lblMontoTotal1 = new System.Windows.Forms.Label();
            this.lblMontoPagado1 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblDireccion2 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblDUCliente2 = new System.Windows.Forms.Label();
            this.lblDireccion1 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblDUCliente1 = new System.Windows.Forms.Label();
            this.gbEvento = new System.Windows.Forms.GroupBox();
            this.lblExcedente2 = new System.Windows.Forms.Label();
            this.lblExcedente1 = new System.Windows.Forms.Label();
            this.lblEmpleadosNecesarios2 = new System.Windows.Forms.Label();
            this.lblCantidadNiños2 = new System.Windows.Forms.Label();
            this.lblCantidadAdultos2 = new System.Windows.Forms.Label();
            this.lblTipoEvento2 = new System.Windows.Forms.Label();
            this.listServicios = new System.Windows.Forms.ListBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblEmpleadosNecesarios1 = new System.Windows.Forms.Label();
            this.lblCantidadNiños1 = new System.Windows.Forms.Label();
            this.lblCantidadAdultos1 = new System.Windows.Forms.Label();
            this.lblTipoEvento1 = new System.Windows.Forms.Label();
            this.gridReserva = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gbBusqueda.SuspendLayout();
            this.gbDetalles.SuspendLayout();
            this.gbCotizacion.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.lblFechaHasta);
            this.gbBusqueda.Controls.Add(this.dtpFechaHasta);
            this.gbBusqueda.Controls.Add(this.lblFechaDesde);
            this.gbBusqueda.Controls.Add(this.dtpFechaDesde);
            this.gbBusqueda.Location = new System.Drawing.Point(13, 14);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBusqueda.Size = new System.Drawing.Size(452, 100);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Location = new System.Drawing.Point(349, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 53);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(5, 64);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(92, 17);
            this.lblFechaHasta.TabIndex = 3;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(108, 59);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(5, 33);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(96, 17);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(108, 28);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.gbCotizacion);
            this.gbDetalles.Controls.Add(this.gbCliente);
            this.gbDetalles.Controls.Add(this.gbEvento);
            this.gbDetalles.Location = new System.Drawing.Point(13, 295);
            this.gbDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalles.Size = new System.Drawing.Size(753, 273);
            this.gbDetalles.TabIndex = 2;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles";
            // 
            // gbCotizacion
            // 
            this.gbCotizacion.Controls.Add(this.lblMontoTotal2);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado2);
            this.gbCotizacion.Controls.Add(this.lblMontoTotal1);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado1);
            this.gbCotizacion.Location = new System.Drawing.Point(376, 185);
            this.gbCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Name = "gbCotizacion";
            this.gbCotizacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Size = new System.Drawing.Size(371, 82);
            this.gbCotizacion.TabIndex = 2;
            this.gbCotizacion.TabStop = false;
            this.gbCotizacion.Text = "Cotización";
            // 
            // lblMontoTotal2
            // 
            this.lblMontoTotal2.AutoSize = true;
            this.lblMontoTotal2.Location = new System.Drawing.Point(117, 49);
            this.lblMontoTotal2.Name = "lblMontoTotal2";
            this.lblMontoTotal2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoTotal2.TabIndex = 17;
            this.lblMontoTotal2.Text = "$0,00";
            // 
            // lblMontoPagado2
            // 
            this.lblMontoPagado2.AutoSize = true;
            this.lblMontoPagado2.Location = new System.Drawing.Point(117, 22);
            this.lblMontoPagado2.Name = "lblMontoPagado2";
            this.lblMontoPagado2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoPagado2.TabIndex = 16;
            this.lblMontoPagado2.Text = "$0,00";
            // 
            // lblMontoTotal1
            // 
            this.lblMontoTotal1.AutoSize = true;
            this.lblMontoTotal1.Location = new System.Drawing.Point(24, 49);
            this.lblMontoTotal1.Name = "lblMontoTotal1";
            this.lblMontoTotal1.Size = new System.Drawing.Size(87, 17);
            this.lblMontoTotal1.TabIndex = 1;
            this.lblMontoTotal1.Text = "Monto Total:";
            this.lblMontoTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontoPagado1
            // 
            this.lblMontoPagado1.AutoSize = true;
            this.lblMontoPagado1.Location = new System.Drawing.Point(7, 22);
            this.lblMontoPagado1.Name = "lblMontoPagado1";
            this.lblMontoPagado1.Size = new System.Drawing.Size(104, 17);
            this.lblMontoPagado1.TabIndex = 0;
            this.lblMontoPagado1.Text = "Monto Pagado:";
            this.lblMontoPagado1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblDireccion2);
            this.gbCliente.Controls.Add(this.lblTel2);
            this.gbCliente.Controls.Add(this.lblNombre2);
            this.gbCliente.Controls.Add(this.lblApellido2);
            this.gbCliente.Controls.Add(this.lblDUCliente2);
            this.gbCliente.Controls.Add(this.lblDireccion1);
            this.gbCliente.Controls.Add(this.lblTel1);
            this.gbCliente.Controls.Add(this.lblNombre1);
            this.gbCliente.Controls.Add(this.lblApellido1);
            this.gbCliente.Controls.Add(this.lblDUCliente1);
            this.gbCliente.Location = new System.Drawing.Point(376, 22);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCliente.Size = new System.Drawing.Size(371, 156);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // lblDireccion2
            // 
            this.lblDireccion2.AutoSize = true;
            this.lblDireccion2.Location = new System.Drawing.Point(82, 128);
            this.lblDireccion2.Name = "lblDireccion2";
            this.lblDireccion2.Size = new System.Drawing.Size(13, 17);
            this.lblDireccion2.TabIndex = 15;
            this.lblDireccion2.Text = "-";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(82, 101);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(13, 17);
            this.lblTel2.TabIndex = 14;
            this.lblTel2.Text = "-";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(82, 75);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(13, 17);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.Text = "-";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(82, 49);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(13, 17);
            this.lblApellido2.TabIndex = 12;
            this.lblApellido2.Text = "-";
            // 
            // lblDUCliente2
            // 
            this.lblDUCliente2.AutoSize = true;
            this.lblDUCliente2.Location = new System.Drawing.Point(82, 22);
            this.lblDUCliente2.Name = "lblDUCliente2";
            this.lblDUCliente2.Size = new System.Drawing.Size(13, 17);
            this.lblDUCliente2.TabIndex = 11;
            this.lblDUCliente2.Text = "-";
            // 
            // lblDireccion1
            // 
            this.lblDireccion1.AutoSize = true;
            this.lblDireccion1.Location = new System.Drawing.Point(5, 128);
            this.lblDireccion1.Name = "lblDireccion1";
            this.lblDireccion1.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion1.TabIndex = 4;
            this.lblDireccion1.Text = "Dirección:";
            this.lblDireccion1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(8, 101);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(68, 17);
            this.lblTel1.TabIndex = 3;
            this.lblTel1.Text = "Teléfono:";
            this.lblTel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(14, 75);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(62, 17);
            this.lblNombre1.TabIndex = 2;
            this.lblNombre1.Text = "Nombre:";
            this.lblNombre1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(14, 49);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(62, 17);
            this.lblApellido1.TabIndex = 1;
            this.lblApellido1.Text = "Apellido:";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDUCliente1
            // 
            this.lblDUCliente1.AutoSize = true;
            this.lblDUCliente1.Location = new System.Drawing.Point(44, 22);
            this.lblDUCliente1.Name = "lblDUCliente1";
            this.lblDUCliente1.Size = new System.Drawing.Size(32, 17);
            this.lblDUCliente1.TabIndex = 0;
            this.lblDUCliente1.Text = "DU:";
            this.lblDUCliente1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbEvento
            // 
            this.gbEvento.Controls.Add(this.lblEstado);
            this.gbEvento.Controls.Add(this.lblExcedente2);
            this.gbEvento.Controls.Add(this.lblExcedente1);
            this.gbEvento.Controls.Add(this.lblEmpleadosNecesarios2);
            this.gbEvento.Controls.Add(this.lblCantidadNiños2);
            this.gbEvento.Controls.Add(this.lblCantidadAdultos2);
            this.gbEvento.Controls.Add(this.lblTipoEvento2);
            this.gbEvento.Controls.Add(this.listServicios);
            this.gbEvento.Controls.Add(this.lblServicios);
            this.gbEvento.Controls.Add(this.lblEmpleadosNecesarios1);
            this.gbEvento.Controls.Add(this.lblCantidadNiños1);
            this.gbEvento.Controls.Add(this.lblCantidadAdultos1);
            this.gbEvento.Controls.Add(this.lblTipoEvento1);
            this.gbEvento.Location = new System.Drawing.Point(9, 22);
            this.gbEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEvento.Size = new System.Drawing.Size(361, 245);
            this.gbEvento.TabIndex = 0;
            this.gbEvento.TabStop = false;
            this.gbEvento.Text = "Evento";
            // 
            // lblExcedente2
            // 
            this.lblExcedente2.AutoSize = true;
            this.lblExcedente2.Location = new System.Drawing.Point(168, 128);
            this.lblExcedente2.Name = "lblExcedente2";
            this.lblExcedente2.Size = new System.Drawing.Size(13, 17);
            this.lblExcedente2.TabIndex = 11;
            this.lblExcedente2.Text = "-";
            // 
            // lblExcedente1
            // 
            this.lblExcedente1.AutoSize = true;
            this.lblExcedente1.Location = new System.Drawing.Point(77, 128);
            this.lblExcedente1.Name = "lblExcedente1";
            this.lblExcedente1.Size = new System.Drawing.Size(85, 17);
            this.lblExcedente1.TabIndex = 10;
            this.lblExcedente1.Text = "Excedentes:";
            this.lblExcedente1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpleadosNecesarios2
            // 
            this.lblEmpleadosNecesarios2.AutoSize = true;
            this.lblEmpleadosNecesarios2.Location = new System.Drawing.Point(168, 101);
            this.lblEmpleadosNecesarios2.Name = "lblEmpleadosNecesarios2";
            this.lblEmpleadosNecesarios2.Size = new System.Drawing.Size(13, 17);
            this.lblEmpleadosNecesarios2.TabIndex = 9;
            this.lblEmpleadosNecesarios2.Text = "-";
            // 
            // lblCantidadNiños2
            // 
            this.lblCantidadNiños2.AutoSize = true;
            this.lblCantidadNiños2.Location = new System.Drawing.Point(168, 75);
            this.lblCantidadNiños2.Name = "lblCantidadNiños2";
            this.lblCantidadNiños2.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadNiños2.TabIndex = 8;
            this.lblCantidadNiños2.Text = "-";
            // 
            // lblCantidadAdultos2
            // 
            this.lblCantidadAdultos2.AutoSize = true;
            this.lblCantidadAdultos2.Location = new System.Drawing.Point(168, 49);
            this.lblCantidadAdultos2.Name = "lblCantidadAdultos2";
            this.lblCantidadAdultos2.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadAdultos2.TabIndex = 7;
            this.lblCantidadAdultos2.Text = "-";
            // 
            // lblTipoEvento2
            // 
            this.lblTipoEvento2.AutoSize = true;
            this.lblTipoEvento2.Location = new System.Drawing.Point(168, 22);
            this.lblTipoEvento2.Name = "lblTipoEvento2";
            this.lblTipoEvento2.Size = new System.Drawing.Size(13, 17);
            this.lblTipoEvento2.TabIndex = 6;
            this.lblTipoEvento2.Text = "-";
            // 
            // listServicios
            // 
            this.listServicios.FormattingEnabled = true;
            this.listServicios.ItemHeight = 16;
            this.listServicios.Location = new System.Drawing.Point(5, 171);
            this.listServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listServicios.Name = "listServicios";
            this.listServicios.Size = new System.Drawing.Size(176, 68);
            this.listServicios.TabIndex = 5;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(2, 152);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(148, 17);
            this.lblServicios.TabIndex = 4;
            this.lblServicios.Text = "Servicios contratados:";
            // 
            // lblEmpleadosNecesarios1
            // 
            this.lblEmpleadosNecesarios1.AutoSize = true;
            this.lblEmpleadosNecesarios1.Location = new System.Drawing.Point(7, 101);
            this.lblEmpleadosNecesarios1.Name = "lblEmpleadosNecesarios1";
            this.lblEmpleadosNecesarios1.Size = new System.Drawing.Size(155, 17);
            this.lblEmpleadosNecesarios1.TabIndex = 3;
            this.lblEmpleadosNecesarios1.Text = "Empleados necesarios:";
            this.lblEmpleadosNecesarios1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantidadNiños1
            // 
            this.lblCantidadNiños1.AutoSize = true;
            this.lblCantidadNiños1.Location = new System.Drawing.Point(34, 75);
            this.lblCantidadNiños1.Name = "lblCantidadNiños1";
            this.lblCantidadNiños1.Size = new System.Drawing.Size(128, 17);
            this.lblCantidadNiños1.TabIndex = 2;
            this.lblCantidadNiños1.Text = "Cantidad de Niños:";
            this.lblCantidadNiños1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantidadAdultos1
            // 
            this.lblCantidadAdultos1.AutoSize = true;
            this.lblCantidadAdultos1.Location = new System.Drawing.Point(43, 49);
            this.lblCantidadAdultos1.Name = "lblCantidadAdultos1";
            this.lblCantidadAdultos1.Size = new System.Drawing.Size(119, 17);
            this.lblCantidadAdultos1.TabIndex = 1;
            this.lblCantidadAdultos1.Text = "Cantidad Adultos:";
            this.lblCantidadAdultos1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoEvento1
            // 
            this.lblTipoEvento1.AutoSize = true;
            this.lblTipoEvento1.Location = new System.Drawing.Point(54, 22);
            this.lblTipoEvento1.Name = "lblTipoEvento1";
            this.lblTipoEvento1.Size = new System.Drawing.Size(108, 17);
            this.lblTipoEvento1.TabIndex = 0;
            this.lblTipoEvento1.Text = "Tipo de Evento:";
            this.lblTipoEvento1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridReserva
            // 
            this.gridReserva.AllowUserToAddRows = false;
            this.gridReserva.AllowUserToDeleteRows = false;
            this.gridReserva.AllowUserToResizeRows = false;
            this.gridReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReserva.Location = new System.Drawing.Point(13, 118);
            this.gridReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridReserva.MultiSelect = false;
            this.gridReserva.Name = "gridReserva";
            this.gridReserva.ReadOnly = true;
            this.gridReserva.RowHeadersVisible = false;
            this.gridReserva.RowTemplate.Height = 24;
            this.gridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReserva.Size = new System.Drawing.Size(756, 173);
            this.gridReserva.TabIndex = 1;
            this.gridReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellClick);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(225, 195);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(13, 17);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "-";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FDetalleEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 574);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.gbDetalles);
            this.Controls.Add(this.gbBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(701, 621);
            this.Name = "FDetalleEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Eventos";
            this.Load += new System.EventHandler(this.FDetalleEvento_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbDetalles.ResumeLayout(false);
            this.gbCotizacion.ResumeLayout(false);
            this.gbCotizacion.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblEmpleadosNecesarios1;
        private System.Windows.Forms.Label lblCantidadNiños1;
        private System.Windows.Forms.Label lblCantidadAdultos1;
        private System.Windows.Forms.Label lblTipoEvento1;
        private System.Windows.Forms.ListBox listServicios;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblDireccion1;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblDUCliente1;
        private System.Windows.Forms.GroupBox gbCotizacion;
        private System.Windows.Forms.Label lblMontoTotal1;
        private System.Windows.Forms.Label lblMontoPagado1;
        private System.Windows.Forms.Label lblMontoTotal2;
        private System.Windows.Forms.Label lblMontoPagado2;
        private System.Windows.Forms.Label lblDireccion2;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblDUCliente2;
        private System.Windows.Forms.Label lblEmpleadosNecesarios2;
        private System.Windows.Forms.Label lblCantidadNiños2;
        private System.Windows.Forms.Label lblCantidadAdultos2;
        private System.Windows.Forms.Label lblTipoEvento2;
        private System.Windows.Forms.Label lblExcedente2;
        private System.Windows.Forms.Label lblExcedente1;
        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.Label lblEstado;
    }
}