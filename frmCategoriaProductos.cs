using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                errorProvider1.SetError(txtNombreCategoria, "Por favor, ingrese el nombre de la categoría.");
                todoCorrecto = false;
            }

            if (todoCorrecto)
            {
                MessageBox.Show("¡Categoría guardada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreCategoria.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
