using System;

    /*Fazer um programa para ler dois números inteiros M e N, e depois ler
      uma matriz de M linhas por N colunas contendo números inteiros,
      podendo haver repetições. Em seguida, ler um número inteiro X que
      pertence à matriz. Para cada ocorrência de X, mostrar os valores à
      esquerda, acima, à direita e abaixo de X, quando houver.*/
namespace ExercicioFixacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ": ");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat.GetValue(i, j - 1));
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat.GetValue(i - 1, j));
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat.GetValue(i, j + 1));
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat.GetValue(i + 1, j));
                        }           
                    }
                }

            }         
        }
    }
}
