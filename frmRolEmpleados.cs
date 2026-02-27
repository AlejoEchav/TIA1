using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Por favor, ingrese la descripcion del rol.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                errorProvider1.SetError(txtNombreRol, "Por favor, ingrese el nombre del rol.");
                todoCorrecto = false;
            }
            if (todoCorrecto)
            {
                MessageBox.Show("¡Registro de cliente actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreRol.Clear();
                txtDescripcion.Clear();
            }
        }
    }
}
