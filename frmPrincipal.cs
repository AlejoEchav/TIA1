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
    }
}
