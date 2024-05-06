using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_archivos_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar(string fileName, string texto)
        {
            FileStream flujo = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(flujo);
            escritor.WriteLine(texto);
            escritor.Close();
        }
      
        private void buttonLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                FileStream flujo = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader lector = new StreamReader(flujo);

                while (lector.Peek() > -1)
                {
                    richTextBox1.AppendText(lector.ReadLine());
                }
                lector.Close();
            }
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            Guardar(@"C:\Users\Sir_d\Documents\archivo.txt", textBox2.Text);
            MessageBox.Show("Texto Guardado");
        }

        private void buttonLeerDirecto_Click(object sender, EventArgs e)
        {
            string fileName = openFileDialog1.FileName;

            FileStream flujo = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(flujo);

            while (lector.Peek() > -1)
            {
                richTextBox1.AppendText(lector.ReadLine());
            }
            lector.Close();
        }
    }
}



