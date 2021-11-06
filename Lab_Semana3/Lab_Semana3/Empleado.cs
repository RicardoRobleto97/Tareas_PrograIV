using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Semana3
{
    class Empleado
    {
        public Empleado()
        {

        }
        public string identidad { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }

        public DateTime fecha_nacimiento { get; set; }

        public double sueldo_base { get; set; }

        public string departament { get; set; }
    }
}
