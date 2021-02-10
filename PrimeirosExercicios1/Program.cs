using System;

namespace PrimeirosExercicios1
{
    class Program
    {
        /*EXERCÍCIO 01:
        Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.*/

        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Informe o nome e a idade da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome e a idade da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Idade: " + p2.idade);

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else{
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
        }
    }
}
