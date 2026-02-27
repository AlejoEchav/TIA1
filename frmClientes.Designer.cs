namespace TIA1
{
    partial class frmClientes
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
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(352, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(354, 168);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(178, 23);
            txtDocumento.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(354, 225);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(180, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(352, 279);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(353, 324);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(283, 381);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(439, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(216, 44);
            label1.Name = "label1";
            label1.Size = new Size(358, 37);
            label1.TabIndex = 7;
            label1.Text = "NUEVO REGISTRO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 120);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 171);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 9;
            label3.Text = "Documento Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 228);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Dirección Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 282);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefono Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 327);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 12;
            label6.Text = "Email Cliente:";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Name = "frmClientes";
            Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnActualizar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}