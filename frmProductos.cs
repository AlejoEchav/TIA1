using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre del producto es obligatorio.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "El código es obligatorio.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                errorProvider1.SetError(txtPrecioCompra, "Ingrese el precio de compra.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                errorProvider1.SetError(txtPrecioVenta, "Ingrese el precio de venta.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadStock.Text))
            {
                errorProvider1.SetError(txtCantidadStock, "Ingrese la cantidad en stock.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría.");
                todoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(txtDetalles.Text))
            {
                errorProvider1.SetError(txtDetalles, "Escriba los detalles del producto.");
                todoCorrecto = false;
            }

            if (todoCorrecto)
            {
                MessageBox.Show("Producto registrado y actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
