using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Por favor, ingrese el nombre del cliente.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                errorProvider1.SetError(txtDocumento, "Por favor, ingrese el documento del cliente.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "Por favor, ingrese la dirección del cliente.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Por favor, ingrese el teléfono del cliente.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Por favor, ingrese el email del cliente.");
                todoCorrecto = false;
            }

            if (todoCorrecto)
            {
                MessageBox.Show("¡Registro de cliente actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                txtDocumento.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
