namespace TIA1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            formularioClientesToolStripMenuItem = new ToolStripMenuItem();
            formularioProductoToolStripMenuItem = new ToolStripMenuItem();
            formularioCategoriasToolStripMenuItem = new ToolStripMenuItem();
            facturacionToolStripMenuItem = new ToolStripMenuItem();
            formularioFacturasToolStripMenuItem = new ToolStripMenuItem();
            formularioInformesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem1 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tablasToolStripMenuItem, facturacionToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioClientesToolStripMenuItem, formularioProductoToolStripMenuItem, formularioCategoriasToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(64, 24);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // formularioClientesToolStripMenuItem
            // 
            formularioClientesToolStripMenuItem.Name = "formularioClientesToolStripMenuItem";
            formularioClientesToolStripMenuItem.Size = new Size(163, 26);
            formularioClientesToolStripMenuItem.Text = "Clientes";
            formularioClientesToolStripMenuItem.Click += formularioClientesToolStripMenuItem_Click;
            // 
            // formularioProductoToolStripMenuItem
            // 
            formularioProductoToolStripMenuItem.Name = "formularioProductoToolStripMenuItem";
            formularioProductoToolStripMenuItem.Size = new Size(163, 26);
            formularioProductoToolStripMenuItem.Text = "Productos";
            // 
            // formularioCategoriasToolStripMenuItem
            // 
            formularioCategoriasToolStripMenuItem.Name = "formularioCategoriasToolStripMenuItem";
            formularioCategoriasToolStripMenuItem.Size = new Size(163, 26);
            formularioCategoriasToolStripMenuItem.Text = "Categorias";
            // 
            // facturacionToolStripMenuItem
            // 
            facturacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioFacturasToolStripMenuItem, formularioInformesToolStripMenuItem });
            facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            facturacionToolStripMenuItem.Size = new Size(98, 24);
            facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // formularioFacturasToolStripMenuItem
            // 
            formularioFacturasToolStripMenuItem.Name = "formularioFacturasToolStripMenuItem";
            formularioFacturasToolStripMenuItem.Size = new Size(150, 26);
            formularioFacturasToolStripMenuItem.Text = "Facturas";
            // 
            // formularioInformesToolStripMenuItem
            // 
            formularioInformesToolStripMenuItem.Name = "formularioInformesToolStripMenuItem";
            formularioInformesToolStripMenuItem.Size = new Size(150, 26);
            formularioInformesToolStripMenuItem.Text = "Informes";
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, rolesToolStripMenuItem, seguridadToolStripMenuItem1 });
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(91, 24);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(224, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(224, 26);
            rolesToolStripMenuItem.Text = "Roles";
            // 
            // seguridadToolStripMenuItem1
            // 
            seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            seguridadToolStripMenuItem1.Size = new Size(224, 26);
            seguridadToolStripMenuItem1.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(160, 26);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(160, 26);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem formularioClientesToolStripMenuItem;
        private ToolStripMenuItem formularioProductoToolStripMenuItem;
        private ToolStripMenuItem formularioCategoriasToolStripMenuItem;
        private ToolStripMenuItem facturacionToolStripMenuItem;
        private ToolStripMenuItem formularioFacturasToolStripMenuItem;
        private ToolStripMenuItem formularioInformesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem1;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
