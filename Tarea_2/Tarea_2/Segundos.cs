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
    public partial class Segundos : Form
    {
        public static Segundos instance;
        public Segundos()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            Segundos.instance.Hide();

        }

        private void CalcularSegs_Click(object sender, EventArgs e)
        {
            try
            {
                int h, m, s;

                h = Convert.ToInt32(txtHoras.Text);
                m = Convert.ToInt32(txtMin.Text);
                s = Convert.ToInt32(txtSegundos.Text);

                SegundosT secs = new SegundosT(h, m, s);
                txtTotal.Text = secs.getTotalSegundos().ToString();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
