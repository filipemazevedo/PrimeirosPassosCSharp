using System;
using System.Globalization;
namespace PrimeirosExercicios2
{
    /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários*/
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func1, func2;
            func1 = new Funcionarios();
            func2 = new Funcionarios();

            Console.WriteLine("Informe o nome e o salário do primeiro funcionário: ");
            func1.nome = Console.ReadLine();
            func1.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome e o salário do segundo funcionário: ");
            func2.nome = Console.ReadLine();
            func2.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (func1.salario + func2.salario) / 2.0;

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + func1.nome);
            Console.WriteLine("Salário: " + func1.salario);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: " + func2.nome);
            Console.WriteLine("Salário: " + func2.salario);
            Console.WriteLine("Salário médio: " + salarioMedio);
        }
    }
}
