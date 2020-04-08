using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUm, numeroDois, soma, multiplicacao, divisao, subtracao;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("CALCULANDO AS QUATRO OPERAÇÕES BÁSICAS");
            Console.WriteLine("--------------------------------------");

            Console.Write("Informe o primeiro número: ");
            numeroUm = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            numeroDois = double.Parse(Console.ReadLine());

            soma = numeroUm + numeroDois;
            subtracao = numeroUm - numeroDois;
            divisao = numeroUm / numeroDois;
            multiplicacao = numeroUm * numeroDois;

            Console.Clear();

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*RESULTADOS*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*---*-*--*-*-*-*");
            Console.WriteLine("A soma do número " + numeroUm + " e o número " + numeroDois + " é igual á: " + soma);
            Console.WriteLine("A subtração do número " + numeroUm + " e o número " + numeroDois + " é igual á: " + subtracao);
            Console.WriteLine("A divisão do número " + numeroUm + " e o número " + numeroDois + " é igual á: " + divisao);
            Console.WriteLine("A multiplicação do número " + numeroUm + " e o número " + numeroDois + " é igual á: " + multiplicacao);

            Console.ReadKey();
        }
    }
}
