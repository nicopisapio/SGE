namespace Gestor_de_Eventos
{
    partial class FIdioma
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
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbIdioma = new System.Windows.Forms.GroupBox();
            this.gbIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(22, 38);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(179, 24);
            this.cboIdioma.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 92);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbIdioma
            // 
            this.gbIdioma.Controls.Add(this.cboIdioma);
            this.gbIdioma.Controls.Add(this.btnAceptar);
            this.gbIdioma.Location = new System.Drawing.Point(12, 12);
            this.gbIdioma.Name = "gbIdioma";
            this.gbIdioma.Size = new System.Drawing.Size(218, 144);
            this.gbIdioma.TabIndex = 2;
            this.gbIdioma.TabStop = false;
            this.gbIdioma.Text = "Seleccione el Idioma";
            // 
            // FIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 169);
            this.Controls.Add(this.gbIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(260, 216);
            this.MinimumSize = new System.Drawing.Size(260, 216);
            this.Name = "FIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.FIdioma_Load);
            this.gbIdioma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbIdioma;
    }
}