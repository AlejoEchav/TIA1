namespace TIA1
{
    partial class frmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbCliente = new ComboBox();
            cmbEmpleado = new ComboBox();
            txtNroFactura = new TextBox();
            txtDescuento = new TextBox();
            txtIVA = new TextBox();
            txtTotalFactura = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dtpFechaRegistro = new DateTimePicker();
            cmbEstadoFactura = new ComboBox();
            label10 = new Label();
            dgvDetalleFactura = new DataGridView();
            btnSalir = new Button();
            btnActualizar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACION FACTURAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Nro. Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 92);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 126);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Empleado";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 160);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 193);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Total IVA ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 228);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 6;
            label7.Text = "Total Factura";
            label7.Click += label7_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(138, 89);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(199, 28);
            cmbCliente.TabIndex = 7;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(138, 123);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(199, 28);
            cmbEmpleado.TabIndex = 8;
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(138, 56);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(199, 27);
            txtNroFactura.TabIndex = 9;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(138, 157);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(151, 27);
            txtDescuento.TabIndex = 10;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(138, 190);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(151, 27);
            txtIVA.TabIndex = 11;
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(138, 225);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(151, 27);
            txtTotalFactura.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(441, 62);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 13;
            label8.Text = "Fecha de registro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(441, 129);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 14;
            label9.Text = "Estado de Factura";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(441, 85);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(140, 27);
            dtpFechaRegistro.TabIndex = 15;
            // 
            // cmbEstadoFactura
            // 
            cmbEstadoFactura.FormattingEnabled = true;
            cmbEstadoFactura.Location = new Point(441, 152);
            cmbEstadoFactura.Name = "cmbEstadoFactura";
            cmbEstadoFactura.Size = new Size(151, 28);
            cmbEstadoFactura.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 267);
            label10.Name = "label10";
            label10.Size = new Size(156, 20);
            label10.TabIndex = 17;
            label10.Text = "DETALLE DE FACTURA";
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFactura.Location = new Point(37, 290);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.RowHeadersWidth = 51;
            dgvDetalleFactura.Size = new Size(555, 134);
            dgvDetalleFactura.TabIndex = 18;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlDarkDark;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Cornsilk;
            btnSalir.Location = new Point(644, 350);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 29);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlDarkDark;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = Color.Cornsilk;
            btnActualizar.Location = new Point(644, 117);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 29);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(dgvDetalleFactura);
            Controls.Add(label10);
            Controls.Add(cmbEstadoFactura);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTotalFactura);
            Controls.Add(txtIVA);
            Controls.Add(txtDescuento);
            Controls.Add(txtNroFactura);
            Controls.Add(cmbEmpleado);
            Controls.Add(cmbCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFacturas";
            Text = "frmFacturas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbCliente;
        private ComboBox cmbEmpleado;
        private TextBox txtNroFactura;
        private TextBox txtDescuento;
        private TextBox txtIVA;
        private TextBox txtTotalFactura;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpFechaRegistro;
        private ComboBox cmbEstadoFactura;
        private Label label10;
        private DataGridView dgvDetalleFactura;
        private Button btnSalir;
        private Button btnActualizar;
        private ErrorProvider errorProvider1;
    }
}