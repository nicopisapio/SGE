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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClienteDU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label18 = new System.Windows.Forms.Label();
            this.lblMontoTotalAnt2 = new System.Windows.Forms.Label();
            this.lblMontoPagado2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.gbCotizacion.SuspendLayout();
            this.gbExcedente.SuspendLayout();
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
            this.txtClienteDU.TabIndex = 6;
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
            this.btnBuscar.TabIndex = 4;
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
            this.dtpFechaDesde.TabIndex = 0;
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
            this.gridReserva.TabIndex = 23;
            this.gridReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(358, 460);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 50);
            this.btnCancelar.TabIndex = 26;
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
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbCotizacion
            // 
            this.gbCotizacion.Controls.Add(this.btnRecotizar);
            this.gbCotizacion.Controls.Add(this.gbExcedente);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalNvo2);
            this.gbCotizacion.Controls.Add(this.label18);
            this.gbCotizacion.Controls.Add(this.lblMontoTotalAnt2);
            this.gbCotizacion.Controls.Add(this.lblMontoPagado2);
            this.gbCotizacion.Controls.Add(this.label14);
            this.gbCotizacion.Controls.Add(this.label13);
            this.gbCotizacion.Location = new System.Drawing.Point(13, 306);
            this.gbCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Name = "gbCotizacion";
            this.gbCotizacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCotizacion.Size = new System.Drawing.Size(449, 150);
            this.gbCotizacion.TabIndex = 27;
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
            this.btnRecotizar.TabIndex = 24;
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
            this.gbExcedente.TabIndex = 20;
            this.gbExcedente.TabStop = false;
            this.gbExcedente.Text = "Ingresar Excedente";
            // 
            // txtExcedente
            // 
            this.txtExcedente.Location = new System.Drawing.Point(45, 34);
            this.txtExcedente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExcedente.Name = "txtExcedente";
            this.txtExcedente.Size = new System.Drawing.Size(101, 22);
            this.txtExcedente.TabIndex = 1;
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
            // FAgregarExcedente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 520);
            this.Controls.Add(this.gbCotizacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FAgregarExcedente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Excedentes";
            this.Load += new System.EventHandler(this.FAgregarExcedente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.gbCotizacion.ResumeLayout(false);
            this.gbCotizacion.PerformLayout();
            this.gbExcedente.ResumeLayout(false);
            this.gbExcedente.PerformLayout();
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
        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbCotizacion;
        private System.Windows.Forms.Button btnRecotizar;
        private System.Windows.Forms.GroupBox gbExcedente;
        private System.Windows.Forms.TextBox txtExcedente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblMontoTotalNvo2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMontoTotalAnt2;
        private System.Windows.Forms.Label lblMontoPagado2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}