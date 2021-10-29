using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class SegundosT
    {
        private int horas;
        private int minutos;
        private int segundos;

        public SegundosT()
        {
        }

        public SegundosT(int horas, int minutos, int segundos)
        {
            this.Horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        public int Horas { get => horas; set => horas = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public int Segundos { get => segundos; set => segundos = value; }

        public int getTotalSegundos()
        {
            return (horas*3600)+(minutos*60)+segundos;
        }
    }
}
