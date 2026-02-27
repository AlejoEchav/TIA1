using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Por favor, ingrese un usuario");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorProvider1.SetError(txtContrasena, "Por favor, ingrese la contraseña.");
                todoCorrecto = false;
            }

            if (todoCorrecto)
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
        }
    }
}
