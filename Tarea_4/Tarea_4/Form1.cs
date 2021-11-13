using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ContarLineas()
        {
            int cantidad;

            ofdLeer.Filter = "*.txt|*.txt*";
            ofdLeer.FilterIndex = 1;//1 archivo a la vez
            ofdLeer.RestoreDirectory = true;// remind directory 
            string line = ""; 
            if (ofdLeer.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofdLeer.FileName;
    
                StreamReader sr = new StreamReader(ruta);
                line = sr.ReadLine();
                cantidad = 0;
                if (line == null)
                {
                    MessageBox.Show("Archivo esta vacio, no contiene ninguna linea");
                }
                while (line != "" && line != null)
                {
                    cantidad += 1;
                    line = sr.ReadLine();
                }
                sr.Close();

                txtResult.Text = cantidad.ToString();
               

            }
            else
            {
                MessageBox.Show("Elija un archivo para leer");
            }

        }

        private void Importar_Click(object sender, EventArgs e)
        {
            try
            {
                ContarLineas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }
    }
}
