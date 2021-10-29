using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class CilindroA : CirculoA
    {


        public double altura;

        public CilindroA()
        {
        }

        //public CilindroA(double radio, double pi) : base(radio, pi)
        //{
        //}

        public CilindroA(double radio, double pi, double altura) : base(radio, pi)
        {
            this.altura = altura;
        }
        public double Altura { get => altura; set => altura = value; }


        public override double getArea()
        {
            return 2*(Radio*Pi)*(Radio+Altura);
        }
    }
}
