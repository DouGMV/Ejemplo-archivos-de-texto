namespace Ejemplo_archivos_de_texto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonLeer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLeerDirecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(64, 118);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 40);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(397, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 214);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonLeer
            // 
            this.buttonLeer.Location = new System.Drawing.Point(415, 265);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(98, 40);
            this.buttonLeer.TabIndex = 3;
            this.buttonLeer.Text = "Leer";
            this.buttonLeer.UseVisualStyleBackColor = true;
            this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLeerDirecto
            // 
            this.buttonLeerDirecto.Location = new System.Drawing.Point(538, 265);
            this.buttonLeerDirecto.Name = "buttonLeerDirecto";
            this.buttonLeerDirecto.Size = new System.Drawing.Size(98, 40);
            this.buttonLeerDirecto.TabIndex = 4;
            this.buttonLeerDirecto.Text = "Leer directo";
            this.buttonLeerDirecto.UseVisualStyleBackColor = true;
            this.buttonLeerDirecto.Click += new System.EventHandler(this.buttonLeerDirecto_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(774, 398);
            this.Controls.Add(this.buttonLeerDirecto);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonLeer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLeerDirecto;
    }
}

