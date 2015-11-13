namespace Gestor_de_Eventos
{
    partial class FABMEmpleado
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
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDU = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.gbDatosEmpleado.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.AllowUserToAddRows = false;
            this.gridEmpleados.AllowUserToDeleteRows = false;
            this.gridEmpleados.AllowUserToResizeRows = false;
            this.gridEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Location = new System.Drawing.Point(11, 296);
            this.gridEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridEmpleados.MultiSelect = false;
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.ReadOnly = true;
            this.gridEmpleados.RowHeadersVisible = false;
            this.gridEmpleados.RowTemplate.Height = 24;
            this.gridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpleados.Size = new System.Drawing.Size(678, 344);
            this.gridEmpleados.TabIndex = 16;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(587, 203);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(102, 58);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(587, 119);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(102, 58);
            this.btnModificacion.TabIndex = 1;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(587, 33);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(102, 58);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.cboCargo);
            this.gbDatosEmpleado.Controls.Add(this.lblCargo);
            this.gbDatosEmpleado.Controls.Add(this.chkActivo);
            this.gbDatosEmpleado.Controls.Add(this.gbDireccion);
            this.gbDatosEmpleado.Controls.Add(this.txtTelefono);
            this.gbDatosEmpleado.Controls.Add(this.lblTelefono);
            this.gbDatosEmpleado.Controls.Add(this.txtNombre);
            this.gbDatosEmpleado.Controls.Add(this.lblNombre);
            this.gbDatosEmpleado.Controls.Add(this.btnCancelar);
            this.gbDatosEmpleado.Controls.Add(this.btnAceptar);
            this.gbDatosEmpleado.Controls.Add(this.txtApellido);
            this.gbDatosEmpleado.Controls.Add(this.txtDU);
            this.gbDatosEmpleado.Controls.Add(this.lblApellido);
            this.gbDatosEmpleado.Controls.Add(this.lblDU);
            this.gbDatosEmpleado.Location = new System.Drawing.Point(11, 11);
            this.gbDatosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosEmpleado.Size = new System.Drawing.Size(563, 266);
            this.gbDatosEmpleado.TabIndex = 12;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "Datos del Empleado";
            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(86, 179);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(151, 24);
            this.cboCargo.TabIndex = 7;
            // 
            // lblCargo
            // 
            this.lblCargo.Location = new System.Drawing.Point(6, 180);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(74, 20);
            this.lblCargo.TabIndex = 15;
            this.lblCargo.Text = "Cargo:";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Location = new System.Drawing.Point(169, 217);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(68, 21);
            this.chkActivo.TabIndex = 8;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.txtDepto);
            this.gbDireccion.Controls.Add(this.lblDpto);
            this.gbDireccion.Controls.Add(this.txtPiso);
            this.gbDireccion.Controls.Add(this.lblPiso);
            this.gbDireccion.Controls.Add(this.txtLocalidad);
            this.gbDireccion.Controls.Add(this.lblLocalidad);
            this.gbDireccion.Controls.Add(this.txtAltura);
            this.gbDireccion.Controls.Add(this.txtCalle);
            this.gbDireccion.Controls.Add(this.lblAltura);
            this.gbDireccion.Controls.Add(this.lblCalle);
            this.gbDireccion.Location = new System.Drawing.Point(276, 24);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(275, 180);
            this.gbDireccion.TabIndex = 12;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Dirección";
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(207, 142);
            this.txtDepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(40, 22);
            this.txtDepto.TabIndex = 13;
            // 
            // lblDpto
            // 
            this.lblDpto.Location = new System.Drawing.Point(150, 143);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(51, 20);
            this.lblDpto.TabIndex = 23;
            this.lblDpto.Text = "Dpto:";
            this.lblDpto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(96, 142);
            this.txtPiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(40, 22);
            this.txtPiso.TabIndex = 12;
            // 
            // lblPiso
            // 
            this.lblPiso.Location = new System.Drawing.Point(16, 143);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(74, 20);
            this.lblPiso.TabIndex = 21;
            this.lblPiso.Text = "Piso:";
            this.lblPiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(96, 107);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(151, 22);
            this.txtLocalidad.TabIndex = 11;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Location = new System.Drawing.Point(16, 108);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 20);
            this.lblLocalidad.TabIndex = 19;
            this.lblLocalidad.Text = "Localidad:";
            this.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(96, 73);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(151, 22);
            this.txtAltura.TabIndex = 10;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(96, 39);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(151, 22);
            this.txtCalle.TabIndex = 9;
            // 
            // lblAltura
            // 
            this.lblAltura.Location = new System.Drawing.Point(16, 74);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(74, 20);
            this.lblAltura.TabIndex = 16;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalle
            // 
            this.lblCalle.Location = new System.Drawing.Point(35, 40);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(55, 21);
            this.lblCalle.TabIndex = 15;
            this.lblCalle.Text = "Calle:";
            this.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(86, 143);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(6, 144);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 20);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(6, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(463, 219);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 39);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(372, 219);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 39);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(86, 74);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // txtDU
            // 
            this.txtDU.Location = new System.Drawing.Point(86, 41);
            this.txtDU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDU.Name = "txtDU";
            this.txtDU.Size = new System.Drawing.Size(151, 22);
            this.txtDU.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(6, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(74, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDU
            // 
            this.lblDU.Location = new System.Drawing.Point(25, 41);
            this.lblDU.Name = "lblDU";
            this.lblDU.Size = new System.Drawing.Size(55, 21);
            this.lblDU.TabIndex = 1;
            this.lblDU.Text = "DU:";
            this.lblDU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 651);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(719, 698);
            this.Name = "FABMEmpleado";
            this.Text = "Gestión de Empleados";
            this.Load += new System.EventHandler(this.FABMEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDU;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDU;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cboCargo;
    }
}