using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                errorProvider1.SetError(txtNombreEmpleado, "Por favor, ingrese el nombre del empleado.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "Por favor, ingrese la direccion.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                errorProvider1.SetError(txtDocumento, "Por favor, ingrese el documento del empleado.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Por favor, ingrese el email del empleado.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Por favor, ingrese el telefono del empleado.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxRol.Text))
            {
                errorProvider1.SetError(comboBoxRol, "Por favor, ingrese el rol del empleado.");
                todoCorrecto = false;
            }
            if (todoCorrecto)
            {
                MessageBox.Show("¡Registro de cliente actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreEmpleado.Clear();
                txtDocumento.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                comboBoxRol.SelectedIndex = -1;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
