namespace Gestor_de_Eventos
{
    partial class FAgregarExcedente
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
            this.gridReserva = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbCotizacion = new System.Windows.Forms.GroupBox();
            this.btnRecotizar = new System.Windows.Forms.Button();
            this.gbExcedente = new System.Windows.Forms.GroupBox();
            this.txtExcedente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblMontoTotalNvo2 = new System.Windows.Forms.Label();
            this.lblMontoTotalNuevo = new System.Windows.Forms.Label();
            this.lblMontoTotalAnt2 = new System.Windows.Forms.Label();
            this.lblMontoPagado2 = new System.Windows.Forms.Label();
            this.lblMontoTotalAnterior = new System.Windows.Forms.Label();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.gbCotizacion.SuspendLayout();
            this.gbExcedente.SuspendLayout();
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
            this.gridReserva.Size = new System.Drawing.Size(449, 160);
            this.gridReserva.TabIndex = 1;
            this.gridReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(358, 460);
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
            this.btnAceptar.Location = new System.Drawing.Point(247, 460);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 50);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbCotizacion
            // 
            this.gbCotizacion.Controls.Add(this.btnRecotizar);
            this.gbCotizacion.Controls.Add(this.gbExcedente);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalNvo2);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalNuevo);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalAnt2);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado2);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalAnterior);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado);
            this.gbCotizacion.Location = new System.Drawing.Point(13, 306);
            this.gbCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Name = "gbCotizacion";
            this.gbCotizacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Size = new System.Drawing.Size(449, 150);
            this.gbCotizacion.TabIndex = 2;
            this.gbCotizacion.TabStop = false;
            this.gbCotizacion.Text = "Cotización";
            // 
            // btnRecotizar
            // 
            this.btnRecotizar.ForeColor = System.Drawing.Color.Black;
            this.btnRecotizar.Location = new System.Drawing.Point(322, 96);
            this.btnRecotizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecotizar.Name = "btnRecotizar";
            this.btnRecotizar.Size = new System.Drawing.Size(99, 46);
            this.btnRecotizar.TabIndex = 1;
            this.btnRecotizar.Text = "Recotizar";
            this.btnRecotizar.UseVisualStyleBackColor = true;
            this.btnRecotizar.Click += new System.EventHandler(this.btnRecotizar_Click);
            // 
            // gbExcedente
            // 
            this.gbExcedente.Controls.Add(this.txtExcedente);
            this.gbExcedente.Controls.Add(this.label22);
            this.gbExcedente.Location = new System.Drawing.Point(266, 28);
            this.gbExcedente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbExcedente.Name = "gbExcedente";
            this.gbExcedente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbExcedente.Size = new System.Drawing.Size(155, 64);
            this.gbExcedente.TabIndex = 0;
            this.gbExcedente.TabStop = false;
            this.gbExcedente.Text = "Ingresar Excedente";
            // 
            // txtExcedente
            // 
            this.txtExcedente.Location = new System.Drawing.Point(45, 31);
            this.txtExcedente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExcedente.Name = "txtExcedente";
            this.txtExcedente.Size = new System.Drawing.Size(101, 22);
            this.txtExcedente.TabIndex = 0;
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
            // lblMontoTotalNuevo
            // 
            this.lblMontoTotalNuevo.AutoSize = true;
            this.lblMontoTotalNuevo.Location = new System.Drawing.Point(16, 104);
            this.lblMontoTotalNuevo.Name = "lblMontoTotalNuevo";
            this.lblMontoTotalNuevo.Size = new System.Drawing.Size(132, 17);
            this.lblMontoTotalNuevo.TabIndex = 18;
            this.lblMontoTotalNuevo.Text = "Monto Total Nuevo:";
            this.lblMontoTotalNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblMontoTotalAnterior
            // 
            this.lblMontoTotalAnterior.AutoSize = true;
            this.lblMontoTotalAnterior.Location = new System.Drawing.Point(7, 75);
            this.lblMontoTotalAnterior.Name = "lblMontoTotalAnterior";
            this.lblMontoTotalAnterior.Size = new System.Drawing.Size(141, 17);
            this.lblMontoTotalAnterior.TabIndex = 1;
            this.lblMontoTotalAnterior.Text = "Monto Total Anterior:";
            this.lblMontoTotalAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Location = new System.Drawing.Point(44, 46);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(104, 17);
            this.lblMontoPagado.TabIndex = 0;
            this.lblMontoPagado.Text = "Monto Pagado:";
            this.lblMontoPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FAgregarExcedente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 520);
            this.Controls.Add(this.gbCotizacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.gbBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(490, 567);
            this.Name = "FAgregarExcedente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Excedentes";
            this.Load += new System.EventHandler(this.FAgregarExcedente_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.gbCotizacion.ResumeLayout(false);
            this.gbCotizacion.PerformLayout();
            this.gbExcedente.ResumeLayout(false);
            this.gbExcedente.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbCotizacion;
        private System.Windows.Forms.Button btnRecotizar;
        private System.Windows.Forms.GroupBox gbExcedente;
        private System.Windows.Forms.TextBox txtExcedente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblMontoTotalNvo2;
        private System.Windows.Forms.Label lblMontoTotalNuevo;
        private System.Windows.Forms.Label lblMontoTotalAnt2;
        private System.Windows.Forms.Label lblMontoPagado2;
        private System.Windows.Forms.Label lblMontoTotalAnterior;
        private System.Windows.Forms.Label lblMontoPagado;
    }
}