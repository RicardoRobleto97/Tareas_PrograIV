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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Volumen form = new Volumen();
            form.Show();
            Form1.instance.Hide();
        }
    }
}
