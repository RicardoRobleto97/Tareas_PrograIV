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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, EventArgs e)
        {


            try
            {

                ofdLeer.Filter = "*.txt|*.txt*";
                ofdLeer.FilterIndex = 1;
                ofdLeer.RestoreDirectory = true;
                if (ofdLeer.ShowDialog() == DialogResult.OK)
                {
                   

                    txtUp1.Text = ofdLeer.FileName;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

         }

        private void Upload_2_Click(object sender, EventArgs e)
        {
            try
            {

                ofdLeer2.Filter = "*.txt|*.txt*";
                ofdLeer2.FilterIndex = 1;
                ofdLeer2.RestoreDirectory = true;
                if (ofdLeer2.ShowDialog() == DialogResult.OK)
                {


                    txtUp2.Text = ofdLeer2.FileName;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Importar_Click(object sender, EventArgs e)
        {
            try
            {
                bool iguales = false;
                string line, line2;

                string route = ofdLeer.FileName;
                string route2 = ofdLeer2.FileName;//rutas

                StreamReader sr = new StreamReader(route);
                StreamReader sr2 = new StreamReader(route2);

                line = sr.ReadLine();
                line2 = sr2.ReadLine();
                while(line !="" && line != null && line2 != "" && line2 != null)
                { //ciclo leyendo linea por linea


                    line = sr.ReadLine();
                    line2 = sr2.ReadLine();
                    if(line == line2)
                    {
                        iguales = true;

                    }
                    else
                    {  
                        iguales = false;
                        break;
                    }
                }
                if (iguales)
                {
                    MessageBox.Show("Archivos son igualess!!");
                }
                else
                {
                    MessageBox.Show("Archivos son diferentes");
                }
                sr.Close();
                sr2.Close();
              
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
