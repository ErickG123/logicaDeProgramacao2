using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27_02_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;
            int quantidadeDoProduto;
            double valorUnitario, pagouPeloProduto;

            Console.Write("Qual produto você comprou: ");
            produto = Console.ReadLine();

            Console.Write("Quantos você comprou do produto: ");
            quantidadeDoProduto = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor de cada produto? ");
            valorUnitario = double.Parse(Console.ReadLine());

            pagouPeloProduto = quantidadeDoProduto * valorUnitario;

            Console.Write("Você comprou " + quantidadeDoProduto + " de " + produto + " e pagou " + pagouPeloProduto + " reais");

            Console.ReadKey();
        }
    }
}
