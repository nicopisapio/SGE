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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClienteDU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRecotizar = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblMontoTotalNvo2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMontoTotalAnt2 = new System.Windows.Forms.Label();
            this.lblMontoPagado2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbDetalleEvento = new System.Windows.Forms.GroupBox();
            this.lblEstado2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblCantidadHoras2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnQuitarDuracion = new System.Windows.Forms.Button();
            this.btnAgregarDuracion = new System.Windows.Forms.Button();
            this.lblHoraFin2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHoraInicio2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnQuitarServicio = new System.Windows.Forms.Button();
            this.listServicios = new System.Windows.Forms.ListBox();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitarPersonas = new System.Windows.Forms.Button();
            this.btnAgregarPersonas = new System.Windows.Forms.Button();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNiños2 = new System.Windows.Forms.Label();
            this.lblAdultos2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTipoEvento2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gridReserva = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbDetalleEvento.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClienteDU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtClienteDU
            // 
            this.txtClienteDU.Location = new System.Drawing.Point(115, 33);
            this.txtClienteDU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDU.Name = "txtClienteDU";
            this.txtClienteDU.Size = new System.Drawing.Size(200, 22);
            this.txtClienteDU.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "DU Cliente:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(115, 89);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(115, 62);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRecotizar);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.lblMontoTotalNvo2);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.lblMontoTotalAnt2);
            this.groupBox6.Controls.Add(this.lblMontoPagado2);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(339, 214);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(436, 150);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cotización";
            // 
            // btnRecotizar
            // 
            this.btnRecotizar.ForeColor = System.Drawing.Color.Black;
            this.btnRecotizar.Location = new System.Drawing.Point(311, 98);
            this.btnRecotizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecotizar.Name = "btnRecotizar";
            this.btnRecotizar.Size = new System.Drawing.Size(99, 46);
            this.btnRecotizar.TabIndex = 15;
            this.btnRecotizar.Text = "Recotizar";
            this.btnRecotizar.UseVisualStyleBackColor = true;
            this.btnRecotizar.Click += new System.EventHandler(this.btnRecotizar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPago);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Location = new System.Drawing.Point(253, 28);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(155, 64);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ingresar Pago";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(45, 34);
            this.txtPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(101, 22);
            this.txtPago.TabIndex = 14;
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
            this.lblMontoTotalNvo2.Location = new System.Drawing.Point(155, 105);
            this.lblMontoTotalNvo2.Name = "lblMontoTotalNvo2";
            this.lblMontoTotalNvo2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoTotalNvo2.TabIndex = 19;
            this.lblMontoTotalNvo2.Text = "$0,00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Monto Total Nuevo:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontoTotalAnt2
            // 
            this.lblMontoTotalAnt2.AutoSize = true;
            this.lblMontoTotalAnt2.Location = new System.Drawing.Point(155, 75);
            this.lblMontoTotalAnt2.Name = "lblMontoTotalAnt2";
            this.lblMontoTotalAnt2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoTotalAnt2.TabIndex = 17;
            this.lblMontoTotalAnt2.Text = "$0,00";
            // 
            // lblMontoPagado2
            // 
            this.lblMontoPagado2.AutoSize = true;
            this.lblMontoPagado2.Location = new System.Drawing.Point(155, 46);
            this.lblMontoPagado2.Name = "lblMontoPagado2";
            this.lblMontoPagado2.Size = new System.Drawing.Size(44, 17);
            this.lblMontoPagado2.TabIndex = 16;
            this.lblMontoPagado2.Text = "$0,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Monto Total Anterior:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Monto Pagado:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDetalleEvento
            // 
            this.gbDetalleEvento.Controls.Add(this.lblEstado2);
            this.gbDetalleEvento.Controls.Add(this.label21);
            this.gbDetalleEvento.Controls.Add(this.groupBox6);
            this.gbDetalleEvento.Controls.Add(this.groupBox7);
            this.gbDetalleEvento.Controls.Add(this.groupBox5);
            this.gbDetalleEvento.Controls.Add(this.groupBox3);
            this.gbDetalleEvento.Controls.Add(this.lblTipoEvento2);
            this.gbDetalleEvento.Controls.Add(this.label19);
            this.gbDetalleEvento.Enabled = false;
            this.gbDetalleEvento.Location = new System.Drawing.Point(12, 313);
            this.gbDetalleEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleEvento.Name = "gbDetalleEvento";
            this.gbDetalleEvento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleEvento.Size = new System.Drawing.Size(781, 370);
            this.gbDetalleEvento.TabIndex = 3;
            this.gbDetalleEvento.TabStop = false;
            this.gbDetalleEvento.Text = "Detalle de Evento";
            // 
            // lblEstado2
            // 
            this.lblEstado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado2.Location = new System.Drawing.Point(131, 28);
            this.lblEstado2.Name = "lblEstado2";
            this.lblEstado2.Size = new System.Drawing.Size(152, 25);
            this.lblEstado2.TabIndex = 19;
            this.lblEstado2.Text = "RESERVADO";
            this.lblEstado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(37, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 25);
            this.label21.TabIndex = 18;
            this.label21.Text = "Estado:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblCantidadHoras2);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.btnQuitarDuracion);
            this.groupBox7.Controls.Add(this.btnAgregarDuracion);
            this.groupBox7.Controls.Add(this.lblHoraFin2);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.lblHoraInicio2);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.lblFecha2);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(7, 214);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(324, 150);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Duración";
            // 
            // lblCantidadHoras2
            // 
            this.lblCantidadHoras2.AutoSize = true;
            this.lblCantidadHoras2.Location = new System.Drawing.Point(115, 119);
            this.lblCantidadHoras2.Name = "lblCantidadHoras2";
            this.lblCantidadHoras2.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadHoras2.TabIndex = 17;
            this.lblCantidadHoras2.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Cantidad Hs:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuitarDuracion
            // 
            this.btnQuitarDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarDuracion.Location = new System.Drawing.Point(209, 85);
            this.btnQuitarDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarDuracion.Name = "btnQuitarDuracion";
            this.btnQuitarDuracion.Size = new System.Drawing.Size(105, 50);
            this.btnQuitarDuracion.TabIndex = 13;
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
            this.btnAgregarDuracion.TabIndex = 12;
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
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Hora Fin:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoraInicio2
            // 
            this.lblHoraInicio2.AutoSize = true;
            this.lblHoraInicio2.Location = new System.Drawing.Point(115, 65);
            this.lblHoraInicio2.Name = "lblHoraInicio2";
            this.lblHoraInicio2.Size = new System.Drawing.Size(13, 17);
            this.lblHoraInicio2.TabIndex = 14;
            this.lblHoraInicio2.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Fecha:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(115, 38);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(13, 17);
            this.lblFecha2.TabIndex = 13;
            this.lblFecha2.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Hora Inicio:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnQuitarServicio);
            this.groupBox5.Controls.Add(this.listServicios);
            this.groupBox5.Controls.Add(this.cboServicios);
            this.groupBox5.Controls.Add(this.btnAgregarServicio);
            this.groupBox5.Location = new System.Drawing.Point(337, 66);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(436, 142);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Servicios Contratados";
            // 
            // btnQuitarServicio
            // 
            this.btnQuitarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarServicio.Location = new System.Drawing.Point(327, 81);
            this.btnQuitarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarServicio.Name = "btnQuitarServicio";
            this.btnQuitarServicio.Size = new System.Drawing.Size(105, 50);
            this.btnQuitarServicio.TabIndex = 11;
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
            this.listServicios.TabIndex = 9;
            // 
            // cboServicios
            // 
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(215, 31);
            this.cboServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(215, 24);
            this.cboServicios.TabIndex = 8;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarServicio.Location = new System.Drawing.Point(213, 81);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(105, 50);
            this.btnAgregarServicio.TabIndex = 10;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitarPersonas);
            this.groupBox3.Controls.Add(this.btnAgregarPersonas);
            this.groupBox3.Controls.Add(this.cboPersonas);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblNiños2);
            this.groupBox3.Controls.Add(this.lblAdultos2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(7, 64);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(324, 144);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personas";
            // 
            // btnQuitarPersonas
            // 
            this.btnQuitarPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarPersonas.Location = new System.Drawing.Point(209, 78);
            this.btnQuitarPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarPersonas.Name = "btnQuitarPersonas";
            this.btnQuitarPersonas.Size = new System.Drawing.Size(105, 50);
            this.btnQuitarPersonas.TabIndex = 7;
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
            this.btnAgregarPersonas.TabIndex = 6;
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
            this.cboPersonas.Location = new System.Drawing.Point(20, 97);
            this.cboPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(159, 24);
            this.cboPersonas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad Adultos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNiños2
            // 
            this.lblNiños2.AutoSize = true;
            this.lblNiños2.Location = new System.Drawing.Point(155, 66);
            this.lblNiños2.Name = "lblNiños2";
            this.lblNiños2.Size = new System.Drawing.Size(16, 17);
            this.lblNiños2.TabIndex = 8;
            this.lblNiños2.Text = "0";
            // 
            // lblAdultos2
            // 
            this.lblAdultos2.AutoSize = true;
            this.lblAdultos2.Location = new System.Drawing.Point(155, 38);
            this.lblAdultos2.Name = "lblAdultos2";
            this.lblAdultos2.Size = new System.Drawing.Size(16, 17);
            this.lblAdultos2.TabIndex = 7;
            this.lblAdultos2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad de Niños:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoEvento2
            // 
            this.lblTipoEvento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento2.Location = new System.Drawing.Point(535, 28);
            this.lblTipoEvento2.Name = "lblTipoEvento2";
            this.lblTipoEvento2.Size = new System.Drawing.Size(208, 25);
            this.lblTipoEvento2.TabIndex = 6;
            this.lblTipoEvento2.Text = "Cumpleaños Infantil";
            this.lblTipoEvento2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(362, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tipo de Evento:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(687, 692);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 50);
            this.btnCancelar.TabIndex = 17;
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
            this.btnAceptar.TabIndex = 16;
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
            this.gridReserva.TabIndex = 4;
            this.gridReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellDoubleClick);
            // 
            // FModificacionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 754);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDetalleEvento);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(821, 801);
            this.Name = "FModificacionEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificación de Eventos";
            this.Load += new System.EventHandler(this.FModificacionEvento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.gbDetalleEvento.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.TextBox txtClienteDU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblMontoTotalAnt2;
        private System.Windows.Forms.Label lblMontoPagado2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbDetalleEvento;
        private System.Windows.Forms.Label lblNiños2;
        private System.Windows.Forms.Label lblAdultos2;
        private System.Windows.Forms.Label lblTipoEvento2;
        private System.Windows.Forms.ListBox listServicios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitarPersonas;
        private System.Windows.Forms.Button btnAgregarPersonas;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.Label lblHoraFin2;
        private System.Windows.Forms.Label lblHoraInicio2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnQuitarServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnQuitarDuracion;
        private System.Windows.Forms.Button btnAgregarDuracion;
        private System.Windows.Forms.Label lblMontoTotalNvo2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEstado2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCantidadHoras2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRecotizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView gridReserva;
    }
}