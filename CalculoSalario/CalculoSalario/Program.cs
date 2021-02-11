using System;
using System.Globalization;
namespace CalculoSalario
{
    class Program
    {
        /*
         Fazer um programa para ler os dados de um funcionário (nome,
         salário bruto e imposto). Em seguida, mostrar os dados do
         funcionário (nome e salário líquido). Em seguida, aumentar o salário
         do funcionário com base em uma porcentagem dada (somente o
         salário bruto é afetado pela porcentagem) e mostrar novamente os
         dados do funcionário. Use a classe projetada abaixo.
         */
        static void Main(string[] args)
        {
            Funcionario func;
            func = new Funcionario();

            Console.WriteLine("Informe o nome do funcioário: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto deste funcionário: ");
            func.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o imposto: ");
            func.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine("");

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = Double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);
            Console.WriteLine("");

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
