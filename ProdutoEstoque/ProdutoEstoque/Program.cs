using System;
using System.Globalization;
namespace ProdutoEstoque
{
    /* Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida: 
       1 - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
       2 - Realizar uma entrada no estoque e mostrar novamente os dados do produto
       3 - Realizar uma saída no estoque e mostrar novamente os dados do produto */
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto;
            produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
