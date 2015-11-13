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
            this.gridDetalleHoras.Location = new System.Drawing.Point(11, 130);
            this.gridDetalleHoras.Margin = new System.Windows.Forms.Padding(2);
            this.gridDetalleHoras.Name = "gridDetalleHoras";
            this.gridDetalleHoras.ReadOnly = true;
            this.gridDetalleHoras.RowHeadersVisible = false;
            this.gridDetalleHoras.RowTemplate.Height = 24;
            this.gridDetalleHoras.Size = new System.Drawing.Size(501, 303);
            this.gridDetalleHoras.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(244, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 55);
            this.btnBuscar.TabIndex = 4;
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
            this.gpFecha.Location = new System.Drawing.Point(11, 11);
            this.gpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gpFecha.Name = "gpFecha";
            this.gpFecha.Padding = new System.Windows.Forms.Padding(2);
            this.gpFecha.Size = new System.Drawing.Size(184, 103);
            this.gpFecha.TabIndex = 3;
            this.gpFecha.TabStop = false;
            this.gpFecha.Text = "Fecha";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(34, 63);
            this.lblMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(34, 32);
            this.lblAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año";
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(64, 61);
            this.cboMes.Margin = new System.Windows.Forms.Padding(2);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(92, 21);
            this.cboMes.TabIndex = 2;
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(64, 29);
            this.cboAño.Margin = new System.Windows.Forms.Padding(2);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(92, 21);
            this.cboAño.TabIndex = 1;
            // 
            // FDetalleHorasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 444);
            this.Controls.Add(this.gridDetalleHoras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpFecha);
            this.Name = "FDetalleHorasMensuales";
            this.Text = "FDetalleHorasMensuales";
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