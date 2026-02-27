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
            txtNombre.Location = new Point(402, 156);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(405, 224);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(203, 27);
            txtDocumento.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(405, 300);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(205, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(402, 372);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(403, 432);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(323, 508);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(502, 508);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
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
            label1.Location = new Point(247, 59);
            label1.Name = "label1";
            label1.Size = new Size(451, 46);
            label1.TabIndex = 7;
            label1.Text = "NUEVO REGISTRO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 160);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 228);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 9;
            label3.Text = "Documento Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 304);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 10;
            label4.Text = "Dirección Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 376);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 11;
            label5.Text = "Telefono Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 436);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 12;
            label6.Text = "Email Cliente:";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
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