using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2
{
    public partial class Circulo : Form
    {
        public static Circulo instance;
        public Circulo()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            Circulo.instance.Hide();
        }

        private void CalcularAreaCircula_Click(object sender, EventArgs e)
        {
            try
            {
                double r;
                double p= Math.PI;
                r = Convert.ToDouble(txtRadio.Text);

                CirculoA Circle = new CirculoA(r,p);
                txtArea.Text = Circle.getArea().ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
