using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComIf
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUm, numeroDois, resultado;
            string escolha;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("CALCULANDO AS QUATRO OPERAÇÕES BÁSICAS");
            Console.WriteLine("--------------------------------------");

            Console.Write("Informe o primeiro número: ");
            numeroUm = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            numeroDois = double.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.WriteLine("1 ou + => Soma");
            Console.WriteLine("2 ou - => Subtração");
            Console.WriteLine("3 ou * => Multiplicação");
            Console.WriteLine("4 ou / => Divisão");

            Console.Write("\n");

            Console.Write("Qual operação você deseja realizar? ");
            escolha = Console.ReadLine();

            if((escolha == "+")||(escolha == "1"))
            {
                resultado = numeroUm + numeroDois;
                Console.WriteLine("O valor da soma entre " + numeroUm + " e " + numeroDois + " é de " + resultado);
            }
            else if((escolha == "-")||(escolha == "2"))
            {
                resultado = numeroUm - numeroDois;
                Console.WriteLine("O valor da subtração entre " + numeroUm + " e " + numeroDois + " é de " + resultado);
            }
            else if ((escolha == "*") || (escolha == "3"))
            {
                resultado = numeroUm * numeroDois;
                Console.WriteLine("O valor da multiplicação entre " + numeroUm + " e " + numeroDois + " é de " + resultado);
            }
            else if ((escolha == "/") || (escolha == "4"))
            {
                resultado = numeroUm / numeroDois;
                Console.WriteLine("O valor da divisão entre " + numeroUm + " e " + numeroDois + " é de " + resultado);
            }
            else
            {
                Console.Write("DIGITE UMA OPERAÇÃO VÁLIDA");
            }

            Console.ReadKey();
        }
    }
}
