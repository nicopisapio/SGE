﻿namespace Gestor_de_Eventos
{
    partial class FBitacora
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
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gridBitacora = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltro
            // 
            this.gpFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFiltro.AutoSize = true;
            this.gpFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpFiltro.Controls.Add(this.chkUsuario);
            this.gpFiltro.Controls.Add(this.cboUsuario);
            this.gpFiltro.Controls.Add(this.lblUsuario);
            this.gpFiltro.Controls.Add(this.cboTipo);
            this.gpFiltro.Controls.Add(this.dtpFechaDesde);
            this.gpFiltro.Controls.Add(this.lblFechaDesde);
            this.gpFiltro.Controls.Add(this.lblTipo);
            this.gpFiltro.Location = new System.Drawing.Point(12, 12);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Size = new System.Drawing.Size(611, 121);
            this.gpFiltro.TabIndex = 0;
            this.gpFiltro.TabStop = false;
            this.gpFiltro.Text = "Filtros";
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Location = new System.Drawing.Point(405, 40);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(152, 21);
            this.chkUsuario.TabIndex = 3;
            this.chkUsuario.Text = "Buscar por Usuario";
            this.chkUsuario.UseVisualStyleBackColor = true;
            this.chkUsuario.CheckedChanged += new System.EventHandler(this.chkUsuario_CheckedChanged);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(405, 76);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(200, 24);
            this.cboUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(338, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(121, 38);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(200, 24);
            this.cboTipo.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(121, 78);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(19, 79);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(96, 17);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Fecha Desde:";
            this.lblFechaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(75, 41);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridBitacora
            // 
            this.gridBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBitacora.Location = new System.Drawing.Point(12, 149);
            this.gridBitacora.Name = "gridBitacora";
            this.gridBitacora.RowHeadersVisible = false;
            this.gridBitacora.RowTemplate.Height = 24;
            this.gridBitacora.Size = new System.Drawing.Size(729, 384);
            this.gridBitacora.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(643, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 58);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 545);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gridBitacora);
            this.Controls.Add(this.gpFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(769, 592);
            this.Name = "FBitacora";
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.FBitacora_Load);
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView gridBitacora;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox chkUsuario;
    }
}