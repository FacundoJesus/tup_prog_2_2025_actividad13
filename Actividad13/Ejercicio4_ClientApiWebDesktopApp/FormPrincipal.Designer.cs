namespace Ejercicio4_ClientApiWebDesktopApp
{
    partial class FormPrincipal
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
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnImportarPaquetes = new Button();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            cBoxCamiones = new ComboBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnRetirar = new Button();
            btnAgregar = new Button();
            btnIniciar = new Button();
            textBox1 = new TextBox();
            listBcarga = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnImportarPaquetes);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Depósito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 19);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Zona 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 19);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Zona 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Zona 1";
            // 
            // btnImportarPaquetes
            // 
            btnImportarPaquetes.Location = new Point(435, 54);
            btnImportarPaquetes.Name = "btnImportarPaquetes";
            btnImportarPaquetes.Size = new Size(127, 121);
            btnImportarPaquetes.TabIndex = 4;
            btnImportarPaquetes.Text = "Importar Paquetes Pedidos";
            btnImportarPaquetes.UseVisualStyleBackColor = true;
            btnImportarPaquetes.Click += btnImportarPaquetes_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(288, 37);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(127, 169);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 37);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(127, 169);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(144, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(127, 169);
            listBox1.TabIndex = 0;
            // 
            // cBoxCamiones
            // 
            cBoxCamiones.FormattingEnabled = true;
            cBoxCamiones.Location = new Point(6, 53);
            cBoxCamiones.Name = "cBoxCamiones";
            cBoxCamiones.Size = new Size(121, 23);
            cBoxCamiones.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnRetirar);
            groupBox2.Controls.Add(cBoxCamiones);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnIniciar);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(listBcarga);
            groupBox2.Location = new Point(12, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 228);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preparar reparto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 193);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 10;
            label6.Text = "Kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 172);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 9;
            label5.Text = "Peso acumulado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 8;
            label4.Text = "Lista de Camiones";
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(435, 130);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(127, 23);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(435, 81);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 24);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(6, 82);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 1;
            // 
            // listBcarga
            // 
            listBcarga.FormattingEnabled = true;
            listBcarga.ItemHeight = 15;
            listBcarga.Location = new Point(144, 29);
            listBcarga.Name = "listBcarga";
            listBcarga.Size = new Size(271, 184);
            listBcarga.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 478);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FeDeX 3.0";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private ComboBox cBoxCamiones;
        private GroupBox groupBox2;
        private ListBox listBcarga;
        private TextBox textBox1;
        private Button btnImportarPaquetes;
        private Button btnIniciar;
        private Button btnAgregar;
        private Button btnRetirar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
