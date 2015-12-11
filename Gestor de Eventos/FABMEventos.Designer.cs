namespace Gestor_de_Eventos
{
    partial class FABMEventos
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
            this.gridEventos = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.gbDatosEvento = new System.Windows.Forms.GroupBox();
            this.numCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.numCantidadNiños = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioDecena = new System.Windows.Forms.TextBox();
            this.lblPrecioDecena = new System.Windows.Forms.Label();
            this.txtPrecioBloque = new System.Windows.Forms.TextBox();
            this.lblCantAdultos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCantNiños = new System.Windows.Forms.Label();
            this.lblPrecioBloque = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            this.gbDatosEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadNiños)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEventos
            // 
            this.gridEventos.AllowUserToAddRows = false;
            this.gridEventos.AllowUserToDeleteRows = false;
            this.gridEventos.AllowUserToResizeRows = false;
            this.gridEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventos.Location = new System.Drawing.Point(12, 232);
            this.gridEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridEventos.MultiSelect = false;
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.ReadOnly = true;
            this.gridEventos.RowHeadersVisible = false;
            this.gridEventos.RowTemplate.Height = 24;
            this.gridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEventos.Size = new System.Drawing.Size(611, 371);
            this.gridEventos.TabIndex = 4;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(517, 158);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(104, 58);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(517, 86);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(104, 58);
            this.btnModificacion.TabIndex = 1;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(517, 15);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(104, 58);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // gbDatosEvento
            // 
            this.gbDatosEvento.Controls.Add(this.numCantidadAdultos);
            this.gbDatosEvento.Controls.Add(this.numCantidadNiños);
            this.gbDatosEvento.Controls.Add(this.txtPrecioDecena);
            this.gbDatosEvento.Controls.Add(this.lblPrecioDecena);
            this.gbDatosEvento.Controls.Add(this.txtPrecioBloque);
            this.gbDatosEvento.Controls.Add(this.lblCantAdultos);
            this.gbDatosEvento.Controls.Add(this.btnCancelar);
            this.gbDatosEvento.Controls.Add(this.btnAceptar);
            this.gbDatosEvento.Controls.Add(this.txtPrecio);
            this.gbDatosEvento.Controls.Add(this.txtDescripcion);
            this.gbDatosEvento.Controls.Add(this.lblCantNiños);
            this.gbDatosEvento.Controls.Add(this.lblPrecioBloque);
            this.gbDatosEvento.Controls.Add(this.lblPrecio);
            this.gbDatosEvento.Controls.Add(this.lblDescripcion);
            this.gbDatosEvento.Location = new System.Drawing.Point(12, 11);
            this.gbDatosEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosEvento.Name = "gbDatosEvento";
            this.gbDatosEvento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosEvento.Size = new System.Drawing.Size(486, 205);
            this.gbDatosEvento.TabIndex = 3;
            this.gbDatosEvento.TabStop = false;
            this.gbDatosEvento.Text = "Datos del Evento";
            // 
            // numCantidadAdultos
            // 
            this.numCantidadAdultos.Location = new System.Drawing.Point(374, 109);
            this.numCantidadAdultos.Name = "numCantidadAdultos";
            this.numCantidadAdultos.Size = new System.Drawing.Size(98, 22);
            this.numCantidadAdultos.TabIndex = 4;
            // 
            // numCantidadNiños
            // 
            this.numCantidadNiños.Location = new System.Drawing.Point(141, 109);
            this.numCantidadNiños.Name = "numCantidadNiños";
            this.numCantidadNiños.Size = new System.Drawing.Size(98, 22);
            this.numCantidadNiños.TabIndex = 3;
            // 
            // txtPrecioDecena
            // 
            this.txtPrecioDecena.Location = new System.Drawing.Point(141, 143);
            this.txtPrecioDecena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioDecena.Name = "txtPrecioDecena";
            this.txtPrecioDecena.Size = new System.Drawing.Size(98, 22);
            this.txtPrecioDecena.TabIndex = 5;
            // 
            // lblPrecioDecena
            // 
            this.lblPrecioDecena.AutoSize = true;
            this.lblPrecioDecena.Location = new System.Drawing.Point(30, 146);
            this.lblPrecioDecena.Name = "lblPrecioDecena";
            this.lblPrecioDecena.Size = new System.Drawing.Size(105, 17);
            this.lblPrecioDecena.TabIndex = 15;
            this.lblPrecioDecena.Text = "Precio Decena:";
            this.lblPrecioDecena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecioBloque
            // 
            this.txtPrecioBloque.Location = new System.Drawing.Point(374, 75);
            this.txtPrecioBloque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioBloque.Name = "txtPrecioBloque";
            this.txtPrecioBloque.Size = new System.Drawing.Size(98, 22);
            this.txtPrecioBloque.TabIndex = 2;
            // 
            // lblCantAdultos
            // 
            this.lblCantAdultos.AutoSize = true;
            this.lblCantAdultos.Location = new System.Drawing.Point(260, 112);
            this.lblCantAdultos.Name = "lblCantAdultos";
            this.lblCantAdultos.Size = new System.Drawing.Size(96, 17);
            this.lblCantAdultos.TabIndex = 11;
            this.lblCantAdultos.Text = "Cant. Adultos:";
            this.lblCantAdultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(387, 157);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(296, 157);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 39);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(141, 75);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(98, 22);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(141, 41);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(331, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblCantNiños
            // 
            this.lblCantNiños.AutoSize = true;
            this.lblCantNiños.Location = new System.Drawing.Point(50, 112);
            this.lblCantNiños.Name = "lblCantNiños";
            this.lblCantNiños.Size = new System.Drawing.Size(85, 17);
            this.lblCantNiños.TabIndex = 4;
            this.lblCantNiños.Text = "Cant. Niños:";
            this.lblCantNiños.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecioBloque
            // 
            this.lblPrecioBloque.AutoSize = true;
            this.lblPrecioBloque.Location = new System.Drawing.Point(262, 78);
            this.lblPrecioBloque.Name = "lblPrecioBloque";
            this.lblPrecioBloque.Size = new System.Drawing.Size(100, 17);
            this.lblPrecioBloque.TabIndex = 3;
            this.lblPrecioBloque.Text = "Precio Bloque:";
            this.lblPrecioBloque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(83, 78);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(49, 44);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FABMEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 614);
            this.Controls.Add(this.gridEventos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.gbDatosEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(653, 661);
            this.Name = "FABMEventos";
            this.Text = "Gestión de Eventos";
            this.Load += new System.EventHandler(this.FABMEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            this.gbDatosEvento.ResumeLayout(false);
            this.gbDatosEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadNiños)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEventos;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.GroupBox gbDatosEvento;
        private System.Windows.Forms.TextBox txtPrecioBloque;
        private System.Windows.Forms.Label lblCantAdultos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCantNiños;
        private System.Windows.Forms.Label lblPrecioBloque;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecioDecena;
        private System.Windows.Forms.Label lblPrecioDecena;
        private System.Windows.Forms.NumericUpDown numCantidadAdultos;
        private System.Windows.Forms.NumericUpDown numCantidadNiños;
    }
}