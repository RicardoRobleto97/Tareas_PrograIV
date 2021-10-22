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
    public partial class Form7 : Form
    {
        int segundosT;
        int horas;
        int minutos;
        public static Form7 instance;
        public Form7()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            Form7.instance.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            segundosT = int.Parse(textvalue1.Text);

            horas = segundosT / 3600;
            segundosT %= 3600;
            minutos = segundosT / 60;
            segundosT %= 60;
            MessageBox.Show("H: "+horas+" M:"+minutos+" S:" + segundosT , "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
