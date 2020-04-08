using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declarando as variáveis
            double numero;

            //Pedindo o número ao usuário
            Console.Write("Informe um número => ");
            numero = double.Parse(Console.ReadLine());

            //Testando para ver se ele é ímpar ou par
            //Se o resto da divisão for igual á zero o número é par
            if (numero % 2 == 0)
            {
                Console.Write("O número " + numero + " é par");
            }

            //Se o resto da divisão for igual á um o número é impar
            else
            {
                Console.Write("O número " + numero + " é impar");
            }

            //Finalizando o programa
            Console.ReadKey();
        }
    }
}
