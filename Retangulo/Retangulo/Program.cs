using System;
using System.Globalization;
namespace ExercicioRetangulo
{
    /* Fazer um programa para ler os valores da largura e altura de um retângulo. Em
    seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
    como mostrado no projeto ao lado.*/
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            ret.L = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret.H = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
