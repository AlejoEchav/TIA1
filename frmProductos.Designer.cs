namespace TIA1
{
    partial class frmProductos
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
            txtNombreProducto = new TextBox();
            txtCodigo = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCantidadStock = new TextBox();
            cmbCategoria = new ComboBox();
            txtDetalles = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(213, 137);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(114, 27);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(213, 200);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(127, 27);
            txtCodigo.TabIndex = 1;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(213, 265);
            txtPrecioCompra.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(114, 27);
            txtPrecioCompra.TabIndex = 2;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(213, 329);
            txtPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(114, 27);
            txtPrecioVenta.TabIndex = 3;
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(213, 404);
            txtCantidadStock.Margin = new Padding(3, 4, 3, 4);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(114, 27);
            txtCantidadStock.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Tecnologia", "Salud" });
            cmbCategoria.Location = new Point(680, 137);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(138, 28);
            cmbCategoria.TabIndex = 5;
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(650, 289);
            txtDetalles.Margin = new Padding(3, 4, 3, 4);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(233, 173);
            txtDetalles.TabIndex = 6;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(242, 495);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(583, 495);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 141);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 204);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 10;
            label2.Text = "Código Referencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 269);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 11;
            label3.Text = "Precio Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 333);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 12;
            label4.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 408);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 13;
            label5.Text = "Cantidad Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(599, 141);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 14;
            label6.Text = "Categoria:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(650, 240);
            label7.Name = "label7";
            label7.Size = new Size(207, 32);
            label7.TabIndex = 15;
            label7.Text = "Detalle Producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(199, 39);
            label8.Name = "label8";
            label8.Size = new Size(636, 50);
            label8.TabIndex = 16;
            label8.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtDetalles);
            Controls.Add(cmbCategoria);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombreProducto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtCodigo;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtCantidadStock;
        private ComboBox cmbCategoria;
        private TextBox txtDetalles;
        private Button btnActualizar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ErrorProvider errorProvider1;
    }
}