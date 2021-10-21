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
    public partial class Main : Form
    {
        public static Main instance;
        public Main()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form3 form= new Form3();
            form.Show();
            Main.instance.Hide();

        }
    }
}
