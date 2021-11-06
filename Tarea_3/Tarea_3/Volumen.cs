using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3
{
    public partial class Volumen : Form
    {
        int v;

        public static Volumen instance;
        public Volumen()
        {
            InitializeComponent();
            instance = this;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            progressBar1.Value = progressBar1.Value + 5;
            //Valores value = new Valores();
            //progressBar1.Value = v;
            //    v=Convert.ToInt32(Mayor_Valor.Text);

        }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Volume_Down_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 5;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Volumen.instance.Hide();
        }
    }
}
