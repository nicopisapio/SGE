namespace Gestor_de_Eventos
{
    partial class FDetalleHorasMensuales
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
            this.gridDetalleHoras = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpFecha = new System.Windows.Forms.GroupBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.cboAño = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleHoras)).BeginInit();
            this.gpFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDetalleHoras
            // 
            this.gridDetalleHoras.AllowUserToAddRows = false;
            this.gridDetalleHoras.AllowUserToDeleteRows = false;
            this.gridDetalleHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleHoras.Location = new System.Drawing.Point(15, 160);
            this.gridDetalleHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridDetalleHoras.Name = "gridDetalleHoras";
            this.gridDetalleHoras.ReadOnly = true;
            this.gridDetalleHoras.RowHeadersVisible = false;
            this.gridDetalleHoras.RowTemplate.Height = 24;
            this.gridDetalleHoras.Size = new System.Drawing.Size(668, 373);
            this.gridDetalleHoras.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(325, 47);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 68);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gpFecha
            // 
            this.gpFecha.Controls.Add(this.lblMes);
            this.gpFecha.Controls.Add(this.lblAño);
            this.gpFecha.Controls.Add(this.cboMes);
            this.gpFecha.Controls.Add(this.cboAño);
            this.gpFecha.Location = new System.Drawing.Point(15, 14);
            this.gpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpFecha.Name = "gpFecha";
            this.gpFecha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpFecha.Size = new System.Drawing.Size(245, 127);
            this.gpFecha.TabIndex = 3;
            this.gpFecha.TabStop = false;
            this.gpFecha.Text = "Fecha";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(45, 78);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 17);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(45, 39);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(33, 17);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año";
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(85, 75);
            this.cboMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 24);
            this.cboMes.TabIndex = 1;
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(85, 36);
            this.cboAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(121, 24);
            this.cboAño.TabIndex = 0;
            // 
            // FDetalleHorasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 546);
            this.Controls.Add(this.gridDetalleHoras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(715, 593);
            this.Name = "FDetalleHorasMensuales";
            this.Text = "Detalle de Horas Mensuales";
            this.Load += new System.EventHandler(this.FDetalleHorasMensuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleHoras)).EndInit();
            this.gpFecha.ResumeLayout(false);
            this.gpFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDetalleHoras;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpFecha;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.ComboBox cboAño;
    }
}