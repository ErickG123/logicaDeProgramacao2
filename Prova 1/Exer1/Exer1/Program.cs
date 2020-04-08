using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a variável
            string escolha;

            //Mostrando as escolhas do usuário
            Console.WriteLine("*********************************************");
            Console.WriteLine("Digite 1 para linguagem de programação");
            Console.WriteLine("Digite 2 para código fonte");
            Console.WriteLine("Digite 3 para compilador");
            Console.WriteLine("Digite 4 para programação");
            Console.Write("*********************************************");
            Console.Write("\n");

            //Pedindo para o usuário escolher a opção
            Console.Write("Qual conceito de técnicas de programação deseja aprender ? ");
            escolha = Console.ReadLine();

            //Limpando a tela para mostrar apenas o conceito
            Console.Clear();

            //Identificando qual a escolha dele 
            //Se ele escolher a opção 1
            if(escolha == "1")
            {
                Console.WriteLine("Você escolheu linguagem de programação");
                Console.WriteLine("- Serve como ponte entre homem e a maquina, transforma linguagem natural em linguagem de maquina.");
                Console.Write("- Existem diversas linguagens de programação(C#, C, C++, Java, JavaScript, Delphi, PHP...).");
            }
            //Se ele escolher a opção 2
            else if (escolha == "2")
            {
                Console.WriteLine("Você escolheu código fonte");
                Console.WriteLine("- Uma sequencia de códigos de uma determinada linguagem de programação.");
                Console.Write("- Instruções para que o computador realize algo.");
            }
            //Se ele escolher a opção 3
            else if (escolha == "3")
            {
                Console.WriteLine("Você escolheu compilador");
                Console.WriteLine("- Conversão da linguagem de programação em linguagem de máquina.");
                Console.WriteLine("- Cria o programa que será executado pelo computador.");
            }
            //Se ele escolher a opção 4
            else if (escolha == "4")
            {
                Console.WriteLine("Você escolheu programa");
                Console.WriteLine("- Resultado da compilação de um código fonte.");
                Console.WriteLine("- Deve realizar alguma atividade no computador.");
                Console.WriteLine("- Pode ou não requerer interação do usuário.");
            }
            //Se ele escolher uma opção invalida
            else
            {
                Console.Write("OPÇÃO INVALIDA, ESCOLHA OUTRA OPÇÃO");
            }

            //Finalizando o programa 
            Console.ReadKey();
        }
    }
}
