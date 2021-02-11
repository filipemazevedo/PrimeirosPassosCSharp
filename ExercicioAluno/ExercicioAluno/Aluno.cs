using System;
using System.Globalization;

namespace ExercicioAluno
{
    class Aluno
    {
        public String Nome;
        public Double Nota1, Nota2, Nota3,Pontos;
        
        public double CalculoNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        
        public void Aprovacao()
        {
            if (CalculoNotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Pontos = 60 - CalculoNotaFinal();
                Console.WriteLine("FALTARAM " + Pontos.ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
        
        
    }
}
