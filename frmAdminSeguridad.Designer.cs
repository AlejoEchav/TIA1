namespace TIA1
{
    partial class frmAdminSeguridad
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
            errorProvider1 = new ErrorProvider(components);
            lblNombreForm = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxEmpleado = new ComboBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnSalir = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblNombreForm
            // 
            lblNombreForm.AutoSize = true;
            lblNombreForm.Location = new Point(210, 9);
            lblNombreForm.Name = "lblNombreForm";
            lblNombreForm.Size = new Size(322, 20);
            lblNombreForm.TabIndex = 0;
            lblNombreForm.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 168);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 234);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 3;
            label3.Text = "Clave";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(95, 99);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(452, 28);
            comboBoxEmpleado.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(95, 191);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(226, 27);
            txtUsuario.TabIndex = 5;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(95, 257);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(226, 27);
            txtClave.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlDarkDark;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Cornsilk;
            btnSalir.Location = new Point(432, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 29);
            btnSalir.TabIndex = 24;
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
            btnActualizar.Location = new Point(235, 374);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 29);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombreForm);
            Name = "frmAdminSeguridad";
            Text = "frmAdminSeguridad";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label lblNombreForm;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private ComboBox comboBoxEmpleado;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private Button btnActualizar;
    }
}