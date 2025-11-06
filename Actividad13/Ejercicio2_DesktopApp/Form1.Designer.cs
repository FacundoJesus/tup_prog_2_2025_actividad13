namespace Ejercicio2_DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnImportarPaquetesPedidos = new Button();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            btnRetirar = new Button();
            btnAgregarPaquete = new Button();
            listBox4 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            btnExportar = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImportarPaquetesPedidos);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnImportarPaquetesPedidos
            // 
            btnImportarPaquetesPedidos.Location = new Point(531, 67);
            btnImportarPaquetesPedidos.Name = "btnImportarPaquetesPedidos";
            btnImportarPaquetesPedidos.Size = new Size(75, 61);
            btnImportarPaquetesPedidos.TabIndex = 3;
            btnImportarPaquetesPedidos.Text = "Importar Paquetes";
            btnImportarPaquetesPedidos.UseVisualStyleBackColor = true;
            btnImportarPaquetesPedidos.Click += btnImportarPaquetesPedidos_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(360, 48);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(199, 48);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnExportar);
            groupBox2.Controls.Add(btnRetirar);
            groupBox2.Controls.Add(btnAgregarPaquete);
            groupBox2.Controls.Add(listBox4);
            groupBox2.Location = new Point(12, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(637, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(546, 98);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(75, 23);
            btnRetirar.TabIndex = 2;
            btnRetirar.Text = "button2";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnAgregarPaquete
            // 
            btnAgregarPaquete.Location = new Point(546, 41);
            btnAgregarPaquete.Name = "btnAgregarPaquete";
            btnAgregarPaquete.Size = new Size(75, 23);
            btnAgregarPaquete.TabIndex = 1;
            btnAgregarPaquete.Text = "button1";
            btnAgregarPaquete.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(152, 41);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(379, 94);
            listBox4.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(86, 112);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnImportarPaquetesPedidos;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox4;
        private Button btnRetirar;
        private Button btnAgregarPaquete;
        private Button button2;
        private Button btnExportar;
    }
}
