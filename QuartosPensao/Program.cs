using System;

namespace ExercicioAluguelDeQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vect = new Estudantes[10];
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine( i + ": " + vect[i]);
                }
            }


        }
    }
}
