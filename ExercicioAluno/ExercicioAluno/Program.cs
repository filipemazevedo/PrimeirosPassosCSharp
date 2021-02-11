using System;
using System.Globalization;

namespace ExercicioAluno
{
    /*
     Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
     (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
     ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
     para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
     este problema.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.CalculoNotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            aluno.Aprovacao();
        }
    }
}
