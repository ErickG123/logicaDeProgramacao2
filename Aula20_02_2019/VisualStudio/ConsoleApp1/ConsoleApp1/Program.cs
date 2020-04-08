using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, idade, diasDeVida;
            const int anoAtual = 2019;

            Console.Write("Digite sua ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;

            Console.WriteLine("Você tem: " + idade + " anos");

            diasDeVida = 365 * idade;

            Console.Write("Você viu: " + diasDeVida + " dias");

            Console.ReadKey();

            
        }
    }
}
