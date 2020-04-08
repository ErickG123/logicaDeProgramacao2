using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis
            double salario, reajuste, salarioComReajuste;

            //Pedindo o salário do funciononário
            Console.Write("Informe o seu salário => ");
            salario = double.Parse(Console.ReadLine());

            //Se o salário for até 300 o reajuste é de 50%
            if (salario <= 300)
            {
                //Calculando o reajuste 
                reajuste = salario * 0.5;

                //Calculando o salário com o reajuste
                salarioComReajuste = salario + reajuste;

                Console.WriteLine("O seu reajuste foi de => R${0:N}", reajuste);
                Console.Write("O seu salario com o reajuste é de => R${0:N}", salarioComReajuste);
            }

            //Se o salário for maior que 300 o reajuste é de 30%
            else
            {
                //Calculando o reajuste 
                reajuste = salario * 0.3;

                //Calculando o salário com o reajuste
                salarioComReajuste = salario + reajuste;

                Console.WriteLine("O seu reajuste foi de => R${0:N}", reajuste);
                Console.Write("O seu salario com o reajuste é de => R${0:N}", salarioComReajuste);
            }

            //Finalizando a programação
            Console.ReadKey();
        }
    }
}
