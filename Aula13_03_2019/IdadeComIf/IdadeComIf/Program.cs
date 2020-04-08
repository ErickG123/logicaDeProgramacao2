using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeComIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual, anoDeNascimento, idade;

            Console.Write("Qual o ano atual? ");
            anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Em que ano você nasceu? ");
            anoDeNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoDeNascimento;

            Console.WriteLine("Você tem " + idade + " anos ");

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
                Console.WriteLine("Você pode entrar.");
                Console.WriteLine("Você pode beber.");
            }
            else if (idade >= 16)
            {
                Console.WriteLine("Você pode entrar.");
                Console.WriteLine("Você NÃO pode beber.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
            Console.ReadKey();

        }
    }
}
