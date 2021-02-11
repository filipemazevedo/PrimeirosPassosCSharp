using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        public Double L, H;

        public double Area()
        {
            return L * H;
        }

        public double Perimetro()
        {
            return 2 * (L + H);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(L,2) + Math.Pow(H,2));
        }
    }
}
