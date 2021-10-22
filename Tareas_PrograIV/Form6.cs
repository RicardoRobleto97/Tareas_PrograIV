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
    public partial class Form6 : Form
    {
        public static Form6 instance;

        int Fahrenheit;
        int resultado;

        string CelsiusLBL;

        public Form6()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            Form6.instance.Hide();
        }

        private void Covert_button_Click(object sender, EventArgs e)
        {
            Fahrenheit= int.Parse(textvalue1.Text);
            resultado = (Fahrenheit - 32) * 5 / 9;
            CelsiusLBL = resultado+" C";
            this.Resultlabel.Text = CelsiusLBL;
        }

        private void Resultlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
