using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errorProvider1.SetError(txtClave, "Por favor, ingrese la Clave.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Por favor, ingrese el Usuario.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxEmpleado.Text))
            {
                errorProvider1.SetError(comboBoxEmpleado, "Por favor, ingrese un empleado.");
                todoCorrecto = false;
            }
            if (todoCorrecto)
            {
                MessageBox.Show("¡Registro de cliente actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsuario.Clear();
                txtClave.Clear();
                comboBoxEmpleado.SelectedIndex = -1;
            }
        }
    }
}
