namespace Ejercicio2_DesktopApp
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnImportarPaquetesPedidos = new Button();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            cmbCamiones = new ComboBox();
            label4 = new Label();
            tbKg = new TextBox();
            btnIniciar = new Button();
            btnEnviar = new Button();
            btnRetirarPaquete = new Button();
            btnAgregarPaquete = new Button();
            lsbCarga = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnImportarPaquetesPedidos);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Depósito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 30);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Zona 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 30);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Zona 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Zona 1";
            // 
            // btnImportarPaquetesPedidos
            // 
            btnImportarPaquetesPedidos.Location = new Point(525, 84);
            btnImportarPaquetesPedidos.Name = "btnImportarPaquetesPedidos";
            btnImportarPaquetesPedidos.Size = new Size(106, 83);
            btnImportarPaquetesPedidos.TabIndex = 3;
            btnImportarPaquetesPedidos.Text = "Importar Paquetes Pedidos";
            btnImportarPaquetesPedidos.UseVisualStyleBackColor = true;
            btnImportarPaquetesPedidos.Click += btnImportarPaquetesPedidos_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(354, 48);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(155, 169);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(178, 48);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(155, 169);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 169);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbCamiones);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbKg);
            groupBox2.Controls.Add(btnIniciar);
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(btnRetirarPaquete);
            groupBox2.Controls.Add(btnAgregarPaquete);
            groupBox2.Controls.Add(lsbCarga);
            groupBox2.Location = new Point(12, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preparar reparto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 36);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 7;
            label5.Text = "Lista de camiones";
            // 
            // cmbCamiones
            // 
            cmbCamiones.FormattingEnabled = true;
            cmbCamiones.Location = new Point(6, 54);
            cmbCamiones.Name = "cmbCamiones";
            cmbCamiones.Size = new Size(155, 23);
            cmbCamiones.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 160);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 7;
            label4.Text = "Peso acumulado:";
            // 
            // tbKg
            // 
            tbKg.Location = new Point(109, 152);
            tbKg.Name = "tbKg";
            tbKg.Size = new Size(52, 23);
            tbKg.TabIndex = 5;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(5, 96);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(86, 96);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextAlign = ContentAlignment.TopCenter;
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnRetirarPaquete
            // 
            btnRetirarPaquete.Location = new Point(525, 134);
            btnRetirarPaquete.Name = "btnRetirarPaquete";
            btnRetirarPaquete.Size = new Size(96, 23);
            btnRetirarPaquete.TabIndex = 2;
            btnRetirarPaquete.Text = "Retirar";
            btnRetirarPaquete.UseVisualStyleBackColor = true;
            btnRetirarPaquete.Click += btnRetirar_Click;
            // 
            // btnAgregarPaquete
            // 
            btnAgregarPaquete.Location = new Point(525, 73);
            btnAgregarPaquete.Name = "btnAgregarPaquete";
            btnAgregarPaquete.Size = new Size(96, 23);
            btnAgregarPaquete.TabIndex = 1;
            btnAgregarPaquete.Text = "Agregar";
            btnAgregarPaquete.UseVisualStyleBackColor = true;
            btnAgregarPaquete.Click += btnAgregarPaquete_Click;
            // 
            // lsbCarga
            // 
            lsbCarga.FormattingEnabled = true;
            lsbCarga.ItemHeight = 15;
            lsbCarga.Location = new Point(178, 41);
            lsbCarga.Name = "lsbCarga";
            lsbCarga.Size = new Size(331, 139);
            lsbCarga.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FeDeX 3.0";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private ListBox lsbCarga;
        private Button btnRetirarPaquete;
        private Button btnAgregarPaquete;
        private Button btnIniciar;
        private Button btnEnviar;
        private TextBox tbKg;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private ComboBox cmbCamiones;
        private Label label4;
    }
}
