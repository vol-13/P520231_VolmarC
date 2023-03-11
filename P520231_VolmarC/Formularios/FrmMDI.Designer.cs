namespace P520231_VolmarC.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoríasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reimpresiónDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.AccessibleName = "";
            this.MnuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuReportes,
            this.MnuSalir,
            this.MnuAcercaDe});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(800, 29);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestiónDeProductosToolStripMenuItem,
            this.gestiónDeProveedoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoríasDeProductosToolStripMenuItem,
            this.rolesDeUsuarioToolStripMenuItem,
            this.tiposDeProveedorToolStripMenuItem,
            this.tiposDeCompraToolStripMenuItem,
            this.toolStripSeparator4});
            this.MnuGestiones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(103, 25);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestiónDeProductosToolStripMenuItem
            // 
            this.gestiónDeProductosToolStripMenuItem.Name = "gestiónDeProductosToolStripMenuItem";
            this.gestiónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.gestiónDeProductosToolStripMenuItem.Text = "Gestión de Productos";
            // 
            // gestiónDeProveedoresToolStripMenuItem
            // 
            this.gestiónDeProveedoresToolStripMenuItem.Name = "gestiónDeProveedoresToolStripMenuItem";
            this.gestiónDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.gestiónDeProveedoresToolStripMenuItem.Text = "Gestión de Proveedores";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // categoríasDeProductosToolStripMenuItem
            // 
            this.categoríasDeProductosToolStripMenuItem.Name = "categoríasDeProductosToolStripMenuItem";
            this.categoríasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.categoríasDeProductosToolStripMenuItem.Text = "Categorías de Productos";
            // 
            // rolesDeUsuarioToolStripMenuItem
            // 
            this.rolesDeUsuarioToolStripMenuItem.Name = "rolesDeUsuarioToolStripMenuItem";
            this.rolesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.rolesDeUsuarioToolStripMenuItem.Text = "Roles de Usuario";
            // 
            // tiposDeProveedorToolStripMenuItem
            // 
            this.tiposDeProveedorToolStripMenuItem.Name = "tiposDeProveedorToolStripMenuItem";
            this.tiposDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tiposDeProveedorToolStripMenuItem.Text = "Tipos de Proveedor";
            // 
            // tiposDeCompraToolStripMenuItem
            // 
            this.tiposDeCompraToolStripMenuItem.Name = "tiposDeCompraToolStripMenuItem";
            this.tiposDeCompraToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tiposDeCompraToolStripMenuItem.Text = "Tipos de Compra";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeComprasToolStripMenuItem,
            this.toolStripSeparator3});
            this.MnuProcesos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(101, 25);
            this.MnuProcesos.Text = "PROCESOS";
            // 
            // registroDeComprasToolStripMenuItem
            // 
            this.registroDeComprasToolStripMenuItem.Name = "registroDeComprasToolStripMenuItem";
            this.registroDeComprasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.registroDeComprasToolStripMenuItem.Text = "Registro de Compras";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasPorFechaToolStripMenuItem,
            this.comprasPorProveedorToolStripMenuItem,
            this.comprasDeProductoToolStripMenuItem,
            this.listadoDeInventarioToolStripMenuItem,
            this.toolStripSeparator2,
            this.reimpresiónDeCompraToolStripMenuItem});
            this.MnuReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(95, 25);
            this.MnuReportes.Text = "REPORTES";
            // 
            // comprasPorFechaToolStripMenuItem
            // 
            this.comprasPorFechaToolStripMenuItem.Name = "comprasPorFechaToolStripMenuItem";
            this.comprasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.comprasPorFechaToolStripMenuItem.Text = "Compras por Fecha";
            // 
            // comprasPorProveedorToolStripMenuItem
            // 
            this.comprasPorProveedorToolStripMenuItem.Name = "comprasPorProveedorToolStripMenuItem";
            this.comprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.comprasPorProveedorToolStripMenuItem.Text = "Compras por Proveedor";
            // 
            // comprasDeProductoToolStripMenuItem
            // 
            this.comprasDeProductoToolStripMenuItem.Name = "comprasDeProductoToolStripMenuItem";
            this.comprasDeProductoToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.comprasDeProductoToolStripMenuItem.Text = "Compras de Producto";
            // 
            // listadoDeInventarioToolStripMenuItem
            // 
            this.listadoDeInventarioToolStripMenuItem.Name = "listadoDeInventarioToolStripMenuItem";
            this.listadoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.listadoDeInventarioToolStripMenuItem.Text = "Listado de Inventario";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // reimpresiónDeCompraToolStripMenuItem
            // 
            this.reimpresiónDeCompraToolStripMenuItem.Name = "reimpresiónDeCompraToolStripMenuItem";
            this.reimpresiónDeCompraToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.reimpresiónDeCompraToolStripMenuItem.Text = "Reimpresión de Compra";
            // 
            // MnuSalir
            // 
            this.MnuSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(63, 25);
            this.MnuSalir.Text = "SALIR";
            // 
            // MnuAcercaDe
            // 
            this.MnuAcercaDe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuAcercaDe.Name = "MnuAcercaDe";
            this.MnuAcercaDe.Size = new System.Drawing.Size(89, 25);
            this.MnuAcercaDe.Text = "Acerca de";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmMDI";
            this.Text = "SISTEMA DE COMPRAS PROGRA 5 2023-1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoríasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem registroDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reimpresiónDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercaDe;
    }
}