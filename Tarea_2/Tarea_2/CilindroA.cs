using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class CilindroA : CirculoA
    {
        private double altura;

       

        public CilindroA()
        {
        }

        //public CilindroA(double radio, double pi) : base(radio, pi)
        //{
        //}

        public CilindroA(double radio, double pi, double altura) : base(radio, pi)
        {

        }

        public double Altura { get => altura; set => altura = value; }

        public CilindroA(double altura)
        {
            this.altura = altura;
        }

        public override double getArea()
        {
            return 2*(Pi*Radio)*(Radio+altura);
        }
    }
}
