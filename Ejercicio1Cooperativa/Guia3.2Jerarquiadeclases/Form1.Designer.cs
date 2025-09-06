namespace Guia3._2Jerarquiadeclases
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
            label1 = new Label();
            tbCoperativa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnIniciarCooperativa = new Button();
            btnAgregarCliente = new Button();
            btnSeleccionarCliente = new Button();
            btnRegistrarConsumo = new Button();
            btnCerrar = new Button();
            btnVerConsumo = new Button();
            tbNroServicio = new TextBox();
            tbLecturaMedidor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Coperativa";
            // 
            // tbCoperativa
            // 
            tbCoperativa.Location = new Point(164, 32);
            tbCoperativa.Name = "tbCoperativa";
            tbCoperativa.Size = new Size(236, 23);
            tbCoperativa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Atta de clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 186);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 3;
            label3.Text = "Consultas de clientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 222);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 4;
            label4.Text = "Número de Servicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 294);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 5;
            label5.Text = "Carga de consumos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 365);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 6;
            label6.Text = "Consumos";
            // 
            // btnIniciarCooperativa
            // 
            btnIniciarCooperativa.Location = new Point(433, 31);
            btnIniciarCooperativa.Name = "btnIniciarCooperativa";
            btnIniciarCooperativa.Size = new Size(126, 23);
            btnIniciarCooperativa.TabIndex = 7;
            btnIniciarCooperativa.Text = "Iniciar Cooperativa";
            btnIniciarCooperativa.UseVisualStyleBackColor = true;
            btnIniciarCooperativa.Click += button1_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(177, 91);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(178, 23);
            btnAgregarCliente.TabIndex = 8;
            btnAgregarCliente.Text = "Carga de clientes";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += button2_Click;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new Point(433, 214);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(269, 23);
            btnSeleccionarCliente.TabIndex = 9;
            btnSeleccionarCliente.Text = "Seleccionar";
            btnSeleccionarCliente.UseVisualStyleBackColor = true;
            btnSeleccionarCliente.Click += button3_Click;
            // 
            // btnRegistrarConsumo
            // 
            btnRegistrarConsumo.Location = new Point(433, 309);
            btnRegistrarConsumo.Name = "btnRegistrarConsumo";
            btnRegistrarConsumo.Size = new Size(126, 23);
            btnRegistrarConsumo.TabIndex = 10;
            btnRegistrarConsumo.Text = "Cargar Consumo";
            btnRegistrarConsumo.UseVisualStyleBackColor = true;
            btnRegistrarConsumo.Click += button4_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(239, 414);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(105, 36);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button5_Click;
            // 
            // btnVerConsumo
            // 
            btnVerConsumo.Location = new Point(164, 361);
            btnVerConsumo.Name = "btnVerConsumo";
            btnVerConsumo.Size = new Size(236, 23);
            btnVerConsumo.TabIndex = 12;
            btnVerConsumo.Text = "Ver Consumo";
            btnVerConsumo.UseVisualStyleBackColor = true;
            btnVerConsumo.Click += button6_Click;
            // 
            // tbNroServicio
            // 
            tbNroServicio.Location = new Point(164, 214);
            tbNroServicio.Name = "tbNroServicio";
            tbNroServicio.Size = new Size(236, 23);
            tbNroServicio.TabIndex = 13;
            // 
            // tbLecturaMedidor
            // 
            tbLecturaMedidor.Location = new Point(164, 310);
            tbLecturaMedidor.Name = "tbLecturaMedidor";
            tbLecturaMedidor.Size = new Size(236, 23);
            tbLecturaMedidor.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbLecturaMedidor);
            Controls.Add(tbNroServicio);
            Controls.Add(btnVerConsumo);
            Controls.Add(btnCerrar);
            Controls.Add(btnRegistrarConsumo);
            Controls.Add(btnSeleccionarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnIniciarCooperativa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbCoperativa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCoperativa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSeleccionarCliente;
        private Button btnRegistrarConsumo;
        private Button btnCerrar;
        private Button btnVerConsumo;
        private TextBox tbNroServicio;
        private TextBox tbLecturaMedidor;
        public Button btnIniciarCooperativa;
        public Button btnAgregarCliente;
    }
}
