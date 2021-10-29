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
    public partial class Main : Form
    {
        public static Main instance;
        public Main()
        {
            InitializeComponent();
            instance = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            Circulo form = new Circulo();
            form.Show();
            Main.instance.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cilindro form = new Cilindro();
            form.Show();
            Main.instance.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segundos form = new Segundos();
            form.Show();
            Main.instance.Hide();
        }
    }
}
