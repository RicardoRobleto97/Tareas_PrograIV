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
    public partial class Cilindro : Form
    {
        public static Cilindro instance;
        public Cilindro()
        {
            InitializeComponent();
            instance = this;

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            Cilindro.instance.Hide();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double r, h;
                double p = Math.PI;
                r = Convert.ToDouble(txtRadio.Text);
                h = Convert.ToDouble(txtAltura.Text);

                CilindroA Cilinder = new CilindroA(r,h, p);
                txtArea.Text = Cilinder.getArea().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
