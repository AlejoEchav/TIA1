using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                errorProvider1.SetError(txtDescuento, "Por favor, ingrese el descuento.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtIVA.Text))
            {
                errorProvider1.SetError(txtIVA, "Por favor, ingrese el IVA.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtNroFactura.Text))
            {
                errorProvider1.SetError(txtNroFactura, "Por favor, ingrese el numero de factura.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(txtTotalFactura.Text))
            {
                errorProvider1.SetError(txtTotalFactura, "Por favor, ingrese el total de la factura.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(cmbCliente.Text))
            {
                errorProvider1.SetError(cmbCliente, "Por favor, ingrese el cliente");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(cmbEmpleado.Text))
            {
                errorProvider1.SetError(cmbEmpleado, "Por favor, ingrese el empleado.");
                todoCorrecto = false;
            }
            if (string.IsNullOrWhiteSpace(cmbEstadoFactura.Text))
            {
                errorProvider1.SetError(cmbEstadoFactura, "Por favor, coloque el estado de la factura.");
                todoCorrecto = false;
            }
            if (todoCorrecto)
            {
                MessageBox.Show("¡Registro de la factura se hizo correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDescuento.Clear();
                txtIVA.Clear();
                txtNroFactura.Clear();
                txtTotalFactura.Clear();
                cmbCliente.SelectedIndex = -1;
                cmbEmpleado.SelectedIndex = -1;
                cmbEstadoFactura.SelectedIndex = -1;
                dgvDetalleFactura.Rows.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
