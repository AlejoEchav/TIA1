namespace TIA1
{
    partial class frmInformes
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
            cmbInforme = new ComboBox();
            cmbOrdenar = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            btnSalir = new Button();
            btnGenerarInforme = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            rdbPantalla = new RadioButton();
            rdbPDF = new RadioButton();
            rdbExcel = new RadioButton();
            grpBotones = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            grpBotones.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 20);
            label1.TabIndex = 0;
            label1.Text = "GENERADOR DE INFORMES DE FACTURACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 71);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 1;
            label2.Text = "SELECCIONE INFORME ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 71);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Ordenar por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 121);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha de inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 121);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha final";
            // 
            // cmbInforme
            // 
            cmbInforme.FormattingEnabled = true;
            cmbInforme.Location = new Point(199, 68);
            cmbInforme.Name = "cmbInforme";
            cmbInforme.Size = new Size(259, 28);
            cmbInforme.TabIndex = 5;
            // 
            // cmbOrdenar
            // 
            cmbOrdenar.FormattingEnabled = true;
            cmbOrdenar.Location = new Point(590, 68);
            cmbOrdenar.Name = "cmbOrdenar";
            cmbOrdenar.Size = new Size(151, 28);
            cmbOrdenar.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(199, 116);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(123, 27);
            dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(482, 116);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(123, 27);
            dtpFechaFinal.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlDarkDark;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = Color.Cornsilk;
            btnSalir.Location = new Point(413, 226);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(157, 29);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = SystemColors.ControlDarkDark;
            btnGenerarInforme.Cursor = Cursors.Hand;
            btnGenerarInforme.FlatStyle = FlatStyle.Popup;
            btnGenerarInforme.ForeColor = Color.Cornsilk;
            btnGenerarInforme.Location = new Point(200, 226);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(157, 29);
            btnGenerarInforme.TabIndex = 27;
            btnGenerarInforme.Text = "GENERAR INFORME";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 156);
            dataGridView1.TabIndex = 29;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // rdbPantalla
            // 
            rdbPantalla.AutoSize = true;
            rdbPantalla.Location = new Point(6, 26);
            rdbPantalla.Name = "rdbPantalla";
            rdbPantalla.Size = new Size(104, 24);
            rdbPantalla.TabIndex = 30;
            rdbPantalla.TabStop = true;
            rdbPantalla.Text = "En pantalla";
            rdbPantalla.UseVisualStyleBackColor = true;
            // 
            // rdbPDF
            // 
            rdbPDF.AutoSize = true;
            rdbPDF.Location = new Point(116, 26);
            rdbPDF.Name = "rdbPDF";
            rdbPDF.Size = new Size(76, 24);
            rdbPDF.TabIndex = 31;
            rdbPDF.TabStop = true;
            rdbPDF.Text = "En PDF";
            rdbPDF.UseVisualStyleBackColor = true;
            rdbPDF.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbExcel
            // 
            rdbExcel.AutoSize = true;
            rdbExcel.Location = new Point(198, 26);
            rdbExcel.Name = "rdbExcel";
            rdbExcel.Size = new Size(84, 24);
            rdbExcel.TabIndex = 32;
            rdbExcel.TabStop = true;
            rdbExcel.Text = "En Excel";
            rdbExcel.UseVisualStyleBackColor = true;
            // 
            // grpBotones
            // 
            grpBotones.Controls.Add(rdbPantalla);
            grpBotones.Controls.Add(rdbExcel);
            grpBotones.Controls.Add(rdbPDF);
            grpBotones.Location = new Point(229, 149);
            grpBotones.Name = "grpBotones";
            grpBotones.Size = new Size(290, 59);
            grpBotones.TabIndex = 33;
            grpBotones.TabStop = false;
            grpBotones.Enter += grpBotones_Enter;
            // 
            // fmrInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBotones);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarInforme);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicio);
            Controls.Add(cmbOrdenar);
            Controls.Add(cmbInforme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmrInformes";
            Text = "fmrInformes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            grpBotones.ResumeLayout(false);
            grpBotones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbInforme;
        private ComboBox cmbOrdenar;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFinal;
        private Button btnSalir;
        private Button btnGenerarInforme;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private RadioButton rdbExcel;
        private RadioButton rdbPDF;
        private RadioButton rdbPantalla;
        private GroupBox grpBotones;
    }
}