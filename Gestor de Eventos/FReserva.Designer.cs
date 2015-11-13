namespace Gestor_de_Eventos
{
    partial class FReserva
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
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.gridHorarios = new System.Windows.Forms.DataGridView();
            this.gbCalendario = new System.Windows.Forms.GroupBox();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.gbHorarios = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.gbNuevaReserva = new System.Windows.Forms.GroupBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).BeginInit();
            this.gbCalendario.SuspendLayout();
            this.gbHorarios.SuspendLayout();
            this.gbNuevaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(12, 27);
            this.calFecha.MaxSelectionCount = 1;
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 0;
            this.calFecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calFecha_DateChanged);
            // 
            // gridHorarios
            // 
            this.gridHorarios.AllowUserToAddRows = false;
            this.gridHorarios.AllowUserToDeleteRows = false;
            this.gridHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHorarios.Location = new System.Drawing.Point(11, 31);
            this.gridHorarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridHorarios.Name = "gridHorarios";
            this.gridHorarios.ReadOnly = true;
            this.gridHorarios.RowHeadersVisible = false;
            this.gridHorarios.RowTemplate.Height = 24;
            this.gridHorarios.Size = new System.Drawing.Size(360, 491);
            this.gridHorarios.TabIndex = 1;
            // 
            // gbCalendario
            // 
            this.gbCalendario.Controls.Add(this.btnNuevaReserva);
            this.gbCalendario.Controls.Add(this.calFecha);
            this.gbCalendario.Location = new System.Drawing.Point(12, 12);
            this.gbCalendario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCalendario.Name = "gbCalendario";
            this.gbCalendario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCalendario.Size = new System.Drawing.Size(367, 299);
            this.gbCalendario.TabIndex = 0;
            this.gbCalendario.TabStop = false;
            this.gbCalendario.Text = "Seleccione el día";
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaReserva.Location = new System.Drawing.Point(125, 241);
            this.btnNuevaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(125, 50);
            this.btnNuevaReserva.TabIndex = 1;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // gbHorarios
            // 
            this.gbHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHorarios.Controls.Add(this.gridHorarios);
            this.gbHorarios.Location = new System.Drawing.Point(385, 11);
            this.gbHorarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHorarios.MinimumSize = new System.Drawing.Size(376, 533);
            this.gbHorarios.Name = "gbHorarios";
            this.gbHorarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHorarios.Size = new System.Drawing.Size(376, 533);
            this.gbHorarios.TabIndex = 2;
            this.gbHorarios.TabStop = false;
            this.gbHorarios.Text = "Reservas Agendadas";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(76, 167);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 50);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(177, 167);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(11, 37);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(79, 17);
            this.lblHoraInicio.TabIndex = 7;
            this.lblHoraInicio.Text = "Hora Inicio:";
            this.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbNuevaReserva
            // 
            this.gbNuevaReserva.Controls.Add(this.btnNuevoCliente);
            this.gbNuevaReserva.Controls.Add(this.cboCliente);
            this.gbNuevaReserva.Controls.Add(this.lblCliente);
            this.gbNuevaReserva.Controls.Add(this.dtpHoraFin);
            this.gbNuevaReserva.Controls.Add(this.btnCancelar);
            this.gbNuevaReserva.Controls.Add(this.dtpHoraInicio);
            this.gbNuevaReserva.Controls.Add(this.lblHoraFin);
            this.gbNuevaReserva.Controls.Add(this.btnAceptar);
            this.gbNuevaReserva.Controls.Add(this.lblHoraInicio);
            this.gbNuevaReserva.Enabled = false;
            this.gbNuevaReserva.Location = new System.Drawing.Point(17, 318);
            this.gbNuevaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.gbNuevaReserva.Name = "gbNuevaReserva";
            this.gbNuevaReserva.Padding = new System.Windows.Forms.Padding(4);
            this.gbNuevaReserva.Size = new System.Drawing.Size(363, 228);
            this.gbNuevaReserva.TabIndex = 1;
            this.gbNuevaReserva.TabStop = false;
            this.gbNuevaReserva.Text = "Nueva Reserva";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(290, 116);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(65, 28);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(97, 117);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(184, 24);
            this.cboCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(33, 121);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(97, 71);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(89, 22);
            this.dtpHoraFin.TabIndex = 1;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(97, 33);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(89, 22);
            this.dtpHoraInicio.TabIndex = 0;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(23, 76);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(66, 17);
            this.lblHoraFin.TabIndex = 8;
            this.lblHoraFin.Text = "Hora Fin:";
            this.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 555);
            this.Controls.Add(this.gbNuevaReserva);
            this.Controls.Add(this.gbHorarios);
            this.Controls.Add(this.gbCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(794, 566);
            this.Name = "FReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Búsqueda y Reserva de Fechas Disponibles";
            this.Load += new System.EventHandler(this.FReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).EndInit();
            this.gbCalendario.ResumeLayout(false);
            this.gbHorarios.ResumeLayout(false);
            this.gbNuevaReserva.ResumeLayout(false);
            this.gbNuevaReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.DataGridView gridHorarios;
        private System.Windows.Forms.GroupBox gbCalendario;
        private System.Windows.Forms.GroupBox gbHorarios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.GroupBox gbNuevaReserva;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
    }
}