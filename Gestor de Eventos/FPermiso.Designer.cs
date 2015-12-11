namespace Gestor_de_Eventos
{
    partial class FPermiso
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
            this.gbPermiso = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.treePermisosPadre = new System.Windows.Forms.TreeView();
            this.listPermisosPadre = new System.Windows.Forms.ListBox();
            this.listPermisosHijo = new System.Windows.Forms.ListBox();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.gbPermiso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPermiso
            // 
            this.gbPermiso.Controls.Add(this.txtDescripcion);
            this.gbPermiso.Controls.Add(this.lblDescripcion);
            this.gbPermiso.Location = new System.Drawing.Point(16, 15);
            this.gbPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.gbPermiso.Name = "gbPermiso";
            this.gbPermiso.Padding = new System.Windows.Forms.Padding(4);
            this.gbPermiso.Size = new System.Drawing.Size(421, 105);
            this.gbPermiso.TabIndex = 0;
            this.gbPermiso.TabStop = false;
            this.gbPermiso.Text = "Nuevo Grupo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 46);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 49);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(532, 41);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 66);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(444, 41);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 66);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(16, 146);
            this.lblPermisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(70, 17);
            this.lblPermisos.TabIndex = 7;
            this.lblPermisos.Text = "Permisos:";
            // 
            // treePermisosPadre
            // 
            this.treePermisosPadre.Location = new System.Drawing.Point(16, 166);
            this.treePermisosPadre.Margin = new System.Windows.Forms.Padding(4);
            this.treePermisosPadre.Name = "treePermisosPadre";
            this.treePermisosPadre.Size = new System.Drawing.Size(299, 372);
            this.treePermisosPadre.TabIndex = 3;
            // 
            // listPermisosPadre
            // 
            this.listPermisosPadre.FormattingEnabled = true;
            this.listPermisosPadre.ItemHeight = 16;
            this.listPermisosPadre.Location = new System.Drawing.Point(324, 166);
            this.listPermisosPadre.Margin = new System.Windows.Forms.Padding(4);
            this.listPermisosPadre.Name = "listPermisosPadre";
            this.listPermisosPadre.Size = new System.Drawing.Size(299, 180);
            this.listPermisosPadre.TabIndex = 4;
            this.listPermisosPadre.SelectedIndexChanged += new System.EventHandler(this.listPermisosPadre_SelectedIndexChanged);
            // 
            // listPermisosHijo
            // 
            this.listPermisosHijo.FormattingEnabled = true;
            this.listPermisosHijo.ItemHeight = 16;
            this.listPermisosHijo.Location = new System.Drawing.Point(324, 358);
            this.listPermisosHijo.Margin = new System.Windows.Forms.Padding(4);
            this.listPermisosHijo.Name = "listPermisosHijo";
            this.listPermisosHijo.Size = new System.Drawing.Size(299, 180);
            this.listPermisosHijo.TabIndex = 5;
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(15, 545);
            this.btnEliminarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(83, 46);
            this.btnEliminarPermiso.TabIndex = 6;
            this.btnEliminarPermiso.Text = "Eliminar";
            this.btnEliminarPermiso.UseVisualStyleBackColor = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(233, 545);
            this.btnAgregarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(83, 46);
            this.btnAgregarPermiso.TabIndex = 7;
            this.btnAgregarPermiso.Text = "Agregar";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.Location = new System.Drawing.Point(324, 545);
            this.btnQuitarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(83, 46);
            this.btnQuitarPermiso.TabIndex = 8;
            this.btnQuitarPermiso.Text = "Quitar";
            this.btnQuitarPermiso.UseVisualStyleBackColor = true;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // FPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 598);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.listPermisosHijo);
            this.Controls.Add(this.listPermisosPadre);
            this.Controls.Add(this.treePermisosPadre);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbPermiso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(658, 645);
            this.Name = "FPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permiso";
            this.Load += new System.EventHandler(this.FPermiso_Load);
            this.gbPermiso.ResumeLayout(false);
            this.gbPermiso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPermiso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.TreeView treePermisosPadre;
        private System.Windows.Forms.ListBox listPermisosPadre;
        private System.Windows.Forms.ListBox listPermisosHijo;
        private System.Windows.Forms.Button btnEliminarPermiso;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Button btnQuitarPermiso;
    }
}