using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis que seram utilizadas
            string nomeUsuario;
            int respostaUsuario;

            //Pedindo o nome do usuário
            Console.Write("Qual o seu nome? ");
            nomeUsuario = Console.ReadLine();

            //Mostrando as opções do usuário
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Professor");
            Console.WriteLine("2 - Aluno");
            respostaUsuario = int.Parse(Console.ReadLine());

            //Limpando a tela para mostrar apenas o resultado
            Console.Clear();

            //Identificando as escolhas
            //Se ele escolher a opção 1
            if(respostaUsuario == 1)
            {
                Console.WriteLine("Olá " + nomeUsuario + ", você escolheu: Professor.");
            }
            //Se ele escolher a opção 2
            else
            {
                Console.WriteLine("Olá " + nomeUsuario + ", você escolheu: Aluno");
            }

            //Finalizando o código
            Console.ReadKey();
        }
    }
}
