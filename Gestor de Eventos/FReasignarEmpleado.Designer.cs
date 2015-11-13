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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoDU = new System.Windows.Forms.TextBox();
            this.lblDUEmpleado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.listEmpleadosAsignados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listEmpleadosDisponibles = new System.Windows.Forms.ListBox();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.gridReserva.TabIndex = 25;
            this.gridReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReserva_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpleadoDU);
            this.groupBox1.Controls.Add(this.lblDUEmpleado);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 124);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtEmpleadoDU
            // 
            this.txtEmpleadoDU.Location = new System.Drawing.Point(115, 33);
            this.txtEmpleadoDU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpleadoDU.Name = "txtEmpleadoDU";
            this.txtEmpleadoDU.Size = new System.Drawing.Size(200, 22);
            this.txtEmpleadoDU.TabIndex = 6;
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
            // listEmpleadosAsignados
            // 
            this.listEmpleadosAsignados.FormattingEnabled = true;
            this.listEmpleadosAsignados.ItemHeight = 16;
            this.listEmpleadosAsignados.Location = new System.Drawing.Point(16, 39);
            this.listEmpleadosAsignados.Margin = new System.Windows.Forms.Padding(4);
            this.listEmpleadosAsignados.Name = "listEmpleadosAsignados";
            this.listEmpleadosAsignados.Size = new System.Drawing.Size(275, 164);
            this.listEmpleadosAsignados.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empleados Asignados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Empleados Disponibles:";
            // 
            // listEmpleadosDisponibles
            // 
            this.listEmpleadosDisponibles.FormattingEnabled = true;
            this.listEmpleadosDisponibles.ItemHeight = 16;
            this.listEmpleadosDisponibles.Location = new System.Drawing.Point(347, 39);
            this.listEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.listEmpleadosDisponibles.Name = "listEmpleadosDisponibles";
            this.listEmpleadosDisponibles.Size = new System.Drawing.Size(275, 164);
            this.listEmpleadosDisponibles.TabIndex = 28;
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.btnQuitar);
            this.gbEmpleados.Controls.Add(this.btnAgregar);
            this.gbEmpleados.Controls.Add(this.listEmpleadosAsignados);
            this.gbEmpleados.Controls.Add(this.label3);
            this.gbEmpleados.Controls.Add(this.listEmpleadosDisponibles);
            this.gbEmpleados.Controls.Add(this.label4);
            this.gbEmpleados.Location = new System.Drawing.Point(15, 325);
            this.gbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.gbEmpleados.Size = new System.Drawing.Size(637, 217);
            this.gbEmpleados.TabIndex = 31;
            this.gbEmpleados.TabStop = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(300, 126);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(37, 28);
            this.btnQuitar.TabIndex = 30;
            this.btnQuitar.Text = ">";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(300, 90);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 28);
            this.btnAgregar.TabIndex = 29;
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
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FReasignarEmpleado";
            this.Text = "Reasignación de Empleados";
            this.Load += new System.EventHandler(this.FReasignarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReserva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEmpleados.ResumeLayout(false);
            this.gbEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmpleadoDU;
        private System.Windows.Forms.Label lblDUEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ListBox listEmpleadosAsignados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listEmpleadosDisponibles;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
    }
}