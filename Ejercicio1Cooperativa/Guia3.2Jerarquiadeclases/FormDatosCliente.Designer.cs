namespace Guia3._2Jerarquiadeclases
{
    partial class FormDatosCliente
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNumeroServicio = new TextBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbDireccion = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(98, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(297, 346);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 122);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero de servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 180);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 237);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 290);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Dirección";
            // 
            // tbNumeroServicio
            // 
            tbNumeroServicio.Location = new Point(194, 119);
            tbNumeroServicio.Name = "tbNumeroServicio";
            tbNumeroServicio.Size = new Size(100, 23);
            tbNumeroServicio.TabIndex = 6;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(194, 172);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 7;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(194, 234);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(100, 23);
            tbDNI.TabIndex = 8;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(194, 287);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(100, 23);
            tbDireccion.TabIndex = 9;
            // 
            // FormDatosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDireccion);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(tbNumeroServicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormDatosCliente";
            Text = "FormDatosCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox tbNumeroServicio;
        public TextBox tbNombre;
        public TextBox tbDNI;
        public TextBox tbDireccion;
    }
}