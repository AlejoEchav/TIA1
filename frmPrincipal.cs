namespace TIA1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void formularioClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.MdiParent = this;
            ayuda.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercade = new frmAcercaDe();
            acercade.MdiParent = this;
            acercade.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.MdiParent = this;
            empleados.Show();
        }

        private void formularioCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos categoriaProductos = new frmCategoriaProductos();
            categoriaProductos.MdiParent = this;
            categoriaProductos.Show();
        }

        private void formularioProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.MdiParent = this;
            productos.Show();
        }
    }
}
