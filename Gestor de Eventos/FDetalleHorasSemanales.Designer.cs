﻿namespace Gestor_de_Eventos
{
    partial class FDetalleHorasSemanales
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
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboSemana = new System.Windows.Forms.ComboBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridDetalleHoras = new System.Windows.Forms.DataGridView();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.lblSemana);
            this.gbFecha.Controls.Add(this.lblMes);
            this.gbFecha.Controls.Add(this.lblAño);
            this.gbFecha.Controls.Add(this.cboSemana);
            this.gbFecha.Controls.Add(this.cboMes);
            this.gbFecha.Controls.Add(this.cboAño);
            this.gbFecha.Location = new System.Drawing.Point(12, 12);
            this.gbFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFecha.Size = new System.Drawing.Size(245, 161);
            this.gbFecha.TabIndex = 0;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Location = new System.Drawing.Point(18, 117);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(64, 17);
            this.lblSemana.TabIndex = 5;
            this.lblSemana.Text = "Semana:";
            this.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(44, 78);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(38, 17);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes:";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(45, 39);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(37, 17);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año:";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSemana
            // 
            this.cboSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemana.FormattingEnabled = true;
            this.cboSemana.Location = new System.Drawing.Point(85, 113);
            this.cboSemana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSemana.Name = "cboSemana";
            this.cboSemana.Size = new System.Drawing.Size(121, 24);
            this.cboSemana.TabIndex = 2;
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(85, 74);
            this.cboMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 24);
            this.cboMes.TabIndex = 1;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(85, 35);
            this.cboAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(121, 24);
            this.cboAño.TabIndex = 0;
            this.cboAño.SelectedIndexChanged += new System.EventHandler(this.cboAño_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(323, 71);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 68);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridDetalleHoras
            // 
            this.gridDetalleHoras.AllowUserToAddRows = false;
            this.gridDetalleHoras.AllowUserToDeleteRows = false;
            this.gridDetalleHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetalleHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleHoras.Location = new System.Drawing.Point(12, 193);
            this.gridDetalleHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridDetalleHoras.Name = "gridDetalleHoras";
            this.gridDetalleHoras.ReadOnly = true;
            this.gridDetalleHoras.RowHeadersVisible = false;
            this.gridDetalleHoras.RowTemplate.Height = 24;
            this.gridDetalleHoras.Size = new System.Drawing.Size(616, 305);
            this.gridDetalleHoras.TabIndex = 2;
            // 
            // FDetalleHorasSemanales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 510);
            this.Controls.Add(this.gridDetalleHoras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(658, 557);
            this.Name = "FDetalleHorasSemanales";
            this.Text = "Detalle de Horas Semanales";
            this.Load += new System.EventHandler(this.FDetalleHorasSemanales_Load);
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cboSemana;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridDetalleHoras;
    }
}