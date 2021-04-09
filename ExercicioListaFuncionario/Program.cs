using System;
using System.Globalization;
using System.Collections.Generic;
namespace ExercicioListaFunc
/*  - Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
      N funcionários. Não deve haver repetição de id. 

    - Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
      Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
      mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários.
 */

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de funcionários");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
            Console.WriteLine("Informe a id do funcionário que terá o salário aumentado.");
            int idAumento= int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == idAumento);

            if (func != null) 
            {  
                Console.Write("Entre com a porcentagem: ");
                int porcentagem = int.Parse(Console.ReadLine());
                func.aumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe. ");
            }          
            foreach (Funcionario obj in list)
            {
                Console.WriteLine("Lista atualizada dos empregados: ");
                Console.WriteLine(obj);
            }

        }
    }
}
