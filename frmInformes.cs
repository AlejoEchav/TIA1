using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpBotones_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool todoCorrecto = true;

            if (string.IsNullOrWhiteSpace(cmbInforme.Text))
            {
                errorProvider1.SetError(cmbInforme, "Por favor, ingrese el informe.");
                todoCorrecto = false;
            }
            if (!rdbExcel.Checked && !rdbPantalla.Checked && !rdbPDF.Checked)
            {
                errorProvider1.SetError(grpBotones, "Por favor, seleccione un formato de salida.");
                todoCorrecto = false;
            }
            if (todoCorrecto)
            {
                MessageBox.Show("Informe generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbInforme.SelectedIndex = -1;
                rdbExcel.Checked = false;
                rdbPantalla.Checked = false;
                rdbPDF.Checked = false;
            }
        }
    }
}
