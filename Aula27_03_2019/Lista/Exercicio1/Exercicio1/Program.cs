using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis 
            int idadeAluno1, idadeAluno2, idadeAluno3, idadeAluno4, idadeAluno5, mediaDasIdades;

            //Pedindo a idade do primeiro aluno
            Console.Write("Informe a idade do primeiro aluno => ");
            idadeAluno1 = int.Parse(Console.ReadLine());

            //Pedindo a idade do segundo aluno
            Console.Write("Informe a idade do segundo aluno => ");
            idadeAluno2 = int.Parse(Console.ReadLine());

            //Pedindo a idade do terceiro aluno
            Console.Write("Informe a idade do terceiro aluno => ");
            idadeAluno3 = int.Parse(Console.ReadLine());

            //Pedindo a idade do quarto aluno
            Console.Write("Informe a idade do quarto aluno => ");
            idadeAluno4 = int.Parse(Console.ReadLine());

            //Pedindo a idade do quinto aluno
            Console.Write("Informe a idade do quinto aluno => ");
            idadeAluno5 = int.Parse(Console.ReadLine());

            //Calculando a média das idades
            mediaDasIdades = (idadeAluno1 + idadeAluno2 + idadeAluno3 + idadeAluno4 + idadeAluno5) / 5;

            //Mostrando a média na tela
            Console.Write("A média de idade entre od alunos é de: " + mediaDasIdades);

            //Finalizando o código
            Console.ReadKey();
        }
    }
}
