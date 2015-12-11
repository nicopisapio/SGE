namespace Gestor_de_Eventos
{
    partial class FPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuSGE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBusquedaYReservaDeFechas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCotizacionDeEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionDeTipoDeEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionDeServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetalleDeEventosReservados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModificacionDeEventosReservados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarExcedentes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReasignacionDeEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionDeEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionDePermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionDeCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetalleDeHorasTrabajadas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSemanal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMensual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCambiarIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealizarBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealizarRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSGE,
            this.menuVenta,
            this.menuEventos,
            this.menuAdministracion,
            this.menuOpciones,
            this.menuHerramientas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuSGE
            // 
            this.menuSGE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIniciarSesion,
            this.menuCerrarSesion,
            this.toolStripSeparator1,
            this.menuSalir});
            this.menuSGE.Name = "menuSGE";
            this.menuSGE.Size = new System.Drawing.Size(47, 24);
            this.menuSGE.Text = "SGE";
            // 
            // menuIniciarSesion
            // 
            this.menuIniciarSesion.Name = "menuIniciarSesion";
            this.menuIniciarSesion.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuIniciarSesion.Size = new System.Drawing.Size(195, 26);
            this.menuIniciarSesion.Text = "Iniciar Sesion";
            this.menuIniciarSesion.Click += new System.EventHandler(this.menuIniciarSesion_Click);
            // 
            // menuCerrarSesion
            // 
            this.menuCerrarSesion.Name = "menuCerrarSesion";
            this.menuCerrarSesion.Size = new System.Drawing.Size(195, 26);
            this.menuCerrarSesion.Text = "Cerrar Sesión";
            this.menuCerrarSesion.Click += new System.EventHandler(this.menuCerrarSesion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuSalir.Size = new System.Drawing.Size(195, 26);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuVenta
            // 
            this.menuVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBusquedaYReservaDeFechas,
            this.menuCotizacionDeEventos});
            this.menuVenta.Name = "menuVenta";
            this.menuVenta.Size = new System.Drawing.Size(66, 24);
            this.menuVenta.Text = "VENTA";
            // 
            // menuBusquedaYReservaDeFechas
            // 
            this.menuBusquedaYReservaDeFechas.Name = "menuBusquedaYReservaDeFechas";
            this.menuBusquedaYReservaDeFechas.Size = new System.Drawing.Size(284, 26);
            this.menuBusquedaYReservaDeFechas.Text = "Búsqueda y Reserva de Fechas";
            this.menuBusquedaYReservaDeFechas.Click += new System.EventHandler(this.menuBusquedaYReservaDeFechas_Click);
            // 
            // menuCotizacionDeEventos
            // 
            this.menuCotizacionDeEventos.Name = "menuCotizacionDeEventos";
            this.menuCotizacionDeEventos.Size = new System.Drawing.Size(284, 26);
            this.menuCotizacionDeEventos.Text = "Cotización de Eventos";
            this.menuCotizacionDeEventos.Click += new System.EventHandler(this.menuCotizacionDeEventos_Click);
            // 
            // menuEventos
            // 
            this.menuEventos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionDeTipoDeEventos,
            this.menuGestionDeServicios,
            this.menuDetalleDeEventosReservados,
            this.menuModificacionDeEventosReservados,
            this.menuAgregarExcedentes,
            this.menuReasignacionDeEmpleados});
            this.menuEventos.Name = "menuEventos";
            this.menuEventos.Size = new System.Drawing.Size(83, 24);
            this.menuEventos.Text = "EVENTOS";
            // 
            // menuGestionDeTipoDeEventos
            // 
            this.menuGestionDeTipoDeEventos.Name = "menuGestionDeTipoDeEventos";
            this.menuGestionDeTipoDeEventos.Size = new System.Drawing.Size(326, 26);
            this.menuGestionDeTipoDeEventos.Text = "Gestión de Tipo de Eventos";
            this.menuGestionDeTipoDeEventos.Click += new System.EventHandler(this.menuGestionDeTipoDeEventos_Click);
            // 
            // menuGestionDeServicios
            // 
            this.menuGestionDeServicios.Name = "menuGestionDeServicios";
            this.menuGestionDeServicios.Size = new System.Drawing.Size(326, 26);
            this.menuGestionDeServicios.Text = "Gestión de Servicios";
            this.menuGestionDeServicios.Click += new System.EventHandler(this.menuGestionDeServicios_Click);
            // 
            // menuDetalleDeEventosReservados
            // 
            this.menuDetalleDeEventosReservados.Name = "menuDetalleDeEventosReservados";
            this.menuDetalleDeEventosReservados.Size = new System.Drawing.Size(326, 26);
            this.menuDetalleDeEventosReservados.Text = "Detalle de Eventos Reservados";
            this.menuDetalleDeEventosReservados.Click += new System.EventHandler(this.menuDetalleDeEventosReservados_Click);
            // 
            // menuModificacionDeEventosReservados
            // 
            this.menuModificacionDeEventosReservados.Name = "menuModificacionDeEventosReservados";
            this.menuModificacionDeEventosReservados.Size = new System.Drawing.Size(326, 26);
            this.menuModificacionDeEventosReservados.Text = "Modificación de Eventos Reservados";
            this.menuModificacionDeEventosReservados.Click += new System.EventHandler(this.menuModificacionDeEventosReservados_Click);
            // 
            // menuAgregarExcedentes
            // 
            this.menuAgregarExcedentes.Name = "menuAgregarExcedentes";
            this.menuAgregarExcedentes.Size = new System.Drawing.Size(326, 26);
            this.menuAgregarExcedentes.Text = "Agregar Excedentes";
            this.menuAgregarExcedentes.Click += new System.EventHandler(this.menuAgregarExcedentes_Click);
            // 
            // menuReasignacionDeEmpleados
            // 
            this.menuReasignacionDeEmpleados.Name = "menuReasignacionDeEmpleados";
            this.menuReasignacionDeEmpleados.Size = new System.Drawing.Size(326, 26);
            this.menuReasignacionDeEmpleados.Text = "Reasignación de Empleados";
            this.menuReasignacionDeEmpleados.Click += new System.EventHandler(this.menuReasignacionDeEmpleados_Click);
            // 
            // menuAdministracion
            // 
            this.menuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionDeEmpleados,
            this.menuGestionDeUsuarios,
            this.menuGestionDePermisos,
            this.menuGestionDeCargos,
            this.menuDetalleDeHorasTrabajadas});
            this.menuAdministracion.Name = "menuAdministracion";
            this.menuAdministracion.Size = new System.Drawing.Size(144, 24);
            this.menuAdministracion.Text = "ADMINISTRACIÓN";
            // 
            // menuGestionDeEmpleados
            // 
            this.menuGestionDeEmpleados.Name = "menuGestionDeEmpleados";
            this.menuGestionDeEmpleados.Size = new System.Drawing.Size(272, 26);
            this.menuGestionDeEmpleados.Text = "Gestión de Empleados";
            this.menuGestionDeEmpleados.Click += new System.EventHandler(this.menuGestionDeEmpleados_Click);
            // 
            // menuGestionDeUsuarios
            // 
            this.menuGestionDeUsuarios.Name = "menuGestionDeUsuarios";
            this.menuGestionDeUsuarios.Size = new System.Drawing.Size(272, 26);
            this.menuGestionDeUsuarios.Text = "Gestión de Usuarios";
            this.menuGestionDeUsuarios.Click += new System.EventHandler(this.menuGestionDeUsuarios_Click);
            // 
            // menuGestionDePermisos
            // 
            this.menuGestionDePermisos.Name = "menuGestionDePermisos";
            this.menuGestionDePermisos.Size = new System.Drawing.Size(272, 26);
            this.menuGestionDePermisos.Text = "Gestión de Permisos";
            this.menuGestionDePermisos.Click += new System.EventHandler(this.menuGestionDePermisos_Click);
            // 
            // menuGestionDeCargos
            // 
            this.menuGestionDeCargos.Name = "menuGestionDeCargos";
            this.menuGestionDeCargos.Size = new System.Drawing.Size(272, 26);
            this.menuGestionDeCargos.Text = "Gestión de Cargos";
            this.menuGestionDeCargos.Click += new System.EventHandler(this.menuGestionDeCargos_Click);
            // 
            // menuDetalleDeHorasTrabajadas
            // 
            this.menuDetalleDeHorasTrabajadas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSemanal,
            this.menuMensual});
            this.menuDetalleDeHorasTrabajadas.Name = "menuDetalleDeHorasTrabajadas";
            this.menuDetalleDeHorasTrabajadas.Size = new System.Drawing.Size(272, 26);
            this.menuDetalleDeHorasTrabajadas.Text = "Detalle de Horas Trabajadas";
            // 
            // menuSemanal
            // 
            this.menuSemanal.Name = "menuSemanal";
            this.menuSemanal.Size = new System.Drawing.Size(181, 26);
            this.menuSemanal.Text = "Semanal";
            this.menuSemanal.Click += new System.EventHandler(this.semanalToolStripMenuItem_Click);
            // 
            // menuMensual
            // 
            this.menuMensual.Name = "menuMensual";
            this.menuMensual.Size = new System.Drawing.Size(181, 26);
            this.menuMensual.Text = "Mensual";
            this.menuMensual.Click += new System.EventHandler(this.mensualToolStripMenuItem_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCambiarIdioma,
            this.menuAgregarIdioma});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuOpciones.Size = new System.Drawing.Size(91, 24);
            this.menuOpciones.Text = "OPCIONES";
            // 
            // menuCambiarIdioma
            // 
            this.menuCambiarIdioma.Name = "menuCambiarIdioma";
            this.menuCambiarIdioma.Size = new System.Drawing.Size(191, 26);
            this.menuCambiarIdioma.Text = "Cambiar Idioma";
            this.menuCambiarIdioma.Click += new System.EventHandler(this.menuCambiarIdioma_Click);
            // 
            // menuAgregarIdioma
            // 
            this.menuAgregarIdioma.Name = "menuAgregarIdioma";
            this.menuAgregarIdioma.Size = new System.Drawing.Size(191, 26);
            this.menuAgregarIdioma.Text = "Agregar Idioma";
            this.menuAgregarIdioma.Click += new System.EventHandler(this.menuAgregarIdioma_Click);
            // 
            // menuHerramientas
            // 
            this.menuHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBD,
            this.menuBitacora});
            this.menuHerramientas.Name = "menuHerramientas";
            this.menuHerramientas.Size = new System.Drawing.Size(129, 24);
            this.menuHerramientas.Text = "HERRAMIENTAS";
            // 
            // menuBD
            // 
            this.menuBD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRealizarBackup,
            this.menuRealizarRestore});
            this.menuBD.Name = "menuBD";
            this.menuBD.Size = new System.Drawing.Size(181, 26);
            this.menuBD.Text = "Base de Datos";
            // 
            // menuRealizarBackup
            // 
            this.menuRealizarBackup.Name = "menuRealizarBackup";
            this.menuRealizarBackup.Size = new System.Drawing.Size(191, 26);
            this.menuRealizarBackup.Text = "Realizar Backup";
            this.menuRealizarBackup.Click += new System.EventHandler(this.menuRealizarBackup_Click);
            // 
            // menuRealizarRestore
            // 
            this.menuRealizarRestore.Name = "menuRealizarRestore";
            this.menuRealizarRestore.Size = new System.Drawing.Size(191, 26);
            this.menuRealizarRestore.Text = "Realizar Restore";
            this.menuRealizarRestore.Click += new System.EventHandler(this.menuRealizarRestore_Click);
            // 
            // menuBitacora
            // 
            this.menuBitacora.Name = "menuBitacora";
            this.menuBitacora.Size = new System.Drawing.Size(181, 26);
            this.menuBitacora.Text = "Bitácora";
            this.menuBitacora.Click += new System.EventHandler(this.menuBitacora_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 682);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FPrincipal";
            this.Text = "Gestor de Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FPrincipal_Activated);
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuSGE;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuVenta;
        private System.Windows.Forms.ToolStripMenuItem menuBusquedaYReservaDeFechas;
        private System.Windows.Forms.ToolStripMenuItem menuCotizacionDeEventos;
        private System.Windows.Forms.ToolStripMenuItem menuEventos;
        private System.Windows.Forms.ToolStripMenuItem menuGestionDeTipoDeEventos;
        private System.Windows.Forms.ToolStripMenuItem menuGestionDeServicios;
        private System.Windows.Forms.ToolStripMenuItem menuDetalleDeEventosReservados;
        private System.Windows.Forms.ToolStripMenuItem menuModificacionDeEventosReservados;
        private System.Windows.Forms.ToolStripMenuItem menuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem menuGestionDeEmpleados;
        private System.Windows.Forms.ToolStripMenuItem menuDetalleDeHorasTrabajadas;
        private System.Windows.Forms.ToolStripMenuItem menuIniciarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarExcedentes;
        private System.Windows.Forms.ToolStripMenuItem menuReasignacionDeEmpleados;
        private System.Windows.Forms.ToolStripMenuItem menuGestionDePermisos;
        private System.Windows.Forms.ToolStripMenuItem menuGestionDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarIdioma;
        private System.Windows.Forms.ToolStripMenuItem menuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem menuBD;
        private System.Windows.Forms.ToolStripMenuItem menuRealizarBackup;
        private System.Windows.Forms.ToolStripMenuItem menuRealizarRestore;
        private System.Windows.Forms.ToolStripMenuItem menuBitacora;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarIdioma;
        private System.Windows.Forms.ToolStripMenuItem menuSemanal;
        private System.Windows.Forms.ToolStripMenuItem menuMensual;
        private System.Windows.Forms.ToolStripMenuItem menuGestionDeCargos;
    }
}