using System;
namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            conta.Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            conta.DepositoInicial = Console.ReadLine();
            conta.DepositoInicio();

            Console.WriteLine("");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre com um valor para depósito: ");
            double quantidade = double.Parse(Console.ReadLine());
            conta.Deposito(quantidade);
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre com um valor para saque: ");
            quantidade = double.Parse(Console.ReadLine());
            conta.Saque(quantidade);
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
