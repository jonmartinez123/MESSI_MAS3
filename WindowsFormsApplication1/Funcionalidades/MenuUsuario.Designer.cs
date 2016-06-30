namespace MercadoEnvio.Funcionalidades
{
    partial class MenuUsuario
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
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_rubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abm_visibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPublicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarOfertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificarAlVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadisticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darseDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiontoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.publicacionesToolStripMenuItem,
            this.comprarOfertarToolStripMenuItem,
            this.historialDeClienteToolStripMenuItem,
            this.calificarAlVendedorToolStripMenuItem,
            this.consultarFacturasToolStripMenuItem,
            this.listadoEstadisticoToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.cerrarSesiontoolStripMenuItem,
            this.salirtoolStripMenuItem});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(986, 24);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abm_rolToolStripMenuItem,
            this.abm_usuarioToolStripMenuItem,
            this.abm_rubroToolStripMenuItem,
            this.abm_visibilidadToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administración";
            // 
            // abm_rolToolStripMenuItem
            // 
            this.abm_rolToolStripMenuItem.Name = "abm_rolToolStripMenuItem";
            this.abm_rolToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abm_rolToolStripMenuItem.Text = "ABM ROL";
            this.abm_rolToolStripMenuItem.Click += new System.EventHandler(this.abm_rolToolStripMenuItem_Click);
            // 
            // abm_usuarioToolStripMenuItem
            // 
            this.abm_usuarioToolStripMenuItem.Name = "abm_usuarioToolStripMenuItem";
            this.abm_usuarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abm_usuarioToolStripMenuItem.Text = "ABM USUARIO";
            this.abm_usuarioToolStripMenuItem.Click += new System.EventHandler(this.abm_usuarioToolStripMenuItem_Click);
            // 
            // abm_rubroToolStripMenuItem
            // 
            this.abm_rubroToolStripMenuItem.Name = "abm_rubroToolStripMenuItem";
            this.abm_rubroToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abm_rubroToolStripMenuItem.Text = "ABM RUBRO";
            this.abm_rubroToolStripMenuItem.Click += new System.EventHandler(this.abm_rubroToolStripMenuItem_Click);
            // 
            // abm_visibilidadToolStripMenuItem
            // 
            this.abm_visibilidadToolStripMenuItem.Name = "abm_visibilidadToolStripMenuItem";
            this.abm_visibilidadToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abm_visibilidadToolStripMenuItem.Text = "ABM VISIBILIDAD";
            this.abm_visibilidadToolStripMenuItem.Click += new System.EventHandler(this.abm_visibilidadToolStripMenuItem_Click);
            // 
            // publicacionesToolStripMenuItem
            // 
            this.publicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.generarPublicacionToolStripMenuItem});
            this.publicacionesToolStripMenuItem.Name = "publicacionesToolStripMenuItem";
            this.publicacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.publicacionesToolStripMenuItem.Text = "Publicaciones";
            this.publicacionesToolStripMenuItem.Click += new System.EventHandler(this.publicarToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem.Text = "Mis publicaciones";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // generarPublicacionToolStripMenuItem
            // 
            this.generarPublicacionToolStripMenuItem.Name = "generarPublicacionToolStripMenuItem";
            this.generarPublicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarPublicacionToolStripMenuItem.Text = "Generar Publicacion";
            this.generarPublicacionToolStripMenuItem.Click += new System.EventHandler(this.generarPublicacionToolStripMenuItem_Click);
            // 
            // comprarOfertarToolStripMenuItem
            // 
            this.comprarOfertarToolStripMenuItem.Name = "comprarOfertarToolStripMenuItem";
            this.comprarOfertarToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.comprarOfertarToolStripMenuItem.Text = "Comprar/Ofertar";
            this.comprarOfertarToolStripMenuItem.Click += new System.EventHandler(this.comprarOfertarToolStripMenuItem_Click);
            // 
            // historialDeClienteToolStripMenuItem
            // 
            this.historialDeClienteToolStripMenuItem.Name = "historialDeClienteToolStripMenuItem";
            this.historialDeClienteToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.historialDeClienteToolStripMenuItem.Text = "Historial de Cliente";
            this.historialDeClienteToolStripMenuItem.Click += new System.EventHandler(this.historialDeClienteToolStripMenuItem_Click);
            // 
            // calificarAlVendedorToolStripMenuItem
            // 
            this.calificarAlVendedorToolStripMenuItem.Name = "calificarAlVendedorToolStripMenuItem";
            this.calificarAlVendedorToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.calificarAlVendedorToolStripMenuItem.Text = "Calificar al Vendedor";
            this.calificarAlVendedorToolStripMenuItem.Click += new System.EventHandler(this.calificarAlVendedorToolStripMenuItem_Click);
            // 
            // consultarFacturasToolStripMenuItem
            // 
            this.consultarFacturasToolStripMenuItem.Name = "consultarFacturasToolStripMenuItem";
            this.consultarFacturasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.consultarFacturasToolStripMenuItem.Text = "Consultar Facturas";
            this.consultarFacturasToolStripMenuItem.Click += new System.EventHandler(this.consultarFacturasToolStripMenuItem_Click);
            // 
            // listadoEstadisticoToolStripMenuItem
            // 
            this.listadoEstadisticoToolStripMenuItem.Name = "listadoEstadisticoToolStripMenuItem";
            this.listadoEstadisticoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.listadoEstadisticoToolStripMenuItem.Text = "Listado Estadistico";
            this.listadoEstadisticoToolStripMenuItem.Click += new System.EventHandler(this.listadoEstadisticoToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.darseDeBajaToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // darseDeBajaToolStripMenuItem
            // 
            this.darseDeBajaToolStripMenuItem.Name = "darseDeBajaToolStripMenuItem";
            this.darseDeBajaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.darseDeBajaToolStripMenuItem.Text = "Darse de Baja";
            this.darseDeBajaToolStripMenuItem.Click += new System.EventHandler(this.darseDeBajaToolStripMenuItem_Click);
            // 
            // cerrarSesiontoolStripMenuItem
            // 
            this.cerrarSesiontoolStripMenuItem.Name = "cerrarSesiontoolStripMenuItem";
            this.cerrarSesiontoolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiontoolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesiontoolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiontoolStripMenuItem_Click);
            // 
            // salirtoolStripMenuItem
            // 
            this.salirtoolStripMenuItem.Name = "salirtoolStripMenuItem";
            this.salirtoolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirtoolStripMenuItem.Text = "Salir";
            this.salirtoolStripMenuItem.Click += new System.EventHandler(this.salirtoolStripMenuItem_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 356);
            this.Controls.Add(this.menuHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuHome;
            this.MaximizeBox = false;
            this.Name = "MenuUsuario";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu De Usuario";
            this.Load += new System.EventHandler(this.MenuUsuario_Load);
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarOfertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abm_rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abm_usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abm_rubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abm_visibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificarAlVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadisticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiontoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darseDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPublicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirtoolStripMenuItem;
    }
}