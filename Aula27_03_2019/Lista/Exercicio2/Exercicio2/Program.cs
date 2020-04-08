using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {	
			//Declarando as variáveis
            string nomeDaPrimeiraPessoa, nomeDaSegundaPessoa;
            double alturaDaPrimeiraPessoa, alturaDaSegundaPessoa;

            //Pedindo o nome da primeira pessoa 
            Console.Write("Informe o nome da primeira pessoa => ");
            nomeDaPrimeiraPessoa = Console.ReadLine();

            //Pedindo o nome da segunda pessoa 
            Console.Write("Informe o nome da segunda pessoa => ");
            nomeDaSegundaPessoa = Console.ReadLine();

            //Pedindo a altura da primeira pessoa
            Console.Write("Informe a altura da primeira pessoa => ");
            alturaDaPrimeiraPessoa = double.Parse(Console.ReadLine());

            //Pedindo a altura da segunda pessoa
            Console.Write("Informe a altura da segunda pessoa => ");
            alturaDaSegundaPessoa = double.Parse(Console.ReadLine());

            //Testando para ver quem é o mais alto
            if (alturaDaPrimeiraPessoa > alturaDaSegundaPessoa)
            {
                Console.Write(nomeDaPrimeiraPessoa + " é maior que " + nomeDaSegundaPessoa);
            }
            else
            {
                Console.Write(nomeDaPrimeiraPessoa + " não é maior que " + nomeDaSegundaPessoa);
            }

            //Finalizando a programação
            Console.ReadKey();
        }
    }
}
