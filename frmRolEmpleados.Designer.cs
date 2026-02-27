namespace TIA1
{
    partial class frmRolEmpleados
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
            lblRol = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            txtNombreRol = new TextBox();
            lblNombreForm = new Label();
            btnSalir = new Button();
            btnActualizar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(41, 75);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(90, 20);
            lblRol.TabIndex = 0;
            lblRol.Text = "Nombre Rol";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 159);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(180, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion detallada Rol";
            lblDescripcion.Click += label2_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(41, 182);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(467, 119);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(41, 98);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(262, 27);
            txtNombreRol.TabIndex = 3;
            // 
            // lblNombreForm
            // 
            lblNombreForm.AutoSize = true;
            lblNombreForm.Location = new Point(312, 9);
            lblNombreForm.Name = "lblNombreForm";
            lblNombreForm.Size = new Size(147, 20);
            lblNombreForm.TabIndex = 4;
            lblNombreForm.Text = "ROL DE EMPLEADOS";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlDarkDark;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Cornsilk;
            btnSalir.Location = new Point(436, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 29);
            btnSalir.TabIndex = 22;
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
            btnActualizar.Location = new Point(263, 378);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 29);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRolEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(lblNombreForm);
            Controls.Add(txtNombreRol);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblRol);
            Name = "frmRolEmpleados";
            Text = "frmRolEmpleados";
            Load += frmRolEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRol;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private TextBox txtNombreRol;
        private Label lblNombreForm;
        private Button btnSalir;
        private Button btnActualizar;
        private ErrorProvider errorProvider1;
    }
}