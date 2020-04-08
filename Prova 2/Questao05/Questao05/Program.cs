using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean a = false;
            int b = 20;
            int c = 10;
            String d = "";

            for (int i = 0; i < 3; i++)
            {
                b += 2;
                c -= 1;
                a = ((b % c) == 0);               
            }
            Console.Write("Fim da execução");
            Console.ReadKey();
        }
    }
}
