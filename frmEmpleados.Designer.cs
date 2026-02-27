namespace TIA1
{
    partial class frmEmpleados
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
            lblNombreForm = new Label();
            lblNombre = new Label();
            lblRol = new Label();
            lblDocumento = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblIngreso = new Label();
            lblRetiro = new Label();
            label1 = new Label();
            txtNombreEmpleado = new TextBox();
            txtDocumento = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            comboBoxRol = new ComboBox();
            dataTimeIngreso = new DateTimePicker();
            dateTimeRetiro = new DateTimePicker();
            textBox1 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnActualizar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreForm
            // 
            lblNombreForm.AutoSize = true;
            lblNombreForm.Location = new Point(259, 9);
            lblNombreForm.Name = "lblNombreForm";
            lblNombreForm.Size = new Size(243, 20);
            lblNombreForm.TabIndex = 0;
            lblNombreForm.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(136, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Empleado";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(460, 70);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(103, 20);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol Empleado";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(22, 123);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(22, 176);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(22, 229);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telfono";
            lblTelefono.Click += lblTelefono_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 282);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(460, 123);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(72, 20);
            lblIngreso.TabIndex = 7;
            lblIngreso.Text = "F. Ingreso";
            // 
            // lblRetiro
            // 
            lblRetiro.AutoSize = true;
            lblRetiro.Location = new Point(460, 176);
            lblRetiro.Name = "lblRetiro";
            lblRetiro.Size = new Size(63, 20);
            lblRetiro.TabIndex = 8;
            lblRetiro.Text = "F. Retiro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 229);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 9;
            label1.Text = "DATOS ADICIONALES";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(22, 93);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(269, 27);
            txtNombreEmpleado.TabIndex = 10;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(22, 146);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(269, 27);
            txtDocumento.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 199);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(269, 27);
            txtDireccion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(22, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(269, 27);
            txtTelefono.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 305);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 27);
            txtEmail.TabIndex = 14;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(460, 93);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(228, 28);
            comboBoxRol.TabIndex = 15;
            // 
            // dataTimeIngreso
            // 
            dataTimeIngreso.CustomFormat = "";
            dataTimeIngreso.Format = DateTimePickerFormat.Short;
            dataTimeIngreso.Location = new Point(460, 144);
            dataTimeIngreso.Name = "dataTimeIngreso";
            dataTimeIngreso.Size = new Size(228, 27);
            dataTimeIngreso.TabIndex = 16;
            // 
            // dateTimeRetiro
            // 
            dateTimeRetiro.Format = DateTimePickerFormat.Short;
            dateTimeRetiro.Location = new Point(460, 197);
            dateTimeRetiro.Name = "dateTimeRetiro";
            dateTimeRetiro.Size = new Size(228, 27);
            dateTimeRetiro.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 18;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlDarkDark;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = Color.Cornsilk;
            btnActualizar.Location = new Point(235, 372);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 29);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlDarkDark;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Cornsilk;
            btnSalir.Location = new Point(408, 372);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 29);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(textBox1);
            Controls.Add(dateTimeRetiro);
            Controls.Add(dataTimeIngreso);
            Controls.Add(comboBoxRol);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(label1);
            Controls.Add(lblRetiro);
            Controls.Add(lblIngreso);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblDocumento);
            Controls.Add(lblRol);
            Controls.Add(lblNombre);
            Controls.Add(lblNombreForm);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreForm;
        private Label lblNombre;
        private Label lblRol;
        private Label lblDocumento;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblIngreso;
        private Label lblRetiro;
        private Label label1;
        private TextBox txtNombreEmpleado;
        private TextBox txtDocumento;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private ComboBox comboBox1;
        private DateTimePicker dataTimeIngreso;
        private DateTimePicker dateTimeRetiro;
        private TextBox textBox1;
        private ErrorProvider errorProvider1;
        private Button btnSalir;
        private Button btnActualizar;
        private ComboBox comboBoxRol;
    }
}