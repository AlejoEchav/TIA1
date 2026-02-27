namespace TIA1
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            panel1 = new Panel();
            btnAceptar = new Button();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(14, 88);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 496);
            panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(762, 441);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label5
            // 
            label5.Location = new Point(45, 352);
            label5.Name = "label5";
            label5.Size = new Size(803, 73);
            label5.TabIndex = 8;
            label5.Text = resources.GetString("label5.Text");
            // 
            // button3
            // 
            button3.Location = new Point(582, 296);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(165, 31);
            button3.TabIndex = 7;
            button3.Text = "DxDiag";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(582, 240);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 31);
            button2.TabIndex = 6;
            button2.Text = "Info. del Sistema";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(582, 183);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 31);
            button1.TabIndex = 5;
            button1.Text = "Copiar Información";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 159);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 4;
            label4.Text = "Actualizaciones realizadas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 41);
            label3.Name = "label3";
            label3.Size = new Size(214, 80);
            label3.TabIndex = 3;
            label3.Text = "Microsoft .NET Framework\r\nVersion 10.1.1.1.1\r\n© 2026 Microsoft Corporation.\r\nTodos los derechos reservados.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 183);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(479, 143);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 39);
            label2.Name = "label2";
            label2.Size = new Size(244, 92);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Facturación\r\nVersión 1.0\r\n© 2026 Alejandro y Daniel. \r\nTodos los derechos reservados.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(460, 32);
            label1.TabIndex = 0;
            label1.Text = "Acerca del Sistema de Facturación";
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAcercaDe";
            Text = "frmAcercaDe";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button btnAceptar;
    }
}