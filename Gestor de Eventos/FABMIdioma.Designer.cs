namespace Gestor_de_Eventos
{
    partial class FABMIdioma
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
            this.gbNuevoIdioma = new System.Windows.Forms.GroupBox();
            this.cboCulturas = new System.Windows.Forms.ComboBox();
            this.txtNombreIdioma = new System.Windows.Forms.TextBox();
            this.lblCultura = new System.Windows.Forms.Label();
            this.lblNombreIdioma = new System.Windows.Forms.Label();
            this.gridTraduccion = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbNuevoIdioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoIdioma
            // 
            this.gbNuevoIdioma.Controls.Add(this.cboCulturas);
            this.gbNuevoIdioma.Controls.Add(this.txtNombreIdioma);
            this.gbNuevoIdioma.Controls.Add(this.lblCultura);
            this.gbNuevoIdioma.Controls.Add(this.lblNombreIdioma);
            this.gbNuevoIdioma.Location = new System.Drawing.Point(12, 12);
            this.gbNuevoIdioma.Name = "gbNuevoIdioma";
            this.gbNuevoIdioma.Size = new System.Drawing.Size(451, 113);
            this.gbNuevoIdioma.TabIndex = 0;
            this.gbNuevoIdioma.TabStop = false;
            this.gbNuevoIdioma.Text = "Nuevo Idioma";
            // 
            // cboCulturas
            // 
            this.cboCulturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCulturas.FormattingEnabled = true;
            this.cboCulturas.Location = new System.Drawing.Point(119, 69);
            this.cboCulturas.Name = "cboCulturas";
            this.cboCulturas.Size = new System.Drawing.Size(314, 24);
            this.cboCulturas.TabIndex = 1;
            // 
            // txtNombreIdioma
            // 
            this.txtNombreIdioma.Location = new System.Drawing.Point(119, 30);
            this.txtNombreIdioma.Name = "txtNombreIdioma";
            this.txtNombreIdioma.Size = new System.Drawing.Size(314, 22);
            this.txtNombreIdioma.TabIndex = 0;
            // 
            // lblCultura
            // 
            this.lblCultura.AutoSize = true;
            this.lblCultura.Location = new System.Drawing.Point(56, 73);
            this.lblCultura.Name = "lblCultura";
            this.lblCultura.Size = new System.Drawing.Size(57, 17);
            this.lblCultura.TabIndex = 2;
            this.lblCultura.Text = "Cultura:";
            this.lblCultura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreIdioma
            // 
            this.lblNombreIdioma.AutoSize = true;
            this.lblNombreIdioma.Location = new System.Drawing.Point(6, 33);
            this.lblNombreIdioma.Name = "lblNombreIdioma";
            this.lblNombreIdioma.Size = new System.Drawing.Size(107, 17);
            this.lblNombreIdioma.TabIndex = 1;
            this.lblNombreIdioma.Text = "Nombre Idioma:";
            this.lblNombreIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridTraduccion
            // 
            this.gridTraduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTraduccion.Location = new System.Drawing.Point(12, 132);
            this.gridTraduccion.MinimumSize = new System.Drawing.Size(628, 527);
            this.gridTraduccion.Name = "gridTraduccion";
            this.gridTraduccion.RowHeadersVisible = false;
            this.gridTraduccion.RowTemplate.Height = 24;
            this.gridTraduccion.Size = new System.Drawing.Size(628, 527);
            this.gridTraduccion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(469, 42);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 66);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(557, 42);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 66);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FABMIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 671);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gridTraduccion);
            this.Controls.Add(this.gbNuevoIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(669, 718);
            this.Name = "FABMIdioma";
            this.Text = "Agregar Idioma";
            this.Load += new System.EventHandler(this.FABMIdioma_Load);
            this.gbNuevoIdioma.ResumeLayout(false);
            this.gbNuevoIdioma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoIdioma;
        private System.Windows.Forms.ComboBox cboCulturas;
        private System.Windows.Forms.TextBox txtNombreIdioma;
        private System.Windows.Forms.Label lblCultura;
        private System.Windows.Forms.Label lblNombreIdioma;
        private System.Windows.Forms.DataGridView gridTraduccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}