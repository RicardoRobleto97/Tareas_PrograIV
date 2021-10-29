using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class CirculoA
    {
        private double radio;
        private double pi = Math.PI;
       // private double altura;
        public CirculoA()
        {
        }
        public CirculoA(double radio, double pi)
        {
            this.radio = radio;
            this.pi = pi;
        }

        public double Pi { get => pi; set => pi = value; }
        public double Radio { get => radio; set => radio = value; }

        public virtual double getArea() { return (pi * radio * radio); }

    }
}
