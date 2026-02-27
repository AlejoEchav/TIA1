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

        private ToolStripMenuItem GetFormularioClientesToolStripMenuItem1()
        {
            return formularioClientesToolStripMenuItem;
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
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tablasToolStripMenuItem, facturacionToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioClientesToolStripMenuItem, formularioProductoToolStripMenuItem, formularioCategoriasToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(52, 20);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // formularioClientesToolStripMenuItem
            // 
            formularioClientesToolStripMenuItem.Name = "formularioClientesToolStripMenuItem";
            formularioClientesToolStripMenuItem.Size = new Size(130, 22);
            formularioClientesToolStripMenuItem.Text = "Clientes";
            formularioClientesToolStripMenuItem.Click += formularioClientesToolStripMenuItem_Click;
            // 
            // formularioProductoToolStripMenuItem
            // 
            formularioProductoToolStripMenuItem.Name = "formularioProductoToolStripMenuItem";
            formularioProductoToolStripMenuItem.Size = new Size(130, 22);
            formularioProductoToolStripMenuItem.Text = "Productos";
            formularioProductoToolStripMenuItem.Click += formularioProductoToolStripMenuItem_Click;
            // 
            // formularioCategoriasToolStripMenuItem
            // 
            formularioCategoriasToolStripMenuItem.Name = "formularioCategoriasToolStripMenuItem";
            formularioCategoriasToolStripMenuItem.Size = new Size(130, 22);
            formularioCategoriasToolStripMenuItem.Text = "Categorias";
            formularioCategoriasToolStripMenuItem.Click += formularioCategoriasToolStripMenuItem_Click;
            // 
            // facturacionToolStripMenuItem
            // 
            facturacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioFacturasToolStripMenuItem, formularioInformesToolStripMenuItem });
            facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            facturacionToolStripMenuItem.Size = new Size(81, 20);
            facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // formularioFacturasToolStripMenuItem
            // 
            formularioFacturasToolStripMenuItem.Name = "formularioFacturasToolStripMenuItem";
            formularioFacturasToolStripMenuItem.Size = new Size(121, 22);
            formularioFacturasToolStripMenuItem.Text = "Facturas";
            formularioFacturasToolStripMenuItem.Click += formularioFacturasToolStripMenuItem_Click;
            // 
            // formularioInformesToolStripMenuItem
            // 
            formularioInformesToolStripMenuItem.Name = "formularioInformesToolStripMenuItem";
            formularioInformesToolStripMenuItem.Size = new Size(121, 22);
            formularioInformesToolStripMenuItem.Text = "Informes";
            formularioInformesToolStripMenuItem.Click += formularioInformesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, rolesToolStripMenuItem, seguridadToolStripMenuItem1 });
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(72, 20);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(132, 22);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(132, 22);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem1
            // 
            seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            seguridadToolStripMenuItem1.Size = new Size(132, 22);
            seguridadToolStripMenuItem1.Text = "Seguridad";
            seguridadToolStripMenuItem1.Click += seguridadToolStripMenuItem1_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(127, 22);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(127, 22);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 126);
            label1.Name = "label1";
            label1.Size = new Size(316, 86);
            label1.TabIndex = 3;
            label1.Text = "Welcome";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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
        private Label label1;
    }
}
