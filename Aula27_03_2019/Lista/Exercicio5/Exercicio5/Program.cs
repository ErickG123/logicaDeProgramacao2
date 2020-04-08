using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis 
            int numeroUm, numeroDois, numeroTres;

            //Declarei como zero pois depois um valor será armazenado nele 
            //O valor 0 vai ser substituido pelo valor digitado pelo usuário
            int primeiro = 0;
            int segundo = 0;
            int terceiro = 0;

            //Pedindo o primeiro número
            Console.Write("Informe o primeiro número => ");
            numeroUm = int.Parse(Console.ReadLine());

            //Pedindo o segundo número
            Console.Write("Informe o segundo número => ");
            numeroDois = int.Parse(Console.ReadLine());

            //Pedindo o terceiro número
            Console.Write("Informe o terceiro número => ");
            numeroTres = int.Parse(Console.ReadLine());
            
            //Fazendo as condições e armazenando os valores nas variáveis 
            if(numeroUm <= numeroDois && numeroUm <= numeroTres && numeroDois <= numeroTres)
            {
                primeiro = numeroUm;
                segundo = numeroDois;
                terceiro = numeroTres;
            }
            else if(numeroDois <= numeroUm && numeroDois <= numeroTres && numeroUm <= numeroTres)
            {
                primeiro = numeroDois;
                segundo = numeroUm;
                terceiro = numeroTres;
            }
            else if(numeroTres <= numeroUm && numeroTres <= numeroDois && numeroDois <= numeroUm)
            {
                primeiro = numeroTres;
                segundo = numeroDois;
                terceiro = numeroUm;
            }

            //Limpando a tela 
            //Para mostrar apenas as ordens
            Console.Clear();

            //Mostrando na tela
            Console.WriteLine("Ordem Crescente => " + primeiro + " -> " + segundo + " -> " +  terceiro);
            Console.WriteLine("Ordem Decrescente => " + terceiro + " <- " + segundo + " <- " + primeiro);

            //Finalizando o programa
            Console.ReadKey();
        }
    }
}
