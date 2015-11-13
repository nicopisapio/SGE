namespace Gestor_de_Eventos
{
    partial class FReasignarEmpleado
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
            this.gridReserva = new System.Windows.Forms.DataGridView();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoDU = new System.Windows.Forms.TextBox();
            this.lblDUEmpleado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.listEmpleadosAsignados = new System.Windows.Forms.ListBox();
            this.lblEmpleadosAsignados = new System.Windows.Forms.Label();
            this.lblEmpleadosDisponibles = new System.Windows.Forms.Label();
            this.listEmpleadosDisponibles = new System.Windows.Forms.ListBox();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.gbEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridReserva
            // 
            this.gridReserva.AllowUserToAddRows = false;
            this.gridReserva.AllowUserToDeleteRows = false;
            this.gridReserva.AllowUserToResizeRows = false;
            this.gridReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReserva.Location = new System.Drawing.Point(16, 143);
            this.gridReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridReserva.Name = "gridReserva";
            this.gridReserva.ReadOnly = true;
            this.gridReserva.RowHeadersVisible = false;
            this.gridReserva.RowTemplate.Height = 24;
            this.gridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReserva.Size = new System.Drawing.Size(633, 160);
            this.gridReserva.TabIndex = 1;
            this.gridReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellDoubleClick);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.txtEmpleadoDU);
            this.gbBusqueda.Controls.Add(this.lblDUEmpleado);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.lblFechaHasta);
            this.gbBusqueda.Controls.Add(this.dtpFechaHasta);
            this.gbBusqueda.Controls.Add(this.lblFechaDesde);
            this.gbBusqueda.Controls.Add(this.dtpFechaDesde);
            this.gbBusqueda.Location = new System.Drawing.Point(15, 14);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBusqueda.Size = new System.Drawing.Size(451, 124);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // txtEmpleadoDU
            // 
            this.txtEmpleadoDU.Location = new System.Drawing.Point(115, 33);
            this.txtEmpleadoDU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpleadoDU.Name = "txtEmpleadoDU";
            this.txtEmpleadoDU.Size = new System.Drawing.Size(200, 22);
            this.txtEmpleadoDU.TabIndex = 0;
            // 
            // lblDUEmpleado
            // 
            this.lblDUEmpleado.AutoSize = true;
            this.lblDUEmpleado.Location = new System.Drawing.Point(9, 37);
            this.lblDUEmpleado.Name = "lblDUEmpleado";
            this.lblDUEmpleado.Size = new System.Drawing.Size(99, 17);
            this.lblDUEmpleado.TabIndex = 5;
            this.lblDUEmpleado.Text = "DU Empleado:";
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
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(115, 89);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(12, 66);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(96, 17);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(115, 62);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // listEmpleadosAsignados
            // 
            this.listEmpleadosAsignados.FormattingEnabled = true;
            this.listEmpleadosAsignados.ItemHeight = 16;
            this.listEmpleadosAsignados.Location = new System.Drawing.Point(16, 39);
            this.listEmpleadosAsignados.Margin = new System.Windows.Forms.Padding(4);
            this.listEmpleadosAsignados.Name = "listEmpleadosAsignados";
            this.listEmpleadosAsignados.Size = new System.Drawing.Size(275, 164);
            this.listEmpleadosAsignados.TabIndex = 0;
            // 
            // lblEmpleadosAsignados
            // 
            this.lblEmpleadosAsignados.AutoSize = true;
            this.lblEmpleadosAsignados.Location = new System.Drawing.Point(16, 20);
            this.lblEmpleadosAsignados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleadosAsignados.Name = "lblEmpleadosAsignados";
            this.lblEmpleadosAsignados.Size = new System.Drawing.Size(152, 17);
            this.lblEmpleadosAsignados.TabIndex = 7;
            this.lblEmpleadosAsignados.Text = "Empleados Asignados:";
            // 
            // lblEmpleadosDisponibles
            // 
            this.lblEmpleadosDisponibles.AutoSize = true;
            this.lblEmpleadosDisponibles.Location = new System.Drawing.Point(343, 20);
            this.lblEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleadosDisponibles.Name = "lblEmpleadosDisponibles";
            this.lblEmpleadosDisponibles.Size = new System.Drawing.Size(159, 17);
            this.lblEmpleadosDisponibles.TabIndex = 27;
            this.lblEmpleadosDisponibles.Text = "Empleados Disponibles:";
            // 
            // listEmpleadosDisponibles
            // 
            this.listEmpleadosDisponibles.FormattingEnabled = true;
            this.listEmpleadosDisponibles.ItemHeight = 16;
            this.listEmpleadosDisponibles.Location = new System.Drawing.Point(347, 39);
            this.listEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.listEmpleadosDisponibles.Name = "listEmpleadosDisponibles";
            this.listEmpleadosDisponibles.Size = new System.Drawing.Size(275, 164);
            this.listEmpleadosDisponibles.TabIndex = 2;
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.btnQuitar);
            this.gbEmpleados.Controls.Add(this.btnAgregar);
            this.gbEmpleados.Controls.Add(this.listEmpleadosAsignados);
            this.gbEmpleados.Controls.Add(this.lblEmpleadosAsignados);
            this.gbEmpleados.Controls.Add(this.listEmpleadosDisponibles);
            this.gbEmpleados.Controls.Add(this.lblEmpleadosDisponibles);
            this.gbEmpleados.Location = new System.Drawing.Point(15, 325);
            this.gbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.gbEmpleados.Size = new System.Drawing.Size(637, 217);
            this.gbEmpleados.TabIndex = 2;
            this.gbEmpleados.TabStop = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(299, 91);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(37, 28);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = ">";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(299, 127);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FReasignarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 552);
            this.Controls.Add(this.gbEmpleados);
            this.Controls.Add(this.gridReserva);
            this.Controls.Add(this.gbBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FReasignarEmpleado";
            this.Text = "Reasignación de Empleados";
            this.Load += new System.EventHandler(this.FReasignarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbEmpleados.ResumeLayout(false);
            this.gbEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox txtEmpleadoDU;
        private System.Windows.Forms.Label lblDUEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ListBox listEmpleadosAsignados;
        private System.Windows.Forms.Label lblEmpleadosAsignados;
        private System.Windows.Forms.Label lblEmpleadosDisponibles;
        private System.Windows.Forms.ListBox listEmpleadosDisponibles;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
    }
}