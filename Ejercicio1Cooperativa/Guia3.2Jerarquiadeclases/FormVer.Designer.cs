namespace Guia3._2Jerarquiadeclases
{
    partial class FormVer
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
            lbResultados = new ListBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // lbResultados
            // 
            lbResultados.FormattingEnabled = true;
            lbResultados.ItemHeight = 15;
            lbResultados.Location = new Point(69, 48);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(664, 319);
            lbResultados.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(236, 386);
            btn1.Name = "btn1";
            btn1.Size = new Size(327, 43);
            btn1.TabIndex = 1;
            btn1.Text = "Cerrar";
            btn1.UseVisualStyleBackColor = true;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(lbResultados);
            Name = "FormVer";
            Text = "FormVer";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lbResultados;
        public Button btn1;
    }
}