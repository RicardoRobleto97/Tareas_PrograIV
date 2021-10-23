using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas_PrograIV
{
    public partial class Form9 : Form
    {
        public static Form9 instance;
        int montoDado = 100;
        int costoArticulo;
        int monedas50, monedas20, monedas10, monedas5, monedas2, monedas1;

        int cambio;
        string ResultLBL;
        public Form9()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            Form9.instance.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            costoArticulo = int.Parse(textvalue2.Text);
            cambio = (100 - costoArticulo);
            ResultLBL = "" + cambio;
            this.ResultLabel.Text = ResultLBL;

            monedas50 = cambio / 50;
            cambio %= 50;
            monedas20 = cambio / 20;
            cambio %= 20;
            monedas10 = cambio / 10;
            cambio %= 10;
            monedas5 = cambio / 5;
            cambio %= 5;
            monedas2 = cambio / 2;
            cambio %= 2;
            monedas1 = cambio / 1;
            cambio %= 1;
            MessageBox.Show("Cantidad de monedas de 50 es:"+monedas50, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Cantidad de monedas de 20 es:" + monedas20, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Cantidad de monedas de 10 es:" + monedas10, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Cantidad de monedas de 5 es:" + monedas5, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Cantidad de monedas de 2 es:" + monedas2, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Cantidad de monedas de 1 es:" + monedas1, "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
