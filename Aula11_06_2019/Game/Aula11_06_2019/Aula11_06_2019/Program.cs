using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_06_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as variáveis de controle
            int moeda = -1;     // 0 = Cara/1 = Coroa
            int creditos = 5;   //Usuário começa com 5 créditos
            Boolean continuar = true;
            string resposta = "S";
            Random r = new Random(2);

            while(continuar)
            {
                //Instruções do jogo
                Console.WriteLine("Regras do jogo: Cara => Você perde/ Coroa => Você ganha");

                //Jogando a moeda
                moeda = r.Next(2);

                //Se saiu cara (Usuário perdeu)
                if(moeda == 0)
                {
                    creditos = creditos - 1;    //Creditos -= 1
                    Console.WriteLine("Você perdeu");

                    //Vendo se o usuário pode continuar
                    if(creditos <= 0)
                    {
                        continuar = false;
                    }
                }

                //Se saiu coroa (Usuário ganhou)
                else
                {
                    creditos = creditos + 1;    //Creditos += 1
                    Console.WriteLine("Você ganhou");
                }

                //Mostrando os créditos do usuário 
                Console.WriteLine("Créditos => " + creditos);

                if (!continuar) //Se o usuário perdeu tudo
                {
                    Console.WriteLine("Você perdeu todos os seus créditos");
                    Console.ReadKey();
                }

                else //Se ele ainda tiver créditos
                
                {
                    //Testando a condição de saída do jogo
                    //Pergunda se o usuário quer continuar jogando
                    Console.Write("Deseja continuar ? (S/N) => ");
                    resposta = Console.ReadLine();

                    //Se ele não quiser, saímos do jogo
                    if (resposta == "N")
                    {
                        continuar = false;
                    }
                }
            }
        }
    }
}
