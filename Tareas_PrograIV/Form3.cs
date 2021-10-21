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
    public partial class Form3 : Form
    {
        int calificacion1;
        int calificacion2;
        int resultado;
        string ResultLBL;

        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Click(object sender, EventArgs e)
        {

             Main form1 = new Main();
            form1.Show();
            Form3.instance.Hide();
        }

        private void Promedio_button_Click(object sender, EventArgs e)
        {
            calificacion1 = int.Parse(textvalue1.Text);
            calificacion2 = int.Parse(textvalue2.Text);

            resultado = (calificacion1 + calificacion2)/2;
            ResultLBL = "" + resultado;
            this.ResultLabel.Text = ResultLBL;
        }

    
    }
}
